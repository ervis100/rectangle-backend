using RectangleBackend.DTO;
using System.Text.Json;

namespace RectangleBackend.Service
{
    public class RectService : IRectService
    {
        public RectService() { }

        public string sayHello()
        {
            return "Hello";
        }

        public Meassurement getMeassurements()
        {
            using (StreamReader reader = new StreamReader("..\\RectangleBackend\\RectMeassurements\\meassurements.json"))
            {
                string jsonFileData = reader.ReadToEnd();
                Meassurement rect = JsonSerializer.Deserialize<Meassurement>(jsonFileData);
                return rect;

            }
        }

        public bool updateMeasurements(Meassurement measurement)
        {
            try
            {
                File.WriteAllText("..\\RectangleBackend\\RectMeassurements\\meassurements.json", JsonSerializer.Serialize(measurement));
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
