﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core;

namespace BLL.Abstractions.Interfaces
{
    public interface IRoomService
    {
        public void CreateRoom(Room room);
        void DeleteRoom(Room room);
        void UpdateRoom(Room room);
        public Task<IEnumerable<Room>> GetRooms();
        public Task<Room> GetRoom(Func<Room, bool> func);
        public Task<bool> RoomExists(string name);
        bool CreateRole(string roleName, Room room);
        // Task<Room> GetRoom(string roomName);
        bool DeleteRole(string roleName, Room room);
        IEnumerable<Role> GetAllRoles(Room room);


    }
}