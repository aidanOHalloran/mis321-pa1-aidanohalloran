namespace capTaxiBackEnd
{
    public class Driver
    {
        public string ID {get; set;}
        public string Name {get; set;}
        public string DateHired {get; set;}
        public string Rating {get; set;}

        public override string ToString(){
            return $"\t {ID} \t {Name} \t {DateHired} \t {Rating}";
        }
    }
}