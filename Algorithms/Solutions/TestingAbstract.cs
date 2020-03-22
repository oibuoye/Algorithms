using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class TestingAbstract
    {
        public abstract class Car
        {
            public string seats { get; set; }
            public bool IsSedan { get; set; }

            public abstract void getMileage();

            public bool getIsSedan()
            {
                return IsSedan;
            }

            public string getSeats()
            {
                return seats;
            }
        }

        public class WagonR : Car
        {
            public WagonR()
            {
                IsSedan = false;
                seats = "4";
            }
            public override void getMileage()
            {
                //Milliage impl
            }
        }

        public class HondaCity : Car
        {
            public HondaCity()
            {
                IsSedan = true;
                seats = "4";
            }
            public override void getMileage()
            {
                //this.getIsSedan();
            }
        }

        public class InnovaCrysta : Car
        {
            public InnovaCrysta()
            {
                IsSedan = false;
                seats = "6";
            }
            public override void getMileage()
            {
                //this.getIsSedan();
            }
        }

    }
}
