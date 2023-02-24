using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVTProgram
{
    public class CameraModel : NotifyBase
    {
        private string _address;
        private string _protocol;
        private string _model;
        private string _firmware;
        private string _status;

        public string Address  { get => _address;  set => SetProperty(ref _address  , value); }
        public string Protocol { get => _protocol; set => SetProperty(ref _protocol , value); }
        public string Model    { get => _model;    set => SetProperty(ref _model    , value); }
        public string FirmWare { get => _firmware; set => SetProperty(ref _firmware , value); }
        public string Status   { get => _status;   set => SetProperty(ref _status   , value); }

        public CameraModel(string address, string protocol, string model, string firmware, string status)
        {
            Address  = address;
            Protocol = protocol;
            Model    = model;
            FirmWare = firmware;
            Status   = status;
        }
    }
}
