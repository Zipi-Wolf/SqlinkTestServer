using SqlinkTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlinkTest.Interfaces
{
    public interface IProjectsService
    {
        Task<List<Project>> GetProjectsByUser(string id);
    }
}
