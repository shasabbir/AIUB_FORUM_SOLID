namespace BLL.Entities
{
    public class JobModel
    {
        public int JobId { get; set; }
        public int CompanyId { get; set; }
        public string JobType { get; set; }
        public string PositonName { get; set; }
        public string Description { get; set; }
        public string Salary { get; set; }
    }
}
