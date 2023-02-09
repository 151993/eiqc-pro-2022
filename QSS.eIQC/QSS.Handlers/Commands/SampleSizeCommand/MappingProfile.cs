/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.SAPHana.Services.Models;
using System;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.SampleSizeCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SAPSampleSizeModel, SAPSampleSizeCalcModel>()
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID))
              .ForMember(dest => dest.PartNo, opt => opt.MapFrom(src => src.PART_NO))
              .ForMember(dest => dest.PlanType, opt => opt.MapFrom(src => src.PLAN_TYPE))
              .ForMember(dest => dest.GrpNo, opt => opt.MapFrom(src => src.GRP_NO))
              .ForMember(dest => dest.GrpCounter, opt => opt.MapFrom(src => src.GRP_COUNTER))
              .ForMember(dest => dest.CounterAdd, opt => opt.MapFrom(src => src.COUNTER_ADD))
              .ForMember(dest => dest.Counter, opt => opt.MapFrom(src => src.COUNTER))
              .ForMember(dest => dest.Site, opt => opt.MapFrom(src => src.SITE))
              .ForMember(dest => dest.Qdmr, opt => opt.MapFrom(src => src.QDMR))
              .ForMember(dest => dest.Dmr, opt => opt.MapFrom(src => src.DMR))
              .ForMember(dest => dest.SmplProc, opt => opt.MapFrom(src => src.SMPL_PROC))
              .ForMember(dest => dest.DeleteInd, opt => opt.MapFrom(src => src.DELETE_IND))
              .ForMember(dest => dest.InspChar, opt => opt.MapFrom(src => src.INSP_CHAR))
              .ForMember(dest => dest.InspMethod, opt => opt.MapFrom(src => src.INSP_METHOD))
              .ForMember(dest => dest.MethodVer, opt => opt.MapFrom(src => src.METHOD_VER))
              .ForMember(dest => dest.MethodSite, opt => opt.MapFrom(src => src.METHOD_SITE))
              .ForMember(dest => dest.MstrInspChar, opt => opt.MapFrom(src => src.MSTR_INSP_CHAR))
              .ForMember(dest => dest.MstrVer, opt => opt.MapFrom(src => src.MSTR_VER))
              .ForMember(dest => dest.SmplSize, opt => opt.MapFrom(src => src.SMPL_SIZE))
              .ForMember(dest => dest.SmplType, opt => opt.MapFrom(src => src.SMPL_TYPE))
              .ForMember(dest => dest.ValuationMode, opt => opt.MapFrom(src => src.VALUATION_MODE))
              .ForMember(dest => dest.SmplScheme, opt => opt.MapFrom(src => src.SMPL_SCHEME))
              .ForMember(dest => dest.InspSev, opt => opt.MapFrom(src => src.INSP_SEV))
              .ForMember(dest => dest.NoUseIp, opt => opt.MapFrom(src => src.NO_USE_IP))
              .ForMember(dest => dest.UseIp, opt => opt.MapFrom(src => src.USE_IP))
              .ForMember(dest => dest.DetermineKey, opt => opt.MapFrom(src => src.DETERMINE_KEY))
              .ForMember(dest => dest.QdShortText, opt => opt.MapFrom(src => src.QD_SHORT_TEXT))
              .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.CREATED_ON))
              .ForMember(dest => dest.ChangedOn, opt => opt.MapFrom(src => src.CHANGED_ON))
              .ForMember(dest => dest.SeqCtrItScheme, opt => opt.MapFrom(src => src.SEQ_CTR_IT_SCHEME))
              .ForMember(dest => dest.SeqCtrSiScheme, opt => opt.MapFrom(src => src.SEQ_CTR_SI_SCHEME))
              .ForMember(dest => dest.NoSmplSize, opt => opt.MapFrom(src => src.NO_SMPL_SIZE))
              .ForMember(dest => dest.LotSize, opt => opt.MapFrom(src => src.LOT_SIZE))
              .ForMember(dest => dest.AcptNo, opt => opt.MapFrom(src => src.ACPT_NO))
              .ForMember(dest => dest.RejNo, opt => opt.MapFrom(src => src.REJ_NO))
              .ForMember(dest => dest.QdpaInspSev, opt => opt.MapFrom(src => src.QDPA_INSP_SEV))
              .ForMember(dest => dest.QdpsInspSev, opt => opt.MapFrom(src => src.QDPS_INSP_SEV))
              .ForMember(dest => dest.InspStage, opt => opt.MapFrom(src => src.INSP_STAGE))
              .ForMember(dest => dest.NewInspStgOk, opt => opt.MapFrom(src => src.NEW_INSP_STG_OK))
              .ForMember(dest => dest.NewInspStgNok, opt => opt.MapFrom(src => src.NEW_INSP_STG_NOK))
              .ForMember(dest => dest.QddrDmr, opt => opt.MapFrom(src => src.QDDR_DMR))
              .ForMember(dest => dest.InitInspStage, opt => opt.MapFrom(src => src.INIT_INSP_STAGE))
              .ForMember(dest => dest.QdqlSeqCtr, opt => opt.MapFrom(src => src.QDQL_SEQ_CTR))
              .ForMember(dest => dest.QdqlDmr, opt => opt.MapFrom(src => src.QDQL_DMR))
              .ForMember(dest => dest.NextInspStage, opt => opt.MapFrom(src => src.NEXT_INSP_STAGE))
              .ForMember(dest => dest.VendorCode, opt => opt.MapFrom(src => src.VENDOR_CODE));
        }
    }
}
