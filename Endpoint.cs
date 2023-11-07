using RetoNasaAPI;

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
            var url = $"https://air-quality-api.open-meteo.com/v1/air-quality?latitude={lat}&longitude={lon}&current=european_aqi,us_aqi,pm10,pm2_5,carbon_monoxide,nitrogen_dioxide,uv_index&hourly=pm10,pm2_5&timezone=Europe%2FLondon\r\n    ";

            return url;
        }
    }


}
