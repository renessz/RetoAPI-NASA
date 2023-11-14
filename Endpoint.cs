
﻿using RetoNasaAPI;


namespace RetoNasaAPI
{
    public class Endpoint
    {

        public static string getGeoApify(string city)
        {
            // return $"https://api.geoapify.com/v1/geocode/search?text=Bilbao&format=json&apiKey=0285c5b0e08f4660904d080a7370cb8c";   
            return $"https://api.geoapify.com/v1/geocode/search?text={city}&format=json&apiKey={Config.GeoApifykey}";
        }

        public static string GetWeatherEndPointMarine(float lat, float lon)
        {
            var url2 = $"https://marine-api.open-meteo.com/v1/marine?latitude={lat}&longitude={lon}&current=wave_height,wave_direction,wave_period,wind_wave_height,wind_wave_direction,wind_wave_period&daily=wave_height_max,wave_direction_dominant,wave_period_max,wind_wave_height_max,wind_wave_direction_dominant,wind_wave_period_max&timezone=Europe%2FLondon";
            return url2;
        }

       
        public static string GetWeatherEndPointAir(float lat, float lon)
        {
            var url = $" https://air-quality-api.open-meteo.com/v1/air-quality?latitude={lat}&longitude={lon}&current=ozone&hourly=pm10,pm2_5,carbon_monoxide,nitrogen_dioxide,ozone,dust,uv_index\r\n    ";

            return url;
        }
        public static string GetWeatherEndPoint(float lat, float lon)
        {
            var url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,relativehumidity_2m,is_day&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min,uv_index_max,windspeed_10m_max&timezone=Europe%2FLondon\r\n";
            return url;
        }
    }
}

    


