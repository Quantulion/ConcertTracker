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
        Task<Comment> GetAllCommentsByAuthor(Person person);
        Task<Comment> GetAllCommentsRelatedToConcert(Concert concert);
        Task UpdateComment(Comment comment);
        Task<Comment> AddComment(Comment comment);
    }
}
