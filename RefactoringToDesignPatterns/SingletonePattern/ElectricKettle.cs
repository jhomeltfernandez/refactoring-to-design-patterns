using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonePattern
{
    public sealed class ElectricKettle
    {
        private static ElectricKettle _instance = null;

        public static ElectricKettle GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new ElectricKettle();
                _instance.Message = "Starting";
                _instance.Status = KettleStatusEnum.Empty;
                return _instance;
            }
        }

        private ElectricKettle() { }

        public string Message { get; private set; }
        public KettleStatusEnum Status { get; private set; }

        public void Fill()
        {
            _instance.Status = KettleStatusEnum.InProgress;
            _instance.Message = "Filling...";
        }

        public void Drain()
        {
            _instance.Status = KettleStatusEnum.Empty;
            _instance.Message = "Draining...";
        }

        public void Boil()
        {
            _instance.Status = KettleStatusEnum.Boiled;
            _instance.Message = "Boiling...";
        }

        public void ExecuteWhatIsNecessary()
        {
            switch (this.Status)
            {
                case KettleStatusEnum.Empty:
                    _instance.Fill();
                    break;
                case KettleStatusEnum.InProgress:
                    _instance.Boil();
                    break;
                case KettleStatusEnum.Boiled:
                    break;
                default:
                    break;
            }
        }
    }
}
