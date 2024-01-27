using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
        Employee model = new Employee();
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
            EmpNumberBox.Text = FirstNameBox.Text = MiddleNameBox.Text = LastNameBox.Text = CertNoBox.Text = IssuedOnBox.Text = ValidUntilBox.Text = "";
            BttnSave.Text = "Save";
            model.EmpID = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }  

        private void BttnSave_Click(object sender, EventArgs e)
        {
            
            model.EmpNumber = EmpNumberBox.Text.Trim();
            model.FirstName = FirstNameBox.Text.Trim();
            model.MiddleName = MiddleNameBox.Text.Trim();
            model.LastName = LastNameBox.Text.Trim();
            model.CertificateNumber = CertNoBox.Text.Trim();
            if (!string.IsNullOrEmpty(IssuedOnBox.Text) && !string.IsNullOrEmpty(ValidUntilBox.Text))
            {
                model.IssuedOn = DateTime.Parse(IssuedOnBox.Text.Trim());
                model.ValidUntil = DateTime.Parse(ValidUntilBox.Text.Trim());
            }
            using (EmployeeEntities db = new EmployeeEntities())
            {
                if (model.EmpID == 0)
                    db.Employees.Add(model);
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
                    dataGridView1.DataSource = db.Employees.ToList<Employee>();
                }
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                model = new Employee();  

                model.EmpID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgEmpID"].Value);

                using (EmployeeEntities db = new EmployeeEntities())
                {
                    model = db.Employees.FirstOrDefault(x => x.EmpNumber == model.EmpNumber);

                    if (model != null)
                    {
                        EmpNumberBox.Text = model.EmpNumber;
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
            using (EmployeeEntities db = new EmployeeEntities())
            {
                try
                {
                    var entry = db.Entry(model);

                    if (entry.State == EntityState.Detached)
                    {
                        db.Employees.Attach(model);
                    }

                    db.Employees.Remove(model);
                    db.SaveChanges();
                    LoadData();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    // Handle concurrency exception
                    var entry = ex.Entries.Single();
                    var databaseValues = entry.GetDatabaseValues();
                    if (databaseValues == null)
                    {
                        MessageBox.Show("The record has been deleted by another user.");
                    }
                    else
                    {
                        // Refresh the entry with the values from the database
                        entry.OriginalValues.SetValues(databaseValues);
                        // You can display a message to the user indicating that the data has changed
                        MessageBox.Show("The record has been modified by another user. Please try again.");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Employee> employees = Seeder.GenerateRandomEmployees(10); // Change 10 to the number of samples you want

            // Begin
            // Create Context
            // AddRange(employees)
            // Save Changes
            // End

            // Display the generated employees
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
























