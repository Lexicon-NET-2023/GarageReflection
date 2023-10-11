using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageDI.Entities
{
    internal class Rocket : Vehicle
    {
        [Include]
        [Beautify("Some value")]
        public int SomeValue { get; set; }
    }
}
