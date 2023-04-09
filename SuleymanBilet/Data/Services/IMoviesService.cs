using SuleymanBilet.Data.Base;
using SuleymanBilet.Data.ViewModels;
using SuleymanBilet.Models;
using System.Threading.Tasks;

namespace SuleymanBilet.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        Task AddNewMovieAsync(NewMovieVM data);
    }
}