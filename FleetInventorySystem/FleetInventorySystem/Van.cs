using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetInventorySystem
{
    class Van
    {
        private String vanName;
        private String registration;
        private String allocatedDriver;

        public string VanName { get => vanName; set => vanName = value; }
        public string Registration { get => registration; set => registration = value; }
        public string AllocatedDriver { get => allocatedDriver; set => allocatedDriver = value; }
    }
}
