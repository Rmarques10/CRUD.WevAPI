namespace CRUD.WebAPI.DataAccess.Repositories
{
    public interface IUser
    {
        Task<List<Data.User>> GetAll();
        Task<Data.User> GetUserById(string id);
        string AddUser(Data.User user);
        Task UpdateUser(Data.User user);
        Task DeleteUser(Data.User user);
    }
}
