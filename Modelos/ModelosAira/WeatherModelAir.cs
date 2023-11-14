namespace RetoNasaAPI.Modelos.ModelosAira
{
    public class WheatherModelAir
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
        public Hourly_Units hourly_units { get; set; }
        public Hourly hourly { get; set; }
    }

    public class Current_Units
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string ozone { get; set; }
    }

    public class Current
    {
        public string time { get; set; }
        public int interval { get; set; }
        public float ozone { get; set; }
    }

    public class Hourly_Units
    {
        public string time { get; set; }
        public string pm10 { get; set; }
        public string pm2_5 { get; set; }
        public string carbon_monoxide { get; set; }
        public string nitrogen_dioxide { get; set; }
        public string ozone { get; set; }
        public string dust { get; set; }
        public string uv_index { get; set; }
    }

    public class Hourly
    {
        public string[] time { get; set; }
        public float?[] pm10 { get; set; }
        public float?[] pm2_5 { get; set; }
        public float?[] carbon_monoxide { get; set; }
        public float?[] nitrogen_dioxide { get; set; }
        public float?[] ozone { get; set; }
        public float?[] dust { get; set; }
        public float?[] uv_index { get; set; }
    }

}
