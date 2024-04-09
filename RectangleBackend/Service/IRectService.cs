using RectangleBackend.DTO;

namespace RectangleBackend.Service
{
    public interface IRectService
    {
        string sayHello();

        Meassurement getMeassurements();

        bool updateMeasurements(Meassurement measurement);
    }
}
