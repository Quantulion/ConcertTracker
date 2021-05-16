using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface ICommentRepository : IDisposable
    {
        Task<Comment> GetCommentById(int Id);
        Task<User> GetAuthor(Comment comment);
        Task<Comment> AddComment(Comment comment, User user, Concert concert);
        Task UpdateComment(Comment comment);
        Task DeleteComment(Comment comment);
    }
}
