using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4.Enums;
using Project4.Utility;
using Project4.Classes;

namespace Project4.Classes
{
    public class Car : Auto
    {
        private Motor_brand motor_brand;

        public Car(
            string _brand,
            string _model,
            Colors _color,
            Fuel_types _fuel,
            uint _max_speed,
            double _horsepowers,
            double _motor_capacity,
            Motor_brand _motor_brand)
            : base(_brand, _model, _color, _fuel, _max_speed, _horsepowers, _motor_capacity)
        {
            this.motor_brand = _motor_brand;
        }

        public override double find_breakdown_fuel(double average_speed)
        {
            return base.find_breakdown_fuel(average_speed) * Motor_system.get_coefficiente(motor_brand);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($"motor : {Enum.GetName(typeof(Motor_brand), this.motor_brand)}\n");
        }
    }
}
