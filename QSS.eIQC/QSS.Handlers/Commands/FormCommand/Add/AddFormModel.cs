/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.FormCommand.Add
{
    /// <summary>
    /// Representation model for Add Form operation
    /// </summary>
    public class AddFormModel : BaseCommand, IRequest<FormModel>
    {



        /// <summary>
        /// Get or set FormTypeId property
        /// </summary>        
        public int FormTypeId { get; set; }




        /// <summary>
        /// Get or set GRSId property
        /// </summary>        
        public int GRSId { get; set; }

        /// <summary>
        /// Get or set DPID property
        /// </summary>        
        public string DPID { get; set; }

        /// <summary>
        /// Get or set SampleQTY property
        /// </summary>        
        public int SampleQTY { get; set; }

        /// <summary>
        /// Get or set DateCode property
        /// </summary>        
        public string DateCode { get; set; }

        /// <summary>
        /// Get or set DateCodeActual property
        /// </summary>        
        public bool? DateCodeActual { get; set; }

        /// <summary>
        /// Get or set FinalResult property
        /// </summary>        
        public bool? FinalResult { get; set; }

        /// <summary>
        /// Get or set Remark property
        /// </summary>        
        public string Remark { get; set; }

        /// <summary>
        /// Get or set UserName property
        /// </summary>        
        public string UserName { get; set; }

        /// <summary>
        /// Get or set QN property
        /// </summary>        
        public string QN { get; set; }

        /// <summary>
        /// Get or set IPVersion property
        /// </summary>        
        public string IPVersion { get; set; }

        /// <summary>
        /// Get or set RefDoc property
        /// </summary>        
        public string RefDoc { get; set; }

        /// <summary>
        /// Get or set QNSoftcopy property
        /// </summary>        
        public string QNSoftcopy { get; set; }

        /// <summary>
        /// Get or set GRSNoType property
        /// </summary>        
        public string GRSNoType { get; set; }

        /// <summary>
        /// Get or set BatchDC property
        /// </summary>        
        public string BatchDC { get; set; }

        /// <summary>
        /// Get or set StorageLoc property
        /// </summary>        
        public string StorageLoc { get; set; }

        /// <summary>
        /// Get or set RequireStatus property
        /// </summary>        
        public int? RequireStatus { get; set; }

        /// <summary>
        /// Get or set PackQty property
        /// </summary>        
        public int? PackQty { get; set; }

        /// <summary>
        /// Get or set QtyPerBox property
        /// </summary>        
        public double? QtyPerBox { get; set; }

        /// <summary>
        /// Get or set OddQtyPerBox property
        /// </summary>        
        public string OddQtyPerBox { get; set; }

        /// <summary>
        /// Get or set ReceivingInfo property
        /// </summary>        
        public string ReceivingInfo { get; set; }

        /// <summary>
        /// Get or set DANo property
        /// </summary>        
        public string DANo { get; set; }

        /// <summary>
        /// Get or set PackSampleQty property
        /// </summary>        
        public int? PackSampleQty { get; set; }

        /// <summary>
        /// Get or set BuyerID property
        /// </summary>        
        public int? BuyerID { get; set; }

        /// <summary>
        /// Get or set DivisionId property
        /// </summary>        
        public int? DivisionId { get; set; }

        /// <summary>
        /// Get or set SAPDefectTypeID property
        /// </summary>        
        public int? SAPDefectTypeID { get; set; }

        /// <summary>
        /// Get or set VISDefectTypeID property
        /// </summary>        
        public int? VISDefectTypeID { get; set; }

        /// <summary>
        /// Get or set FUNDefectTypeID property
        /// </summary>        
        public int? FUNDefectTypeID { get; set; }

        /// <summary>
        /// Get or set FunMeasureTypeID property
        /// </summary>        
        public int? FunMeasureTypeID { get; set; }

        /// <summary>
        /// Get or set DIMDefectTypeID property
        /// </summary>        
        public int? DIMDefectTypeID { get; set; }

        /// <summary>
        /// Get or set MPositionDefectTypeID property
        /// </summary>        
        public int? MPositionDefectTypeID { get; set; }

        /// <summary>
        /// Get or set LPositionDefectTypeID property
        /// </summary>        
        public int? LPositionDefectTypeID { get; set; }

        /// <summary>
        /// Get or set DateCodeDefectTypeID property
        /// </summary>        
        public int? DateCodeDefectTypeID { get; set; }

        /// <summary>
        /// Get or set BowTwistDefectTypeID property
        /// </summary>        
        public int? BowTwistDefectTypeID { get; set; }

        /// <summary>
        /// Get or set FunParaDefectTypeID property
        /// </summary>        
        public int? FunParaDefectTypeID { get; set; }

        /// <summary>
        /// Get or set MicroDefectTypeID property
        /// </summary>        
        public int? MicroDefectTypeID { get; set; }

        /// <summary>
        /// Get or set TestReportDefectTypeID property
        /// </summary>        
        public int? TestReportDefectTypeID { get; set; }

        /// <summary>
        /// Get or set SpecDefectType property
        /// </summary>        
        public string SpecDefectType { get; set; }

        /// <summary>
        /// Get or set LastFormID property
        /// </summary>        
        public int? LastFormID { get; set; }

        /// <summary>
        /// Get or set LockFlag property
        /// </summary>        
        public int? LockFlag { get; set; }

        /// <summary>
        /// Get or set LockUser property
        /// </summary>        
        public string LockUser { get; set; }

        /// <summary>
        /// Get or set DCRequirement property
        /// </summary>        
        public string DCRequirement { get; set; }

    }
}
