using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int.TryParse(selectedRow.Cells["EmpID"].Value.ToString(), out int EmpId);
                string FirstName = selectedRow.Cells["FirstName"].Value.ToString();
                string MiddleName = selectedRow.Cells["MiddleName"].Value.ToString();
                string LastName = selectedRow.Cells["LastName"].Value.ToString();
                string CertificateNumber = selectedRow.Cells["CertificateNumber"].Value.ToString();
                DateTime IssuedOn = Convert.ToDateTime(selectedRow.Cells["IssuedOn"].Value);
                DateTime ValidUntil = Convert.ToDateTime(selectedRow.Cells["ValidUntil"].Value);

                
                FirstNameBox.ReadOnly = true;
                FirstNameBox.Text = FirstName;
                MiddleNameBox.ReadOnly = true;
                MiddleNameBox.Text = MiddleName;
                LastNameBox.ReadOnly = true;
                LastNameBox.Text = LastName;
                //txtCertificateNumber.Text = certificateNumber;

                
                IssuedOnBox.Text = IssuedOn.ToShortDateString();
                IssuedOnBox.Enabled = true;

                ValidUntilBox.Text = ValidUntil.ToShortDateString();
                ValidUntilBox.Enabled = true;
            }
        }

        private void SaveDate()
        {
            try
            {
                var employee = new Empolyee_Table
                {
                    
                    FirstName = FirstNameBox.Text,
                    MiddleName = MiddleNameBox.Text,
                    LastName = LastNameBox.Text,
                    IssuedOn = DateTime.Parse(IssuedOnBox.Text),
                    ValidUntil = DateTime.Parse(ValidUntilBox.Text),
                };
                using (var context = new EmplyeeCertManagementEntities1())
                {
                    //context.Empolyee_Table.Add(employee);
                    context.SaveChanges();
                }
                MessageBox.Show("Saved Succesfully");

                FirstNameBox.Clear();
                MiddleNameBox.Clear();
                LastNameBox.Clear();
                IssuedOnBox.Clear();
                ValidUntilBox.Clear();
            }
            catch (Exception ex)
            {
                foreach (var validationError in ((DbEntityValidationException)ex).EntityValidationErrors.SelectMany(validationErrors => validationErrors.ValidationErrors))
                {
                    MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                }
            }
        }
        private void BttnSave_Click(object sender, EventArgs e)
        {
            SaveDate();
            
        }
    }
}


























//this.Hide();
//notifyIcon1.ShowBalloonTip(1000, Certificate Notification", " Certificate Expired as of Today, Click this to know more.", ToolTipIcon.Info);


    //this.Hide();
    //System.Drawing.Icon customIcon = new System.Drawing.Icon("D:\\Users\\cj.junio\\Downloads\\ico.ico");
    //notifyIcon1.Icon = customIcon;
    //notifyIcon1.ShowBalloonTip(1000, "Kurth Chester", "Ilan ba docstamp kaylangan sagot ko na kayong lahat .", ToolTipIcon.None);