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
    }
}
