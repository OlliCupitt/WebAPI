var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/add", (int num1, int num2) => AddNumbers(num1, num2));

app.MapGet("/subtrct", (int num1, int num2) => SubtractNumbers(num1, num2));

app.Run();


string AddNumbers(int num1, int num2)
{
    return $"Summan av tal {num1} och tal {num2} är {num1 + num2}";
}

string SubtractNumbers(int num1, int num2)
{
    return $"Difference av tal {num1} och tal {num2} är {num1 - num2}";
}