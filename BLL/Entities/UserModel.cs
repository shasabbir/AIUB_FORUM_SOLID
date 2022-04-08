namespace BLL.Entities
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string AboutMe { get; set; }
        public int? Views { get; set; }
        public System.DateTime? CreationDate { get; set; }
        public int? Reputation { get; set; }
        public byte[] ProfilePic { get; set; }
        public string UserType { get; set; }
        public int? ApplyCount { get; set; }
        public byte[] Cv { get; set; }
    }
}