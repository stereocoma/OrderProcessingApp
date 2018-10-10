using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Models
{
    public enum VehicleType
    {
        CAR,
        VAN,
        BUS,
        NONE
    }
}

namespace OrderProcessingApp.Models
{
    static class VehicleTypeMethods
    {
        private const int CAR_PASSENGERS_CAPACITY = 4;
        private const int VAN_PASSENGERS_CAPACITY = 15;
        private const int BUS_PASSENGERS_CAPACITY = 40;
        private const int CAR_CARGO_CAPACITY = 100;
        private const int VAN_CARGO_CAPACITY = int.MaxValue;
        private const int BUS_CARGO_CAPACITY = int.MaxValue;

        public static int GetPassengersCapacity(this VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.CAR:
                    return CAR_PASSENGERS_CAPACITY;
                case VehicleType.VAN:
                    return VAN_PASSENGERS_CAPACITY;
                case VehicleType.BUS:
                    return BUS_PASSENGERS_CAPACITY;
                default:
                    return CAR_PASSENGERS_CAPACITY;
            }
        }

        public static int GetCargoWeightCapacity(this VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.CAR:
                    return CAR_CARGO_CAPACITY;
                case VehicleType.VAN:
                    return VAN_CARGO_CAPACITY;
                case VehicleType.BUS:
                    return BUS_CARGO_CAPACITY;
                default:
                    return CAR_CARGO_CAPACITY;
            }
        }
    }
}
