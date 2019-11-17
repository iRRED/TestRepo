using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1 {

    public partial class Radio : Form {

    public Radio()
        {
            InitializeComponent();
        }

        WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Blues_Click(object sender, EventArgs e)
        {
            //WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
            //mediaPlayer.settings.volume = 100;
            
            mediaPlayer.settings.volume = 100;
            mediaPlayer.URL = "https://www.internet-radio.com/servers/tools/playlistgenerator/?u=http://us2.internet-radio.com:8443/listen.pls&t=.m3u";
            mediaPlayer.controls.play();
        }

        private void Metal_Click(object sender, EventArgs e)
        {
            //WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
            mediaPlayer.settings.volume = 100;
            mediaPlayer.URL = "https://www.internet-radio.com/servers/tools/playlistgenerator/?u=http://uk1.internet-radio.com:8294/live.m3u&t=.m3u";
            mediaPlayer.controls.play();
        }

        private void Dance_Click(object sender, EventArgs e)
        {
            //WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
            mediaPlayer.settings.volume = 100;
            mediaPlayer.URL = "https://www.internet-radio.com/servers/tools/playlistgenerator/?u=http://uk2.internet-radio.com:8024/listen.pls&t=.m3u";
            mediaPlayer.controls.play();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            mediaPlayer.controls.stop();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            mediaPlayer.settings.volume = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
