using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QSS.eIQC.SAPHana.Services.Models
{
    public class SAPSampleSizeCalcModel
    {
        [Key]
        public string Id { get; set; }
        public string PartNo { get; set; }
        public string PlanType { get; set; }
        public string GrpNo { get; set; }
        public string GrpCounter { get; set; }
        public string CounterAdd { get; set; }
        public string Counter { get; set; }
        public string Site { get; set; }
        public string Qdmr { get; set; }
        public string Dmr { get; set; }
        public string SmplProc { get; set; }
        public string DeleteInd { get; set; }
        public string InspChar { get; set; }
        public string InspMethod { get; set; }
        public string MethodVer { get; set; }
        public string MethodSite { get; set; }
        public string MstrInspChar { get; set; }
        public string MstrVer { get; set; }
        public string SmplSize { get; set; }
        public string SmplType { get; set; }
        public string ValuationMode { get; set; }
        public string SmplScheme { get; set; }
        public string InspSev { get; set; }
        public string NoUseIp { get; set; }
        public string UseIp { get; set; }
        public string DetermineKey { get; set; }
        public string QdShortText { get; set; }
        public string CreatedOn { get; set; }
        public string ChangedOn { get; set; }
        public string SeqCtrItScheme { get; set; }
        public string SeqCtrSiScheme { get; set; }
        public string NoSmplSize { get; set; }
        public string LotSize { get; set; }
        public string AcptNo { get; set; }
        public string RejNo { get; set; }
        public string QdpaInspSev { get; set; }
        public string QdpsInspSev { get; set; }
        public string InspStage { get; set; }
        public string NewInspStgOk { get; set; }
        public string NewInspStgNok { get; set; }
        public string QddrDmr { get; set; }
        public string InitInspStage { get; set; }
        public string QdqlSeqCtr { get; set; }
        public string QdqlDmr { get; set; }
        public string NextInspStage { get; set; }
        public string VendorCode { get; set; }
        public string PART_NO { get; set; }
        public string VENDOR_CODE { get; set; }

    }
}
