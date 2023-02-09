namespace QSS.eIQC.Domain
{
    public class AuditMetadata
    {
        public AuditMetadataEntity Entity { get; set; }
    }

    public class AuditMetadataEntity
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
