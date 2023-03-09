using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiDemoDel2_2.Models;
using MongoDB.Driver;
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
        public static int number = 1;  //testa använd denna
        [ObservableProperty]
        ObservableCollection<Models.Team> teams;

        [ObservableProperty]
        Guid id;
        [ObservableProperty]
        string teamName;
        [ObservableProperty]
        string imageSource;
        [ObservableProperty]
        string details;
      

        public Models.Shop Shop { get; set; }

        public  ShopPageViewModel()
        {
            Teams = new ObservableCollection<Models.Team>();
    
            Teams.Add(new Models.Team     //lägg till apiresponse fixa knapp som visar saker 
            {
                Id = Guid.NewGuid(),
                TeamName = "Atlanta Hawks",
                ImageSource = "atlantahawks.png", 
                teamId =1,
                response = NBAAPIResponse.GetResponse(1)
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Boston Celtics",
                ImageSource = "bostonceltics.png",
                teamId = 2
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Brooklyn Nets",
                ImageSource = "brooklynnets.png",
                teamId =4
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Charlotte Hornets",
                ImageSource = "charlottehornets.png",
                teamId =5
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Chicago Bulls",
                ImageSource = "chicagobulls.png",
                teamId =6
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Cleveland Cavaliers",
                ImageSource = "clevelandcavaliers.png",
                teamId =7
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Dallas Mavericks",
                ImageSource = "dallasmavericks.png",
                teamId =8
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Denver Nuggets",
                ImageSource = "denvernuggets.png",
                teamId =9
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Detroit Pistons",
                ImageSource = "detroitpistons.png",
                teamId =10
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Golden State Warriors",
                ImageSource = "goldenstatewarriors.png",
                teamId =11
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Houston Rockets",
                ImageSource = "houstonrockets.png",
                teamId =14
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Indiana Pacers",
                ImageSource = "indianapacers.png",
                teamId =15
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Los Angeles Clippers",
                ImageSource = "losangelesclippers.png",
                teamId =16
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Los Angeles Lakers",
                ImageSource = "losangeleslakers.png",
                teamId =17
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Memphis Grizzlies",
                ImageSource = "memphisgrizzlies.png",
                teamId =19
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Miami Heat",
                ImageSource = "miamiheat.gif",
                teamId =20
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Milwaukee Bucks",
                ImageSource = "milwaukeebucks.png",
                teamId =21
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Minnesota Timberwolves",
                ImageSource = "minnesotatimberwolves.png",
                teamId =22


            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "New Orleans Pelicans",
                ImageSource = "neworleanspelicans.png",
                teamId =23
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "New York Knicks",
                ImageSource = "newyorkknicks.gif",
                teamId =24
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Oklahoma City Thunder",
                ImageSource = "oklahomacitythunder.png",
                teamId =25
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Orlando Magic",
                ImageSource = "orlandomagic.png",
                teamId =26
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Philadelphia 76ers",
                ImageSource = "philadelphia76ers.png",
                teamId =27
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Phoenix Suns",
                ImageSource = "phoenixsuns.png",
                teamId =28
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Portland Trail Blazers",
                ImageSource = "portlandtrailblazers.png",
                teamId =29
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Sacramento Kings",
                ImageSource = "sacramentokings.png",
                teamId =30
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "San Antonio Spurs",
                ImageSource = "sanantoniospurs.png",
                teamId =31
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Toronto Raptors",
                ImageSource = "torontoraptors.png",
                teamId =38
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Utah Jazz",
                ImageSource = "utahjazz.png",
                teamId =40
            });
            Teams.Add(new Models.Team
            {
                Id = Guid.NewGuid(),
                TeamName = "Washington Wizards",
                ImageSource = "washingtonwizards.png",
                teamId =41
            });

          
        }


     
    }
}
