
﻿namespace RetoNasaAPI.Modelos


{

    public class CityData
    {
        public Result[] results { get; set; }
        public Query query { get; set; }
    }

    public class Query
    {
        public string text { get; set; }
        public Parsed parsed { get; set; }
    }

    public class Parsed
    {
        public string city { get; set; }
        public string expected_type { get; set; }
    }

    public class Result
    {
        public Datasource datasource { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string state { get; set; }
        public string county { get; set; }
        public string city { get; set; }
        public float lon { get; set; }
        public float lat { get; set; }
        public string formatted { get; set; }
        public string address_line1 { get; set; }
        public string address_line2 { get; set; }
        public string category { get; set; }
        public Timezone timezone { get; set; }
        public string plus_code { get; set; }
        public string plus_code_short { get; set; }
        public string result_type { get; set; }
        public Rank rank { get; set; }
        public string place_id { get; set; }
        public Bbox bbox { get; set; }
        public string name { get; set; }
        public string state_code { get; set; }
        public string region { get; set; }
        public string state_district { get; set; }
        public string village { get; set; }
    }

    public class Datasource
    {
        public string sourcename { get; set; }
        public string attribution { get; set; }
        public string license { get; set; }
        public string url { get; set; }
    }

    public class Timezone
    {
        public string name { get; set; }
        public string offset_STD { get; set; }
        public int offset_STD_seconds { get; set; }
        public string offset_DST { get; set; }
        public int offset_DST_seconds { get; set; }
        public string abbreviation_STD { get; set; }
        public string abbreviation_DST { get; set; }
    }

    public class Rank
    {
        public float importance { get; set; }
        public float popularity { get; set; }
        public int confidence { get; set; }
        public int confidence_city_level { get; set; }
        public string match_type { get; set; }
    }

    public class Bbox
    {
        public float lon1 { get; set; }
        public float lat1 { get; set; }
        public float lon2 { get; set; }
        public float lat2 { get; set; }
    }

}
