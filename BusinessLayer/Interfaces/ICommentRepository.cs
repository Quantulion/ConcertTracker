using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface ICommentRepository : IDisposable
    {
        Task<Comment> GetCommentByIdAsync(int Id);
        Task<Comment> AddCommentAsync(Comment comment, User user, Concert concert);
        Task UpdateCommentAsync(Comment comment);
        Task DeleteCommentAsync(Comment comment);
    }
}
