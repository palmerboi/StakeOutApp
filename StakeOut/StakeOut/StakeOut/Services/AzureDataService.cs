
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using StakeOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeOut.Services
{
    class AzureDataService
    {
        private static AzureDataService instance;
        private MobileServiceClient client;
        private IMobileServiceTable<Profile> ProfileTab;

        private AzureDataService()
        {
            this.client = new MobileServiceClient("http://stakeoutapp.azurewebsites.net");
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public static AzureDataService AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureDataService();
                }

                return instance;
            }
        }
    }
}
