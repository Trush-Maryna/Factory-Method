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
