class Car implements IMotorVehicle {
    public void build(String typeName) {
        Client.Instance.showMessage(typeName + " is being created...");
        try {
            Thread.sleep(2000);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        Client.Instance.showMessageWithImage("Created " + typeName, "car.jpg");
    }
}