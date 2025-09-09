namespace dotnet_dependencies_project.Services
{
    public interface IUserService
    {
        Task<User> CreateUser(User user);
        Task<User> GetUser(int id);
        Task<IEnumerable<User>> GetAllUsers();
        Task<bool> DeleteUser(int id);
        Task<User> UpdateUser(User user);
    }
}