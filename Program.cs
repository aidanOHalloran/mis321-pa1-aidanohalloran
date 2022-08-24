using capTaxiBackEnd;

DriverUtility utils = new DriverUtility();
Menu menu = new Menu();

string userChoice = menu.GetMainMenuChoice();
while(userChoice != "6"){
    RouteEm(userChoice);
    userChoice = menu.GetMainMenuChoice();
}
if(userChoice == "6")
    Environment.Exit(0);

void RouteEm(string userChoice)
    {
        switch(userChoice)
            {
                case "1":
                    utils.DisplayDrivers();
                    break;
                case "2":
                    utils.AddDriver();
                    break;
                case "3":
                    utils.UpdateRating();
                    break;
                case "4":
                    utils.DeleteDriver();
                    break;
                case "5":
                    System.Console.WriteLine("goto view maint date");
                    break;
                default:
                    System.Console.WriteLine("Bad Entry");
                    break;
            }
    }