namespace QSS.eIQC.Handlers.Commands
{
    public class AuditLogModel : BaseModel<long>
    {
        public string AuditLogType { get; set; }
        public string Title { get; set; }
        public string ChangeReason { get; set; }
        public virtual AuditDataModel AuditData { get; set; }
    }
}
