namespace DAL
{
    public interface IAuth<out TX>
    {
        TX Authenticate(string email, string password);
    }
}