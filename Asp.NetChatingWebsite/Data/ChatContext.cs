using Asp.NetChatingWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetChatingWebsite.Data
{
    public class ChatContext : DbContext
    {

        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=sourav;Database=ChatTable;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
         public DbSet<ChatingPage> MsgTable1 { get; set; }
    }
}
