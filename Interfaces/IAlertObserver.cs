using CampusSafetyHub.Models;

namespace CampusSafetyHub.Interfaces;

public interface IAlertObserver
{
 
    void Update(AlertEvent alertEvent);
}
