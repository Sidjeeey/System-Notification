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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "Certificate Notification", " Certificate Expired as of Today, Click this to know more.", ToolTipIcon.Info);


            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var dbContext = new EmplyeeCertManagementEntities1())
            {
                List<Empolyee_Table> employees = dbContext.Empolyee_Table.ToList();
                dataGridView1.DataSource = employees;
            }
        }
    }

}
//this.Hide();
//notifyIcon1.ShowBalloonTip(1000, Certificate Notification", " Certificate Expired as of Today, Click this to know more.", ToolTipIcon.Info);


    //this.Hide();
    //System.Drawing.Icon customIcon = new System.Drawing.Icon("D:\\Users\\cj.junio\\Downloads\\ico.ico");
    //notifyIcon1.Icon = customIcon;
    //notifyIcon1.ShowBalloonTip(1000, "Kurth Chester", "Ilan ba docstamp kaylangan sagot ko na kayong lahat .", ToolTipIcon.None);