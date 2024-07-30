using API.Extensions;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200", "https://localhost:4200"));
//中介軟體設定該服務允許任何http頭部 任何http方法並且指定網域才可進入

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
