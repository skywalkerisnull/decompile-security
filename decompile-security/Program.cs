// Initialize the Config object tat holds all of our example strings.
Config config = new Config();

Console.WriteLine("Hello, this is a trival application to demonstrate how to extract strings from the compiled binary \n");


// Write out each property to the console
Console.WriteLine("Database Configuration:");
Console.WriteLine($"Username: {config.Database.Username}");
Console.WriteLine($"Password: {config.Database.Password}");
Console.WriteLine($"Host: {config.Database.Host}");
Console.WriteLine($"Port: {config.Database.Port}");
Console.WriteLine();

Console.WriteLine("API Configuration:");
Console.WriteLine($"Key: {config.Api.Key}");
Console.WriteLine($"Endpoint: {config.Api.Endpoint}");
Console.WriteLine();

Console.WriteLine("Service Account Configuration:");
Console.WriteLine($"ClientId: {config.ServiceAccount.ClientId}");
Console.WriteLine($"ClientSecret: {config.ServiceAccount.ClientSecret}");
Console.WriteLine();

// Pause and wait for the user to press any key before exiting
Console.WriteLine("Press any key to exit...");
Console.ReadKey();