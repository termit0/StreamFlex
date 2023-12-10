using StreamFlex.DownloadWorker;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<DownloadWorker>();
    })
    .Build();

host.Run();