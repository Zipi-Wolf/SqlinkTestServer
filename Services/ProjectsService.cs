using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SqlinkTest.Infrastructure;
using SqlinkTest.Interfaces;
using SqlinkTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlinkTest.Services
{
    public class ProjectsService : IProjectsService
    {

        private readonly IAsyncRepository<Project> _projectRepository;
        protected readonly Context _context;

        public ProjectsService(IAsyncRepository<Project> projectRepository , Context context)
        {
            _projectRepository = projectRepository;
            _context = context;
        }
        public async Task<List<Project>> GetProjectsByUser(string id)
        {
            try
            {
                //projectsForUser = await _projectRepository.ListAllAsync();
                var projectsForUser = await _context.projects.Where(x => x.id == id).ToListAsync();
                return projectsForUser;
            }
            catch (Exception ex)
            {
                // _logger.LogError(ex.Message);
                return null;
                throw ex;
            }


        }
    }
}
