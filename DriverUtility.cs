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
                System.Console.WriteLine("\tID: \t Name: \t\t    DateHired:    DriverRating: \n");
                foreach(Driver driver in drivers)
                {
                    if(drivers != null){
                        System.Console.WriteLine(driver.ToString());
                    }
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
                System.Console.WriteLine($"ID: {newDriver.ID}");

                System.Console.WriteLine("Enter a name: ");
                newDriver.Name = Console.ReadLine();
                
                Console.WriteLine("Enter Date Hired: ");
                newDriver.DateHired = Console.ReadLine();

                System.Console.WriteLine("Enter Driver Rating");
                newDriver.Rating = Console.ReadLine();
                
                if(newDriver != null){
                    drivers.Add(newDriver);
                    SortDriversByDateHired();
                    SaveToDos();
                }
            }




        public void SaveToDos()
            {
                fileHandler.SaveAllDrivers();
            }

        public void SortDriversByDateHired()
            {
                drivers.Sort((x,y) => y.DateHired.CompareTo(x.DateHired));
            }
    }
}