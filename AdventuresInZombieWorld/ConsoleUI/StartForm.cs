using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace ConsoleUI
{
    public partial class StartForm : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public StartForm()
        {
            
            InitializeComponent();

            player.URL = @"C:\Users\oreng\Downloads\zapsplat_sound_design_cinematic_musical_guitar_plucked_long_serious_dark_tension_drama_80203.mp3";
            player.controls.play();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            start_progressBar.Visible = true;
            this.timer_load.Start();
        }

        private void timer_load_Tick(object sender, EventArgs e)
        {
            this.start_progressBar.Increment(10);
            if(start_progressBar.Value >= 100)
            {
                title_label.ForeColor = Color.Red;

                start_button.Visible = false;
                enter_button.Visible = true;
            }
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void enterButton_Hover(object sender, EventArgs e)
        {
            enter_button.BackColor = Color.Black;
        }

        private void enterButton_Leave(object sender, EventArgs e)
        {
            enter_button.BackColor = Color.Red;
        }
    }
}
