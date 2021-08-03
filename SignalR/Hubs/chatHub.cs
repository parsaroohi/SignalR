using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.Hubs
{
    public class chatHub : Hub
    {
        public void send(string name, string message)
        {
            //Clients.Client("connectionString").send();
            Clients.All.addNewMessage(name, message);
        }
    }
}