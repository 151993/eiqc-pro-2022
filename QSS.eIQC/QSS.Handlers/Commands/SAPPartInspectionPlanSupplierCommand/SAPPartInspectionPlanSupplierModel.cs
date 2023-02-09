namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand
{
    /// <summary>
    /// Representation model for SAPPartInspectionPlan entity
    /// </summary>
    public class SAPPartInspectionPlanSupplierModel : BaseStausModel<int>
    {
        public int SAPPartInspectionPlanSupplierId { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int SAPPartInspectionPlanId { get; set; }

    }
}