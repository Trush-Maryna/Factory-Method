class CarCreator implements ICreator {
    public IMotorVehicle create() {
        return new Car();
    }
}
