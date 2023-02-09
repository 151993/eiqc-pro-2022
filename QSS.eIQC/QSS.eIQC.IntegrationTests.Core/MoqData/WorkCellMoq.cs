using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.MoqData
{
    public static class WorkCellMoq
    {
        public static WorkCell[] WorkCells = new[] {
            new WorkCell { Id = 1, Name= "WorkCell 1", Description= "WorkCell Description 1" },
            new WorkCell { Id = 2, Name= "WorkCell 2", Description= "WorkCell Description 2" },
            new WorkCell { Id = 3, Name= "WorkCell 3", Description= "WorkCell Description 3" },
            new WorkCell { Id = 4, Name= "WorkCell 4", Description= "WorkCell Description 4" },
            new WorkCell { Id = 5, Name= "Europe WorkCell 5", Description= "WorkCell Description 5" },
            new WorkCell { Id = 6, Name= "Europe WorkCell 6", Description= "WorkCell Description 6" },
            new WorkCell { Id = 7, Name= "WorkCell 7 Asia", Description= "WorkCell Description 7" },
            new WorkCell { Id = 8, Name= "WorkCell 8 Asia", Description= "WorkCell Description 8" },
            new WorkCell { Id = 9, Name= "WorkCell 9 Asia", Description= "WorkCell Description 9" },
            new WorkCell { Id = 10, Name= "WorkCell 10", Description= "WorkCell Description 10" }
        };
    }
}
