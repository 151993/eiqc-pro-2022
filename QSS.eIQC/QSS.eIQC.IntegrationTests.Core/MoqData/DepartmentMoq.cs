using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.MoqData
{
    public static class DepartmentMoq
    {
        public static Department[] Departments = new[] {
            new Department { Id = 1, Name= "Department 1", Description= "Department Description 1" },
            new Department { Id = 2, Name= "Department 2", Description= "Department Description 2" },
            new Department { Id = 3, Name= "Department 3", Description= "Department Description 3" },
            new Department { Id = 4, Name= "Department 4", Description= "Department Description 4" },
            new Department { Id = 5, Name= "Europe Department 5", Description= "Department Description 5" },
            new Department { Id = 6, Name= "Europe Department 6", Description= "Department Description 6" },
            new Department { Id = 7, Name= "Department 7 Asia", Description= "Department Description 7" },
            new Department { Id = 8, Name= "Department 8 Asia", Description= "Department Description 8" },
            new Department { Id = 9, Name= "Department 9 Asia", Description= "Department Description 9" },
            new Department { Id = 10, Name= "Department 10", Description= "Department Description 10" }
        };
    }
}
