namespace capTaxiBackEnd
{
    public class DriverUtility
    {
        public List<Driver> drivers;
        private DriverFileHandler fileHandler = new DriverFileHandler();

        public DriverUtility()
            {
                drivers = fileHandler.drivers;
            }


        public void DisplayDrivers()
            {
                Console.Clear();
                System.Console.WriteLine("\n\t\t1. Sort by Date Hired\n\t\t2. Sort by Rating\n\t\t3. Home\n");
                string userInput = Console.ReadLine();
                if(userInput == "1")
                {
                    SortDriversByDateHired();
                    System.Console.WriteLine("\tID: \t Name: \t\t    DateHired:    DriverRating: \n");
                    foreach(Driver driver in drivers)
                    {
                        if(drivers != null){
                            System.Console.WriteLine(driver.ToString());
                        }
                    }
                }else if(userInput == "2")
                {
                    SortDriversByRating();
                    System.Console.WriteLine("\tID: \t Name: \t\t    DateHired:    DriverRating: \n");
                    foreach(Driver driver in drivers)
                    {
                        if(drivers != null){
                            System.Console.WriteLine(driver.ToString());
                        }
                    }
                }else{
                    System.Console.WriteLine("Bad Entry");
                    userInput = Console.ReadLine();
                }
            
                System.Console.WriteLine();
               
            }
        public void AddDriver()
            {
                Driver newDriver = new Driver();
                System.Console.WriteLine("Press enter to assign ID: ");
                Console.ReadLine();
                int intID = drivers.Count();
                newDriver.ID = intID.ToString();
                foreach(Driver driver in drivers)
                    {
                        while(newDriver.ID == driver.ID){
                            intID += 1;
                            newDriver.ID = intID.ToString();
                        }
                    }
                System.Console.WriteLine($"ID: {newDriver.ID}");

                System.Console.WriteLine("Enter a name: ");
                newDriver.Name = Console.ReadLine();
                
                Console.WriteLine("Enter Date Hired: ");
                newDriver.DateHired = Console.ReadLine();

                System.Console.WriteLine("Enter Driver Rating");
                newDriver.Rating = Console.ReadLine();
                if(newDriver.Name == "")
                    newDriver.Name = null;

                if(newDriver.ID != null && newDriver.Name != null && newDriver.Rating != null && newDriver.DateHired != null){
                    drivers.Add(newDriver);
                    SortDriversByDateHired();
                    SaveDrivers();
                }else{
                    System.Console.WriteLine("Bad Entry. Press any key to re-start process");
                    AddDriver();
                }
            }

            public void UpdateRating(){
                System.Console.WriteLine("Enter the ID of the driver you want to edit: ");
                string userInput = Console.ReadLine();
                Driver driver = FindDriver(userInput);
                if(driver == null){
                    System.Console.WriteLine("404 ~~ driver ID not found");
                }else{
                    System.Console.WriteLine("Enter new rating: ");
                    driver.Rating = Console.ReadLine();
                }
                SaveDrivers();
            }

            public void DeleteDriver()
            {
                System.Console.WriteLine("Enter the id of the driver you want to delete: ");
                string userInput = Console.ReadLine();
                Driver driver = FindDriver(userInput); 
                if(driver == null)
                    {
                        System.Console.WriteLine("Driver not found");
                    }else
                    {
                        int index = drivers.IndexOf(driver);
                        drivers.RemoveAt(index);
                    }
                SaveDrivers();
            }    

            private Driver FindDriver(string searchVal){
                Driver returnVal = drivers.Find(x => x.ID.ToLower() == searchVal.ToLower());
                return returnVal;
            }

        public void SaveDrivers()
            {
                fileHandler.SaveAllDrivers();
            }

        public void SortDriversByDateHired()
            {
                drivers.Sort((x,y) => y.DateHired.CompareTo(x.DateHired));
            }
        public void SortDriversByRating()
            {
                drivers.Sort((x,y) => y.Rating.CompareTo(x.Rating));
            }
    }
}