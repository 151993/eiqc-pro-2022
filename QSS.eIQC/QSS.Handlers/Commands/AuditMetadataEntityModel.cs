using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.Handlers.Commands
{
    public class AuditMetadataEntityModel
    {
        [Key]
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
