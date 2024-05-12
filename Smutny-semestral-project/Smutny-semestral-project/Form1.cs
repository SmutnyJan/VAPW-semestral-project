using smutny_carwash;
using System.Xml.Linq;
using static smutny_carwash.CarGoofer;

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
                    this.Invoke(new Action(() =>
                    {
                        InStreetLightRed.Checked = false;
                        InStreetLightGreen.Checked = true;
                        CarEnteringButton.Enabled = true;
                    }));
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        InStreetLightRed.Checked = true;
                        InStreetLightGreen.Checked = false;
                        CarEnteringButton.Enabled = false;
                    }));
                }
            }
        }

        private bool _carInside = false;
        private bool _carLeaving = false;
        public CarGoofer CarGoofer { get; set; }

        public int FrontDoorMaxHeight { get; set; }
        public int BackDoorMaxHeight { get; set; }
        public int CarInsideXLocation { get; set; }
        public int CarOutsideXLocation { get; set; }
        public int GoofedCarWidth { get; set; }




        public Form1()
        {
            InitializeComponent();
            FrontDoorMaxHeight = FrontDoor.Size.Height;
            BackDoorMaxHeight = BackDoor.Size.Height;
            CarInsideXLocation = 357;
            CarOutsideXLocation = 800;
            GoofedCarWidth = CarPictureBox.Width + 100;
            CarGoofer = new CarGoofer(FrontDoorMaxHeight, BackDoorMaxHeight, CarPictureBox.Location.X, CarInsideXLocation, CarOutsideXLocation, CarPictureBox.Width, GoofedCarWidth);
            
            var form = new VisualUpdateForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                _setVisualUpdate(form.IsEventBased);
            }
            else
            {
                _setVisualUpdate(true);
            }


        }

        private void CarGoofer_OnCarWidthChange(object sender, int carWidth)
        {
            this.Invoke(new Action(() =>
            {
                CarPictureBox.Size = new Size(carWidth, CarPictureBox.Size.Height);
            }));

            if (carWidth == GoofedCarWidth)
            {
                this.Invoke(new Action(() =>
                {
                    CarLeavingButton.Enabled = true;
                }));
            }

        }

        private void CarGoofer_OnCarLocationChange(object sender, int carXLocation)
        {
            this.Invoke(new Action(() =>
            {
                CarPictureBox.Location = new Point(carXLocation, CarPictureBox.Location.Y);
            }));

            if (carXLocation == CarInsideXLocation)
            {
                this.Invoke(new Action(() =>
                {
                    GoofCarButton.Enabled = true;
                }));
            }



        }

        private void Car_OnFrontDoorHeightChange(object sender, int doorHeight)
        {
            this.Invoke(new Action(() =>
            {
                FrontDoor.Size = new Size(FrontDoor.Size.Width, doorHeight);
            }));
            if (doorHeight == CarGoofer.OPEN_GATE_TOLERATION)
            {
                IsCarReady = true;
            }
            else if (doorHeight == FrontDoorMaxHeight)
            {
                IsCarReady = false;
            }
        }

        private void Car_OnBackDoorHeightChange(object sender, int doorHeight)
        {
            this.Invoke(new Action(() =>
            {
                BackDoor.Size = new Size(BackDoor.Size.Width, doorHeight);
                if (CarGoofer.BackDoorHeight == CarGoofer.OPEN_GATE_TOLERATION)
                {
                    OutStreetLightGreen.Checked = true;
                    OutStreetLightRed.Checked = false;
                }
            }));
        }

        private void CarLeavingButton_Click(object sender, EventArgs e)
        {
            CarGoofer.ChangeDoorState(CarGoofer.DoorState.Open, CarGoofer.DoorLocation.Back);
            CarLeavingButton.Enabled = false;
        }

        private void CarEnteringButton_Click(object sender, EventArgs e)
        {
            CarEnteringButton.Enabled = false;
            CarGoofer.ChangeCarLocation(CarGoofer.CarLocation.Inside);

        }

        private void CarReadyButton_Click(object sender, EventArgs e)
        {
            CarReadyButton.Enabled = false;
            CarGoofer.ChangeDoorState(CarGoofer.DoorState.Open, CarGoofer.DoorLocation.Front);
        }

        private void GoofCarButton_Click(object sender, EventArgs e)
        {
            CarGoofer.ChangeDoorState(CarGoofer.DoorState.Close, CarGoofer.DoorLocation.Front);
            GoofCarButton.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            FrontDoor.Size = new Size(FrontDoor.Size.Width, CarGoofer.FrontDoorHeight);
            if (CarGoofer.FrontDoorHeight == CarGoofer.OPEN_GATE_TOLERATION && !IsCarReady)
            {
                IsCarReady = true;
            }
            else if (CarGoofer.FrontDoorHeight == FrontDoorMaxHeight)
            {
                IsCarReady = false;
            }

            BackDoor.Size = new Size(BackDoor.Size.Width, CarGoofer.BackDoorHeight);
            if (CarGoofer.BackDoorHeight == CarGoofer.OPEN_GATE_TOLERATION)
            {
                OutStreetLightGreen.Checked = true;
                OutStreetLightRed.Checked = false;
            }



            CarPictureBox.Location = new Point(CarGoofer.CarXLocation, CarPictureBox.Location.Y);
            if (CarGoofer.CarXLocation == CarInsideXLocation && !GoofCarButton.Enabled && !_carInside)
            {
                _carInside = true;
                GoofCarButton.Enabled = true;
            }


            CarPictureBox.Size = new Size(CarGoofer.CarWidth, CarPictureBox.Size.Height);
            if (CarGoofer.CarWidth == GoofedCarWidth && !CarLeavingButton.Enabled && !_carLeaving)
            {
                CarLeavingButton.Enabled = true;
                _carLeaving = true;
            }

        }

        private void _setVisualUpdate(bool isEventBased)
        {
            if (!isEventBased)
            {
                Timer.Enabled = true;
            }
            else
            {
                CarGoofer.OnFrontDoorHeightChange += Car_OnFrontDoorHeightChange;
                CarGoofer.OnBackDoorHeightChange += Car_OnBackDoorHeightChange;
                CarGoofer.OnCarLocationChange += CarGoofer_OnCarLocationChange;
                CarGoofer.OnCarWidthChange += CarGoofer_OnCarWidthChange;
            }
        }
    }
}
