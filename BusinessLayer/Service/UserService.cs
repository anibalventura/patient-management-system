﻿using BusinessLayer.Interface;
using Database.Model;
using Database.Repository;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer.Service
{
    public class UserService: IService<User>
    {
        private UserRepository userRepository;

        public UserService(SqlConnection connection)
        {
            userRepository = new UserRepository(connection);
        }

        public bool Add(User user)
        {
            return userRepository.Add(user);
        }

        public bool Edit(User user)
        {
            return userRepository.Edit(user);
        }

        public bool Delete(int id)
        {
            return userRepository.Delete(id);
        }

        public DataTable GetAll()
        {
            return userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return userRepository.GetById(id);
        }

        public bool CheckUsername(string username)
        {
            return userRepository.CheckUsername(username);
        }

        public User GetLogin(string username, string password)
        {
            return userRepository.GetLogin(username, password);
        }
    }
}