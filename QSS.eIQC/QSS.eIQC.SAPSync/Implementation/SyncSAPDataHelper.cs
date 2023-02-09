using AutoMapper;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.DataAccess.Repositories.SAPDataSync;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.SAPHana.Services.Models;
using QSS.eIQC.SAPSync.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace QSS.eIQC.SAPSync.Implementation
{
    public class SyncSAPDataHelper : ISyncSAPDataHelper
    {
        private readonly QSSContext _context;

        private readonly ILogger<SyncSAPDataHelper> _logger;
        private readonly IMapper _mapper;
        private readonly MaterialGroupRepository _materialGroupRepository;
        private readonly PartRepository _partRepository;
        private readonly SAPDataSyncDetailsRepository _syncSAPDataSyncDetailsRepository;
        private readonly CommodityRepository _commodityRepository;
        private readonly CommodityPartNumberSiteRepository _commodityPartNumberSiteRepository;
        private readonly PurchaseOrderRepository _purchaseOrderRepository;

        private readonly SupplierRepository _supplierRepository;
        private const string materialGroup = "MaterialGroup";
        private const string commodity = "Commodity";
        private const string Part = "Part";
        private const string supplier = "Supplier";

        public SyncSAPDataHelper(QSSContext context, IMapper mapper, ILogger<SyncSAPDataHelper> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
            _materialGroupRepository = new MaterialGroupRepository(_context);
            _syncSAPDataSyncDetailsRepository = new SAPDataSyncDetailsRepository(_context);
            _commodityRepository = new CommodityRepository(_context);
            _commodityPartNumberSiteRepository = new CommodityPartNumberSiteRepository(_context);
            _supplierRepository = new SupplierRepository(_context);
            _partRepository = new PartRepository(_context);
            _purchaseOrderRepository = new PurchaseOrderRepository(_context);

        }
        public dynamic GetSAPLastSyncDate(SyncSAPDataType key)
        {
            var syncSAPdatatypeid = (int)key;
            var obj = _context.SAPDataSyncDetails.FirstOrDefault(x => x.SAPDataSyncDetailsId == syncSAPdatatypeid);
            return ((obj != null && obj.LastSyncDate != null) ? obj.LastSyncDate : null);
        }

        public async Task<bool> SyncMaterialGroup(IList<MaterialGroups> sapData)
        {

            // Scenario 1 : SAP Data Empty.
            if (sapData == null || sapData.Count == 0)
            {
                return true;
            }
            try
            {
                _logger.LogInformation($"MaterialGroup : From SAP = {sapData.Count()}");
                var eiqcMaterialGroup = await _materialGroupRepository.GetAll();

                var newRec = new List<MaterialGroup>();
                var delRec = new List<MaterialGroup>();
                var disabledRec = new List<MaterialGroup>();

                // Scenario 2 : EIQC Database Empty.

                if (eiqcMaterialGroup == null || !eiqcMaterialGroup.Any())
                {
                    // Add active records
                    var activeMaterialGroup = sapData.Where(x => !x.Deleted).ToList();
                    newRec = _mapper.Map<IList<MaterialGroups>, IList<MaterialGroup>>(activeMaterialGroup).ToList();
                }
                else
                {
                    // Scenario 3 :Eiqc and SAP both have data.
                    // Get matching records to find deleted and inactive records.
                    var matchingMaterialGroup = from eiqcMG in eiqcMaterialGroup
                                                join sapMG in sapData on eiqcMG.MaterialGroupName equals sapMG.MaterialGroupName
                                                select new { EiqcMG = eiqcMG, sapMGroup = sapMG };
                    // Get deleted records from SAP and set warning.
                    delRec = matchingMaterialGroup.Where(x => x.sapMGroup.Deleted == true).Select(x => x.EiqcMG).ToList();
                    // Get inactive records from Eiqc and set warning
                    disabledRec = matchingMaterialGroup.Where(x => x.EiqcMG.Status == StatusType.Inactive).Select(x => x.EiqcMG).ToList();
                    // Get all new records.
                    var newRecords = sapData.Except(matchingMaterialGroup.Select(x => x.sapMGroup)).ToList();
                    if (newRecords.Any())
                    {
                        newRec = _mapper.Map<IList<MaterialGroups>, IList<MaterialGroup>>(newRecords).ToList();
                        _logger.LogInformation($"SyncMaterialGroup : New = {JsonConvert.SerializeObject(newRec, Newtonsoft.Json.Formatting.Indented)}");
                    }
                }

                if (newRec.Any())
                {
                    _materialGroupRepository.AddRange(newRec);
                    UpdateSyncUTCTime((int)SyncSAPDataType.Last_Sync_MaterialGroup, materialGroup);
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
            var sysVar = _context.SAPDataSyncDetails.FirstOrDefault(x => x.SAPDataSyncDetailsId == sysVarId);
            if (sysVar != null)
            {
                sysVar.LastSyncDate = DateTimeOffset.UtcNow;
                _logger.LogInformation($"UpdateSyncUTCTime({sysVarId}) : {sysVar.LastSyncDate.ToString()}");
            }
            else
            {
                SAPDataSyncDetails sapDataSyncDetails = new SAPDataSyncDetails()
                {
                    Name = name,
                    LastSyncDate = DateTimeOffset.UtcNow,
                };
                _syncSAPDataSyncDetailsRepository.AddAsync(sapDataSyncDetails, $"Sync up from SAP for{name} ");
            }

        }

        public async Task<bool> SyncPart(IList<SAPPartModel> sapData)
        {

            // Scenario 1 : SAP Data Empty.
            if (sapData == null || sapData.Count == 0)
            {
                return true;
            }
            try
            {
                _logger.LogInformation($"Part : From SAP = {sapData.Count()}");
                var eiqParts = await _partRepository.GetAll();

                var newRec = new List<Part>();
                var delRec = new List<Part>();
                var disabledRec = new List<Part>();

                // Scenario 2 : EIQC Database Empty.

                if (eiqParts == null || !eiqParts.Any())
                {
                    // Add active records
                    var activeInspectionParts = sapData.ToList();
                    newRec = _mapper.Map<IList<SAPPartModel>, IList<Part>>(activeInspectionParts).ToList();
                }
                else
                {
                    // Scenario 3 :Eiqc and SAP both have data.
                    // Get matching records to find deleted and inactive records.
                    var matchingParts = from eiqcPart in eiqParts
                                        join sapPart in sapData on eiqcPart.PartNo equals sapPart.PartNo
                                        select new { EiqcPart = eiqcPart, sapPart = sapPart };
                    // Get deleted records from SAP and set warning.
                    //delRec = matchingParts.Where(x => x.sapPart.Deleted == true).Select(x => x.EiqcPart).ToList();
                    // Get inactive records from Eiqc and set warning
                    disabledRec = matchingParts.Where(x => x.EiqcPart.Status == StatusType.Inactive).Select(x => x.EiqcPart).ToList();
                    // Get all new records.
                    var newRecords = sapData.Except(matchingParts.Select(x => x.sapPart)).ToList();
                    if (newRecords.Any())
                    {
                        newRec = _mapper.Map<IList<SAPPartModel>, IList<Part>>(newRecords).ToList();
                        _logger.LogInformation($"SyncParts : New = {JsonConvert.SerializeObject(newRec, Newtonsoft.Json.Formatting.Indented)}");
                    }
                }

                if (newRec.Any())
                {
                    _partRepository.AddRange(newRec);
                    UpdateSyncUTCTime((int)SyncSAPDataType.Last_Sync_Part, Part);
                }

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<bool> SyncPurchaseOrders(IList<SAPPurchaseOrderModel> sapData)
        {

            if (sapData == null || sapData.Count == 0)
            {
                return true;
            }
            try
            {
                _logger.LogInformation($"PurchaseOrder : From SAP = {sapData.Count()}");

                IEnumerable<PurchaseOrder> eiqcPurchaseOrder = await _purchaseOrderRepository.GetAll();

                var newPurchaseOrder = new List<PurchaseOrder>();

                if (eiqcPurchaseOrder == null || !eiqcPurchaseOrder.Any())
                {

                    var activePurchaseOrder = sapData.ToList();
                    newPurchaseOrder = _mapper.Map<IList<SAPPurchaseOrderModel>, IList<PurchaseOrder>>(activePurchaseOrder).ToList();
                }
                else
                {

                    var matchingPurchaseOrder = from eiqCM in eiqcPurchaseOrder
                                                join sapCM in sapData on eiqCM.PurchaseOrderNo.Trim() equals sapCM.PO_NO.Trim()
                                                select new { EiqcCM = eiqCM, sapCom = sapCM };

                    var newPurchaseOrderRecords = sapData.Except(matchingPurchaseOrder.Select(x => x.sapCom)).ToList();

                    if (newPurchaseOrderRecords.Any())
                    {
                        newPurchaseOrder = _mapper.Map<IList<SAPPurchaseOrderModel>, IList<PurchaseOrder>>(newPurchaseOrderRecords).ToList();
                        _logger.LogInformation($"SyncPurchaseOrder : New = {JsonConvert.SerializeObject(newPurchaseOrder, Newtonsoft.Json.Formatting.Indented)}");
                    }

                    var updatedSAPPurchaseOrders = matchingPurchaseOrder.Where(k => k.EiqcCM.PurchaseOrderNo == k.sapCom.PO_NO
                    && (k.EiqcCM.Site.Trim() != k.sapCom.SITE.Trim() || k.EiqcCM.PartNo != k.sapCom.PART_NO || k.EiqcCM.MPNMaterial != k.sapCom.MPN_MATERIAL
                        || k.EiqcCM.PurchaseOrderNo.Trim() != k.sapCom.PO_NO.Trim() || k.EiqcCM.PurchaseOrderLineNo.Trim() != k.sapCom.PO_LINE_NO.Trim()
                        || k.EiqcCM.Quantity != k.sapCom.QUANTITY || k.EiqcCM.VendorCode.Trim() != k.sapCom.VENDOR_CODE.Trim()
                        || k.EiqcCM.Manufacturer.Trim() != k.sapCom.MANUFACTURER.Trim() || k.EiqcCM.ManufacturerPartNo.Trim() != k.sapCom.MANUF_PART_NO.Trim()
                        || k.EiqcCM.PurchaseOrderStatus.Trim() != k.sapCom.PO_STATUS.Trim() || k.EiqcCM.Deleted.Trim() != k.sapCom.DELETED.Trim()
                        || k.EiqcCM.QuantityDelivered != k.sapCom.QTY_DELIVERED || k.EiqcCM.PurchaseOrg.Trim() != k.sapCom.PURCHASE_ORG.Trim()
                        || k.EiqcCM.PurchaseGroup.Trim() != k.sapCom.PURCHASE_GROUP.Trim() || k.EiqcCM.CompanyCode.Trim() != k.sapCom.COMPANY_CODE.Trim()
                        || k.EiqcCM.DeliveryComplete.Trim() != k.sapCom.DELIVERY_COMPLETE.Trim()));

                    var updatedPurchaseOrderRecords = sapData.Intersect(updatedSAPPurchaseOrders.Select(x => x.sapCom)).ToList();

                    foreach (var sapSupplierData in updatedPurchaseOrderRecords)
                    {
                        var dbSupplier = _context.PurchaseOrder.Where(d => d.PurchaseOrderNo == sapSupplierData.PO_NO).FirstOrDefault();
                        if (dbSupplier != null)
                        {
                            dbSupplier.SAPPurchaseOrderId = sapSupplierData.PurchaseOrderId;
                            dbSupplier.Site = sapSupplierData.SITE;
                            dbSupplier.PartNo = sapSupplierData.PART_NO;
                            dbSupplier.MPNMaterial = sapSupplierData.MPN_MATERIAL;
                            dbSupplier.CreatedDate = sapSupplierData.CREATED_DATE;
                            dbSupplier.PurchaseOrderNo = sapSupplierData.PO_NO;
                            dbSupplier.PurchaseOrderLineNo = sapSupplierData.PO_LINE_NO;
                            dbSupplier.Quantity = Convert.ToDecimal(sapSupplierData.QUANTITY);
                            dbSupplier.VendorCode = sapSupplierData.VENDOR_CODE;
                            dbSupplier.Manufacturer = sapSupplierData.MANUFACTURER;
                            dbSupplier.ManufacturerPartNo = sapSupplierData.MANUF_PART_NO;
                            dbSupplier.PurchaseOrderStatus = sapSupplierData.PO_STATUS;
                            dbSupplier.Deleted = sapSupplierData.DELETED;
                            dbSupplier.QuantityDelivered = Convert.ToDecimal(sapSupplierData.QTY_DELIVERED);
                            dbSupplier.PurchaseGroup = sapSupplierData.PURCHASE_GROUP;
                            dbSupplier.PurchaseOrg = sapSupplierData.PURCHASE_ORG;
                            dbSupplier.CompanyCode = sapSupplierData.COMPANY_CODE;
                            dbSupplier.DeliveryComplete = sapSupplierData.DELIVERY_COMPLETE;
                            dbSupplier.Status = StatusType.Active;
                        }
                    }
                }

                if (newPurchaseOrder.Any())
                {
                    _purchaseOrderRepository.AddRange(newPurchaseOrder);
                }

                UpdateSyncUTCTime((int)SyncSAPDataType.Last_Sync_PurchaseOrder, supplier);

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> SyncCommodity(IList<SAPCommodity> sapData)
        {

            if (sapData == null || sapData.Count == 0)
            {
                UpdateSyncUTCTime((int)SyncSAPDataType.Last_Sync_Commodity, commodity);
                _context.SaveChanges();
                return true;
            }
            try
            {
                _logger.LogInformation($"Commodity : From SAP = {sapData.Count()}");

                IEnumerable<Commodity> eiqcCommodity = await _commodityRepository.GetAll();
                var sAPCommodityWithoutParts = sapData.Select(y => new SAPCommodityWithoutPart { SAPCommodityId = y.SAPCommodityId, CommodityValidFrom = y.CommodityValidFrom, CommodityValidTo = y.CommodityValidTo, Name = y.Name, Description = y.Description }).Distinct().ToList();
                var uniqueCommodity = sAPCommodityWithoutParts.GroupBy(c => c.SAPCommodityId).Select(group => group.FirstOrDefault()).OrderBy(x => x.SAPCommodityId).ToList();
                var newCommodity = new List<Commodity>();

                if (eiqcCommodity == null || !eiqcCommodity.Any())
                {
                    List<SAPCommodity> activeCommodity = _mapper.Map<IList<SAPCommodityWithoutPart>, IList<SAPCommodity>>(uniqueCommodity).ToList();
                    newCommodity = _mapper.Map<IList<SAPCommodity>, IList<Commodity>>(activeCommodity).ToList();
                }
                else
                {

                    var matchingCommodity = from eiqCM in eiqcCommodity
                                            join sapCM in uniqueCommodity on eiqCM.Name equals sapCM.Name
                                            select new { EiqcCM = eiqCM, sapCom = sapCM };

                    var uniqueCommodityRecords = uniqueCommodity.Except(matchingCommodity.Select(x => x.sapCom)).ToList();
                    List<SAPCommodity> newCommodityRecords = _mapper.Map<IList<SAPCommodityWithoutPart>, IList<SAPCommodity>>(uniqueCommodityRecords).ToList();

                    if (newCommodityRecords.Any())
                    {
                        newCommodity = _mapper.Map<IList<SAPCommodity>, IList<Commodity>>(newCommodityRecords).ToList();
                        _logger.LogInformation($"SyncCommodity : New = {JsonConvert.SerializeObject(newCommodity, Newtonsoft.Json.Formatting.Indented)}");
                    }

                    var updatedSAPCommodities = matchingCommodity.Where(k => k.EiqcCM.SAPCommodityId == k.sapCom.SAPCommodityId && k.EiqcCM.Name == k.sapCom.Name
                    && (k.EiqcCM.SAPCommodityId != k.sapCom.SAPCommodityId || k.EiqcCM.Description != k.sapCom.Description
                        || k.EiqcCM.CommodityValidFrom != k.sapCom.CommodityValidFrom
                        || k.EiqcCM.CommodityValidTo != k.sapCom.CommodityValidTo));

                    var updatedCommodityRecords = uniqueCommodity.Intersect(updatedSAPCommodities.Select(x => x.sapCom)).ToList();

                    foreach (var sapCommodityData in updatedCommodityRecords)
                    {
                        var dbCommodity = _context.Commodity.Where(d => d.SAPCommodityId == sapCommodityData.SAPCommodityId).FirstOrDefault();
                        if (dbCommodity != null)
                        {
                            dbCommodity.Name = sapCommodityData.Name;
                            dbCommodity.Description = sapCommodityData.Description;
                            dbCommodity.SAPCommodityId = sapCommodityData.SAPCommodityId;
                            dbCommodity.AppearanceInspectionItem = "";
                            dbCommodity.FunctionTestItem = "";
                            dbCommodity.CommodityValidFrom = sapCommodityData.CommodityValidFrom;
                            dbCommodity.CommodityValidTo = sapCommodityData.CommodityValidTo;
                            dbCommodity.Status = StatusType.Active;
                        }
                    }
                }

                if (newCommodity.Any())
                {
                    _commodityRepository.AddRange(newCommodity);
                }

                UpdateSyncUTCTime((int)SyncSAPDataType.Last_Sync_Commodity, commodity);

                _context.SaveChanges();

                await SyncCommodityPartNumberSite(sapData);


                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private async Task<bool> SyncCommodityPartNumberSite(IList<SAPCommodity> sapData)
        {
            try
            {
                // ==============To Sync Part Number Commodity Data
                _logger.LogInformation($"CommodityPartNumberSite : From SAP = {sapData.Count()}");

                IEnumerable<CommodityPartNumberSite> eiqcCommodityPartNumberSite = await _commodityPartNumberSiteRepository.GetAll();

                var uniqueCommodityPartSite = (from cm in _context.Commodity.AsEnumerable()
                                               join cmps in sapData.AsEnumerable() on cm.SAPCommodityId equals cmps.SAPCommodityId
                                               select new SAPCommodityPartSite { SAPCommodityId = cmps.SAPCommodityId, CommodityId = cm.Id, PartNumber = cmps.PartNumber, SiteNo = cmps.SiteNo }).ToList();

                var newCommodityPartNumberSite = new List<CommodityPartNumberSite>();

                if (eiqcCommodityPartNumberSite == null || !eiqcCommodityPartNumberSite.Any())
                {
                    newCommodityPartNumberSite = _mapper.Map<IList<SAPCommodityPartSite>, IList<CommodityPartNumberSite>>(uniqueCommodityPartSite).ToList();
                }
                else
                {

                    var matchingCommodityPartSite = from eiqCM in eiqcCommodityPartNumberSite
                                                    join sapCM in uniqueCommodityPartSite on eiqCM.PartNumber equals sapCM.PartNumber
                                                    select new { EiqcCM = eiqCM, sapCom = sapCM };

                    var uniqueCommodityPartSiteRecords = uniqueCommodityPartSite.Except(matchingCommodityPartSite.Select(x => x.sapCom)).ToList();
                    List<SAPCommodityPartSite> newCommodityPartSiteRecords = uniqueCommodityPartSiteRecords;

                    if (newCommodityPartSiteRecords.Any())
                    {
                        newCommodityPartNumberSite = _mapper.Map<IList<SAPCommodityPartSite>, IList<CommodityPartNumberSite>>(newCommodityPartSiteRecords).ToList();
                        _logger.LogInformation($"SyncCommodityPartNumberSite : New = {JsonConvert.SerializeObject(newCommodityPartNumberSite, Newtonsoft.Json.Formatting.Indented)}");
                    }

                    var updatedSAPCommodityPartSite = matchingCommodityPartSite.Where(k => k.EiqcCM.CommodityId == k.sapCom.CommodityId && k.EiqcCM.PartNumber == k.sapCom.PartNumber
                    && (k.EiqcCM.CommodityId != k.sapCom.CommodityId || k.EiqcCM.PartNumber != k.sapCom.PartNumber
                        || k.EiqcCM.SiteNo != k.sapCom.SiteNo));

                    var updatedCommodityPartSiteRecords = uniqueCommodityPartSite.Intersect(updatedSAPCommodityPartSite.Select(x => x.sapCom)).ToList();


                    foreach (var sapCommodityPartSiteData in updatedCommodityPartSiteRecords)
                    {
                        var dbCommodityPartSite = _context.CommodityPartNumberSite.Where(d => d.CommodityId == sapCommodityPartSiteData.CommodityId).FirstOrDefault();
                        if (dbCommodityPartSite != null)
                        {
                            dbCommodityPartSite.PartNumber = sapCommodityPartSiteData.PartNumber;
                            dbCommodityPartSite.SiteNo = sapCommodityPartSiteData.SiteNo;
                            dbCommodityPartSite.CommodityId = sapCommodityPartSiteData.CommodityId;
                            // dbCommodityPartSite.Status = StatusType.Active;
                        }
                    }
                }

                if (newCommodityPartNumberSite.Any())
                {
                    _commodityPartNumberSiteRepository.AddRange(newCommodityPartNumberSite);
                }

                // End Part Number Commodity Sync data

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SyncSuppliers(IList<SAPSupplierModel> sapData, string valuationArea)
        {
            if (sapData == null || sapData.Count == 0)
            {
                return true;
            }
            try
            {
                _logger.LogInformation($"Supplier : From SAP = {sapData.Count()}");

                IEnumerable<Supplier> eiqcSupplier = null;
                if (!string.IsNullOrEmpty(valuationArea))
                {
                    valuationArea = valuationArea.Replace("'", "");
                    eiqcSupplier = _context.Supplier.Where(k => k.ValuationArea == valuationArea);
                }


                var newSupplier = new List<Supplier>();

                if (eiqcSupplier == null || !eiqcSupplier.Any())
                {

                    var activeSupplier = sapData.ToList();
                    newSupplier = _mapper.Map<IList<SAPSupplierModel>, IList<Supplier>>(activeSupplier).ToList();
                }
                else
                {

                    var matchingSupplier = from eiqCM in eiqcSupplier
                                           join sapCM in sapData on
                                           eiqCM.ValuationArea.Trim() equals sapCM.VALUATION_AREA.Trim()
                                           where !string.IsNullOrEmpty(eiqCM.Email) && !string.IsNullOrEmpty(sapCM.EMAIL) && eiqCM.Email.Trim() == sapCM.EMAIL.Trim() &&
                                           !string.IsNullOrEmpty(eiqCM.VendorCode) && !string.IsNullOrEmpty(sapCM.VENDOR_CODE) && eiqCM.VendorCode.Trim() == sapCM.VENDOR_CODE.Trim()
                                           select new { EiqcCM = eiqCM, sapCom = sapCM };

                    var newSupplierRecords = sapData.Except(matchingSupplier.Select(x => x.sapCom)).ToList();

                    if (newSupplierRecords.Any())
                    {
                        newSupplier = _mapper.Map<IList<SAPSupplierModel>, IList<Supplier>>(newSupplierRecords).ToList();
                        _logger.LogInformation($"SyncSupplier : New = {JsonConvert.SerializeObject(newSupplier, Newtonsoft.Json.Formatting.Indented)}");
                    }

                    var updatedSAPSuppliers = matchingSupplier.Where(k => k.EiqcCM.SAPSupplierModel_ID == k.sapCom.SAPSupplierModel_ID && k.EiqcCM.Email.Trim() == k.sapCom.EMAIL.Trim()
                    && (k.EiqcCM.SiteCode.Trim() != k.sapCom.SITE_CODE.Trim() || k.EiqcCM.PhoneNo != k.sapCom.PHONE_NO || k.EiqcCM.FaxNo != k.sapCom.FAX_NO
                        || k.EiqcCM.VendorCode.Trim() != k.sapCom.VENDOR_CODE.Trim() || k.EiqcCM.VendorName.Trim() != k.sapCom.VENDOR_NAME.Trim()
                        || k.EiqcCM.Address.Trim() != k.sapCom.ADDRESS_NO.Trim() || k.EiqcCM.StreetNo.Trim() != k.sapCom.STREET_NO.Trim()
                        || k.EiqcCM.City.Trim() != k.sapCom.CITY.Trim() || k.EiqcCM.PostalCode.Trim() != k.sapCom.POSTAL_CODE.Trim()
                        || k.EiqcCM.Country.Trim() != k.sapCom.COUNTRY.Trim() || k.EiqcCM.SupplierStatus.Trim() != k.sapCom.SUPPLIER_STATUS.Trim()
                        || k.EiqcCM.SearchTerm.Trim() != k.sapCom.SEARCH_TERM.Trim() || k.EiqcCM.SiteName.Trim() != k.sapCom.SITE_NAME.Trim()
                        || k.EiqcCM.VendorName2.Trim() != k.sapCom.VENDOR_NAME2.Trim() || k.EiqcCM.VendorName3.Trim() != k.sapCom.VENDOR_NAME3.Trim()
                        || k.EiqcCM.VendorName4.Trim() != k.sapCom.VENDOR_NAME4.Trim() || k.EiqcCM.IcSite.Trim() != k.sapCom.IC_SITE.Trim()
                        || k.EiqcCM.VendorAcctGrp.Trim() != k.sapCom.VENDOR_ACCT_GRP.Trim() || k.EiqcCM.PurchaseOrg.Trim() != k.sapCom.PURCHASE_ORG.Trim()
                        || k.EiqcCM.SalesOrgPoc.Trim() != k.sapCom.SALES_ORG_POC.Trim() || k.EiqcCM.CompanyCode.Trim() != k.sapCom.COMPANY_CODE.Trim()
                        || k.EiqcCM.ValuationArea.Trim() != k.sapCom.VALUATION_AREA.Trim() || k.EiqcCM.IcVendorOfPlant.Trim() != k.sapCom.IC_VENDOR_OF_PLANT.Trim()
                        || k.EiqcCM.CreatedDate.Trim() != k.sapCom.CREATED_DATE.Trim() || k.EiqcCM.Region.Trim() != k.sapCom.REGION.Trim()
                        || k.EiqcCM.LandCode.Trim() != k.sapCom.LAND_CODE.Trim()));

                    var updatedSupplierRecords = sapData.Intersect(updatedSAPSuppliers.Select(x => x.sapCom)).ToList();

                    foreach (var sapSupplierData in updatedSupplierRecords)
                    {
                        var dbSupplier = _context.Supplier.Where(d => d.SAPSupplierModel_ID == sapSupplierData.SAPSupplierModel_ID).FirstOrDefault();
                        if (dbSupplier != null)
                        {
                            dbSupplier.SAPSupplierModel_ID = sapSupplierData.SAPSupplierModel_ID;
                            dbSupplier.SiteCode = sapSupplierData.SITE_CODE;
                            dbSupplier.Email = sapSupplierData.EMAIL;
                            dbSupplier.PhoneNo = sapSupplierData.PHONE_NO;
                            dbSupplier.FaxNo = sapSupplierData.FAX_NO;
                            dbSupplier.VendorCode = sapSupplierData.VENDOR_CODE;
                            dbSupplier.VendorName = sapSupplierData.VENDOR_NAME;
                            dbSupplier.Address = sapSupplierData.ADDRESS_NO;
                            dbSupplier.StreetNo = sapSupplierData.STREET_NO;
                            dbSupplier.City = sapSupplierData.CITY;
                            dbSupplier.PostalCode = sapSupplierData.POSTAL_CODE;
                            dbSupplier.Country = sapSupplierData.COUNTRY;
                            dbSupplier.SupplierStatus = sapSupplierData.SUPPLIER_STATUS;
                            dbSupplier.SearchTerm = sapSupplierData.SEARCH_TERM;
                            dbSupplier.SiteName = sapSupplierData.SITE_NAME;
                            dbSupplier.VendorName2 = sapSupplierData.VENDOR_NAME2;
                            dbSupplier.VendorName3 = sapSupplierData.VENDOR_NAME3;
                            dbSupplier.VendorName4 = sapSupplierData.VENDOR_NAME4;
                            dbSupplier.IcSite = sapSupplierData.IC_SITE;
                            dbSupplier.VendorAcctGrp = sapSupplierData.VENDOR_ACCT_GRP;
                            dbSupplier.PurchaseOrg = sapSupplierData.PURCHASE_ORG;
                            dbSupplier.SalesOrgPoc = sapSupplierData.SALES_ORG_POC;
                            dbSupplier.CompanyCode = sapSupplierData.COMPANY_CODE;
                            dbSupplier.ValuationArea = sapSupplierData.VALUATION_AREA;
                            dbSupplier.IcVendorOfPlant = sapSupplierData.IC_VENDOR_OF_PLANT;
                            dbSupplier.CreatedDate = sapSupplierData.CREATED_DATE;
                            dbSupplier.Region = sapSupplierData.REGION;
                            dbSupplier.LandCode = sapSupplierData.LAND_CODE;
                            dbSupplier.Status = StatusType.Active;
                        }
                    }
                }

                if (newSupplier.Any())
                {
                    _supplierRepository.AddRange(newSupplier);
                }

                UpdateSyncUTCTime((int)SyncSAPDataType.Last_Sync_Supplier, supplier);

                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
