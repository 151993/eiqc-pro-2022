using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.IntegrationTests.Core.MoqData
{
    public static class RolePermissionMoq
    {
        public static RolePermission[] RolePermissions = new[] {
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminWorkCellCanAccess},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminWorkCellCanCreate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminWorkCellCanUpdate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminWorkCellCanDelete},

            new RolePermission { RoleId = 2, PermissionType= Domain.Enums.PermissionType.HomeCanAccess},

            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminCountryCanAccess},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminCountryCanCreate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminCountryCanUpdate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminCountryCanDelete},

            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminDepartmentCanAccess},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminDepartmentCanCreate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminDepartmentCanUpdate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminDepartmentCanDelete},

            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminDivisionCanAccess},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminDivisionCanCreate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminDivisionCanUpdate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminDivisionCanDelete},

            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminRegionCanAccess},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminRegionCanCreate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminRegionCanUpdate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminRegionCanDelete},

            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminRoleCanAccess},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminRoleCanCreate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminRoleCanUpdate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminRoleCanDelete},

            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminPartDimensionCanAccess},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminPartDimensionCanCreate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminPartDimensionCanUpdate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminPartDimensionCanDelete},

            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminBowTwistFormulaCanAccess},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminBowTwistFormulaCanCreate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminBowTwistFormulaCanUpdate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminBowTwistFormulaCanDelete},

            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminDCCConfigurationCanAccess},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminDCCConfigurationCanCreate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminDCCConfigurationCanUpdate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminDCCConfigurationCanDelete},

            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminCertificateTypeCanAccess},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminCertificateTypeCanCreate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminCertificateTypeCanUpdate},
            new RolePermission { RoleId = 1, PermissionType= Domain.Enums.PermissionType.AdminCertificateTypeCanDelete}

        };
    }
}
