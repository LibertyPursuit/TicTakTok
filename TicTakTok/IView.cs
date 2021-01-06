using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTakTok
{
    interface IView
    {
        //Ourside Interaction
        //View Eventlistner Handling
        //Talks to Logik Controler
        //Gives Input to the Controler for Distribution
        void ButtonClick(string type);
    }
}
