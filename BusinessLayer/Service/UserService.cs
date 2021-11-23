using BusinessLayer.Interface;
using Database.Model;
using Database.Repository;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer.Service
{
    public class UserService: IService<User>
    {
        private UserRepository _userRepository;

        public UserService(SqlConnection connection)
        {
            _userRepository = new UserRepository(connection);
        }

        public bool Add(User user)
        {
            return _userRepository.Add(user);
        }

        public bool Edit(User user)
        {
            return _userRepository.Edit(user);
        }

        public bool Delete(int userId)
        {
            return _userRepository.Delete(userId);
        }

        public User GetById(int userId)
        {
            return _userRepository.GetById(userId);
        }

        public DataTable GetAllPending()
        {
            return _userRepository.GetAllPending();
        }

        public bool CheckUsername(string username)
        {
            return _userRepository.CheckUsername(username);
        }

        public User GetLogin(string username, string password)
        {
            return _userRepository.GetLogin(username, password);
        }
    }
}