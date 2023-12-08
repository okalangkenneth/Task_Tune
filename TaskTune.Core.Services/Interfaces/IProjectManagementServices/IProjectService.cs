using TaskTune.Entities.Management.ProjectManagement;

namespace TaskTune.Core.Services.Interfaces.IProjectManagementServices
{
    public interface IProjectService
    {
        Task<Project> CreateProject(Project newProject);
        Task<IEnumerable<Project>> GetAllProjects();
        Task<Project> GetProjectById(int id);
        Task UpdateProject(Project project);
        Task DeleteProject(int id);

    }
}
