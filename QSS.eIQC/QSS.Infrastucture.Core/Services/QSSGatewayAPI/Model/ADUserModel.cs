using System.Collections.Generic;

namespace QSS.Infrastructure.Core.QSSGatewayAPI.Model
{
    public class ADUserResponse
    {
        public int Count { get; set; }
        public List<ADUserModel> Result { get; set; }
    }

    /// <summary>
    /// Class to return User details from ActiveDirectory
    /// </summary>
    public class ADUserModel
    {
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Legal name
        /// </summary>
        public string LegalName { get; set; }
        public string DisplayName => $"{Name} ({SamAccountName})";
        /// <summary>
        /// Full Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Manager details
        /// </summary>
        public string Manager { get; set; }
        /// <summary>
        /// Mobile number
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// <summary>
        /// Office phone number
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// SamAccountName / UserID / NTID / UserName / EmployeeId
        /// </summary>
        public string SamAccountName { get; set; }
        /// <summary>
        /// Position in company
        /// </summary>
        public string Title { get; set; }

        public string EmployeeId { get; set; }

        /// <summary>
        /// Department details
        /// </summary>
        public string Department { get; set; }
    }
}
