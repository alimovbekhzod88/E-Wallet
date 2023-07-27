using Global.Configs;
namespace E_Wallet.WebApi
{
    public class AppSettings
    {
        public static AppSettings Instance { get; set; } = new();
        public static void Init(AppSettings instance) => 
            Instance = instance;


        public DatabaseConfig Database { get; set; } = new();
        public SwaggerConfig Swagger { get; set; } = new();
    }
    public class DatabaseConfig
    {
        public DbConnectionConfig PgSql { get; set; }
    }
}
