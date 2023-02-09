using System.ComponentModel;

namespace QSS.eIQC.Domain.Enums
{
    public enum StateType : byte
    {
        [Description("Draft")]
        Draft = 1,

        [Description("New Inspection Plan Submission Required By Supplier")]
        New_Inspection_Plan_Submission_Required_By_Supplier = 2,

        [Description("Pending Approval By Jabil")]
        Pending_Approval_By_Jabil = 3,

        [Description("Approved By SQE")]
        Approved_By_SQE = 4,

        [Description("Rejected By SQE")]
        Rejected_By_SQE = 5,

        [Description("Deactivated By SQE")]
        Deactivated_By_SQE = 6,

        [Description("Redefined By SQE")]
        Redefined_By_SQE = 7,

        [Description("Approved By DCC")]
        Approved_By_DCC = 8,

        [Description("Rejected By DCC")]
        Rejected_By_DCC = 9,

        [Description("Submitted By Supplier")]
        Submitted_By_Supplier = 10,

        [Description("Rejected By Supplier")]
        Rejected_By_Supplier = 11,


    }
}
