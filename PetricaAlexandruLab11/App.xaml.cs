using PetricaAlexandruLab11.Data;
using PetricaAlexandruLab11.Models;

namespace PetricaAlexandruLab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}
