/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierFormCommand
{
    /// <summary>
    /// Representation model for SupplierForm entity
    /// </summary>
    public class SupplierFormModel : BaseStausModel<int>
    {


        /// <summary>
        /// Get or set PONo property
        /// </summary>        
        public string PONo { get; set; }



        /// <summary>
        /// Get or set PartNo property
        /// </summary>        
        public string PartNo { get; set; }



        /// <summary>
        /// Get or set FileName property
        /// </summary>        
        public string FileName { get; set; }



        /// <summary>
        /// Get or set DateCode property
        /// </summary>        
        public string DateCode { get; set; }



        /// <summary>
        /// Get or set DateCodeActual property
        /// </summary>        
        public bool? DateCodeActual { get; set; }



        /// <summary>
        /// Get or set ApproveTime property
        /// </summary>        
        public DateTimeOffset? ApproveTime { get; set; }



        /// <summary>
        /// Get or set ApproveUser property
        /// </summary>        
        public string ApproveUser { get; set; }



        /// <summary>
        /// Get or set TotalQty property
        /// </summary>        
        public int TotalQty { get; set; }



        /// <summary>
        /// Get or set SampleQty property
        /// </summary>        
        public int SampleQty { get; set; }



        /// <summary>
        /// Get or set Inspector property
        /// </summary>        
        public string Inspector { get; set; }



        /// <summary>
        /// Get or set Verify property
        /// </summary>        
        public string Verify { get; set; }



        /// <summary>
        /// Get or set ImportStatus property
        /// </summary>        
        public int ImportStatus { get; set; }



        /// <summary>
        /// Get or set ImportError property
        /// </summary>        
        public string ImportError { get; set; }



        /// <summary>
        /// Get or set MO property
        /// </summary>        
        public string MO { get; set; }



        /// <summary>
        /// Get or set MovedPath property
        /// </summary>        
        public string MovedPath { get; set; }

    }
}
