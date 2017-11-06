namespace PokeConf.App.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new PokeConf.App.App());
        }
    }
}