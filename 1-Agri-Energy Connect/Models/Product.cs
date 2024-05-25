namespace _1_Agri_Energy_Connect.Models
{
    public class Product
    {
        public enum Categories
        {
            Livestock,
            Crops,
            Diary,
            Fish,
            Miscellaneus
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        public DateTime ProductionDatae { get; set; }
    }
}
