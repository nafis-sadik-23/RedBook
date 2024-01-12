﻿using Identity.Data.Models;
using Identity.Domain.Abstraction;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBook.Core.Models;

namespace Identity.WebAPI.Controllers
{
    /// <summary>
    /// Organization Module
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class OrganizationController : ControllerBase
    {
        private readonly IOrganizationService _organizationService;

        /// <summary>
        /// Organization Module Constructor
        /// </summary>
        /// <param name="organizationService">An implementation of IOrganizationService injected by IOC Controller</param>
        public OrganizationController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }

        /// <summary>
        /// Get organization details by organization Id
        /// </summary>
        /// <param name="orgId">Organization Id or unique identifier which is the primary key of organization table</param>
        [HttpGet]
        [Route("{orgId}")]
        public async Task<IActionResult> Get(int orgId) => Ok(await _organizationService.GetOrganizationAsync(orgId));

        /// <summary>
        /// Get all organizations
        /// </summary>
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll() => Ok(await _organizationService.GetOrganizationsAsync());

        /// <summary>
        /// Add new organization with details
        /// </summary>
        /// <param name="orgInfo">Organization details object</param>
        [HttpPost]
        public async Task<IActionResult> Add(OrganizationModel orgInfo) => Ok(await _organizationService.AddOrganizationAsync(orgInfo));

        /// <summary>
        /// Update existing organization with details
        /// </summary>
        /// <param name="orgInfo">Organization details object</param>
        [HttpPut]
        public async Task<IActionResult> Update(OrganizationModel orgInfo) => Ok(await _organizationService.UpdateOrganizationAsync(orgInfo));

        /// <summary>
        /// Get Paginated collection of organizations
        /// </summary>
        /// <param name="orgPagedCollection">Paginated Organization list for paging table</param>
        [HttpGet]
        [Route("PagedOrganizations")]
        public async Task<IActionResult> GetPagedAsync([FromQuery] PagedModel<OrganizationModel> orgPagedCollection) => Ok(await _organizationService.GetPagedOrganizationsAsync(orgPagedCollection));

        /// <summary>
        /// Delete existing organization with details
        /// </summary>
        /// <param name="orgId">Organization Id or unique identifier which is the primary key of organization table</param>
        [HttpDelete]
        [Route("{orgId}")]
        public async Task<IActionResult> Delete(int orgId)
        {
            await _organizationService.DeleteOrganizationAsync(orgId);
            return Ok();
        }

        /// <summary>
        /// Get user list under organization (organization admin access only)
        /// </summary>
        /// <param name="businessId">Organization Id <see cref="int"/></param>
        /// <param name="pagedModel">Organization Id <see cref="PagedModel<UserModel>"/></param>
        [HttpGet]
        [Authorize]
        [Route("User")]
        public async Task<IActionResult> GetUserByBusiness([FromQuery] PagedModel<UserModel> pagedModel, [FromQuery] int businessId) => Ok(await _organizationService.GetUserByOrganizationId(pagedModel, businessId));

        /// <summary>
        /// Add a new or existing user to your business. If the user already has an account, he shall be identified by email address and automatically assigned the role.
        /// In case, the user is new, his account shall be created and default password shall be set as his password
        /// </summary>
        /// <param name="userModel">User details object<see cref="UserModel"/>Data of user to be added to the business</param>
        [HttpPost]
        [Authorize]
        [Route("User")]
        public async Task<IActionResult> AddUserToBusiness(UserModel userModel)
        {
            await _organizationService.AddUserToBusiness(userModel);
            return Ok();
        }

        /// <summary>
        /// Remove user from Organization.
        /// </summary>
        /// <param name="userId">User details object<see cref="string"/>Data of user to be added to the business</param>
        /// <param name="orgId">User details object<see cref="int"/>Data of user to be added to the business</param>
        [HttpDelete]
        [Authorize]
        [Route("User/{userId}/{orgId}")]
        public async Task RemoveUserFromBusiness(string userId, int orgId) => await _organizationService.RemoveUserFromOrganization(userId, orgId);
    }
}
