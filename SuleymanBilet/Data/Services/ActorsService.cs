using Microsoft.EntityFrameworkCore;
using SuleymanBilet.Data.Services;
using SuleymanBilet.Data;
using SuleymanBilet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuleymanBilet.Data.Base;

namespace eTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
