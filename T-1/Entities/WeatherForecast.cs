namespace T_1.Entities
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TempratureC {  get; set; }

        public int TempratureF => 32 + (int)(TempratureC / 0.5556);

        public string? Summery { get; set; }

    }
}