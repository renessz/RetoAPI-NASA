namespace RetoNasaAPI.Modelos.ModelosMarine
{


    public class WeatherModelMarine
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public float elevation { get; set; }
        public Current_Units current_units { get; set; }
        public Current current { get; set; }
        public Daily_Units daily_units { get; set; }
        public Daily daily { get; set; }
    }

    public class Current_Units
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string wave_height { get; set; }
        public string wave_direction { get; set; }
        public string wave_period { get; set; }
        public string wind_wave_height { get; set; }
        public string wind_wave_direction { get; set; }
        public string wind_wave_period { get; set; }
    }

    public class Current
    {
        public string time { get; set; }
        public int interval { get; set; }
        public float wave_height { get; set; }
        public int wave_direction { get; set; }
        public float wave_period { get; set; }
        public float wind_wave_height { get; set; }
        public int wind_wave_direction { get; set; }
        public float wind_wave_period { get; set; }
    }

    public class Daily_Units
    {
        public string time { get; set; }
        public string wave_height_max { get; set; }
        public string wave_direction_dominant { get; set; }
        public string wave_period_max { get; set; }
        public string wind_wave_height_max { get; set; }
        public string wind_wave_direction_dominant { get; set; }
        public string wind_wave_period_max { get; set; }
    }

    public class Daily
    {
        public string[] time { get; set; }
        public float[] wave_height_max { get; set; }
        public int[] wave_direction_dominant { get; set; }
        public float[] wave_period_max { get; set; }
        public float[] wind_wave_height_max { get; set; }
        public int[] wind_wave_direction_dominant { get; set; }
        public float[] wind_wave_period_max { get; set; }
    }


}
