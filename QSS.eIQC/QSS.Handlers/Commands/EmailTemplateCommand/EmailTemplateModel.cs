namespace QSS.eIQC.Handlers.Commands.EmailTemplateCommand
{
    /// <summary>
    /// Representation model for EmailTemplate entity
    /// </summary>
    public class EmailTemplateModel : BaseModel<int>
	{
		/// <summary>
		/// Get or set Name property
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Get or set Subject property
		/// </summary>
		public string Subject { get; set; }

		/// <summary>
		/// Get or set Body property
		/// </summary>
		public string Body { get; set; }
	}
}
