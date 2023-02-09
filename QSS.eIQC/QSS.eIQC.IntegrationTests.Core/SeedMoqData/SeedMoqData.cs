using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.IntegrationTests.Core.MoqData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.IntegrationTests.Core
{
    public class SeedMoqData
    {
        private readonly QSSContext _context;
        private static object _qssContextLock = new object();
        public SeedMoqData(QSSContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            // Workaround: https://www.codeproject.com/Articles/5250190/Integration-Tests-in-ASP-NET-Core-A-DBContext
            lock (_qssContextLock)
            {
                if (!_context.Role.Any())
                {
                    _context.Role.AddRange(RoleMoq.Roles);
                    _context.SaveChanges();
                }

                if (!_context.RolePermission.Any())
                {
                    _context.RolePermission.AddRange(RolePermissionMoq.RolePermissions);
                    _context.SaveChanges();
                }

                if (!_context.User.Any())
                {
                    _context.User.AddRange(UserMoq.Users);
                    _context.SaveChanges();
                }

                if (!_context.UserRole.Any())
                {
                    _context.UserRole.AddRange(UserRoleMoq.UserRoles);
                    _context.SaveChanges();
                }

                if (!_context.WorkCell.Any())
                {
                    _context.WorkCell.AddRange(WorkCellMoq.WorkCells);
                    _context.SaveChanges();
                }

                if (!_context.Country.Any())
                {
                    _context.Country.AddRange(CountryMoq.Countrys);
                    _context.SaveChanges();
                }

                if (!_context.Department.Any())
                {
                    _context.Department.AddRange(DepartmentMoq.Departments);
                    _context.SaveChanges();
                }

                if (!_context.Division.Any())
                {
                    _context.Division.AddRange(DivisionMoq.Divisions);
                    _context.SaveChanges();
                }

                if (!_context.Region.Any())
                {
                    _context.Region.AddRange(RegionMoq.Regions);
                    _context.SaveChanges();
                }
                if (!_context.PartDimension.Any())
                {
                    _context.PartDimension.AddRange(PartDimensionMoq.PartDimensions);
                    _context.SaveChanges();
                }

                if (!_context.BowTwistFormula.Any())
                {
                    _context.BowTwistFormula.AddRange(BowTwistFormulaMoq.BowTwistFormulas);
                    _context.SaveChanges();
                }

                if (!_context.DCCConfiguration.Any())
                {
                    _context.DCCConfiguration.AddRange(DCCConfigurationMoq.DCCConfigurations);
                    _context.SaveChanges();
                }

                if (!_context.CertificateType.Any())
                {
                    _context.CertificateType.AddRange(CertificateTypeMoq.CertificateTypes);
                    _context.SaveChanges();
                }

            }
        }
    }
}
