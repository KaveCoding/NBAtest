using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiDemoDel2_2.Models
{
  
    public class NBAAPIResponse
    {
        public Guid? Id { get; set; }
        public string? get { get; set; }
        public Parameters? parameters { get; set; }
        public object?[] errors { get; set; }
        public int? results { get; set; }
        public Response?[] response { get; set; }

        public static async Task<NBAAPIResponse> Getplayers(string input)
        {
            NBAAPIResponse newbody = new NBAAPIResponse();


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-nba-v1.p.rapidapi.com/players?search=" + $"{input}"),
                Headers =
    {
        { "X-RapidAPI-Key", "f05060df2fmshb5d970a07cc07bep17709djsnb951b9d040b3" },
        { "X-RapidAPI-Host", "api-nba-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                newbody = JsonSerializer.Deserialize<NBAAPIResponse>(body);
            }


            return newbody;
        }
        public  static async Task<NBAAPIResponse> GetNBATeam(int input)
            {
                NBAAPIResponse newbody = new NBAAPIResponse();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://api-nba-v1.p.rapidapi.com/" + $"players?team={input}&season=2022"),
                    Headers =
        {
        { "X-RapidAPI-Key", "f05060df2fmshb5d970a07cc07bep17709djsnb951b9d040b3" },
        { "X-RapidAPI-Host", "api-nba-v1.p.rapidapi.com" },
        },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                try
                {
                    newbody = JsonSerializer.Deserialize<NBAAPIResponse>(body);
                }
                catch (JsonException)                                                            //ibland funkar inte serializern
                {

                }
                return newbody;
                }
            }
        
    }
        
    }

    public class Parameters
    {
        public string? team { get; set; }
        public string? season { get; set; }

    }

    public class Response
    {
        public Guid? Id { get; set; }
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public Birth? birth { get; set; }
        public Nba? nba { get; set; }
        public Height? height { get; set; }
        public Weight? weight { get; set; }
        public string college { get; set; }
        public string affiliation { get; set; }
        public Leagues? leagues { get; set; }
        public string? heightinM { get; set; }
        public string? weightinKG { get; set; }
        public string? birthdate { get; set; }
        public string? position { get; set; }



}

    public class Birth
    {
        public string date { get; set; }
        public string country { get; set; }
    }

    public class Nba
    {
        public int start { get; set; }
        public int pro { get; set; }
    }

    public class Height
    {
        public string feets { get; set; }
        public string inches { get; set; }
        public string meters { get; set; }
    }

    public class Weight
    {
        public string pounds { get; set; }
        public string kilograms { get; set; }
    }

    public class Leagues
    {
        public Standard? standard { get; set; }
        public Africa? africa { get; set; }
        public Vegas? vegas { get; set; }
        public Utah? utah { get; set; }
        public Sacramento? sacramento { get; set; }
    }

    public class Standard
    {
        public int? jersey { get; set; }
        public bool? active { get; set; }
        public string? pos { get; set; }
    }

    public class Africa
    {
        public int? jersey { get; set; }
        public bool active { get; set; }
        public string pos { get; set; }
    }

    public class Vegas
    {
        public int jersey { get; set; }
        public bool active { get; set; }
        public string pos { get; set; }
    }

    public class Utah
    {
        public int jersey { get; set; }
        public bool active { get; set; }
        public string pos { get; set; }
    }

    public class Sacramento
    {
        public int jersey { get; set; }
        public bool active { get; set; }
        public string pos { get; set; }
    }




    
