using ChatApi.Hubs;
using ChatApi.Services;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSingleton<ChatService>(); //service registered.
builder.Services.AddSignalR();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors();
var app = builder.Build();
app.UseCors(x=>x.AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithOrigins("http://localhost:4200"));
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseDefaultFiles();
app.UseStaticFiles();
app.MapControllers();
app.MapHub<ChatHub>("hubs/chat"); // map added.
app.Run();
