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
            public override void getMileage()
            {
                IsSedan = false;
                seats = "4";
            }
        }

        public class HondaCity : Car
        {
            public override void getMileage()
            {
                IsSedan = true;
                seats = "4";
                //this.getIsSedan();
            }
        }

        public class InnovaCrysta : Car
        {
            public override void getMileage()
            {
                IsSedan = false;
                seats = "6";
                //this.getIsSedan();
            }
        }

    }
}
