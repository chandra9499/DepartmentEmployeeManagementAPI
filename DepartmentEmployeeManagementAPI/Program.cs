using BusinessLogicLayer.Helper;
using BusinessLogicLayer.Interface;
using BusinessLogicLayer.Service;
using DataAccessLayer.Interface;
using DataAccessLayer.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//to set up into the service collection for dependecy injection
//builder.Services.AddTransient<IDepartmentBLL, DepartmentBLL>();
//builder.Services.AddTransient<IDepartmentDAL, DepartmentDAL>();
builder.Services.AddTransient<GlobelExceptionHandler>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

//this are framework sprcific middelware which we want to use in our application

app.UseHttpsRedirection();

//adding middel ware class
app.UseMiddleware<GlobelExceptionHandler>();

app.UseAuthorization();

//to handle error 
//i have made the method async bez i want await for the execution of request handler delegate (approch)
//app.Use(async(context , next)=>
//{
//    //we can intraduce logic befour executing the request
//    //Task task = next(context);
//    ////additional logic
//    //return task;
//    try 
//    {
//        // any request not handled explicitly is cought by our middle ware and can be caught
//        await next(context);
//    }
//    catch (Exception ex) 
//    {
//        //we can catch the exception
//        //await Console.Out.WriteLineAsync(ex.Message);
//        //throw;
        
//        //to access the http responce of the request
//        context.Response.StatusCode = 500;//internal server error
//    }
    
//}
//);

app.MapControllers();

app.Run();
