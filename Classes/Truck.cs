using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4.Enums;
using Project4.Utility;

namespace Project4.Classes
{
    class Truck:Auto
    {
        private Transmission_brand transmission_brand;

        public Truck(
            string _brand,
            string _model,
            Colors _color,
            Fuel_types _fuel,
            uint _max_speed,
            double _horsepowers,
            double _motor_capacity,
            Transmission_brand transmission_brand)
            : base(_brand, _model, _color, _fuel, _max_speed, _horsepowers, _motor_capacity)
        {
            this.transmission_brand = transmission_brand;
        }

        public override double find_breakdown_fuel(double average_speed)
        {
            return base.find_breakdown_fuel(average_speed) * Transmission_system.get_coefficient(transmission_brand);
        }
    }
}
