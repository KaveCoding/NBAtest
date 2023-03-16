using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NBAapp
{

    public class Statistics
    {
        public string get { get; set; }
        public Parameters parameters { get; set; }
        public object[] errors { get; set; }
        public int results { get; set; }
        public Response[] response { get; set; }

        public static async Task<Statistics> GetTeamstatistics(int input)
        {
            Statistics newbody = new Statistics();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-nba-v1.p.rapidapi.com/" + $"teams/statistics?id={input}&season=2022"),
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
                    newbody = JsonSerializer.Deserialize<Statistics>(body);
                }
                catch (System.Text.Json.JsonException)
                {

                }
                return newbody;
            }
        }
    }

    public class Parameters
    {
        public string id { get; set; }
        public string season { get; set; }
    }

    public class Response
    {
        public int games { get; set; }
        public int fastBreakPoints { get; set; }
        public int pointsInPaint { get; set; }
        public int biggestLead { get; set; }
        public int secondChancePoints { get; set; }
        public int pointsOffTurnovers { get; set; }
        public int longestRun { get; set; }
        public int points { get; set; }
        public int fgm { get; set; }
        public int fga { get; set; }
        public string fgp { get; set; }
        public int ftm { get; set; }
        public int fta { get; set; }
        public string ftp { get; set; }
        public int tpm { get; set; }
        public int tpa { get; set; }
        public string tpp { get; set; }
        public int offReb { get; set; }
        public int defReb { get; set; }
        public int totReb { get; set; }
        public int assists { get; set; }
        public int pFouls { get; set; }
        public int steals { get; set; }
        public int turnovers { get; set; }
        public int blocks { get; set; }
        public int plusMinus { get; set; }
    }

}
