using Xamarin.Forms;
using YmChat;

namespace ymchat.demo
{
    public partial class App : Application
    {
        public App(IYmChat iymchat)
        {
            InitializeComponent();
            MainPage = new MainPage(iymchat);
        }

        protected override void OnStart()
        {
           
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
