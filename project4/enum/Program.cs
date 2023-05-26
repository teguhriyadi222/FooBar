
namespace programenum;

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
