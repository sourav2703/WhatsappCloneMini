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
            optionsBuilder.UseSqlServer("Server=sourav;Database=ChatData;Integrated Security=True;");
        }
         public DbSet<ChatingPage> Messagesss { get; set; }
    }
}
