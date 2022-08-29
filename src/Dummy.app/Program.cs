var builder = WebApplication.CreateBuilder(args);

var unusedVar = string.Empty;

if(unusedVar != null)
{
    //nothing
}

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

app.Run();



public class GenericExceptionsCaught
{
    FileStream inStream;
    FileStream outStream;

    public GenericExceptionsCaught(string inFile, string outFile)
    {
        try
        {
            inStream = File.Open(inFile, FileMode.Open);
        }
        catch (SystemException)
        {
            Console.WriteLine("Unable to open {0}.", inFile);
        }

        try
        {
            outStream = File.Open(outFile, FileMode.Open);
        }
        catch
        {
            Console.WriteLine("Unable to open {0}.", outFile);
        }
    }
}