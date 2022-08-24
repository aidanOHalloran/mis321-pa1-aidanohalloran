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
            string json = File.ReadAllText("input.txt");
            drivers = JsonConvert.DeserializeObject<List<Driver>>(json);
        }

        public void SaveAllDrivers()
            {
                File.WriteAllText("input.txt", JsonConvert.SerializeObject(drivers));
            }
    }
}