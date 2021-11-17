using System.Collections.Generic;
using System.Data.SqlClient;
using Database.Model;
using Database.Repository;

namespace BusinessLayer.Service
{
    public class UserTypeService
    {
        private readonly UserTypeRepository _repository;

        public UserTypeService(SqlConnection connection)
        {
            _repository = new UserTypeRepository(connection);

        }

        public List<UserType> GetList()
        {
            return _repository.GetList();
        }
    }
}
