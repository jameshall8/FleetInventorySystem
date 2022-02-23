using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetInventorySystem
{
    class VanPart : Part
    {
        private String registrationNumber;

        public string RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }
    }
}
