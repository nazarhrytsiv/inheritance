using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4.Enums;
using Project4.Utility;

namespace Project4.Classes
{
    public abstract class Auto
    {
        public string brand { get; private set; }
        public string model { get; private set; }
        public Colors color { get; private set; }
        public Guid vin { get; private set; }
        public Fuel_types fuel { get; private set; }
        public uint max_speed { get; private set; }
        public double horsepower { get; private set; }
        public double motor_capacity { get; private set; }

        public Auto( string _brand, string _model, Colors _color, Fuel_types _fuel, uint _max_speed, double _horsepowers, double _motor_capacity)
        {
            this.brand = _brand;
            this.model = _model;
            this.color = _color;
            this.vin = Guid.NewGuid();
            this.fuel = _fuel;
            this.max_speed = _max_speed;
            this.horsepower = _horsepowers;
            this.motor_capacity = _motor_capacity;
        }

        public virtual double find_breakdown_fuel(double average_speed)
        {
            
            var distance = Utility.Utility.kilpmeters_to_meters(1);
            var horsepower = this.horsepower;
            var speed = Utility.Utility.convert_to_meters_in_seconds(average_speed);
            var ecr = Utility.Utility.check_ecr(fuel);
            var result = horsepower * distance / (speed * ecr * Utility.Utility.average_brackdown);
            return result;
        }

        public override string ToString()
        {
            return string.Format(
                $"brand : {brand}\n" +
                $"model : {model}\n" +
                $"color : {Enum.GetName(typeof(Colors), color)}\n" +
                $"fuel : {Enum.GetName(typeof(Fuel_types), fuel)}\n" +
                $"max speed : {max_speed}\n" +
                $"horse powers : {horsepower}\n" +
                $"motor capactiy : {motor_capacity}\n");
        }
    }
}


