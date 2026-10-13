using Microsoft.Extensions.Configuration;


namespace Flashcards.matejadb.Config; 
public static class AppSettings {
    public static string ConnectionString { get; }

    static AppSettings() {
        IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        ConnectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found in appsettings.json");
    }
}
