using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    public class Car
    {
        public float MaxGas = 13;
        public float GasLevel { get; set; }

        public float AddGas(float gasAdded)
        {
            GasLevel = gasAdded + GasLevel;
            return GasLevel;
        }
        public float FillUp(float gasAmount)
        {
            float gasAdded = MaxGas - gasAmount;
            return gasAdded;
        }
        public Car(float GasLevel)
        {
            float gasLevel = new Random().Next(0, 13);
            GasLevel = gasLevel;
        }

    }
}
