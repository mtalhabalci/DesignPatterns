using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Contcretes
{
    public class LightReceiver
    {
        public bool IsActive { get; set; }

        public void On()
        {
            this.IsActive = true;
        }
        public void Off()
        {
            this.IsActive = false;
        }
    }
}
