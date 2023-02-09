using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.TM1Sync.Interface;
using QSS.Infrastructure.Core.QSSGatewayAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.TM1Sync.Implementation
{
    public class SyncTM1DataHelper : ISyncTM1DataHelper
    {
        private readonly QSSContext _context;

        private readonly ILogger<SyncTM1DataHelper> _logger;
        private readonly IMapper _mapper;
        private readonly DivisionRepository _divisionRepository;
        private readonly SiteRepository _siteRepository;
        private readonly TM1DataSyncDetailsRepository _syncTM1DataSyncDetailsRepository;
        private const string division = "Division";
        private const string site = "Site";
        public SyncTM1DataHelper(QSSContext context, IMapper mapper, ILogger<SyncTM1DataHelper> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
            _divisionRepository = new DivisionRepository(_context);
            _siteRepository = new SiteRepository(_context);
            _syncTM1DataSyncDetailsRepository = new TM1DataSyncDetailsRepository(_context);
        }
        public DateTimeOffset GetTM1LastSyncDate(SyncTM1DataType key)
        {
            var synctm1datatypeid = (int)key;
            var obj = _context.TM1DataSyncDetails.FirstOrDefault(x => x.TM1DataSyncDetailsId == synctm1datatypeid);
            return (DateTimeOffset)(obj != null ? obj.LastSyncDate : null);
        }

        public async Task<bool> SyncDivision(IList<TM1DivisionModel> tm1Data)
        {

            // Scenario 1 : TM1 Data Empty.

            if (tm1Data == null || tm1Data.Count == 0)
            {
                return true;
            }

            // Check if exist in DB
            // New - Create
            try
            {
                _logger.LogInformation($"SyncDivision : From TM1 = {tm1Data.Count()}");
                var eiqcDivision = await _divisionRepository.GetAll();

                var newRec = new List<Division>();
                var delRec = new List<Division>();
                var disabledRec = new List<Division>();

                // Scenario 2 : EIQC Database Empty.

                if (eiqcDivision == null || !eiqcDivision.Any())
                {
                    // Add active records
                    var activeDivisions = tm1Data.Where(x => !x.Deleted).ToList();
                    newRec = _mapper.Map<IList<TM1DivisionModel>, IList<Division>>(activeDivisions).ToList();

                }
                else
                {
                    // Scenario 3 :Eiqc and TM1 both have data.

                    // Get matching records to find deleted and inactive records.
                    var matchingDivisions = from eiqcDiv in eiqcDivision
                                            join tm1Div in tm1Data on eiqcDiv.Name equals tm1Div.Name
                                            select new { EiqcDiv = eiqcDiv, Tm1Div = tm1Div };

                    // Get deleted records from TM1 and set warning.
                    delRec = matchingDivisions.Where(x => x.Tm1Div.Deleted == true).Select(x => x.EiqcDiv).ToList();

                    // Get inactive records from Eiqc and set warning
                    disabledRec = matchingDivisions.Where(x => x.EiqcDiv.Status == StatusType.Inactive).Select(x => x.EiqcDiv).ToList();
                    // Get all new records.
                    var newRecords = tm1Data.Except(matchingDivisions.Select(x => x.Tm1Div)).ToList();

                    if (newRecords.Any())
                    {
                        newRec = _mapper.Map<IList<TM1DivisionModel>, IList<Division>>(newRecords).ToList();
                        _logger.LogInformation($"SyncDivision : New = {JsonConvert.SerializeObject(newRec, Formatting.Indented)}");
                    }
                }

                if (newRec.Any())
                {
                    _divisionRepository.AddRange(newRec);
                    UpdateSyncUTCTime((int)SyncTM1DataType.Last_Sync_Division, division);
                }

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UpdateSyncUTCTime(int sysVarId, string name)
        {
            var sysVar = _context.TM1DataSyncDetails.FirstOrDefault(x => x.TM1DataSyncDetailsId == sysVarId);
            if (sysVar != null)
            {
                sysVar.LastSyncDate = DateTimeOffset.UtcNow;
                _logger.LogInformation($"UpdateSyncUTCTime({sysVarId}) : {sysVar.LastSyncDate.ToString()}");
            }
            else
            {
                TM1DataSyncDetails tm1DataSyncDetails = new TM1DataSyncDetails()
                {
                    Name = name,
                    LastSyncDate = DateTimeOffset.UtcNow,
                };
                _syncTM1DataSyncDetailsRepository.AddAsync(tm1DataSyncDetails, $"Sync up from TM1 for{name} ");
            }

        }

        public async Task<bool> SyncSite(IList<TM1SiteModel> tm1Data)
        {

            // Scenario 1 : TM1 Data Empty.

            if (tm1Data == null || tm1Data.Count == 0)
            {
                return true;
            }

            // Check if exist in DB
            // New - Create
            try
            {
                _logger.LogInformation($"SyncSite : From TM1 = {tm1Data.Count()}");
                var eiqcSite = await _siteRepository.GetAll();

                var newRec = new List<Site>();
                var delRec = new List<Site>();
                var disabledRec = new List<Site>();

                // Scenario 2 : EIQC Database Empty.
                if (eiqcSite == null || !eiqcSite.Any())
                {
                    // Add active records
                    List<TM1SiteModel> activeSites = tm1Data.Where(x => !x.Deleted).ToList();
                    newRec = GetExtractSites(activeSites);
                }
                else
                {
                    // Scenario 3 :Eiqc and TM1 both have data.
                   // Get matching records to find deleted and inactive records.
                    var TM1SiteList = GetExtractSites(tm1Data);
                    var matchingSites = from eSite in eiqcSite
                                        join tm1Site in TM1SiteList on eSite.Code equals tm1Site.Code
                                        select new { EiqcSite = eSite, Tm1Site = tm1Site };


                    newRec = TM1SiteList.Except(matchingSites.Select(x => x.Tm1Site)).ToList();

                    if (newRec.Any())
                    {
                        _logger.LogInformation($"SyncSite : New = {JsonConvert.SerializeObject(newRec, Formatting.Indented)}");
                    }
                }

                if (newRec.Any())
                {
                    _siteRepository.AddRange(newRec);
                    UpdateSyncUTCTime((int)SyncTM1DataType.Last_Sync_Site, site);
                }

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Site> GetExtractSites(List<TM1SiteModel> activeSites)
        {
            var newSiteRec = new List<Site>();

            foreach (var tm1Record in activeSites)
            {
                if (tm1Record.SitePlantCode != null)
                {
                    foreach (var item in tm1Record.SitePlantCode)
                    {
                        if(!item.PlantCode.Deleted)
                        {
                            Site site = new Site()
                            {
                                Name = tm1Record.Name,
                                Code = item.PlantCode.Name,
                                Status = StatusType.Active,
                                AuditLog = new Models.AuditLog()
                                {
                                    Title = "Site",
                                    ChangeReason = "Add new SITE by TM1 system/job",
                                },
                            };
                            newSiteRec.Add(site);
                        }
                        
                    }
                }
            }
            return newSiteRec.ToList();
        }


        public List<Site> GetExtractSites(IList<TM1SiteModel> activeSites)
        {
            var newSiteRec = new List<Site>();

            foreach (var tm1Record in activeSites)
            {
                if(tm1Record.SitePlantCode!=null)
                {
                    foreach (var item in tm1Record.SitePlantCode)
                    {
                        if (!item.PlantCode.Deleted)
                        {
                            Site site = new Site()
                            {

                                Name = tm1Record.Name,
                                Code = item.PlantCode.Name,
                                Status = StatusType.Active,
                                AuditLog = new Models.AuditLog()
                                {
                                    Title = "Site",
                                    ChangeReason = "Add new SITE by TM1 system/job",
                                },
                            };
                            newSiteRec.Add(site);
                        }
                    }
                }
            }
            return newSiteRec.ToList();
        }

    }
}
