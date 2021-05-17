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
