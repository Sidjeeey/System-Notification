using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        Empolyee_Table model = new Empolyee_Table();
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

        private void BttnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            EmpIdBox.Text = FirstNameBox.Text = MiddleNameBox.Text = LastNameBox.Text = CertNoBox.Text = IssuedOnBox.Text = ValidUntilBox.Text = "";
            BttnSave.Text = "Save";
            model.EmpNumber = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }  

        private void BttnSave_Click(object sender, EventArgs e)
        {
            
            model.EmpID = EmpIdBox.Text.Trim();
            model.FirstName = FirstNameBox.Text.Trim();
            model.MiddleName = MiddleNameBox.Text.Trim();
            model.LastName = LastNameBox.Text.Trim();
            model.CertificateNumber = CertNoBox.Text.Trim();
            model.IssuedOn = DateTime.Parse(IssuedOnBox.Text.Trim());
            model.ValidUntil = DateTime.Parse(IssuedOnBox.Text.Trim());
            using (EmployeeEntities db = new EmployeeEntities())
            {
                if (model.EmpNumber == 0)
                    db.Empolyee_Table.Add(model);
                else
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                
            }
            
            Clear();
            LoadData();
            MessageBox.Show("Saved Successfully");

        } 

        void LoadData()
        {
            {
                dataGridView1.AutoGenerateColumns = false;
                using (EmployeeEntities db = new EmployeeEntities ())
                {
                    dataGridView1.DataSource = db.Empolyee_Table.ToList<Empolyee_Table>();
                }
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                model = new Empolyee_Table();  

                model.EmpNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgEmpNumber"].Value);

                using (EmployeeEntities db = new EmployeeEntities())
                {
                    model = db.Empolyee_Table.FirstOrDefault(x => x.EmpNumber == model.EmpNumber);

                    if (model != null)
                    {
                        EmpIdBox.Text = model.EmpID;
                        FirstNameBox.Text = model.FirstName;
                        MiddleNameBox.Text = model.MiddleName;
                        LastNameBox.Text = model.LastName;
                        CertNoBox.Text = model.CertificateNumber;
                        IssuedOnBox.Text = model.IssuedOn.HasValue ? model.IssuedOn.Value.ToShortDateString() : string.Empty;
                        ValidUntilBox.Text = model.ValidUntil.HasValue ? model.ValidUntil.Value.ToShortDateString() : string.Empty;

                        BttnSave.Text = "Update";
                        BttnDelete.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Employee not found!");
                    }
                }
            }
        }

        private void BttnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Record", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (EmployeeEntities db = new EmployeeEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == EntityState.Detached)
                    {
                        db.Empolyee_Table.Attach(model);
                        db.Empolyee_Table.Remove(model);
                        db.SaveChanges();
                        LoadData();
                        Clear();
                        MessageBox.Show("Deleted Successfully");
                    }
                }
            }
        }

        // Button Style

        private void BttnSave_MouseHover(object sender, EventArgs e)
        {
           BttnSave.BackColor = Color.Turquoise;
        }

        private void BttnSave_MouseLeave(object sender, EventArgs e)
        {
            BttnSave.BackColor = Color.Gainsboro;
        }

        private void BttnDelete_MouseHover(object sender, EventArgs e)
        {
            BttnDelete.BackColor = Color.Red;
        }

        private void BttnDelete_MouseLeave(object sender, EventArgs e)
        {
            BttnDelete.BackColor = Color.Gainsboro;
        }

        private void BttnCancel_MouseHover(object sender, EventArgs e)
        {
            BttnCancel.BackColor = Color.SandyBrown;
        }

        private void BttnCancel_MouseLeave(object sender, EventArgs e)
        {
            BttnCancel.BackColor = Color.Gainsboro;
        }
    }
}
























