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
        public async Task<Comment> GetCommentById(int id)
        {
            return await _ctx.Comments.FirstOrDefaultAsync(f => f.Id == id);
        }
        public async Task<Comment> AddComment(Comment comment)
        {
            _ctx.Comments.Add(comment);
            await _ctx.SaveChangesAsync();
            return comment;
        }
        public Task UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

    }
}
