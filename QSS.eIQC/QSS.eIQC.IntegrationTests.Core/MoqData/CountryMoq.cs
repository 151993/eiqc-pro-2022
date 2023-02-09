using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.MoqData
{
    public static class CountryMoq
    {
        public static Country[] Countrys = new[] {
            new Country { Id = 1, Name= "Country 1", Description= "Country Description 1" },
            new Country { Id = 2, Name= "Country 2", Description= "Country Description 2" },
            new Country { Id = 3, Name= "Country 3", Description= "Country Description 3" },
            new Country { Id = 4, Name= "Country 4", Description= "Country Description 4" },
            new Country { Id = 5, Name= "Europe Country 5", Description= "Country Description 5" },
            new Country { Id = 6, Name= "Europe Country 6", Description= "Country Description 6" },
            new Country { Id = 7, Name= "Country 7 Asia", Description= "Country Description 7" },
            new Country { Id = 8, Name= "Country 8 Asia", Description= "Country Description 8" },
            new Country { Id = 9, Name= "Country 9 Asia", Description= "Country Description 9" },
            new Country { Id = 10, Name= "Country 10", Description= "Country Description 10" }
        };
    }
}
