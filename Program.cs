
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new
{
    message = "Gujarati Quiz API is running.",
    endpoint = "/api/quizzes"
}));

app.MapGet("/api/quizzes", () => Results.Json(new
{
    quizzes = new[]
    {
        new
        {
            id = 1,
            options = new[]
            {
                new { id = 0, text = "કૃપા" },
                new { id = 1, text = "આકાશ" },
                new { id = 2, text = "આત્મવિશ્વાસ" }
            }
        },

        new
        {
            id = 2,
            options = new[]
            {
                new { id = 0, text = "ગુજરાત" },
                new { id = 1, text = "પ્રેમ" },
                new { id = 2, text = "વિશ્વાસ" }
            }
        },

        new
        {
            id = 3,
            options = new[]
            {
                new { id = 0, text = "શિક્ષણ" },
                new { id = 1, text = "પ્રકૃતિ" },
                new { id = 2, text = "સ્વચ્છતા" }
            }
        }
    }
}));

app.Run();