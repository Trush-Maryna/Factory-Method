import javax.swing.*;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;

public class Client extends JFrame {
    private ICreator creator;
    public static Client Instance;

    private JList<String> listObject;
    private JTextField textResult;
    private JLabel pictureObject;

    public Client() {
        initComponents();
        Instance = this;
    }

    private void initComponents() {
        listObject = new JList<>(new String[]{"Motorcycle", "Car"});
        listObject.setBounds(10, 10, 350, 40);
        add(listObject);

        textResult = new JTextField();
        textResult.setBounds(10, 50, 350, 30);
        add(textResult);

        pictureObject = new JLabel();
        pictureObject.setBounds(10, 90, 350, 150);
        add(pictureObject);

        listObject.addListSelectionListener(new ListSelectionListener() {
            public void valueChanged(ListSelectionEvent event) {
                switch (listObject.getSelectedValue()) {
                    case "Motorcycle":
                        creator = new MotorcycleCreator();
                        break;
                    case "Car":
                        creator = new CarCreator();
                        break;
                    default:
                        break;
                }
                String typeName = listObject.getSelectedValue();
                IMotorVehicle vehicle = creator.create();
                vehicle.build(typeName);
            }
        });

        setTitle("Factory Method Pattern");
        setSize(400, 350);
        setLayout(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
    }

    public void showMessage(String message) {
        textResult.setText(message);
    }

    public void showMessageWithImage(String message, String imageName) {
        textResult.setText(message);
        ImageIcon icon = createImageIcon(imageName);
        pictureObject.setIcon(icon);
    }

    private ImageIcon createImageIcon(String imageName) {
        java.net.URL imageURL = Client.class.getResource("/resources/" + imageName);
        if (imageURL != null) {
            return new ImageIcon(imageURL);
        } else {
            System.err.println("Couldn't find file: " + imageName);
            return null;
        }
    }

    public void clearImage() {
        pictureObject.setIcon(null);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            Client client = new Client();
            client.setVisible(true);
        });
    }
}