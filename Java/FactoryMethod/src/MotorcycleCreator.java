class MotorcycleCreator implements ICreator {
    public IMotorVehicle create() {
        return new Motorcycle();
    }
}