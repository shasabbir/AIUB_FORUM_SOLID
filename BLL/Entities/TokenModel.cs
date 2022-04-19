namespace BLL.Entities
{
    public class TokenModel
    {
        public int Id { get; set; }
        public string Tkey { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime? ExpireDate { get; set; }
        public int UserId { get; set; }
    }
}
