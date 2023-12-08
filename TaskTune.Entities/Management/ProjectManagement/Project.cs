namespace TaskTune.Entities.Management.ProjectManagement
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        // Other properties like status, priority, etc.
    }

}
