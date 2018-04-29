using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4.Enums;

namespace Project4.Utility
{
    class Utility
    {
        public static double average_brackdown = 25000;
        public static int meters_in_km = 1000;
        public static int seconds = 3600;
        public static double ecr_for_petrol = 0.3;
        public static double ecr_for_gas = 0.6;


        public static double check_ecr(Fuel_types fuelType)
        {
            switch (fuelType)
            {
                case Fuel_types.gas:
                    {
                        return ecr_for_gas;
                    }
                case Fuel_types.petrol:
                    {
                        return ecr_for_petrol;
                    }
            }

            return 0;
        }

        public static double convert_to_meters_in_seconds(double km_in_hour)
        {
            return (km_in_hour * meters_in_km) / seconds;
        }

        public static double kilpmeters_to_meters(double kilometers)
        {
            return kilometers * meters_in_km;
        }
    }
}

