using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration
{
	/// <summary>
	/// Api资源Dto
	/// </summary>
	public class ApiResourceDto
	{
		public ApiResourceDto()
		{
			UserClaims = new List<string>();
		}

		public int Id { get; set; }
		/// <summary>
		/// 资源名称
		/// </summary>
        [Required]
		public string Name { get; set; }
		/// <summary>
		/// 默认名称
		/// </summary>
		public string DisplayName { get; set; }
		/// <summary>
		/// 资源介绍
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// 资源状态
		/// </summary>
		public bool Enabled { get; set; } = true;

		public List<string> UserClaims { get; set; }

		public string UserClaimsItems { get; set; }
	}
}