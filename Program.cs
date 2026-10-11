using System.Net;
using System.Reflection;

namespace Bibliotekssystem;

class Program
{
    static void Main(string[] args)
    {
        MenuHelper menu = new MenuHelper();
        menu.ShowMenu();
    }
}
