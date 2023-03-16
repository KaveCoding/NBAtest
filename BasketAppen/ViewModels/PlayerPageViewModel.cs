using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using BasketAppen.Models;
using MongoDB.Driver;

namespace BasketAppen.ViewModels
{
    internal partial class PlayerPageViewModel : ObservableObject
    {
        [ObservableProperty] 
        ObservableCollection<Response> players;
        

        [ObservableProperty]
        Guid id;

        [ObservableProperty]
        string namn;
        [ObservableProperty]
        string firstname;
        [ObservableProperty]
        string lastname;





        public PlayerPageViewModel()
        {
            Players = new ObservableCollection<Response>();

        }


        // NYTT!
        [RelayCommand]
        public async void SearchForPlayer()
        {
            var response = await NBAAPIResponse.Getplayers(namn);

            foreach (var item in response.response)
            {
                Response player = new Response()
                {
                    Id = Guid.NewGuid(),
                    firstname = item.firstname,
                    lastname = item.lastname,
                    heightinM = item.height.meters,
                    weightinKG = item.weight.kilograms,
                    birthdate = item.birth.date,
                    position = item.leagues.standard.pos

                };
                await GetDbCollection().InsertOneAsync(player);
                Players.Add(player);
            }
            
        }

        [RelayCommand]
        public async void DeletePlayers(object p)
        {
            var prod = (Response)p;
            await GetDbCollection().DeleteOneAsync(x => x.Id == prod.Id);
            Players.Remove(prod);
        }

        public async Task GetPlayers()
        {
            List<Response> LagmedlemsFromDb = await GetDbCollection().AsQueryable().ToListAsync();
            await Task.Delay(3000);
            LagmedlemsFromDb.ForEach(x => Players.Add(x));

        }

        public IMongoCollection<Response> GetDbCollection()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://EliasZanghnaeh:Eazking23@eliastestdb.r8tqfe0.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("test");
            var myCollection = database.GetCollection<Response>("Sökhistorik");
            return myCollection;
        }
    }
}
