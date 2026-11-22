namespace CampusSafetyHub.Interfaces;

public interface ISensor
{
    double ReadValue();

    string GetUnit();
}
