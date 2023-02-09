/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class SAPPartInspectionPlanRepository : BaseRepository<SAPPartInspectionPlan, int>, ISAPPartInspectionPlanRepository
    {
        private readonly QSSContext _context;
        public const int Zero = 0;
        public const int One = 1;
        public const int PaddingPosition = 4;
        public const char PaddingPrefix = '0';
        public const int AtoZZZIterationIndex = 18280;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="QSSContext"/></param>
        public SAPPartInspectionPlanRepository(QSSContext context) :
            base(context, AuditLogType.Configuration)
        {
            _context = context;
        }

        /// <summary>
        /// Create new SAPPartInspectionPlan into database
        /// </summary>
        /// <param name="SAPPartInspectionPlan">New entity of SAPPartInspectionPlan, <see cref="SAPPartInspectionPlan"/></param>
        /// <returns>Saved entity of Role, <see cref="SAPPartInspectionPlan"/></returns>
        public async Task<SAPPartInspectionPlan> AddAsync(SAPPartInspectionPlan sAPPartInspectionPlan, string changeReason, bool isRedefine)
        {
            List<string> lstSequence = null;
            if (isRedefine)
            {
                 lstSequence = GenerateAtoZZZVersions();
            }
            sAPPartInspectionPlan = this.GenerateIPSerialNumber(sAPPartInspectionPlan,isRedefine, lstSequence);
            sAPPartInspectionPlan = this.GenerateSiteIPSerialNumber(sAPPartInspectionPlan, isRedefine, lstSequence);
            if (isRedefine)
            {
                sAPPartInspectionPlan.Id = 0;
            }
            return await AddAsync(sAPPartInspectionPlan, Constants.AuditLog.Title.AddSAPPartInspectionPlan(sAPPartInspectionPlan.PartNo), changeReason);
        }

        /// <summary>
        /// Updates existing SAPPartInspectionPlan with new values
        /// </summary>
        /// <param name="SAPPartInspectionPlan">Updated entity of SAPPartInspectionPlan, <see cref="SAPPartInspectionPlan"/></param>
        /// <returns>Saved entity of SAPPartInspectionPlan, <see cref="SAPPartInspectionPlan"/></returns>
        public async Task<SAPPartInspectionPlan> UpdateAsync(SAPPartInspectionPlan sAPPartInspectionPlan, string changeReason)
        {
            return await UpdateAsync(sAPPartInspectionPlan, Constants.AuditLog.Title.EditSAPPartInspectionPlan(sAPPartInspectionPlan.PartNo), changeReason);
        }

        /// <summary>
        /// Checks if the SAPPartInspectionPlan with id presents in database, if found then deletes from database
        /// </summary>
        /// <param name="id">SAPPartInspectionPlan Id</param>
        /// <param name="changeReason">Change reason entered by user to store into audit log</param>
        /// <returns>Returns instance of removed SAPPartInspectionPlan, <see cref="{Entity}"/></returns>
        public async Task<bool> RemoveByIdAsync(int id, string changeReason)
        {
            var sAPPartInspectionPlan = await ValidateExistsAndGetAsync(id);

            SetAuditLog(sAPPartInspectionPlan, Constants.AuditLog.Title.DeleteSAPPartInspectionPlan(sAPPartInspectionPlan.PartNo), changeReason);

            return Remove(sAPPartInspectionPlan);
        }

        private SAPPartInspectionPlan GenerateIPSerialNumber(SAPPartInspectionPlan sAPPartInspectionPlan,bool isRedefine,List<string> lstSequence)
        {
            var maxIPSerialNumber = _context.SAPPartInspectionPlan.DefaultIfEmpty().Max(p => p.IPSerialNumber == null ? Zero : p.IPSerialNumber) + One;
            var formatIPSerialNumber = Convert.ToString(maxIPSerialNumber).PadLeft(PaddingPosition, PaddingPrefix);
            if (isRedefine)
            {
                SAPPartInspectionPlan maxIPVersionData = null;
                if (sAPPartInspectionPlan.ReferenceSAPPartInspectionPlanId!=null)
                {
                      maxIPVersionData = _context.SAPPartInspectionPlan
                        .Where(k => k.ReferenceSAPPartInspectionPlanId == sAPPartInspectionPlan.ReferenceSAPPartInspectionPlanId)
                        .OrderByDescending(k => k.Id).FirstOrDefault();
                }
                
                string ipVersion = maxIPVersionData != null ? maxIPVersionData.IPVersion : String.Empty;
                string newIp = sAPPartInspectionPlan.IP;

                if(!string.IsNullOrEmpty(ipVersion))
                {                    
                    newIp = newIp.Remove(newIp.LastIndexOf("-" + ipVersion));
                    ipVersion = lstSequence[lstSequence.IndexOf(ipVersion) + One].ToString();
                }
                else
                {
                    ipVersion = lstSequence[One].ToString();
                }
                sAPPartInspectionPlan.IP = string.Format("{0}-{1}", newIp, ipVersion);
                sAPPartInspectionPlan.IPVersion = ipVersion;
            }
            else
            {
                sAPPartInspectionPlan.IP = string.Format("{0}-{1}", sAPPartInspectionPlan.IP, formatIPSerialNumber);                
            }

            sAPPartInspectionPlan.IPSerialNumber = maxIPSerialNumber;
            return sAPPartInspectionPlan;
        }

        private static List<string> GenerateAtoZZZVersions()
        {
            List<string> lstSequence = new List<string>();
            int i = 0;
            while (i < AtoZZZIterationIndex)
            {
                lstSequence.Add(GenerateSequence(i));
                i++;
            }
            return lstSequence;
        }

        private SAPPartInspectionPlan GenerateSiteIPSerialNumber(SAPPartInspectionPlan sAPPartInspectionPlan, bool isRedefine, List<string> lstSequence)
        {
            
            var maxSiteIPSerialNumber = _context.SAPPartInspectionPlan.DefaultIfEmpty().Max(p => p.SiteIPSerialNumber == null ? Zero : p.SiteIPSerialNumber) + One;
            var formatSiteIPSerialNumber = Convert.ToString(maxSiteIPSerialNumber).PadLeft(PaddingPosition, PaddingPrefix);
            if (isRedefine)
            {
                SAPPartInspectionPlan maxIPVersionData = null;
                if(sAPPartInspectionPlan.ReferenceSAPPartInspectionPlanId!=null)
                {
                    maxIPVersionData = _context.SAPPartInspectionPlan.Where(k => k.ReferenceSAPPartInspectionPlanId == sAPPartInspectionPlan.ReferenceSAPPartInspectionPlanId).OrderByDescending(k => k.Id).FirstOrDefault();
                }                
                string siteIPVersion = maxIPVersionData != null ? maxIPVersionData.SiteIPVersion : String.Empty;
                string newSiteIP = sAPPartInspectionPlan.SiteIP;
                if (!string.IsNullOrEmpty(siteIPVersion))
                {
                    newSiteIP = newSiteIP.Remove(newSiteIP.LastIndexOf("-" + siteIPVersion));
                    siteIPVersion = lstSequence[lstSequence.IndexOf(siteIPVersion) + One].ToString();
                }
                else
                {
                    siteIPVersion = lstSequence[One].ToString();
                }
                sAPPartInspectionPlan.SiteIP = string.Format("{0}-{1}", newSiteIP, siteIPVersion);
                sAPPartInspectionPlan.SiteIPVersion = siteIPVersion;
            }
            else
            {                
                sAPPartInspectionPlan.SiteIP = string.Format("{0}-{1}", sAPPartInspectionPlan.SiteIP, formatSiteIPSerialNumber);
            }
            sAPPartInspectionPlan.SiteIPSerialNumber = maxSiteIPSerialNumber;
            return sAPPartInspectionPlan;
        }

        static string GenerateSequence(int index)
        {
            string result = string.Empty;
            while (index > 0)
            {
                index = index - 1;
                result = char.ConvertFromUtf32(65 + index % 26) + result;
                index = index / 26;
            }
            return result;
        }
    }
}

