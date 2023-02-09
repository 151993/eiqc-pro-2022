namespace QSS.eIQC.Handlers.Commands
{
    public class AuditLogModifiedFieldModel
    {
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
