using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class Car : IMotorVehicle
    {
        public void Build(string typeName)
        {
            Client.Instance.Invoke((MethodInvoker)(() => Client.Instance.ClearImage()));
            Client.Instance.Invoke((MethodInvoker)(() => Client.Instance.ShowMessage(typeName + " створюється...")));
            Task.Delay(2000).Wait();
            Client.Instance.Invoke((MethodInvoker)(() => Client.Instance.ShowMessageWithImage("Створено " + typeName, "car.jpg")));
        }
    }
}
