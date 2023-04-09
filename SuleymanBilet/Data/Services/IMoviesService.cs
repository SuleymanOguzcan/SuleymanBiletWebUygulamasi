using SuleymanBilet.Data.Base;
using SuleymanBilet.Models;
using System.Threading.Tasks;

namespace SuleymanBilet.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}