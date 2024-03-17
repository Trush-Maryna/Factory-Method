﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class CarCreator : ICreator
    {
        public IMotorVehicle Create()
        {
            return new Car();
        }
    }
}
