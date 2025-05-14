using System;
using System.Collections.Generic;
using System.Linq;
using CeresBusManagement;

namespace CeresBusManagement
{
    public class Employee
    {
        public string Name { get; set; }
        public string Role { get; set; } 
        public Employee(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public override string ToString()
        {
            return $"{Role}: {Name}";
        }
    }
    public class Bus
    {
        public string BusID { get; set; }
        public string Route { get; set; }
        public Employee Driver { get; set; }
        public Employee Conductor { get; set; }
        public string DepartureTime { get; set; }

        public Bus(string busID, string route, Employee driver, Employee conductor, string departureTime)
        {
            BusID = busID;
            Route = route;
            Driver = driver;
            Conductor = conductor;
            DepartureTime = departureTime;
        }

        public string GetInfo()
        {
            return $"Bus ID: {BusID}\nRoute: {Route}\nDriver: {Driver.Name}\nConductor: {Conductor.Name}";
        }
    }
    public class BusManagement
    {
        private List<Bus> buses;
        private Dictionary<string, decimal> earningsData;

        public BusManagement()
        {
            buses = new List<Bus>();
            earningsData = new Dictionary<string, decimal>();
        }
      
        // === BUS MANAGEMENT ===

        public void AddBus(Bus bus)
        {
            buses.Add(bus);
        }

        public bool RemoveBus(string busID)
        {
            var bus = buses.FirstOrDefault(b => b.BusID == busID);
            if (bus != null)
            {
                buses.Remove(bus);
                return true;
            }
            return false;
        }

        public bool UpdateBus(string busID, Bus updated)
        {
            int index = buses.FindIndex(b => b.BusID == busID);
            if (index >= 0)
            {
                buses[index] = updated;
                return true;
            }
            return false;
        }

        public List<Bus> GetAllBuses() => buses;

        public List<Bus> SearchByRoute(string route)
        {
            return buses.Where(b => b.Route.Contains(route, StringComparison.OrdinalIgnoreCase)).ToList();
        }



        // === EARNINGS MANAGEMENT ===
        public void AddEarning(string busID, decimal amount)
        {
            if (earningsData.ContainsKey(busID))
                earningsData[busID] += amount;
            else
                earningsData[busID] = amount;
        }

        public Dictionary<string, decimal> GetBusEarnings() => earningsData;

        public decimal GetTotalEarnings() => earningsData.Values.Sum();
    }

}
