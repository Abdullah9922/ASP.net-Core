using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Expart
{
    public class Car
    {
        private int _topSpeed;
        private int _hp;

        public int TopSpeed
        {
            get { return _topSpeed; }
            set
            {
                if(value >= 0) { _topSpeed = value; }
            }
        }

        public int Hp
        {
            get { return _hp; }
            set
            {
                if (value >= 0 && value <= 1000 ) { _hp = value; }
            }
        }

        public Car() : this(100) { }

        public Car(int topspeed) : this(topspeed, 200) { }

        public Car(int topspeed, int hp)
        {
            TopSpeed = topspeed;
            Hp = hp;
        }


        public virtual void Specification() { }
        public virtual void Speciality() { }
    }
}
