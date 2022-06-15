using JapaneseKanjiService;
using Serilog;

var progData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File(Path.Combine(progData, "JapaneseService", "serviceLog.txt"))
    .CreateLogger();

IHost host = Host.CreateDefaultBuilder(args)
    .UseWindowsService(options =>
    {
        options.ServiceName = "Japanese Kanji Service";
    })
    .UseSerilog()
    .ConfigureServices(services =>
    {
        services.AddSingleton<JapaneseService>();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();