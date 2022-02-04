using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using Core.Models;

namespace BLL.Abstractions.Interfaces
{
    public interface IChatService
    {
        Task<bool> CreateChat(Chat chat, Room room);
        void DeleteChat(Chat chat);
        void UpdateChat(Chat chat);
        Task<IEnumerable<Chat>> GetChats(Room room);
        public Task<bool> ChatExists(Chat chat, Room room);
        public Task<Chat> GetChat(string chatName, Room room);
    }
}