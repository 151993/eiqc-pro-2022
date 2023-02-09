using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.MoqData
{
    public static class DivisionMoq
    {
        public static Division[] Divisions = new[] {
            new Division { Id = 1, Name= "Division 1", Description= "Division Description 1" },
            new Division { Id = 2, Name= "Division 2", Description= "Division Description 2" },
            new Division { Id = 3, Name= "Division 3", Description= "Division Description 3" },
            new Division { Id = 4, Name= "Division 4", Description= "Division Description 4" },
            new Division { Id = 5, Name= "Europe Division 5", Description= "Division Description 5" },
            new Division { Id = 6, Name= "Europe Division 6", Description= "Division Description 6" },
            new Division { Id = 7, Name= "Division 7 Asia", Description= "Division Description 7" },
            new Division { Id = 8, Name= "Division 8 Asia", Description= "Division Description 8" },
            new Division { Id = 9, Name= "Division 9 Asia", Description= "Division Description 9" },
            new Division { Id = 10, Name= "Division 10", Description= "Division Description 10" }
        };
    }
}
