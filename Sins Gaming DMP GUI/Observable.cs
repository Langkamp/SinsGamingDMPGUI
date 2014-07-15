using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sins_Gaming_DMP_GUI
{
    interface Observable
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObserver(string line);
    }
}
