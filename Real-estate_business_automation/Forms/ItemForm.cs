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
    public partial class ItemForm : Form
    {
        private PropertyViewModel _model;

        public ItemForm()
        {
            InitializeComponent();
            
        }
        public ItemForm(PropertyViewModel model)
        {
            InitializeComponent();

            _model = model;


        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            var districts = new List<District>();
            districts.Add(new District() { Id = 0, Name = "" });
            districts.AddRange(Controller.DistrictsList);

            comboBoxDistrict.DataSource = districts;
            comboBoxDistrict.DisplayMember = "Name";
            comboBoxDistrict.ValueMember = "Id";

            RoomBox.DataSource = new BindingSource(Controller.Rooms, null);
            RoomBox.ValueMember = "Value";
            RoomBox.DisplayMember = "Key";

            comboBoxType.DataSource = new[] {"rent", "sale" };

            this.Text = "Add";
            buttonDelete.Visible = false;
            buttonArchive.Visible = false;

            if (_model != null)
            {
                this.Text = "Edit";
                this.buttonAction.Text = "Save";

                buttonAction.Click -= buttonAdd_Click;
                buttonAction.Click += buttonEdit_Click;

                buttonCancel.Visible = false;
                buttonDelete.Visible = true;
                buttonArchive.Visible = true;
                // Review VM: magic numbers in there. Would be better to use some containers, dock them in form and use anchors in them.
                buttonAction.Location = new Point ( 8, 208 );

                textBoxName.Text = _model.Owner.Name;
                textBoxSurname.Text = _model.Owner.Surname;
                textBoxPhone.Text = _model.Owner.Phone;
                textBoxMail.Text = _model.Owner.Mail;

                comboBoxDistrict.SelectedValue = _model.Estate.DistrictId;

                RoomBox.SelectedValue = _model.Estate.Rooms;
                textBoxAddress.Text = _model.Estate.Address;
                textBoxArea.Text = _model.Estate.Area.ToString(); 
                textBoxPrice.Text = _model.Estate.Price.ToString();

                comboBoxType.SelectedItem = _model.Estate.Rent ? "rent" : "sale";
                
            }
        }
    
        // Review VM: there are a lot of validators in this method, that should be isolated in different functions.
        private PropertyViewModel ParseModel()
        {
            var model = _model ?? new PropertyViewModel();

            if ((int)comboBoxDistrict.SelectedValue == 0)
            {
                model.Estate.DistrictId = null;
            }
            else
            {
                model.Estate.DistrictId = (int?)comboBoxDistrict.SelectedValue;
            }

            if(textBoxAddress.Text == "")
            {
                labelAddress.ForeColor = Color.Red;
                return null;
            }
            model.Estate.Address = textBoxAddress.Text;
            labelAddress.ForeColor = Color.Black;


            if ((int)RoomBox.SelectedValue == 0)
            {
                labelRooms.ForeColor = Color.Red;
                return null;
            }
            model.Estate.Rooms = (int)RoomBox.SelectedValue;
            labelRooms.ForeColor = Color.Black;

            double area;
            if(!double.TryParse(textBoxArea.Text, out area))
            {
                labelArea.ForeColor = Color.Red;
                return null;
            }
            model.Estate.Area = area;
            labelArea.ForeColor = Color.Black;

            int price;
            if(!int.TryParse(textBoxPrice.Text, out price) || price < 0)
            {
                labelPrice.ForeColor = Color.Red;
                return null;
            }
            model.Estate.Price = price;
            labelPrice.ForeColor = Color.Black;
            
            // Review VM: use string.IsNullOrEmpty or string.IsNullOrWhiteSpace in such situations.
            if (textBoxSurname.Text == "")
            {
                labelSurname.ForeColor = Color.Red;
                return null;
            }
            model.Owner.Surname = textBoxSurname.Text;
            labelSurname.ForeColor = Color.Black;
            
            // Review VM: not enough email validation.
            if (!textBoxMail.Text.Contains("@"))
            {
                labelMail.ForeColor = Color.Red;
                return null;
            }
            model.Owner.Mail = textBoxSurname.Text;
            labelMail.ForeColor = Color.Black;
            
            model.Owner.Name = textBoxName.Text;
            model.Owner.Phone = textBoxPhone.Text;

            if ((string)comboBoxType.SelectedValue == "rent")
            {
                model.Estate.Rent = true;
                model.Estate.Sale = false;
            }
            else
            {
                model.Estate.Sale = true;
                model.Estate.Rent = false;
            }

            return model;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PropertyViewModel model = ParseModel();
            if (model != null)
            {
                Controller.AddModel(model);
                this.Close();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            PropertyViewModel model = ParseModel();
            if (model != null)
            {
                Controller.UpdateByModel(model);
                this.Close();
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Controller.DeleteModelByEstateId(_model.Estate.Id);
            Close();
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            this.Width = 720;
            CustomerBox.Visible = true;
            buttonOK.Visible = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var contract = new Contract();
            contract.EstateId = _model.Estate.Id;
            contract.EmpId = Controller.CurrentUser.PersId;

            var customer = new Person();

            customer.Name = textBoxCustName.Text;
            if (textBoxCustSurname.Text == "")
            {
                labelCustSurname.ForeColor = Color.Red;
                return;
            }
            customer.Surname = textBoxCustSurname.Text;
            labelCustSurname.ForeColor = Color.Black;

            customer.Phone = textBoxCustPhone.Text;
            customer.Mail = textBoxCustMail.Text;

            contract.CustId = Controller.AddPerson(customer);

            Controller.AddContractToArchive(contract);
            
            Close();
        }

    }
}
