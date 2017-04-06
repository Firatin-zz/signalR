using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace signalR.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string name, string message) {
            //Clients.All();//bütün istyemciler de tetikle
            //Clients.Others(); //Diğer clientlerde
            //Clients.Caller();//bende
            //Clients.Users("");//bewlirtilen kullanıcıya



            //Burda viewdan gönderilen sunucudaki methotları tetikliyoruz
            Clients.Others.GetMessageOther(name,message);//karşı taraflara name ve message
            Clients.Caller.GetMessageCaller(message);//Mesajı yazan kişiye kendi adını göstermiyoruz

            //Datamız sunucuya çıktı sıra clientlere iletmek >>>Index
        }
    }
}