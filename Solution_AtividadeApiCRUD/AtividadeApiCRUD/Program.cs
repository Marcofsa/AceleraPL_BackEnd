
namespace AtividadeApiCRUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("First Middleware (Before)");
                Console.WriteLine("First Middleware (Before)");
                
                await next();

                await context.Response.WriteAsync("First Middleware (After)");
                Console.WriteLine("Second Middleware (Before)");

            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Second Middleware (Before)");
                Console.WriteLine("Second Middleware (Before)");

                await next();

                await context.Response.WriteAsync("Second Middleware (After)");
                Console.WriteLine("Second Middleware (Before)");

            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Third Middleware (Before)");
                Console.WriteLine("Third Middleware (Before)");

                await next();

                await context.Response.WriteAsync("Third Middleware (After)");
                Console.WriteLine("Third Middleware (Before)");

            });

            app.Run();
        }
    }
}
