namespace BLL.Entities
{
    public class CompanyModel
    {
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public int JobPostCount { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string CDescription { get; set; }
        public string CCategory { get; set; }
        public string Email { get; set; }
    }
}
