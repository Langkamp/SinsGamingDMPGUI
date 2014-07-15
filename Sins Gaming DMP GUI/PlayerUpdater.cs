using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sins_Gaming_DMP_GUI
{
    class PlayerUpdater : Observer
    {
        private Form1 form;

        public PlayerUpdater (Form1 f)
        {
            form = f;
        }

        public void update(string line)
        {
            parseUpdate(line);
        }

        private void parseUpdate(string line)
        {
            if(line.Contains("sent connection end message"))
            {
                string subLine = line.Substring(20);

                subLine = subLine.Substring(0, subLine.IndexOf(' '));

                removePlayer(subLine);
            }
            else if (line.Contains("Connection error for client"))
            {
                string subLine = line.Substring(47);

                subLine = subLine.Substring(0, subLine.IndexOf(','));

                removePlayer(subLine);
            }
            else if (line.Contains("The operation is not allowed on non-connected sockets"))
            {
                string subLine = line.Substring(26);

                subLine = subLine.Substring(0, subLine.IndexOf(' '));

                removePlayer(subLine);
            }
            else if(line.Contains("handshook successfully!"))
            {
                string subLine = line.Substring(26);

                subLine = subLine.Substring(0,subLine.IndexOf(' '));

                addPlayer(subLine);
            }
        }

        private void addPlayer(string Name)
        {
            form.addPlayerToList(Name);
        }

        private void removePlayer(string Name)
        {
            form.removePlayerToList(Name);
        }

        private bool isPlayerOnList(string name)
        {
            return false;
        }
    }
}
