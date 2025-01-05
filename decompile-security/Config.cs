using System;
public class Config
{
    public DatabaseConfig Database { get; set; }
    public ApiConfig Api { get; set; }
    public ServiceAccountConfig ServiceAccount { get; set; }

    public Config()
    {
        Database = new DatabaseConfig
        {
            Username = "root",
            Password = "super_secret_password",
            Host = "postgres.example.com",
            Port = 5432
        };

        Api = new ApiConfig
        {
            Key = "api_key_1234567890",
            Endpoint = "https://api.example.com"
        };

        ServiceAccount = new ServiceAccountConfig
        {
            ClientId = "client_id",
            ClientSecret = "client_secret"
        };
    }

    public struct DatabaseConfig
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }

    public struct ApiConfig
    {
        public string Key { get; set; }
        public string Endpoint { get; set; }
    }

    public struct ServiceAccountConfig
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
