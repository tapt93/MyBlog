namespace MyBlog.Data.IService
{
    public interface IUserService
    {
        User GetUserByAccount(string account);
        int AddUser(User user);
        int DeleteUser(int id);
        int UpdateUser(User user);
    }
}
