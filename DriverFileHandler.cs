using Newtonsoft.Json;
namespace capTaxiBackEnd
{
    public class DriverFileHandler
    {
        public List<Driver> drivers;
        public DriverFileHandler(){
            GetAllDrivers();
        }

        private void GetAllDrivers(){
            try{
            string json = File.ReadAllText("drivers.txt");
            drivers = JsonConvert.DeserializeObject<List<Driver>>(json);
            }catch(Exception ex){
                System.Console.WriteLine($"Error: {ex.Message}");
            }

            
        }

        public void SaveAllDrivers()
            {
                File.WriteAllText("drivers.txt", JsonConvert.SerializeObject(drivers));
            }
    }
}