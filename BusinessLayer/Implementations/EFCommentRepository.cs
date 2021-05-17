using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementations
{
    public class EFCommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _ctx;
        public EFCommentRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Comment> GetCommentByIdAsync(int id)
        {
            return await _ctx.Comments.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<List<UserComment>> GetLikesOfCommentAsync(Comment comment)
        {
            var full = _ctx.Comments.Include(c => c.Likes);
            var likes = await full.FirstOrDefaultAsync(c => c.Id == comment.Id);
            return likes.Likes;
        }

        public async Task<int> LikesCountAsync(Comment comment)
        {
            var full = _ctx.Comments.Include(c => c.Likes);
            var likes = await full.FirstOrDefaultAsync(c => c.Id == comment.Id);
            return likes.Likes.Count;
        }

        public async Task<Comment> AddCommentAsync(Comment comment, User user, Concert concert)
        {
            comment.User = user;
            comment.UserId = user.Id;
            comment.Concert = concert;
            comment.ConcertId = concert.Id;
            _ctx.Comments.Add(comment);
            await _ctx.SaveChangesAsync();
            return comment;
        }

        public async Task AddLikeAsync(Comment comment, User user)
        {
            UserComment userComment = new UserComment
            {
                UserId = user.Id,
                User = user,
                CommentId = comment.Id,
                Comment = comment
            };
            
            bool alreadyLiked = false;
            var full = _ctx.Comments.Include(c => c.Likes);
            var likes = await full.FirstOrDefaultAsync(c => c.Id == comment.Id);
            foreach (var like in likes.Likes)
            {
                if(like.UserId == user.Id && like.CommentId == comment.Id)
                    alreadyLiked = true;
            }
            
            if (!alreadyLiked)
            {
                if (user.Likes == null)
                    user.Likes = new List<UserComment>();
                user.Likes.Add(userComment);
                _ctx.Users.Update(user);
                await _ctx.SaveChangesAsync();
            }
        }

        public async Task UpdateCommentAsync(Comment comment)
        {
            _ctx.Comments.Update(comment);
            await _ctx.SaveChangesAsync();
        }
        public async Task DeleteCommentAsync(Comment comment)
        {
            _ctx.Comments.Remove(comment);
            await _ctx.SaveChangesAsync();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
