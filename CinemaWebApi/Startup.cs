﻿using CinemaWebApi.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi
{

    //sasa
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration["ConnectionStrings:MoiveDBConection"];
            builder.Services.AddDbContext<MovieContext>(o => o.UseSqlServer(connectionString));

            builder.Services.AddControllers();
        }

        public static void Configure(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

        }
    }
}
