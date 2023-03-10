using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace QSS.eIQC.Api.Extensions.Environment
{
	/// <summary>
	/// Custom environments extension
	/// </summary>
	public static class HostingEnvironmentExtension
	{
		/// <summary>
		/// Quality assurance environment
		/// </summary>
		private const string QualityAssurance = "QualityAssurance";
		/// <summary>
		/// Local environment
		/// </summary>
		private const string Local = "Local";
		/// <summary>
		/// Test environment
		/// </summary>
		private const string Test = "Test";


		private const string Developement = "Development";

		/// <summary>
		///  Checks if the current host environment name is quality assurance.
		/// </summary>
		/// <param name="hostingEnvironment">An instance of <see cref="IWebHostEnvironment"/>.</param>
		/// <returns>True if the environment name is quality assurance.</returns>
		public static bool IsQA(this IWebHostEnvironment hostingEnvironment)
		{
			return hostingEnvironment.IsEnvironment(QualityAssurance);
		}

		/// <summary>
		///  Checks if the current host environment name is Local.
		/// </summary>
		/// <param name="hostingEnvironment">An instance of <see cref="IWebHostEnvironment"/>.</param>
		/// <returns>True if the environment name is local</returns>
		public static bool IsLocal(this IWebHostEnvironment hostingEnvironment)
		{
			return hostingEnvironment.IsEnvironment(Local);
		}
		/// <summary>
		///  Checks if the current host environment name is Local.
		/// </summary>
		/// <param name="hostingEnvironment">An instance of <see cref="IWebHostEnvironment"/>.</param>
		/// <returns>True if the environment name is Test</returns>
		public static bool IsTest(this IWebHostEnvironment hostingEnvironment)
		{
			return hostingEnvironment.IsEnvironment(Test);
		}


		/// <summary>
		///  Checks if the current host environment name is Developement.
		/// </summary>
		/// <param name="hostingEnvironment">An instance of <see cref="IWebHostEnvironment"/>.</param>
		/// <returns>True if the environment name is Developement</returns>
		public static bool IsDevelopement(this IWebHostEnvironment hostingEnvironment)
		{
			return hostingEnvironment.IsEnvironment(Developement);
		}
	}
}
