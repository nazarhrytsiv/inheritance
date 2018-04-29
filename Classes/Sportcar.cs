using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4.Enums;
using Project4.Utility;

namespace Project4.Classes
{
    
        public class Sportcar : Auto
        {
            private bool nytro;

            public Sportcar(string _brand, string _model, Colors _color, Fuel_types _fuel, uint _max_speed, double _horsepowers, double _motor_capacity, bool _nytro)
                : base(_brand, _model, _color, _fuel, _max_speed, _horsepowers, _motor_capacity)
            {
                this.nytro = _nytro;
            }

            public override double find_breakdown_fuel(double average_speed)
            {
                double ccd_coefficient = nytro ? 2.7312 : 1;
                return base.find_breakdown_fuel(average_speed) * ccd_coefficient;
            }
        }
 }