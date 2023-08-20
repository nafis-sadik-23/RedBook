﻿using Identity.Data.Entities;
using Identity.Data.Models;
using Identity.Domain.Abstraction;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBook.Core.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Identity.WebAPI.Controllers
{
    /// <summary>
    /// Authentication Module
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        /// <summary>
        /// Authentication Module Controller
        /// </summary>
        /// <param name="applicationService">An implementation of IApplicationService injected by IOC Controller</param>
        public ApplicationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        /// <summary>
        /// Retrieves a specific Application Details by unique id
        /// </summary>
        /// <param name="appId">Application Id or unique identifier which is the primary key of the application</param>
        [HttpGet]
        [SwaggerResponse(statusCode: 200, type: typeof(int), description: "Retrieves Application Details")]
        [SwaggerResponse(statusCode: 401, type: typeof(string), description: "Unauthorized Request")]
        [SwaggerResponse(statusCode: 400, type: typeof(string), description: "Requested operation caused an internal error, read message from the response body.")]
        public async Task<IActionResult> GetAsync(int appId) => Ok(await _applicationService.GetApplicationAsync(appId));

        [HttpPost]
        public async Task<IActionResult> AddAsync(ApplicationInfoModel appInfo) => Ok(await _applicationService.AddApplicationAsync(appInfo));

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(ApplicationInfoModel appInfo) => Ok(await _applicationService.UpdateApplicationAsync(appInfo));

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int appId)
        {
            await _applicationService.DeleteApplicationAsync(appId);
            return Ok();
        }

        [HttpGet]
        [Route("/PagedApplications")]
        public async Task<IActionResult> GetPagedAsync([FromQuery] PagedModel<ApplicationInfoModel> pagedApplications) => Ok(await _applicationService.GetApplicationsAsync(pagedApplications));
    }
}