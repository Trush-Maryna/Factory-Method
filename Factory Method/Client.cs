namespace Factory_Method
{
    public partial class Client : Form
    {
        private ICreator creator;
        public static Client? Instance;

        public Client()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            listObject.Items.Add("Motorcycle");
            listObject.Items.Add("Car");
        }

        private void listObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listObject.SelectedItem.ToString())
            {
                case "Motorcycle":
                    creator = new MotorcycleCreator();
                    break;
                case "Car":
                    creator = new CarCreator();
                    break;
                default:
                    break;
            }
            string typeName = listObject.SelectedItem.ToString();
            IMotorVehicle vehicle = creator.Create();
            vehicle.Build(typeName);
        }

        public void ShowMessage(string message)
        {
            textResult.Text = message;
        }

        public void ShowMessageWithImage(string message, string imageName)
        {
            textResult.Text = message;
            pictureObject.Image = Image.FromFile(imageName);
        }

        public void ClearImage()
        {
            pictureObject.Image = null;
        }
    }
}
