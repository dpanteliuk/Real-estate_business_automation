using Real_estate_business_automation.Controllers;
using Real_estate_business_automation.Entities;
using Real_estate_business_automation.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_estate_business_automation
{
    // Review VM: would be better to give this form some meaningful name, although it's not a big deal in this situation.
    public partial class Form1 : Form
    {
        private void Login()
        {
            var form = new Login();
            form.Show();
            this.Visible = false;
            form.FormClosed += ((obj, arg) => { Close(); });
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void ActualDataLoad(IEnumerable<PropertyViewModel> set)
        {
            var dt = new DataTable();
            dt.Columns.Add("EstateId");
            dt.Columns.Add("District");
            dt.Columns.Add("Rooms");
            dt.Columns.Add("Area");
            dt.Columns.Add("Address");
            dt.Columns.Add("Price");
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone");
            dt.Columns.Add("E-Mail");

            foreach (var item in set)
            {
                DataRow r = dt.NewRow();

                r["EstateId"] = item.Estate.Id;
                r["District"] = item.District == null ? "" : item.District.Name;
                r["Rooms"] = item.Estate.Rooms;
                r["Area"] = item.Estate.Area;
                r["Address"] = item.Estate.Address;
                r["Price"] = item.Estate.Price;
                r["Name"] = item.Owner.Surname + " " + item.Owner.Name;
                r["Phone"] = item.Owner.Phone;
                r["E-Mail"] = item.Owner.Mail;

                dt.Rows.Add(r);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["EstateId"].Visible = false;
            dataGridView1.Columns["Rooms"].Width = 55;
            dataGridView1.Columns["Area"].Width = 55;
            dataGridView1.Columns["District"].Width = 115;
            dataGridView1.Columns["Price"].Width = 65;
            dataGridView1.Columns["Address"].Width = 135;
            dataGridView1.Columns["Name"].Width = 135;
            dataGridView1.Columns["Phone"].Width = 120;
            dataGridView1.Columns["E-Mail"].Width = 150;
        }


        private void LoadUpdateForm(object sender, DataGridViewCellEventArgs e)
        {
            var model = Controller.GetModelByEstateId(Convert.ToInt32(dataGridView1["EstateId", e.RowIndex].Value));

            var form = new ItemForm(model);
            form.Show();
        }

        private void ArchiveDataLoad(IEnumerable<PropertyArchiveModel> set)
        {
            var dt = new DataTable();
            dt.Columns.Add("EstateId");
            dt.Columns.Add("District");
            dt.Columns.Add("Rooms");
            dt.Columns.Add("Area");
            dt.Columns.Add("Address");
            dt.Columns.Add("Price");
            dt.Columns.Add("Owner Name");
            dt.Columns.Add("Owner Detail");
            dt.Columns.Add("Customer Name");
            dt.Columns.Add("Customer Detail");
            dt.Columns.Add("Employee Name");
            dt.Columns.Add("Employee Detail");

            foreach (var item in set)
            {
                DataRow r = dt.NewRow();

                r["EstateId"] = item.Estate.Id;
                r["District"] = item.District == null ? "" : item.District.Name;
                r["Rooms"] = item.Estate.Rooms;
                r["Area"] = item.Estate.Area;
                r["Address"] = item.Estate.Address;
                r["Price"] = item.Estate.Price;
                r["Owner Name"] = item.Owner.Surname + " " + item.Owner.Name;
                r["Owner Detail"] = item.Owner.Phone + "\n" + item.Owner.Mail;
                r["Customer Name"] = item.Customer.Surname + " " + item.Customer.Name;
                r["Customer Detail"] = item.Customer.Phone + "\n" + item.Customer.Mail;
                r["Employee Name"] = item.Employee.Surname + " " + item.Employee.Name;
                r["Employee Detail"] = item.Employee.Phone + "\n" + item.Employee.Mail;

                dt.Rows.Add(r);
            }
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["EstateId"].Visible = false;
            dataGridView1.Columns["Owner Detail"].Visible = false;
            dataGridView1.Columns["Customer Detail"].Visible = false;
            dataGridView1.Columns["Employee Detail"].Visible = false;


            dataGridView1.Columns["Rooms"].Width = 55;
            dataGridView1.Columns["Area"].Width = 55;
            dataGridView1.Columns["District"].Width = 115;
            dataGridView1.Columns["Price"].Width = 65;
            dataGridView1.Columns["Address"].Width = 135;
            dataGridView1.Columns["Owner Name"].Width = 135;
            dataGridView1.Columns["Customer Name"].Width = 135;
            dataGridView1.Columns["Employee Name"].Width = 135;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var districts = new List<District>();
            districts.Add(new District() { Id = 0, Name = "districts" });
            districts.AddRange(Controller.DistrictsList);

            IsActiveBox.DataSource = new[] { "actual", "archive"};
            RentBuyBox.DataSource = new[] { "rent", "buy" };
            RoomBox.DataSource = new BindingSource(Controller.Rooms, null);
            RoomBox.ValueMember = "Value";
            RoomBox.DisplayMember = "Key";
            
            DistrictBox.DataSource = districts;
            DistrictBox.DisplayMember = "Name";
            DistrictBox.ValueMember = "Id";

            dataGridView1.CellDoubleClick += LoadUpdateForm;

            LoginBox.Text = Controller.CurrentUser.Login;

            Search();
        }

        // Review VM: some useless event-handler here, keep code clean. 
        private void button3_Click(object sender, EventArgs e)
        {

        }
        
        // Review VM: had to search which button is fourth, not cool
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Controller.DeleteModelByEstateId(Convert.ToInt32(dataGridView1.CurrentRow.Cells["EstateId"].Value));
                Search_Click(null, null);
            }
        }


        private void Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            if ((string)IsActiveBox.SelectedValue == "actual")
            {
                flowLayoutButtonsPanel.Enabled = true;

                var set = Controller.GetAllPropertyViewModels();

                if ((string)RentBuyBox.SelectedValue == "rent")
                {
                    set = set.Where((item) => { return item.Estate.Rent == true; });
                }
                else
                {
                    set = set.Where((item) => { return item.Estate.Sale == true; });
                }

                if (RoomBox.Text != "rooms")
                {
                    set = set.Where((item) =>
                    {
                        return item.Estate.Rooms == (int)(RoomBox.SelectedValue);
                    });
                }

                if (DistrictBox.Text != "districts")
                {
                    set = set.Where((item) =>
                    {
                        return item.Estate.DistrictId == (int)(DistrictBox.SelectedValue);
                    });
                }
                ActualDataLoad(set);
            }
            else
            {
                flowLayoutButtonsPanel.Enabled = false;
                var set = Controller.GetAllPropertyArchiveModel();

                if (RoomBox.Text != "rooms")
                {
                    set = set.Where((item) =>
                    {
                        return item.Estate.Rooms == Convert.ToInt32(RoomBox.SelectedValue);
                    });
                }

                if (DistrictBox.Text != "districts")
                {
                    set = set.Where((item) =>
                    {
                        return item.Estate.DistrictId == (int)(DistrictBox.SelectedValue);
                    });
                }
                ArchiveDataLoad(set);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            IsActiveBox.SelectedItem = "actual";
            RentBuyBox.SelectedItem = "rent";
            RoomBox.SelectedValue = 0;
            DistrictBox.SelectedValue = 0;

            Search();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form2 = new ItemForm();
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Controller.DeleteModelByEstateId(Convert.ToInt32(dataGridView1.CurrentRow.Cells["EstateId"].Value));
                Search_Click(null, null);
            }
        }
    }
}
