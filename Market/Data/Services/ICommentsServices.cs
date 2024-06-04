using Market.Models;

namespace Market.Data.Services
{
    public interface ICommentsServices
    {
        Task Add(Comment comment);
    }
}
