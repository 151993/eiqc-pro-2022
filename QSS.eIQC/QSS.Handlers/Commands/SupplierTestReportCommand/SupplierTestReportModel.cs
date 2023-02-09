
﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using QSS.eIQC.Handlers.Commands.DefectTypeCommand;
using QSS.eIQC.Handlers.Commands.PartTestReportParameterCommand;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand;
using QSS.eIQC.Handlers.Commands.SupplierTestReportAttachmentCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierTestReportCommand
{
    /// <summary>
    /// Representation model for SupplierTestReport entity
    /// </summary>
    public class SupplierTestReportModel : BaseStausModel<int>
    {
   
        public int SupplierTestReportId { get; set; }
      
        public string InspectionDetails { get; set; }

        public int SupplierMeasurementSubmissionId { get; set; }

        public virtual SupplierMeasurementSubmissionModel SupplierMeasurementSubmission { get; set; }

        public int PartTestReportParameterId { get; set; }

        public virtual PartTestReportParameterModel PartTestReportParameter { get; set; }

        public int? DefectTypeId { get; set; }

        public bool IsChecked { get; set; }

        public bool IsEnabled { get; set; }

        public int ResultId { get; set; }

        public virtual DefectTypeModel DefectType { get; set; }

        public virtual IEnumerable<SupplierTestReportAttachmentModel> SupplierTestReportAttachments { get; set; }

        public List<int> RemovedSupplierTestReportAttachmentIds { get; set; }

        public virtual IEnumerable<AttachmentModel> TestReportAttachments { get; set; }

    }
}
