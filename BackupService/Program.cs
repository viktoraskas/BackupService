using BackupService;
using BackupService.Interfaces;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddSingleton<IConfig,ConfigService>();
    })
    .Build();

await host.RunAsync();
