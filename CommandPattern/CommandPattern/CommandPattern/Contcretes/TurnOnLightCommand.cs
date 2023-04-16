using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Contcretes
{
    public class TurnOnLightCommand : ICommand
    {
        private readonly LightReceiver _light;
        public TurnOnLightCommand(LightReceiver light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.On();
        }
    }
}
