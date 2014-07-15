using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Sins_Gaming_DMP_GUI
{
    public partial class Form1 : Form,Observer
    {
        public Form1()
        {
            InitializeComponent();
        }


        /********************************************Displays********************************************/
        public void writeToConsoleDisplayBox (string line)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(writeToConsoleDisplayBox), new object[] { line });
                return;
            }
            consoleDisplayBox.AppendText(line + "\n");
            consoleDisplayBox.SelectionStart = consoleDisplayBox.TextLength;
            consoleDisplayBox.ScrollToCaret();
        }

        public void addPlayerToList(string name)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(addPlayerToList), new object[] { name });
                return;
            }
            PlayerList.Items.Add(name);
        }

        public void removePlayerToList(string name)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(removePlayerToList), new object[] { name });
                return;
            }
            PlayerList.Items.Remove(name);
        }

        public void removeAllPlayers()
        {
            PlayerList.Items.Clear();
        }

        public void getPlayerList()
        {

        }

        /********************************************Buttons********************************************/
        private void stop_Click(object Sender, EventArgs e)
        {
            Program.StopServer();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Program.RunServer(this);
        }
        private void Dekessler_Click(object sender, EventArgs e)
        {
            Program.executeCommand("dekessler");
        }
        private void NukeKSC_Click(object sender, EventArgs e)
        {
            Program.executeCommand("nukeksc");
        }
        private void SayButton_Click(object sender, EventArgs e)
        {
            Program.executeCommand("say " + ServerMessageBox.Text);
            ServerMessageBox.Clear();
        }
        private void PMButton_Click(object sender, EventArgs e)
        {
            if (PlayerList.SelectedItem == null)
            {
                MessageBox.Show("A player must be selected to send a private message!");
            }
            else
            {
                string playername = PlayerList.SelectedItem.ToString();
                Program.executeCommand("pm " + playername + " " + ServerMessageBox.Text);
                ServerMessageBox.Clear();
            }
        }
        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            //Blocked by lack of player list
        }
        private void RemoveAdminButton_Click(object sender, EventArgs e)
        {
            //Blocked by lack of player list
        }
        private void KickButton_Click(object sender, EventArgs e)
        {
            if (PlayerList.SelectedItem == null)
            {
                MessageBox.Show("A player must be selected to kick from the server!");
            }
            else
            {
                string playername = PlayerList.SelectedItem.ToString();
                Program.executeCommand("kick " + playername);
            }
        }
        private void BanButton_Click(object sender, EventArgs e)
        {
            if (PlayerList.SelectedItem == null)
            {
                MessageBox.Show("A player must be selected to kick from the server!");
            }
            else
            {
                var DlgResult = MessageBox.Show("Are you sure you want to ban this player permanently?", "Sins Gaming - Dark Multiplayer GUI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DlgResult == System.Windows.Forms.DialogResult.Yes)
                {
                    string playername = PlayerList.SelectedItem.ToString();
                    Program.executeCommand("ban " + playername);
                }
            }
        }

        private void BackupRetrievalButton_Click(object sender, EventArgs e)
        {
            if(Program.IsServerRunning())
            {
                MessageBox.Show("The server must be stopped before a backup can be retrieved!");
            }
            else
            {
                DirectoryInfo backupDirectory = new DirectoryInfo("ServerBackup\\DMPServer");
                if (backupDirectory.Exists)
                {
                    var DlgResult = MessageBox.Show("Warning! Performing this retrieval will delete all current game data and replace it with the backup file. Are you sure you want to retrieve the backup?", "Sins Gaming - Dark Multiplayer GUI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DlgResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        string backupData = DirectoryCopyUtil.CopytoBackupDirectory("ServerBackup\\DMPServer", "DMPServer", true, true);
                        writeToConsoleDisplayBox("Performing Retrieval:\n-Confirming the existance of game files\n" + backupData + "-Retrieval Complete!\n");
                    }
                }
                else
                {
                    MessageBox.Show("No backup file exists!");
                }
            }
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            var DlgResult = MessageBox.Show("Warning! Performing this backup will delete and replace all previously backed up data with the current game data. Are you sure you want to perform this backup?", "Sins Gaming - Dark Multiplayer GUI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DlgResult == System.Windows.Forms.DialogResult.Yes)
            {
                string backupData = DirectoryCopyUtil.CopytoBackupDirectory("DMPServer", "ServerBackup\\DMPServer", true, true);
                writeToConsoleDisplayBox("Performing Backup:\n-Checking for existing backup\n" + backupData + "-Backup Complete!\n");
            }
        }

        /****************************************observer methods****************************************/
        public void update(string line)
        {
            writeToConsoleDisplayBox(line);
        }

        private void consoleDisplayBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
