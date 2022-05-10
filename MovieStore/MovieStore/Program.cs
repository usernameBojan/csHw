using Services;
using Domain;
using Domain.Classes;
using Services;
Console.WriteLine(DateTime.Now.Year);
MenuService menuService = new MenuService();
while (true)
{
    menuService.WelcomeMenu();
}