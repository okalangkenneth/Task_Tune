using Microsoft.AspNetCore.Mvc;
using TaskTune.Core.Services.Interfaces.IProjectManagementServices;
using TaskTune.Entities.Management.ProjectManagement;

namespace TaskTune.UI.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetById(int id)
        {
            var project = await _projectService.GetProjectById(id);
            if (project == null)
            {
                return NotFound();
            }
            return project;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Project project)
        {
            var createdProject = await _projectService.CreateProject(project);
            return CreatedAtAction(nameof(GetById), new { id = createdProject.Id }, createdProject);
        }

        // Other actions for Get, Update, Delete...
    }

}
