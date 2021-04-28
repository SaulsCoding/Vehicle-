using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car // as a blue print for any object
    {
        private int _year; //Private member variables - refers to as Fields - Only accessible in the Car class1
        private string _make;
        private int _speed;
        private int _tirePressure;

        public Car() // Constructor - First piece of code that your class calls when it is constructing the instance of the class - starting point of your class
        {
            this._year = 1994;
            this._make = "Ford";
            this._speed = 0;
        }

        public Car(int year, string make, int speed) // Arguments/Parameters - parameters are variables that are coming into the methode
        {
            this._year = year; //current object is the instance of this class
            this._make = make;
            this._speed = speed;//c# convention - best practice - under score naming convention
        }

        public string Make
        {
            get
            {
                return _make;
            }

            set
            {
                _make = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public void DriveFaster(int increment)
        {
            _speed += increment;

        }
        public void DriveSlower(int increment)
        {
            _speed -= increment;
        }


        public string GetMake()
        {
            return _make;
        }

        public void SetMake(string make)
        {
            _make = make;
        }

        public int GetTirePressure()
        {
            return _tirePressure;
        }
    }
}
