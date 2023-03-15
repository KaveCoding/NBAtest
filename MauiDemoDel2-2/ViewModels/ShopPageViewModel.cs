using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDemoDel2_2.Models;
using MongoDB.Driver;
using NBAapp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiDemoDel2_2.ViewModels
{

    
    internal partial class ShopPageViewModel : ObservableObject  
    {
      
        [ObservableProperty]
        ObservableCollection<Models.Team> teams;

        [ObservableProperty]
        Guid id;
        [ObservableProperty]
        string teamName;
        [ObservableProperty]
        string imageSource;

        static string team1info = null;

        static async Task<List<string>> runplayers()
        {

            string teaminfo = null;
            List<string> teaminfos = new List<string>();
            
            for (int i = 1; i <= 41 ; i++)
            {
                var Team = await NBAAPIResponse.GetNBATeam(i);
                if (Team.response != null)
                {
                    foreach (var item in Team.response)
                    {
                        teaminfo += $" {item.firstname} {item.lastname} {item.height.meters}m {item.weight.kilograms}Kg Position ";
                            
                        if (item.leagues.standard != null) 
                            teaminfo += item.leagues.standard.pos + "\n";
                    }
                }
                    
                if (teaminfos != null)
                {
                    teaminfos.Add(teaminfo);
                }
                else if (teaminfos == null)
                {
                    teaminfos.Add("Buggad");
                }
                teaminfo = null;
            }
               
            return teaminfos;
        }
        static async Task<List<string>> runstats()
        {

            string teaminfo = null;
            List<string> teaminfos = new List<string>();

            for (int i = 1; i <= 41; i++)
            {
                var Team = await Statistics.GetTeamstatistics(i);
                if (Team.response != null)
                {
                    foreach (var item in Team.response)
                    {
                        teaminfo += $"Matcher {item.games}\nFastbreakPoäng {item.fastBreakPoints}" +
                            $"\nPoäng från paint {item.pointsInPaint}\nAndra chans poäng {item.secondChancePoints}\n" +
                            $"Poäng från turnovers {item.pointsOffTurnovers}\nStörsta ledningen {item.longestRun}\n" +
                            $"Antal mål {item.fgm}\nMålförsök {item.fga}\nProcent {item.fgp}\n3-poängare {item.tpm}\n" +
                            $"3-poängare försök {item.tpa}\n3-poäng Procent {item.tpp}\nLyckade Frikast {item.ftm}\nFrikast gjorda {item.fta}\n" +
                            $"Frikast Procent {item.ftp}\nTotala Rebounds {item.totReb}\nOffensiva rebounds {item.offReb}\n" +
                            $"Defensiva rebounds {item.defReb}\nAssister {item.assists}\nSteals {item.steals}\nBlocks {item.blocks}\n" +
                            $"Turnovers {item.turnovers}\nFouls {item.pFouls}\nTotala poäng {item.points}";


                    }
                }

                if (teaminfos != null)
                {
                    teaminfos.Add(teaminfo);
                }
                else if (teaminfos == null)
                {
                    teaminfos.Add("Buggad");
                }
                teaminfo = null;
            }

            return teaminfos;
        }
   
        public  ShopPageViewModel()
        {
            var task = Task.Run(() => runplayers());
            task.Wait();
            var task2 = Task.Run(() => runstats());
            task2.Wait();


            try
            {
                Teams = new ObservableCollection<Models.Team>();
                Teams.Add(new Models.Team     
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Atlanta Hawks",
                    ImageSource = "atlantahawks.png",
                    teamId = 1,
                    response = task.Result[0],
                    stats = task2.Result[0]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Boston Celtics",
                    ImageSource = "bostonceltics.png",
                    teamId = 2,
                    response = task.Result[1],
                    stats = task2.Result[1]

                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Brooklyn Nets",
                    ImageSource = "brooklynnets.png",
                    teamId = 4,
                    response = task.Result[3]
                    ,
                    stats = task2.Result[3]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Charlotte Hornets",
                    ImageSource = "charlottehornets.png",
                    teamId = 5,
                    response = task.Result[4]
                    ,
                    stats = task2.Result[4]
                });
                Teams.Add(new Models.Team    
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Chicago Bulls",
                    ImageSource = "chicagobulls.png",
                    teamId = 6,
                    response = task.Result[5],
                    stats = task2.Result[5]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Cleveland Cavaliers",
                    ImageSource = "clevelandcavaliers.png",
                    teamId = 7,
                    response = task.Result[6]
                    ,
                    stats = task2.Result[6]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Dallas Mavericks",
                    ImageSource = "dallasmavericks.png",
                    teamId = 8,
                    response = task.Result[7],
                    stats = task2.Result[7]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Denver Nuggets",
                    ImageSource = "denvernuggets.png",
                    teamId = 9,
                    response = task.Result[8],
                    stats = task2.Result[8]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Detroit Pistons",
                    ImageSource = "detroitpistons.png",
                    teamId = 10,
                    response = task.Result[9],
                    stats = task2.Result[9]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Golden State Warriors",
                    ImageSource = "goldenstatewarriors.png",
                    teamId = 11,
                    response = task.Result[10],
                    stats = task2.Result[10]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Houston Rockets",
                    ImageSource = "houstonrockets.png",
                    teamId = 14,
                    response = task.Result[13],
                    stats = task2.Result[13]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Indiana Pacers",
                    ImageSource = "indianapacers.png",
                    teamId = 15,
                    response = task.Result[14],
                    stats = task2.Result[14]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Los Angeles Clippers",
                    ImageSource = "losangelesclippers.png",
                    teamId = 16,
                    response = task.Result[15],
                    stats = task2.Result[15]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Los Angeles Lakers",
                    ImageSource = "losangeleslakers.png",
                    teamId = 17,
                    response = task.Result[16],
                    stats = task2.Result[16]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Memphis Grizzlies",
                    ImageSource = "memphisgrizzlies.png",
                    teamId = 19,
                    response = task.Result[18],
                    stats = task2.Result[18]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Miami Heat",
                    ImageSource = "miamiheat.gif",
                    teamId = 20,
                    response = task.Result[19],
                    stats = task2.Result[19]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Milwaukee Bucks",
                    ImageSource = "milwaukeebucks.png",
                    teamId = 21,
                    response = task.Result[20],
                    stats = task2.Result[20]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Minnesota Timberwolves",
                    ImageSource = "minnesotatimberwolves.png",
                    teamId = 22,
                    response = task.Result[21],
                    stats = task2.Result[21]


                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "New Orleans Pelicans",
                    ImageSource = "neworleanspelicans.png",
                    teamId = 23,
                    response = task.Result[22],
                    stats = task2.Result[22]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "New York Knicks",
                    ImageSource = "newyorkknicks.gif",
                    teamId = 24,
                    response = task.Result[23],
                    stats = task2.Result[23]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Oklahoma City Thunder",
                    ImageSource = "oklahomacitythunder.png",
                    teamId = 25,
                    response = task.Result[24],
                    stats = task2.Result[24]

                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Orlando Magic",
                    ImageSource = "orlandomagic.png",
                    teamId = 26,
                    response = task.Result[25],
                    stats = task2.Result[25]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Philadelphia 76ers",
                    ImageSource = "philadelphia76ers.png",
                    teamId = 27,
                    response = task.Result[26],
                    stats = task2.Result[26]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Phoenix Suns",
                    ImageSource = "phoenixsuns.png",
                    teamId = 28,
                    response = task.Result[27],
                    stats = task2.Result[27]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Portland Trail Blazers",
                    ImageSource = "portlandtrailblazers.png",
                    teamId = 29,
                    response = task.Result[28],
                    stats = task2.Result[28]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Sacramento Kings",
                    ImageSource = "sacramentokings.png",
                    teamId = 30,
                    response = task.Result[29],
                    stats = task2.Result[29]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "San Antonio Spurs",
                    ImageSource = "sanantoniospurs.png",
                    teamId = 31,
                    response = task.Result[30],
                    stats = task2.Result[30]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Toronto Raptors",
                    ImageSource = "torontoraptors.png",
                    teamId = 38,
                    response = task.Result[31],
                    stats = task2.Result[31]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Utah Jazz",
                    ImageSource = "utahjazz.png",
                    teamId = 40,
                    response = task.Result[39],
                    stats = task2.Result[39]
                });
                Teams.Add(new Models.Team
                {
                    Id = Guid.NewGuid(),
                    TeamName = "Washington Wizards",
                    ImageSource = "washingtonwizards.png",
                    teamId = 41,
                    response = task.Result[40],
                    stats = task2.Result[40]
                });
            }
            catch (System.AggregateException) 
            {
                
            }
            

          
        }


     
    }
}
