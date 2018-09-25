using System;
using System.Collections.Generic;

namespace ExamPlane
{    class Plane
    {
        private int _heigth;
        public int Heigth
        {
            get { return _heigth; }
            private set
            {
                _heigth = value;
                if(_heigth < 0 && OnGround)
                {
                    _heigth = 0;
                }
                OnStateChanged();
            }
        }
        private int _speed;
        public int Speed
        {
            get { return _speed; }
            private set { _speed = value; if (_speed < 0) { _speed = 0; } OnStateChanged(); }
        }        
        public List<Dispatcher> Dispatchers { get; private set; }
        public Plane()
        {
            Dispatchers = new List<Dispatcher>();
            OnGround = true;//не взлетал
        }
        public void FlightHigher(bool more)
        {
            Heigth += more?500:250;            
        }        
        public void FlightLower(bool low)
        {            
            Heigth -= low?500:250;           
        }
        public void Acceleration(bool more)
        {
            Speed += more?150:50;           
        }
        public void Braking(bool low)
        {
            Speed -= low?150:50;           
        }
        public string GetCurrentState()
        {
            return string.Format("Скорость самолета {0} км/ч, высота самолета {1} м", Speed, Heigth);
        }
        public bool OnGround { get; set; }
     
        public event EventHandler StateChanged;
        private void OnStateChanged() // изменились показания самолета, передает объект Plane
        {
            if (OnGround && Heigth > 0)
            {
                OnGround = false; // взлетел ==false
            }
            if (StateChanged != null)
            {                
                StateChanged(this, EventArgs.Empty);
            }
        }        
    }
}