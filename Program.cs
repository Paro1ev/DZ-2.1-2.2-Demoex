var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();


class Order
{
    int number;
    int day;
    int month;
    int year;
    string device;
    string Problem;
    string Description;
    string client;
    string status;
    string master;

    public Order(int number, int day, int month, int year, string device, string problem1, string description1, string client, string status, string master)
    {
        Number = number;
        Day = day;
        Month = month;
        Year = year;
        Device = device;
        Problem1 = problem1;
        Description1 = description1;
        Client = client;
        Status = status;
        Master = master;
    }

    public int Number { get => number; set => number = value; }
    public int Day { get => day; set => day = value; }
    public int Month { get => month; set => month = value; }
    public int Year { get => year; set => year = value; }
    public string Device { get => device; set => device = value; }
    public string Problem1 { get => Problem; set => Problem = value; }
    public string Description1 { get => Description; set => Description = value; }
    public string Client { get => client; set => client = value; }
    public string Status { get => status; set => status = value; }
    public string Master { get => master; set => master = value; }
}