using Market.Models;

namespace Market.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetListings();

    }
}
