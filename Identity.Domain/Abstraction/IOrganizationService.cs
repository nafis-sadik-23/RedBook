﻿using Identity.Data.Models;
using RedBook.Core.Models;

namespace Identity.Domain.Abstraction
{
    public interface IOrganizationService
    {
        Task<OrganizationModel> AddOrganizationAsync(OrganizationModel Organization);
        Task<OrganizationModel> GetOrganizationAsync(int orgId);
        Task<IEnumerable<OrganizationModel>> GetOrganizationsAsync();
        Task<PagedModel<OrganizationModel>> GetPagedOrganizationsAsync(PagedModel<OrganizationModel> pagedOrganizationModel);
        Task<OrganizationModel> UpdateOrganizationAsync(OrganizationModel Organization);
        Task DeleteOrganizationAsync(int OrganizationId);
        Task AddUserToBusiness(UserModel userModel);
        Task<PagedModel<UserModel>> GetByOrganizationId(PagedModel<UserModel> pagedModel, int orgId);
    }
}
