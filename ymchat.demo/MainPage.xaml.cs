using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using YmChat;

namespace ymchat.demo
{
    public partial class MainPage : ContentPage
    {
        IYmChat _ymChatInterface;
        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(IYmChat ymChatInterface)
        {
            Console.WriteLine("Xamarin Forms started");
            var Payload = new Dictionary<string, object> { { "Name ", "Ym" } };

            _ymChatInterface = ymChatInterface;
            string botId = "x1597301712805";//bot ID
            _ymChatInterface.setBotId(botId);//Setting the BOTId
            _ymChatInterface.setEnableSpeech(true);//Enabling the Speech to text Button
            _ymChatInterface.setVersion(2);//Enabling Chat History
            _ymChatInterface.showCloseButton(true);//Showing the Close Button
            _ymChatInterface.setPayLoad(Payload);//setting the payload 
            _ymChatInterface.onEventFromBot((botEvent) =>
            {
                Console.WriteLine(botEvent["code"]);
                Console.WriteLine(botEvent["data"]);
            });

            _ymChatInterface.onBotClose(() =>
            {
                Console.WriteLine("Chatbot closed");
            });


            InitializeComponent();
            


        }

        void OnButtonClick(object sender, EventArgs e)
        {
            _ymChatInterface.startChatBot();// starting the bot
        }



    }
}
