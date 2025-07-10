﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ModularCrm.Products.EntityFrameworkCore;

[ConnectionStringName(ProductsDbProperties.ConnectionStringName)]
public class ProductsDbContext : AbpDbContext<ProductsDbContext>, IProductsDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
        : base(options)
    {

    }
    #region ModelsToBeDBTables

    public DbSet<Product> Products { get; set; } 


    #endregion


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureProducts();
    }
}
