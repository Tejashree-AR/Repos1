using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.TMS.Data
{
   public class TMSContext:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=LAPTOP-J201RQG1\SQLEXPRESS01;Catalog=Tour;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);

        }
    }
}
 