using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.model;

namespace WpfApp4
{
    internal class MyDbContext:DbContext
    {
        public DbSet<Клиент> клиент {  get; set; }
        public DbSet<Товар> товар { get; set; }


        public string connectionString = @"Data Source=vova; Initial Catalog=var3; Integrated Security=True;";


















        //public string connectionString = @"Data Source=vova; Initial Catalog=123; Integrated Security=True;";
    }
}
