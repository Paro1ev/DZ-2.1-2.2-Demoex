var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


List<Order> repo = new List<Order>()
{
    new Order(1, 03, 03, 2005, "Тостер", "Сгорел", "Включил и сгорел", "Кирилл", "В процессе", "Светлоликий")

};


app.MapGet("/", () => repo);
app.MapPost("/", (Order ord) => repo.Add(ord));
app.MapPut("/{number}", (int number, OrderUpdateDTO dto) =>
{
    Order buffer = repo.Find(ord => ord.Number == number);
    if (buffer == null)
        return Results.NotFound("Нету");
    buffer.Status = dto.Status;
    buffer.Description = dto.Description;
    buffer.Master = dto.Master;
    return Results.Json(buffer);
});
app.Run();

class OrderUpdateDTO
{
    string status;
    string description;
    string master;

    public string Status { get => status; set => status = value; }
    public string Description { get => description; set => description = value; }
    public string Master { get => master; set => master = value; }
}
class Order
{
    int number;
    int day;
    int month;
    int year;
    string device;
    string problem;
    string description;
    string client;
    string status;
    string master;

    public Order(int number, int day, int month, int year, string device, string problem, string description, string client, string status, string master)
    {
        Number = number;
        Day = day;
        Month = month;
        Year = year;
        Device = device;
        Problem = problem;
        Description = description;
        Client = client;
        Status = status;
        Master = master;
    }

    public int Number { get => number; set => number = value; }
    public int Day { get => day; set => day = value; }
    public int Month { get => month; set => month = value; }
    public int Year { get => year; set => year = value; }
    public string Device { get => device; set => device = value; }
    public string Problem { get => problem; set => problem = value; }
    public string Description { get => description; set => description = value; }
    public string Client { get => client; set => client = value; }
    public string Status { get => status; set => status = value; }
    public string Master { get => master; set => master = value; }
}