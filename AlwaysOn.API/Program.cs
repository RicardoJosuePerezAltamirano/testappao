using AlwaysOn.API;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>

{
    options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true;
})
    .AddJsonOptions(op =>
    {
        op.JsonSerializerOptions.PropertyNamingPolicy = null;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DBcontextAO>(o => o.UseSqlServer(builder.Configuration["db"]));

builder.Services.AddCors(setup =>
{
    setup.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}



app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllers();

app.UseCors();

app.MapFallbackToPage("/_Host");
app.MapControllerRoute(
    name: "controllers",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
