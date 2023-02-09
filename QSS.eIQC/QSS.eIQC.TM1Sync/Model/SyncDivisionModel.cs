using System.Collections.Generic;

namespace QSS.eIQC.TM1Sync.Model
{
    public class SyncDivisionModel
    {
        public List<DivisionModel> Divisions { get; set; }

        public int Count => Divisions != null ? Divisions.Count : 0;
    }
}
