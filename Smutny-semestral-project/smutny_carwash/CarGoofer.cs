using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace smutny_carwash
{
    public class CarGoofer : IDisposable
    {
        private Thread _entryDoorThread = new Thread(new ParameterizedThreadStart(DoorProcedure));
        private int _frontDoorHeight;
        public int FrontDoorHeight
        {
            get { return _frontDoorHeight; }
            private set
            {
                var changed = value != _frontDoorHeight;
                _frontDoorHeight = value;
                if (changed) OnFrontDoorStateChange?.Invoke(this, _frontDoorHeight);
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
                if (changed) OnBackDoorStateChange?.Invoke(this, _backDoorHeight);
            }
        }
        public delegate void ChangedDoorStateHandler(object sender, int doorHeight);
        public event ChangedDoorStateHandler OnFrontDoorStateChange;
        public event ChangedDoorStateHandler OnBackDoorStateChange;

        public CarGoofer()
        {
            FrontDoorHeight = 200;
            BackDoorHeight = 200;
        }

        private static void DoorProcedure(object obj)
        {
            var carGoofer = (CarGoofer)obj;
            
            
        }

        public void Dispose()
        {
            try
            {
                _entryDoorThread.Interrupt();
                _entryDoorThread.Join();
            }
            catch (Exception e)
            {

            }
        }
    }
}
