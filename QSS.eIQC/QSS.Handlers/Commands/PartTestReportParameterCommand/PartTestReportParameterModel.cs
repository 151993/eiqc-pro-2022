/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.AttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartCommand;
using QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using QSS.eIQC.Handlers.Commands.TestReportCommand;

namespace QSS.eIQC.Handlers.Commands.PartTestReportParameterCommand
{
    /// <summary>
    /// Representation model for PartTestReportParameter entity
    /// </summary>
    public class PartTestReportParameterModel : BaseStausModel<int>
    {
        public int PartTestReportParameterId { get; set; }

        public int SAPPartInspectionPlanId { get; set; }

        public int TestReportId { get; set; }

        public bool IsChecked { get; set; }

        public new bool IsEnabled { get; set; }

        public string TestRequirement { get; set; }

        public virtual SAPPartInspectionPlanModel SAPPartInspectionPlan { get; set; }

        public virtual TestReportModel TestReport { get; set; }

        public virtual IEnumerable<PartTestReportAttachmentModel> PartTestReportAttachments { get; set; }

        public List<int> RemovedTestReportAttachmentIds { get; set; }

        public virtual IEnumerable<AttachmentModel> TestReportAttachments { get; set; }


    }
}
