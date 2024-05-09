using System.ComponentModel;

namespace Inqola.Models;

public class WeatherForecast
{
    public int Id { get; set; }

    [DisplayName("Date")]
    public DateTime? Date { get; set; }

    [DisplayName("Temp. (C)")]
    public int TemperatureC { get; set; }

    [DisplayName("Summary")]
    public string Summary { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public bool Hot { get; set; }
}
