/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.SAPHana.Services.Models;

namespace QSS.eIQC.Handlers.Commands.SAPSamplingPlanCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SAPSamplingPlanModel, SamplingPlanModel>()
                .ForMember(dest => dest.SamplingPlanId, opt =>
                {
                    opt.MapFrom(src => src.ID);
                })
               .ForMember(dest => dest.PartNo, opt =>
               {
                   opt.MapFrom(src => src.PART_NO);
               })
               .ForMember(dest => dest.Site, opt =>
               {
                   opt.MapFrom(src => src.SITE);
               })
               .ForMember(dest => dest.MaterialGroup, opt =>
               {
                   opt.MapFrom(src => src.MATERIAL_GROUP);
               })
               .ForMember(dest => dest.TaskListType, opt =>
               {
                   opt.MapFrom(src => src.TASK_LIST_TYPE);
               })
              .ForMember(dest => dest.Group, opt =>
               {
                   opt.MapFrom(src => src.GROUP);
               })
               .ForMember(dest => dest.GrpCtr, opt =>
               {
                   opt.MapFrom(src => src.GRP_CTR);
               })
               .ForMember(dest => dest.Counter, opt =>
               {
                   opt.MapFrom(src => src.COUNTER);
               })
               .ForMember(dest => dest.TaskListNode, opt =>
               {
                   opt.MapFrom(src => src.TASK_LIST_NODE);
               })
               .ForMember(dest => dest.BaseQty, opt =>
               {
                   opt.MapFrom(src => src.BASE_QTY);
               })
               .ForMember(dest => dest.CharType, opt =>
               {
                   opt.MapFrom(src => src.CHAR_TYPE);
               })
               .ForMember(dest => dest.InspChar, opt =>
               {
                   opt.MapFrom(src => src.INSP_CHAR);

               }).ForMember(dest => dest.SmplProc, opt =>
               {
                   opt.MapFrom(src => src.SMPL_PROC);
               })
               .ForMember(dest => dest.Version, opt =>
               {
                   opt.MapFrom(src => src.VERSION);
               })
               .ForMember(dest => dest.MstrChar, opt =>
               {
                   opt.MapFrom(src => src.MSTRCHAR);
               })
               .ForMember(dest => dest.QmCtrlKey, opt =>
               {
                   opt.MapFrom(src => src.QM_CTRL_KEY);
               })
               .ForMember(dest => dest.CertType, opt =>
               {
                   opt.MapFrom(src => src.CERT_TYPE);
               })
               .ForMember(dest => dest.InspSetUp, opt =>
               {
                   opt.MapFrom(src => src.INSP_SETUP);
               })
               .ForMember(dest => dest.QmActive, opt =>
               {
                   opt.MapFrom(src => src.QM_ACTIVE);
               })
               .ForMember(dest => dest.InspShortText, opt =>
               {
                   opt.MapFrom(src => src.INSP_SHORT_TEXT);
               })
               .ForMember(dest => dest.CreatedOn, opt =>
               {
                   opt.MapFrom(src => src.CREATED_ON);
               })
               .ForMember(dest => dest.ValidDate, opt =>
               {
                   opt.MapFrom(src => src.VALID_DATE);
               })
               .ForMember(dest => dest.DeleteInd, opt =>
               {
                   opt.MapFrom(src => src.DELETE_IND);
               })
               .ForMember(dest => dest.InActive, opt =>
               {
                   opt.MapFrom(src => src.INACTIVE);
               });

        }
    }
}
