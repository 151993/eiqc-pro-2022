namespace QSS.eIQC.Domain
{
    public class AuditData
    {
        public virtual AuditMetadata Metadata { get; set; }
        public virtual AuditLogData LogData { get; set; }
    }
}
