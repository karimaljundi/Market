using Market.Models;

namespace Market.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);
    }
}
