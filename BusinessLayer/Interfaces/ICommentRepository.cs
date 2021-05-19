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
        Task<List<UserComment>> GetLikesOfCommentAsync(Comment comment);
        Task<int> LikesCountAsync(Comment comment);
        Task<Comment> AddCommentAsync(Comment comment, User user, Concert concert);
        Task PressLikeAsync(Comment comment, User user);
        Task UpdateCommentAsync(Comment comment);
        Task DeleteCommentAsync(Comment comment);
    }
}
