using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace PokeConf.App.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");

        } 
        [Test]
        public void PokedexList()
        {
            app.WaitForElement(x => x.Text("pikachu"));
            app.DoubleTap(x => x.Id("search_src_text"));
            app.Screenshot("Double tapped on view with class: SearchView$SearchAutoComplete with id: search_src_text");
            app.EnterText(x => x.Id("search_src_text"), "pika");
            app.DismissKeyboard();
            app.Tap(x => x.Text("pikachu"));
            app.Screenshot("Tapped on view with class: FormsTextView with text: pikachu");
            app.Back();
            app.Screenshot("Tapped on view with class: AppCompatImageButtonBack");
        } 
    }
}
