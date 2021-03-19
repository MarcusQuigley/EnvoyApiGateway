using CategoryApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryApi.DbContexts
{
    public class CatalogDbContext : ICatalogDbContext {
       
    }

    public interface ICatalogDbContext {
      
    }
    //: DbContext
    //{
    //    public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
    //        : base(options)
    //    {

    //    }

    //    public DbSet<Category> Categories { get; set; }


    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {



    //        modelBuilder.Entity<Category>()
    //           .Property(t => t.IsMiniTruck)
    //           .HasDefaultValue(false);
    //        // .ValueGeneratedOnAdd();


    //        base.OnModelCreating(modelBuilder);

    //    }
    // }
}
