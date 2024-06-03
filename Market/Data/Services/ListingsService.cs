﻿using Market.Models;
using Microsoft.EntityFrameworkCore;

namespace Market.Data.Services
{
    public class ListingsService: IListingsService
    {
        private readonly ApplicationDbContext _context;

        public ListingsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<Listing> GetListings()
        {
            var applicationDbContext = _context.Listings.Include(l => l.User);
            return applicationDbContext;

        }

       public async Task Add(Listing listing)
        {
            _context.Listings.Add(listing);
            await _context.SaveChangesAsync();
        }

        public async Task<Listing> GetById(int? id)
        {
            var listing = await _context.Listings
                .Include(l => l.User)
                .Include(l=>l.Comments)
                .Include(l =>l.Bids)
                .ThenInclude(l=>l.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            return listing;
        }
    }
}
