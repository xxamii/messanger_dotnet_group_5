using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BLL.Abstractions.Interfaces;
using Core;
using Core.Models;
using DAL.Abstractions.Interfaces;

namespace BLL.Services
{
    public class UserInvitationService : IUsersInvitationService
    {
        private readonly IRepository<UsersInvitation> _repository;

        public UserInvitationService(IRepository<UsersInvitation> repository)
        {
            _repository = repository;
        }

        public void AddUser(int userId, int roomId)
        {
            var user = new UsersInvitation() {RoomId = roomId, UserId = userId, Id = 0};
            
            _repository.CreateObjectAsync(user);
        }

        public void RemoveUser(int userId, int roomId)
        {
            var user = new UsersInvitation() {UserId = userId, RoomId = roomId};

            _repository.DeleteObjectAsync(user);
        }

        public IEnumerable<UsersInvitation> GetUsers()
        {
            return _repository.GetAllAsync(typeof(UsersInvitation)).Result;
        }
    }
}