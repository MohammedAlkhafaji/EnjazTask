 
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enjaz_StackOverFlow.Hubs
{
    public class ApiHub:Hub
    {
 

        public async  static void PostToClient(string data)
        {
            try
            {
                var chat = Microsoft.AspNet.SignalR.GlobalHost.ConnectionManager.GetHubContext("ApiHub");
                if (chat != null)
                   await  chat.Clients.All.postToClient(data);
            }
            catch
            {
            }
        }
    }
}
