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
        public void PokedexFilter()
        { 
            app.WaitFor(() => app.Query(e => e.Class("ListView")).Count()>0);
            app.Screenshot("Lista de pokemones cargada");
            app.DoubleTap(x => x.Id("search_src_text"));
            app.Screenshot("Barra de busqueda seleccionada");
            app.EnterText(x => x.Id("search_src_text"), "pika");
            app.DismissKeyboard();
            app.Screenshot("Filtrar por pikachu en la lista");
            app.Tap(x => x.Text("pikachu"));
            app.Screenshot("Navegar a detalle de pikachu");
            app.Back();
            app.Screenshot("Regresar a la lista de pokemones");
        } 
        [Test]
        public void PokedexList()
        { 
            app.WaitFor(() => app.Query(e => e.Class("ListView")).Count() > 0);
            app.Screenshot("Lista de pokemones cargada"); 
            app.ScrollDown();
            app.ScrollDown(); 
            app.Screenshot("Scroll Down realizado"); 
            app.ScrollUp();
            app.ScrollUp();
            app.Screenshot("Scroll Up realizado");
        }
    }
}
