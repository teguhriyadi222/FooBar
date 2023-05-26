
enum Month
{
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}

interface IWeatherInfo
{
    string GetWeatherInfo();
}

class Weather
{
    public Month Month { get; set; }
    public string Description { get; set; }

    public Weather(Month month, string description)
    {
        Month = month;
        Description = description;
    }

    public static Weather GetWeather(Month month)
    {
        switch (month)
        {
            case Month.January:
            case Month.February:
                return new Weather(month, "Summer.");
            case Month.March:
            case Month.April:
            case Month.May:
                return new Weather(month, "Winter.");
            case Month.June:
            case Month.July:
            case Month.August:
                return new Weather(month, "Sunny.");
            case Month.September:
            case Month.October:
            case Month.November:
            case Month.December:
                return new Weather(month, "Spring.");
            default:
                return null;
        }
    }
}

class WeatherInfo : IWeatherInfo
{
    private Weather weather;

    public WeatherInfo(Weather weather)
    {
        this.weather = weather;
    }

    public string GetWeatherInfo()
    {
        return $"Weather in {weather.Month}: {weather.Description}";
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the number of a month (1-12):");
            int monthNumber = int.Parse(Console.ReadLine());

            if (monthNumber >= 1 && monthNumber <= 12)
            {
                Month selectedMonth = (Month)(monthNumber - 1);
                Weather weather = Weather.GetWeather(selectedMonth);

                if (weather != null)
                {
                    IWeatherInfo weatherInfo = new WeatherInfo(weather);
                    Console.WriteLine(weatherInfo.GetWeatherInfo());
                }
                else
                {
                    Console.WriteLine("No weather information available for the selected month.");
                }
            }
            else
            {
                Console.WriteLine("Invalid month number.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
