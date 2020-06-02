using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Entities;
using Skoruba.IdentityServer4.Admin.EntityFramework.Extensions.Common;
using ApiResource = IdentityServer4.EntityFramework.Entities.ApiResource;

namespace Skoruba.IdentityServer4.Admin.EntityFramework.Repositories.Interfaces
{
    /// <summary>
    /// Api资源仓库
    /// </summary>
    public interface IApiResourceRepository
    {
        /// <summary>
        /// 获取Api资源
        /// </summary>
        /// <param name="search"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<PagedList<ApiResource>> GetApiResourcesAsync(string search, int page = 1, int pageSize = 10);

        /// <summary>
        /// 获取Api资源详情
        /// </summary>
        /// <param name="apiResourceId"></param>
        /// <returns></returns>
        Task<ApiResource> GetApiResourceAsync(int apiResourceId);
        /// <summary>
        /// 获取Api资源自定义属性
        /// </summary>
        /// <param name="apiResourceId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<PagedList<ApiResourceProperty>> GetApiResourcePropertiesAsync(int apiResourceId, int page = 1, int pageSize = 10);
        /// <summary>
        ///  获取Api资源自定义属性详情
        /// </summary>
        /// <param name="apiResourcePropertyId"></param>
        /// <returns></returns>
        Task<ApiResourceProperty> GetApiResourcePropertyAsync(int apiResourcePropertyId);
        /// <summary>
        /// 添加Api资源自定义属性
        /// </summary>
        /// <param name="apiResourceId"></param>
        /// <param name="apiResourceProperty"></param>
        /// <returns></returns>
        Task<int> AddApiResourcePropertyAsync(int apiResourceId, ApiResourceProperty apiResourceProperty);
        /// <summary>
        /// 删除Api资源自定属性
        /// </summary>
        /// <param name="apiResourceProperty"></param>
        /// <returns></returns>
        Task<int> DeleteApiResourcePropertyAsync(ApiResourceProperty apiResourceProperty);
        /// <summary>
        /// 校验自定义属性是否存在
        /// </summary>
        /// <param name="apiResourceProperty"></param>
        /// <returns></returns>
        Task<bool> CanInsertApiResourcePropertyAsync(ApiResourceProperty apiResourceProperty);
        /// <summary>
        /// 添加Api子资源
        /// </summary>
        /// <param name="apiResource"></param>
        /// <returns></returns>
        Task<int> AddApiResourceAsync(ApiResource apiResource);
        /// <summary>
        /// 更新Api资源
        /// </summary>
        /// <param name="apiResource"></param>
        /// <returns></returns>
        Task<int> UpdateApiResourceAsync(ApiResource apiResource);
        /// <summary>
        /// 删除Api资源
        /// </summary>
        /// <param name="apiResource"></param>
        /// <returns></returns>
        Task<int> DeleteApiResourceAsync(ApiResource apiResource);
        /// <summary>
        /// 校验Api资源是否存在
        /// </summary>
        /// <param name="apiResource"></param>
        /// <returns></returns>
        Task<bool> CanInsertApiResourceAsync(ApiResource apiResource);
        /// <summary>
        /// 获取Api资源范围
        /// </summary>
        /// <param name="apiResourceId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<PagedList<ApiScope>> GetApiScopesAsync(int apiResourceId, int page = 1, int pageSize = 10);
        /// <summary>
        /// 获取Api资源范围详情
        /// </summary>
        /// <param name="apiResourceId"></param>
        /// <param name="apiScopeId"></param>
        /// <returns></returns>
        Task<ApiScope> GetApiScopeAsync(int apiResourceId, int apiScopeId);
        /// <summary>
        /// 添加Api资源范围
        /// </summary>
        /// <param name="apiResourceId"></param>
        /// <param name="apiScope"></param>
        /// <returns></returns>
        Task<int> AddApiScopeAsync(int apiResourceId, ApiScope apiScope);
        /// <summary>
        /// 更新Api资源范围
        /// </summary>
        /// <param name="apiResourceId"></param>
        /// <param name="apiScope"></param>
        /// <returns></returns>
        Task<int> UpdateApiScopeAsync(int apiResourceId, ApiScope apiScope);
        /// <summary>
        /// 删除Api资源范围
        /// </summary>
        /// <param name="apiScope"></param>
        /// <returns></returns>
        Task<int> DeleteApiScopeAsync(ApiScope apiScope);
        /// <summary>
        /// Api资源访问密钥
        /// </summary>
        /// <param name="apiResourceId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<PagedList<ApiSecret>> GetApiSecretsAsync(int apiResourceId, int page = 1, int pageSize = 10);
        /// <summary>
        /// 添加Api资源访问密钥
        /// </summary>
        /// <param name="apiResourceId"></param>
        /// <param name="apiSecret"></param>
        /// <returns></returns>
        Task<int> AddApiSecretAsync(int apiResourceId, ApiSecret apiSecret);
        /// <summary>
        /// 获取Api资源访问密钥
        /// </summary>
        /// <param name="apiSecretId"></param>
        /// <returns></returns>
        Task<ApiSecret> GetApiSecretAsync(int apiSecretId);
        /// <summary>
        /// 删除Api资源访问密钥
        /// </summary>
        /// <param name="apiSecret"></param>
        /// <returns></returns>
        Task<int> DeleteApiSecretAsync(ApiSecret apiSecret);
        /// <summary>
        /// 判断Api资源访问密钥是否存在
        /// </summary>
        /// <param name="apiScope"></param>
        /// <returns></returns>
        Task<bool> CanInsertApiScopeAsync(ApiScope apiScope);
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        Task<int> SaveAllChangesAsync();
        /// <summary>
        /// 获取Api资源名称
        /// </summary>
        /// <param name="apiResourceId"></param>
        /// <returns></returns>
        Task<string> GetApiResourceNameAsync(int apiResourceId);
    }
}