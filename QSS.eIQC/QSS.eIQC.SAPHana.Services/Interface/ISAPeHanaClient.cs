using production.pu.XS_PU_COMMODITY_CLASSIFICATION;
using production.pu.XS_PU_EIQC_SUPPLIER;
using Reference;
using System.Data.Services.Client;
using production.pu.XS_PU_EIQC_PO;
using production.pu.XS_PU_SAMPLESIZECALC;

namespace QSS.eIQC.SAPHana.Services.Interface
{
    public interface ISAPeHanaClient
    {
        DataServiceQuery<COMMODITY_CLASSType> GetCommodityClassfication();

        DataServiceQuery<COMMODITY_CLASSType> GetCommodityClassficationForAllEnv(string filterValue);

        DataServiceQuery<PARTNUMBER_BY_SITEType> GetPartNumber();

        DataServiceQuery<SUPPLIERType> GetSuppliers();

        DataServiceQuery<SUPPLIERType> GetSuppliersForAllEnv(string filterValue, out string valuationArea);

        DataServiceQuery<POType> GetPurchaseOrder();

        DataServiceQuery<POType> GetPurchaseOrderForAllEnv(string filterValue);        

        DataServiceQuery<SAMPLINGPLANType> GetSamplingPlans();

        DataServiceQuery<SAMPLESIZECALCType> GetSampleSize();

        DataServiceQuery<SAMPLESIZECALCType> GetSampleSizeForHAD(string filterValue);


    }
}
