﻿using Market.Models;

namespace Market.Data.Services
{
    public class CommentsService : ICommentsServices
    {
        private readonly ApplicationDbContext _context;

        public CommentsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
        }

    }
}
