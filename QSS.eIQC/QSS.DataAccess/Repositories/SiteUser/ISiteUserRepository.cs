/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public interface ISiteUserRepository
    {
        void AddSiteUsers(Site site, List<int> userIds, string changeReason);
        void RemoveSiteUsers(Site site, List<int> userIds, string changeReason);
        void Update(SiteUser siteUser, string siteName, string changeReason);
        Task RemoveByIdAsync(int id, string auditLogTitle, string changeReason);
    }
}
