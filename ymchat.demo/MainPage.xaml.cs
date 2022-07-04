using System;
using System.Collections.Generic;
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

            // Getting refernce
            _ymChatInterface = ymChatInterface;

            string botId = "x1597301712805";

            // Setting the bOTId
            _ymChatInterface.setBotId(botId);

            // Enabling the Speech to text button
            _ymChatInterface.setEnableSpeech(true);

            // Enabling Chat History
            _ymChatInterface.setVersion(2);

            // Showing the Close Button
            _ymChatInterface.showCloseButton(true);

            // Setting the payload
            _ymChatInterface.setPayLoad(Payload);

            // Setting close button color with hex code
            _ymChatInterface.setCloseButtonColor("#FFFFFF");

            // Setting statubar button color with hex code
            _ymChatInterface.setStatusBarColor("#000000");

            // Listening to bot events
            _ymChatInterface.onEventFromBot((botEvent) =>
            {
                Console.WriteLine(botEvent["code"]);
                Console.WriteLine(botEvent["data"]);
            });

            // Listening to close bot event
            _ymChatInterface.onBotClose(() =>
            {
                Console.WriteLine("Chatbot closed");
            });


            InitializeComponent();

        }

        void OnButtonClick(object sender, EventArgs e)
        {
            // starting the bot
            _ymChatInterface.startChatBot();
        }



    }
}
