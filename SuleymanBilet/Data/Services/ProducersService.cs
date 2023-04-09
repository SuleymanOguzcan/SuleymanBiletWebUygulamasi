using SuleymanBilet.Data.Base;
using SuleymanBilet.Models;

namespace SuleymanBilet.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}