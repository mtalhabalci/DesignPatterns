using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Contcretes
{
    public class TurnOffLightCommand : ICommand
    {
        private readonly LightReceiver _receiver;
        public TurnOffLightCommand(LightReceiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.Off();
        }
    }
}
