using System;

namespace OOShapes
{
    public class Fan
    {
        // public FanType FanType { get; set; }
        // public FanSpeed Speed { get; set; }


        // Auto Implemented Property (the preferred way to encapsulate data)
        public bool IsOn { get; private set; }

        // Fully Implemented Property
        private FanType _fanType; // Atribute
        public FanType FanType
        {
            get { return _fanType; } // C# Style Getter
            set { _fanType = value; } // C# Style Setter
        }
        // Java style Getter
        public FanType GetFanType()
        {
            return _fanType;
        }
        // Java style Setter
        public void SetFanType(FanType type)
        {
            _fanType = type;
        }

        // Method
        public void TurnOn()
        {
            IsOn = true;
        }

        // Null Constructor
        // public Fan()
        // {
        //     // Default Value
        //     FanType = FanType.Wall;
        // }

        public Fan(FanType fanType)
        {
            FanType = fanType;
        }
    }

    public enum FanSpeed
    {
        Low,
        Med,
        High
    }

    public enum FanType
    {
        None = 0,
        Ceiling = 1,
        Wall = 2,
        Pole = 3
    }
}