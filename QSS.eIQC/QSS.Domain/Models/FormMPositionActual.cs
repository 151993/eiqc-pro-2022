/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// FormMPositionActual entity model to map database FormMPositionActual table 
    /// </summary>
    public class FormMPositionActual : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public FormMPositionActual()
        {
        }

        [AuditLog(DisplayName = "Form", ValueField = "DateCode", MappingField = "FormId")]

        public virtual Form Form { get; set; }
        public int FormId { get; set; }
        [AuditLog]
        public string LineNo { get; set; }
 
        public int No { get; set; }
 
        public double? ValueActual { get; set; }
 
        public double? PositionCalcul { get; set; }
 
        public double? PositionActual { get; set; }
 
        public string Result { get; set; }
 
        public string InstrumentID { get; set; }
 
        public double? Base1Actual { get; set; }
 
        public double? Base2Actual { get; set; }
 
        public double? Base3Actual { get; set; }
 
        public string InstrumentID1 { get; set; }
 
        public string InstrumentID2 { get; set; }
 
        public string InstrumentID3 { get; set; }
 
        public int? PositionType { get; set; }
    }
}
