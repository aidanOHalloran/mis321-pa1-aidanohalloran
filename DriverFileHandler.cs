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
            string json = File.ReadAllText("drivers.txt");
            drivers = JsonConvert.DeserializeObject<List<Driver>>(json);
        }

        public void SaveAllDrivers()
            {
                File.WriteAllText("drivers.txt", JsonConvert.SerializeObject(drivers));
            }
    }
}