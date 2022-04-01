namespace DAL
{
    public interface IAuth
    {
        bool Authenticate(string uname, string pass);
    }
}