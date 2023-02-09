using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.MoqData
{
    public static class RegionMoq
    {
        public static Region[] Regions = new[] {
            new Region { Id = 1, Name= "Region 1", Description= "Region Description 1" },
            new Region { Id = 2, Name= "Region 2", Description= "Region Description 2" },
            new Region { Id = 3, Name= "Region 3", Description= "Region Description 3" },
            new Region { Id = 4, Name= "Region 4", Description= "Region Description 4" },
            new Region { Id = 5, Name= "Europe Region 5", Description= "Region Description 5" },
            new Region { Id = 6, Name= "Europe Region 6", Description= "Region Description 6" },
            new Region { Id = 7, Name= "Region 7 Asia", Description= "Region Description 7" },
            new Region { Id = 8, Name= "Region 8 Asia", Description= "Region Description 8" },
            new Region { Id = 9, Name= "Region 9 Asia", Description= "Region Description 9" },
            new Region { Id = 10, Name= "Region 10", Description= "Region Description 10" }
        };
    }
}
