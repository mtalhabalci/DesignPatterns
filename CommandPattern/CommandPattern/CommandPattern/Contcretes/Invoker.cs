using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Contcretes
{
    public class Invoker
    {
        ICommand ilkButton;
        ICommand ikinciButton;
        public Invoker(ICommand ilkButtonunGorevi, ICommand ikinciButtonunGorevi)
        {
            ilkButton = ilkButtonunGorevi;
            ikinciButton = ikinciButtonunGorevi;
        }

        public void ClickIlkButton()
        {
            ilkButton.Execute();
        }

        public void CLickIkinciButton()
        {
            ikinciButton.Execute();
        }
    }
}
