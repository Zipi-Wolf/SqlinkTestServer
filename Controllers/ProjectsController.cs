using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SqlinkTest.Interfaces;
using SqlinkTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlinkTest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class ProjectsController : ControllerBase
    {

        private readonly IProjectsService _projectsService;
        public ProjectsController(IProjectsService projectsService)
        {
            _projectsService = projectsService;       
        }


        [HttpGet("{id}")]
        [ActionName("GetProjectsByUser")]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjectsByUser(string id)
        {
            //_logger.LogInformation("IntekController GetAvodotByIntek");
            var projects = await _projectsService.GetProjectsByUser(id);
            return Ok(projects);
        }
    }
}
