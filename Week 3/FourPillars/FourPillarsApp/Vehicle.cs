using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillarsApp
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;

        public int Position { get; private set; }
        public int NumPassengeres 
        {
            get
            {
                return _numPassengers;
            }
            set
            {
                if (value < 0 || value > _capacity)
                {
                    //am i doing this right???
                    throw new DataException();
                }
                else
                {
                    _numPassengers = value;
                }
            }
         }


        private int _age;
        public int Speed { get; init; }


        public Vehicle(){ this.Speed = 10; }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;

        }



        public string Move()
        {

            return "";
        }
        public string Move(int times)
        {
            Position += times * Speed;
            return $"Moving along {times} times";
        }
       

    }
}
