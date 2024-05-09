using smutny_carwash;
using System.Xml.Linq;

namespace Smutny_semestral_project
{
    public partial class Form1 : Form
    {
        private bool _isCarReady;
        public bool IsCarReady
        {
            get { return _isCarReady; }
            set
            {
                _isCarReady = value;
                if (value)
                {
                    StreetLightRed.Checked = false;
                    StreetLightGreen.Checked = true;
                    CarEnteringButton.Enabled = true;
                }
            }
        }



        public Form1()
        {
            CarGoofer car = new CarGoofer();
            car.OnFrontDoorStateChange += Car_OnFrontDoorStateChange;
            InitializeComponent();
        }

        private void Car_OnFrontDoorStateChange(object sender, int doorHeight)
        {
            throw new NotImplementedException();
        }

        private void StreetLightRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CarLeavingButton_Click(object sender, EventArgs e)
        {
            //FrontDoor.Size = new Size(FrontDoor.Size.Width, 50);
        }

        private void CarEnteringButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CarReadyButton_Click(object sender, EventArgs e)
        {
            IsCarReady = true;
            CarReadyButton.Enabled = false;
        }
    }
}
