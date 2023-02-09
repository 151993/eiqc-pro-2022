namespace QSS.eIQC.Handlers.Commands
{
    public class AuditDataModel
    {
        public virtual AuditMetadataModel Metadata { get; set; }
        public virtual AuditLogDataModel LogData { get; set; }
    }
}
