using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Notification
{
    public partial class SplashScreen : Form
    {
        private double opacityIncrement = 0.05; // Increment value for opacity change
        private double targetOpacity = 1.0; // Target opacity for fade-in effect
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 700)
            {
                timer1.Stop();
                FadeInLoginForm();
            }
        }
        private void FadeInLoginForm()
        {
            Login_form lf = new Login_form();
            lf.Opacity = 0; // Start with zero opacity
            lf.Show();
            this.Hide();

            // Start timer for fade-in effect
            Timer fadeInTimer = new Timer();
            fadeInTimer.Interval = 50; // Adjust as needed
            fadeInTimer.Tick += (s, e) =>
            {
                if (lf.Opacity < targetOpacity)
                {
                    lf.Opacity += opacityIncrement; // Increase opacity gradually
                }
                else
                {
                    fadeInTimer.Stop(); // Stop the timer when target opacity is reached
                }
            };
            fadeInTimer.Start();
        }
    }
}
 