using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using MongoDB.Driver;
using BasketAppen.Models;

namespace BasketAppen.ViewModels
{
   
        internal partial class EBPageViewmodel : ObservableObject  // ÄNDRAT!
        {
            [ObservableProperty] // ÄNDRAT!
            ObservableCollection<Models.Lagmedlem> lagmedlemmar;
            //public List<Models.Lagmedlem> Lagmedlems { get; set; }

            [ObservableProperty]
            Guid id;

            [ObservableProperty]
            string namn;
            [ObservableProperty]
            int vikt;
            [ObservableProperty]
            string bild;
            [ObservableProperty]
            string beskrivning;
            [ObservableProperty]
            string position;
            [ObservableProperty]
            int längd;
           
       
        
            public EBPageViewmodel()
            {
                lagmedlemmar = new ObservableCollection<Lagmedlem>();
              
            }


            // NYTT!
            [RelayCommand]
            public async void AddLagmedlem()
            {
            
                Lagmedlem lagmedlem = new Lagmedlem()
                {
                    Id = Guid.NewGuid(),
                    Namn = Namn,
                    Vikt = Vikt,
                    Bild = Bild,
                    Beskrivning = Beskrivning,
                    Position = Position,
                    Längd = längd
                };
            
            
            await GetDbCollection().InsertOneAsync(lagmedlem);

                Lagmedlemmar.Add(lagmedlem);
            }

            [RelayCommand]
            public async void DeleteLagmedlem(object p)
            {
                var prod = (Lagmedlem)p;
                await GetDbCollection().DeleteOneAsync(x => x.Id == prod.Id);
                Lagmedlemmar.Remove(prod);
            }

            public async Task GetLagmedlemmar()
            {
                List<Lagmedlem> LagmedlemsFromDb = await GetDbCollection().AsQueryable().ToListAsync();
            
                LagmedlemsFromDb.ForEach(x => Lagmedlemmar.Add(x));
               
            }

            public IMongoCollection<Lagmedlem> GetDbCollection()
            {
                var settings = MongoClientSettings.FromConnectionString("mongodb+srv://EliasZanghnaeh:Eazking23@eliastestdb.r8tqfe0.mongodb.net/?retryWrites=true&w=majority");
                settings.ServerApi = new ServerApi(ServerApiVersion.V1);
                var client = new MongoClient(settings);
                var database = client.GetDatabase("test");
                var myCollection = database.GetCollection<Lagmedlem>("MyLagmedlemCollection");
                return myCollection;
            }
        }
}
