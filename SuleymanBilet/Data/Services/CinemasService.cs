using SuleymanBilet.Data.Base;
using SuleymanBilet.Models;

namespace SuleymanBilet.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}