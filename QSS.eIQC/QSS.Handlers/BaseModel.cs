using QSS.eIQC.Handlers.Commands.UserCommand;
using System;

namespace QSS.eIQC.Handlers
{
    public abstract class BaseModel<T>
    {
        /// <summary>
        /// Get or set Id property
        /// </summary>
        public T Id { get; set; }

        /// <summary>
        /// Get or set Created property
        /// </summary>
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// Get or set CreatedByUser property
        /// </summary>
        public virtual JabilUserModel CreatedByUser { get; set; }

        /// <summary>
        /// Get or set LastUpdated property
        /// </summary>
        public DateTimeOffset LastUpdated { get; set; }

        /// <summary>
        /// Get or set LastUpdatedByUser property
        /// </summary>
        public virtual JabilUserModel LastUpdatedByUser { get; set; }

        /// <summary>
        /// Get or set EnableRowEdit property
        /// </summary>
        public bool EnableRowEdit { get; set; } = true;
        /// <summary>
        /// Get or set enableRowView property
        /// </summary>
        public bool enableRowView { get; set; } = true;
        /// <summary>
        /// Get or set enableRowDelete property
        /// </summary>
        public bool enableRowDelete { get; set; } = true;
        /// <summary>
        /// Get or set enableRowDetail property
        /// </summary>
        public bool enableRowDetail { get; set; } = true;
        /// <summary>
        /// Get or set enableRowAssignToUser property
        /// </summary>
        public bool enableRowAssignToUser { get; set; } = true;

        /// <summary>
        /// Get or set enableRowAddDefectTypes property
        /// </summary>
        public bool enableRowAddDefectTypes { get; set; } = true;
        /// <summary>
        /// Get or set enableRowAddChartType property
        /// </summary>
        public bool enableRowAddChartType { get; set; } = true;

    }

    public abstract class BaseStausModel<T> : BaseModel<T>
    {
        /// <summary>
        /// Get or set IsEnabled property
        /// </summary>
        public bool IsEnabled { get; set; }
    }
}
