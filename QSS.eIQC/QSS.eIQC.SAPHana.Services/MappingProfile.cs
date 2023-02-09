using AutoMapper;
using production.pu.XS_PU_COMMODITY_CLASSIFICATION;
using production.pu.XS_PU_EIQC_PO;
using production.pu.XS_PU_EIQC_SUPPLIER;
using production.pu.XS_PU_SAMPLESIZECALC;
using QSS.eIQC.SAPHana.Services.Models;
using Reference;

namespace QSS.eIQC.SAPHana.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<COMMODITY_CLASSType, CommodityClassification>()
                .ForMember(dest => dest.COMMODITY_CLASSIFICATION_ID, opt => opt.MapFrom(src => src.ID));

            CreateMap<POType, SAPPurchaseOrderModel>()
                .ForMember(dest => dest.PurchaseOrderId, opt => opt.MapFrom(src => src.ID))
               .ForMember(dest => dest.PO_STATUS, opt => opt.MapFrom(src => src.STATUS));

            CreateMap<SUPPLIERType, SAPSupplierModel>()
               .ForMember(dest => dest.SAPSupplierModel_ID, opt => opt.MapFrom(src => src.ID))
               .ForMember(dest => dest.SUPPLIER_STATUS, opt => opt.MapFrom(src => src.STATUS));

            CreateMap<SAPSupplierMoqModel, SAPSupplierModel>()
               .ForMember(dest => dest.SAPSupplierModel_ID, opt => opt.MapFrom(src => src.ID))
               .ForMember(dest => dest.SUPPLIER_STATUS, opt => opt.MapFrom(src => src.STATUS));

            CreateMap<PARTNUMBER_BY_SITEType, PartNumberBySiteModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.SITE, opt => opt.MapFrom(src => src.SITE))
                .ForMember(dest => dest.JABIL_PART_NO, opt => opt.MapFrom(src => src.JABIL_PART_NO))
                .ForMember(dest => dest.MPN_MTRL_HERS, opt => opt.MapFrom(src => src.MPN_MTRL_HERS))
                .ForMember(dest => dest.MANUFACTURER, opt => opt.MapFrom(src => src.MANUFACTURER))
                .ForMember(dest => dest.PART_VALID_FROM, opt => opt.MapFrom(src => src.PART_VALID_FROM))
                .ForMember(dest => dest.PART_VALID_TO, opt => opt.MapFrom(src => src.PART_VALID_TO))
                .ForMember(dest => dest.MEDIACODE, opt => opt.MapFrom(src => src.MEDIACODE))
                .ForMember(dest => dest.MANUF_PART_NO, opt => opt.MapFrom(src => src.MANUF_PART_NO))
                .ForMember(dest => dest.MASKED_MPN, opt => opt.MapFrom(src => src.MASKED_MPN))
                .ForMember(dest => dest.MATERIAL_DESC, opt => opt.MapFrom(src => src.MATERIAL_DESC))
                .ForMember(dest => dest.JABIL_OWNER_CONTACT, opt => opt.MapFrom(src => src.JABIL_OWNER_CONTACT))
                .ForMember(dest => dest.MATERIAL_GROUP, opt => opt.MapFrom(src => src.MATERIAL_GROUP))
                .ForMember(dest => dest.CREATED_DATE, opt => opt.MapFrom(src => src.CREATED_DATE))
                .ForMember(dest => dest.LAST_MODIFIED_DATE, opt => opt.MapFrom(src => src.LAST_MODIFIED_DATE));



            CreateMap<SAMPLESIZECALCType, SAPSampleSizeModel>()
              .ForMember(dest => dest.ID , opt => opt.MapFrom(src => src.ID))
              .ForMember(dest => dest.PART_NO , opt => opt.MapFrom(src => src.PART_NO))
              .ForMember(dest => dest.PLAN_TYPE , opt => opt.MapFrom(src => src.PLAN_TYPE))
              .ForMember(dest => dest.GRP_NO , opt => opt.MapFrom(src => src.GRP_NO))
              .ForMember(dest => dest.GRP_COUNTER , opt => opt.MapFrom(src => src.GRP_COUNTER))
              .ForMember(dest => dest.COUNTER_ADD , opt => opt.MapFrom(src => src.COUNTER_ADD))
              .ForMember(dest => dest.COUNTER , opt => opt.MapFrom(src => src.COUNTER))
              .ForMember(dest => dest.SITE , opt => opt.MapFrom(src => src.SITE))
              .ForMember(dest => dest.QDMR , opt => opt.MapFrom(src => src.QDMR))
              .ForMember(dest => dest.DMR , opt => opt.MapFrom(src => src.DMR))
              .ForMember(dest => dest.SMPL_PROC , opt => opt.MapFrom(src => src.SMPL_PROC))
              .ForMember(dest => dest.DELETE_IND , opt => opt.MapFrom(src => src.DELETE_IND))
              .ForMember(dest => dest.INSP_CHAR , opt => opt.MapFrom(src => src.INSP_CHAR))
              .ForMember(dest => dest.INSP_METHOD , opt => opt.MapFrom(src => src.INSP_METHOD))
              .ForMember(dest => dest.METHOD_VER , opt => opt.MapFrom(src => src.METHOD_VER))
              .ForMember(dest => dest.METHOD_SITE , opt => opt.MapFrom(src => src.METHOD_SITE))
              .ForMember(dest => dest.MSTR_INSP_CHAR , opt => opt.MapFrom(src => src.MSTR_INSP_CHAR))
              .ForMember(dest => dest.MSTR_VER , opt => opt.MapFrom(src => src.MSTR_VER))
              .ForMember(dest => dest.SMPL_SIZE , opt => opt.MapFrom(src => src.SMPL_SIZE))
              .ForMember(dest => dest.SMPL_TYPE , opt => opt.MapFrom(src => src.SMPL_TYPE))
              .ForMember(dest => dest.VALUATION_MODE , opt => opt.MapFrom(src => src.VALUATION_MODE))
              .ForMember(dest => dest.SMPL_SCHEME , opt => opt.MapFrom(src => src.SMPL_SCHEME))
              .ForMember(dest => dest.INSP_SEV , opt => opt.MapFrom(src => src.INSP_SEV))
              .ForMember(dest => dest.NO_USE_IP , opt => opt.MapFrom(src => src.NO_USE_IP))
              .ForMember(dest => dest.USE_IP , opt => opt.MapFrom(src => src.USE_IP))
              .ForMember(dest => dest.DETERMINE_KEY , opt => opt.MapFrom(src => src.DETERMINE_KEY))
              .ForMember(dest => dest.QD_SHORT_TEXT , opt => opt.MapFrom(src => src.QD_SHORT_TEXT))
              .ForMember(dest => dest.CREATED_ON , opt => opt.MapFrom(src => src.CREATED_ON))
              .ForMember(dest => dest.CHANGED_ON , opt => opt.MapFrom(src => src.CHANGED_ON))
              .ForMember(dest => dest.SEQ_CTR_IT_SCHEME, opt => opt.MapFrom(src => src.SEQ_CTR_IT_SCHEME))
              .ForMember(dest => dest.SEQ_CTR_SI_SCHEME, opt => opt.MapFrom(src => src.SEQ_CTR_SI_SCHEME))
              .ForMember(dest => dest.NO_SMPL_SIZE , opt => opt.MapFrom(src => src.NO_SMPL_SIZE))
              .ForMember(dest => dest.LOT_SIZE , opt => opt.MapFrom(src => src.LOT_SIZE))
              .ForMember(dest => dest.ACPT_NO , opt => opt.MapFrom(src => src.ACPT_NO))
              .ForMember(dest => dest.REJ_NO , opt => opt.MapFrom(src => src.REJ_NO))
              .ForMember(dest => dest.QDPA_INSP_SEV , opt => opt.MapFrom(src => src.QDPA_INSP_SEV))
              .ForMember(dest => dest.QDPS_INSP_SEV , opt => opt.MapFrom(src => src.QDPS_INSP_SEV))
              .ForMember(dest => dest.INSP_STAGE , opt => opt.MapFrom(src => src.INSP_STAGE))
              .ForMember(dest => dest.NEW_INSP_STG_OK , opt => opt.MapFrom(src => src.NEW_INSP_STG_OK))
              .ForMember(dest => dest.NEW_INSP_STG_NOK , opt => opt.MapFrom(src => src.NEW_INSP_STG_NOK))
              .ForMember(dest => dest.QDDR_DMR , opt => opt.MapFrom(src => src.QDDR_DMR))
              .ForMember(dest => dest.INIT_INSP_STAGE , opt => opt.MapFrom(src => src.INIT_INSP_STAGE))
              .ForMember(dest => dest.QDQL_SEQ_CTR , opt => opt.MapFrom(src => src.QDQL_SEQ_CTR))
              .ForMember(dest => dest.QDQL_DMR , opt => opt.MapFrom(src => src.QDQL_DMR))
              .ForMember(dest => dest.NEXT_INSP_STAGE, opt => opt.MapFrom(src => src.NEXT_INSP_STAGE))
              .ForMember(dest => dest.VENDOR_CODE, opt => opt.MapFrom(src => src.VENDOR_CODE));



            CreateMap<SAMPLINGPLANType, SAPSamplingPlanModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID));
              

        }
    }
}
