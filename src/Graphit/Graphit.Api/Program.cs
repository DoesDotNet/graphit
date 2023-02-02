namespace Graphit.Api;

public class Program
{
    public static async Task Main(string[] args)
    {
        await CreateHostBuilder()
            .Build()
            .RunAsync();

        // var schema = new Schema { Query = new StarWarsQuery() };
        //
        // var json = await schema.ExecuteAsync(_ =>
        // {
        //     _.Query = "{ hero { id name } }";
        // });
        //
        // Console.WriteLine(json);
    }

    public static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureWebHostDefaults(webHost =>
            {
                webHost.UseStartup<Startup>();
            });
    }
}