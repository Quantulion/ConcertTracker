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
            try
            {
                var comment = await _ctx.Comments.FirstOrDefaultAsync(f => f.Id == id);

                if (comment == null)
                    throw new ArgumentException($"No comment with ID {id} found in database");

                return comment;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<List<UserComment>> GetLikesOfCommentAsync(Comment comment)
        {
            try
            {
                if (comment == null)
                    throw new ArgumentNullException("Cannot get likes of null comment");
                
                var commentsWithLikes = _ctx.Comments.Include(c => c.Likes);
                var commentWithLikes = await commentsWithLikes.FirstOrDefaultAsync(c => c.Id == comment.Id);
                return commentWithLikes.Likes;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<List<Comment>> GetCommentsOfUserAsync(User user)
        {
            try
            {
                if (user == null)
                    throw new ArgumentNullException("Cannot get comments of null user");
                
                var usersWithComments = _ctx.Users.Include(c => c.Comments);
                var userWithComments = await usersWithComments.FirstOrDefaultAsync(c => c.Id == user.Id);
                return userWithComments.Comments;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<int> LikesCountAsync(Comment comment)
        {
            try
            {
                if (comment == null)
                    throw new ArgumentNullException("Cannot count likes of null comment");
                
                var commentsWithLikes = _ctx.Comments.Include(c => c.Likes);
                var commentWithLikes = await commentsWithLikes.FirstOrDefaultAsync(c => c.Id == comment.Id);
                return commentWithLikes.Likes.Count;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<Comment> AddCommentAsync(Comment comment, User user, Concert concert)
        {
            try
            {
                if (comment == null)
                    throw new ArgumentNullException("Cannot add null comment");
                
                if (user == null)
                    throw new ArgumentNullException("Cannot add comment by null user");
                
                if (concert == null)
                    throw new ArgumentNullException("Cannot add comment to null concert");
                
                comment.PublishTime = DateTime.Now;
                comment.User = user;
                comment.UserId = user.Id;
                comment.Concert = concert;
                comment.ConcertId = concert.Id;
                
                _ctx.Comments.Add(comment);
                await _ctx.SaveChangesAsync();
                return comment;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task PressLikeAsync(Comment comment, User user)
        {
            try
            {
                if (comment == null)
                    throw new ArgumentNullException("Cannot add like to null comment");
                
                if (user == null)
                    throw new ArgumentNullException("Cannot add like by null user");
                
                var commentsWithLikes = _ctx.Comments.Include(c => c.Likes);
                var commentWithLikes = await commentsWithLikes.FirstOrDefaultAsync(c => c.Id == comment.Id);
                
                foreach (var like in commentWithLikes.Likes)
                {
                    if (like.UserId == user.Id && like.CommentId == comment.Id)
                    {
                        await DeleteLikeFromCommentAsync(commentWithLikes, like);
                        return;
                    }
                }
                await AddLikeToCommentAsync(comment, user);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private async Task AddLikeToCommentAsync(Comment comment, User user)
        {
            try
            {
                UserComment userComment = new UserComment
                {
                    UserId = user.Id,
                    User = user,
                    CommentId = comment.Id,
                    Comment = comment
                };
                
                if (user.Likes == null)
                    user.Likes = new List<UserComment>();
                user.Likes.Add(userComment);
                _ctx.Users.Update(user);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private async Task DeleteLikeFromCommentAsync(Comment comment, UserComment userComment)
        {
            try
            {
                comment.Likes.Remove(userComment);
                _ctx.Comments.Update(comment);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task UpdateCommentAsync(Comment comment)
        {
            try
            {
                if (comment == null)
                    throw new ArgumentNullException("Cannot update null comment");
                
                _ctx.Comments.Update(comment);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public async Task DeleteCommentAsync(Comment comment)
        {
            try
            {
                if (comment == null)
                    throw new ArgumentNullException("Cannot delete null comment");
                
                _ctx.Comments.Remove(comment);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
