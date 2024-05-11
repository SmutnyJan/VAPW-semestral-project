using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static smutny_carwash.CarGoofer;

namespace smutny_carwash
{
    public class CarGoofer : IDisposable
    {
        public enum DoorState
        {
            Open,
            Close
        }
        public enum DoorLocation
        {
            Front,
            Back
        }

        public enum CarLocation
        {
            Inside,
            Outside
        }

        private Thread _thread;
        private int _frontDoorHeight;

        private DoorState _currentDoorState;
        private DoorLocation _currentDoorLocation;
        private CarLocation _currentCarLocation;

        private int _frontDoorMaxHeight;
        private int _backDoorMaxHeight;
        private int _carInsideXLocation;
        private int _carOutsideXLocation;
        private int _goofedCarWidth;
        public int FrontDoorHeight
        {
            get { return _frontDoorHeight; }
            private set
            {
                var changed = value != _frontDoorHeight;
                _frontDoorHeight = value;
                if (changed) OnFrontDoorHeightChange?.Invoke(this, _frontDoorHeight);
            }
        }

        private int _backDoorHeight;
        public int BackDoorHeight
        {
            get { return _backDoorHeight; }
            private set
            {
                var changed = value != _backDoorHeight;
                _backDoorHeight = value;
                if (changed) OnBackDoorHeightChange?.Invoke(this, _backDoorHeight);
            }
        }

        private int _carXLocation;
        public int CarXLocation
        {
            get { return _carXLocation; }
            private set
            {
                var changed = value != _carXLocation;
                _carXLocation = value;
                if (changed) OnCarLocationChange?.Invoke(this, _carXLocation);
            }
        }

        private int _carWidth;
        public int CarWidth
        {
            get { return _carWidth; }
            private set
            {
                var changed = value != _carWidth;
                _carWidth = value;
                if (changed) OnCarWidthChange?.Invoke(this, _carWidth);
            }
        }


        public const int OPEN_GATE_TOLERATION = 10;
        public delegate void ChangedDoorStateHandler(object sender, int doorHeight);
        public delegate void ChangedCarLocationHandler(object sender, int carXLocation);
        public delegate void ChangedCarWidthHandler(object sender, int carWidth);
        public event ChangedDoorStateHandler OnFrontDoorHeightChange;
        public event ChangedDoorStateHandler OnBackDoorHeightChange;
        public event ChangedCarLocationHandler OnCarLocationChange;
        public event ChangedCarWidthHandler OnCarWidthChange;



        public CarGoofer(int frontDoorHeight, int backDoorHeight, int carInitialXLocation, int carInsideXLocation, int carOutsideXLocation, int carWidth, int goofedCarWidth)
        {
            FrontDoorHeight = frontDoorHeight;
            BackDoorHeight = backDoorHeight;
            _frontDoorMaxHeight = frontDoorHeight;
            _backDoorMaxHeight = backDoorHeight;
            _carInsideXLocation = carInsideXLocation;
            _carOutsideXLocation = carOutsideXLocation;
            _carXLocation = carInitialXLocation;
            _carWidth = carWidth;
            _goofedCarWidth = goofedCarWidth;
        }

        private static void _doorProcedure(object obj)
        {
            var carGoofer = (CarGoofer)obj;
            int stepChange = carGoofer._currentDoorState == DoorState.Open ? -1 : 1;

            if (carGoofer._currentDoorLocation == DoorLocation.Front)
            {
                for (int i = 0; i < carGoofer._frontDoorMaxHeight - OPEN_GATE_TOLERATION; i++)
                {
                    carGoofer.FrontDoorHeight += stepChange;
                    Thread.Sleep(1);
                }
            }
            else if (carGoofer._currentDoorLocation == DoorLocation.Back)
            {
                for (int i = 0; i < carGoofer._backDoorMaxHeight - OPEN_GATE_TOLERATION; i++)
                {
                    carGoofer.BackDoorHeight += stepChange;
                    Thread.Sleep(1);
                }
            }
        }

        private static void _moveCarProcedure(object obj)
        {
            var carGoofer = (CarGoofer)obj;

            if (carGoofer._currentCarLocation == CarLocation.Inside)
            {
                for (int i = carGoofer._carXLocation; i < carGoofer._carInsideXLocation; i++)
                {
                    carGoofer.CarXLocation += 1;
                    Thread.Sleep(1);
                }
            }
            else if (carGoofer._currentCarLocation == CarLocation.Outside)
            {
                for (int i = carGoofer._carXLocation; i < carGoofer._carOutsideXLocation; i++)
                {
                    carGoofer.CarXLocation += 1;
                    Thread.Sleep(1);
                }
            }

        }

        private static void _goofCarProcedure(object obj)
        {
            var carGoofer = (CarGoofer)obj;
            int iterations = carGoofer._goofedCarWidth - carGoofer._carWidth;
            for (int i = 0; i < iterations; i++)
            {
                carGoofer.CarWidth += 1;
                Thread.Sleep(1);
            }

        }

        public void ChangeDoorState(DoorState doorState, DoorLocation doorLocation)
        {
            _currentDoorState = doorState;
            _currentDoorLocation = doorLocation;
            Task task = Task.Run(() => _doorProcedure(this));
            if (doorState == DoorState.Close && doorLocation == DoorLocation.Front) //goof car
            {
                task.ContinueWith(t => _goofCarProcedure(this));
            }
            else if(doorState == DoorState.Open && doorLocation == DoorLocation.Back)
            {
                task.ContinueWith(t => ChangeCarLocation(CarLocation.Outside));
            }

        }

        public void ChangeCarLocation(CarLocation carLocation)
        {
            _currentCarLocation = carLocation;
            Task task = Task.Run(() => _moveCarProcedure(this));
        }

        public void Dispose()
        {
            try
            {
                _thread.Interrupt();
                _thread.Join();
            }
            catch (Exception e)
            {

            }
        }
    }
}
