using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace Infrastructure.Context
{
    internal class F1KarteDBContext : DbContext
    {
        public F1KarteDBContext(DBContextOptions<F1KarteDBContext> options)
        {

        }
    }
}
