using System.Windows.Forms;

namespace Factory_Method
{
    public partial class Client : Form
    {
        private ICreator creator;
        public static Client Instance;

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

        private async void listObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listObject.SelectedItem.ToString() == "Motorcycle")
            {
                creator = new MotorcycleCreator();
            }
            else if (listObject.SelectedItem.ToString() == "Car")
            {
                creator = new CarCreator();
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
