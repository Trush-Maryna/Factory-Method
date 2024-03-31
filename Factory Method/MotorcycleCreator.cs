namespace Factory_Method
{
    internal class MotorcycleCreator : ICreator
    {
        public IMotorVehicle Create()
        {
            return new Motorcycle();
        }
    }
}
