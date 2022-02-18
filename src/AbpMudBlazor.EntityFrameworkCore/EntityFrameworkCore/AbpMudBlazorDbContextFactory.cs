using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpMudBlazor.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpMudBlazorDbContextFactory : IDesignTimeDbContextFactory<AbpMudBlazorDbContext>
{
    public AbpMudBlazorDbContext CreateDbContext(string[] args)
    {
        AbpMudBlazorEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AbpMudBlazorDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AbpMudBlazorDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpMudBlazor.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
