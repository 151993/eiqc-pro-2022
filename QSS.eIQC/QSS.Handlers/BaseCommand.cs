namespace QSS.eIQC.Handlers
{
    public abstract class BaseCommand
    {
        /// <summary>
        /// Get or set ChangeReason property
        /// </summary>
        public string ChangeReason { get; set; }

        /// <summary>
        /// Get or set IsEnabled property
        /// </summary>
        public bool IsEnabled { get; set; }
    }
}
