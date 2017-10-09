
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeOut.Services
{
    class AzureDataService
    {
        public MobileServiceClient MobileService { get; set; }
        IMobileServiceSyncTable profileTable;

        public async Task Initialize()
        {
            //Create our client
            MobileService = new MobileServiceClient("http://stakeoutapp.azurewebsites.net");

            const string path = "syncstore.db";
            //setup our local sqlite store and intialize our table
            var store = new MobileServiceSQLiteStore(path);
            store.DefineTable();
            await MobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());

            //Get our sync table that will call out to azure
            profileTable = MobileService.GetSyncTable();
        }

        public async Task<IEnumerable> GetProfiles()
        {
        }

        public async Task AddProfile(bool madeAtHome)
        {
        }

        public async Task SyncProfiles()
        {
        }
    }
}
