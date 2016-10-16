namespace Real_estate_business_automation
{
    partial class ItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonAction = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.CustomerBox = new System.Windows.Forms.GroupBox();
            this.textBoxCustMail = new System.Windows.Forms.TextBox();
            this.textBoxCustPhone = new System.Windows.Forms.TextBox();
            this.labelCustSurname = new System.Windows.Forms.Label();
            this.textBoxCustSurname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCustName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.OwnerBox = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.RoomBox = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.CustomerBox.SuspendLayout();
            this.OwnerBox.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(9, 69);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(60, 17);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Surname";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(9, 99);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(45, 17);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(9, 129);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(46, 17);
            this.labelMail.TabIndex = 3;
            this.labelMail.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "District";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(0, 38);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(57, 17);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Location = new System.Drawing.Point(0, 68);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(49, 17);
            this.labelRooms.TabIndex = 6;
            this.labelRooms.Text = "Rooms";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(0, 98);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(38, 17);
            this.labelArea.TabIndex = 7;
            this.labelArea.Text = "Area";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(0, 128);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(39, 17);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price";
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(48, 208);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(125, 32);
            this.buttonAction.TabIndex = 11;
            this.buttonAction.Text = "Add";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(72, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(148, 25);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(72, 64);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(148, 25);
            this.textBoxSurname.TabIndex = 13;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(72, 94);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(148, 25);
            this.textBoxPhone.TabIndex = 13;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(72, 124);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(148, 25);
            this.textBoxMail.TabIndex = 13;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(55, 125);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(148, 25);
            this.textBoxPrice.TabIndex = 13;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(55, 35);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(148, 25);
            this.textBoxAddress.TabIndex = 13;
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(55, 95);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(148, 25);
            this.textBoxArea.TabIndex = 13;
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Location = new System.Drawing.Point(55, 5);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(148, 25);
            this.comboBoxDistrict.TabIndex = 14;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(280, 208);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 32);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonArchive
            // 
            this.buttonArchive.Location = new System.Drawing.Point(328, 208);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(125, 32);
            this.buttonArchive.TabIndex = 16;
            this.buttonArchive.Text = "Archive";
            this.buttonArchive.UseVisualStyleBackColor = true;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(168, 208);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 32);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // CustomerBox
            // 
            this.CustomerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.CustomerBox.Controls.Add(this.textBoxCustMail);
            this.CustomerBox.Controls.Add(this.textBoxCustPhone);
            this.CustomerBox.Controls.Add(this.labelCustSurname);
            this.CustomerBox.Controls.Add(this.textBoxCustSurname);
            this.CustomerBox.Controls.Add(this.label14);
            this.CustomerBox.Controls.Add(this.textBoxCustName);
            this.CustomerBox.Controls.Add(this.label13);
            this.CustomerBox.Controls.Add(this.label12);
            this.CustomerBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerBox.Location = new System.Drawing.Point(464, 8);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Size = new System.Drawing.Size(232, 184);
            this.CustomerBox.TabIndex = 18;
            this.CustomerBox.TabStop = false;
            this.CustomerBox.Text = "Customer";
            this.CustomerBox.UseCompatibleTextRendering = true;
            this.CustomerBox.Visible = false;
            // 
            // textBoxCustMail
            // 
            this.textBoxCustMail.Location = new System.Drawing.Point(72, 122);
            this.textBoxCustMail.Name = "textBoxCustMail";
            this.textBoxCustMail.Size = new System.Drawing.Size(148, 25);
            this.textBoxCustMail.TabIndex = 24;
            // 
            // textBoxCustPhone
            // 
            this.textBoxCustPhone.Location = new System.Drawing.Point(72, 92);
            this.textBoxCustPhone.Name = "textBoxCustPhone";
            this.textBoxCustPhone.Size = new System.Drawing.Size(148, 25);
            this.textBoxCustPhone.TabIndex = 25;
            // 
            // labelCustSurname
            // 
            this.labelCustSurname.AutoSize = true;
            this.labelCustSurname.Location = new System.Drawing.Point(8, 70);
            this.labelCustSurname.Name = "labelCustSurname";
            this.labelCustSurname.Size = new System.Drawing.Size(60, 17);
            this.labelCustSurname.TabIndex = 19;
            this.labelCustSurname.Text = "Surname";
            // 
            // textBoxCustSurname
            // 
            this.textBoxCustSurname.Location = new System.Drawing.Point(72, 62);
            this.textBoxCustSurname.Name = "textBoxCustSurname";
            this.textBoxCustSurname.Size = new System.Drawing.Size(148, 25);
            this.textBoxCustSurname.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Name";
            // 
            // textBoxCustName
            // 
            this.textBoxCustName.Location = new System.Drawing.Point(72, 32);
            this.textBoxCustName.Name = "textBoxCustName";
            this.textBoxCustName.Size = new System.Drawing.Size(148, 25);
            this.textBoxCustName.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "E-mail";
            // 
            // OwnerBox
            // 
            this.OwnerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OwnerBox.Controls.Add(this.textBoxSurname);
            this.OwnerBox.Controls.Add(this.labelSurname);
            this.OwnerBox.Controls.Add(this.labelName);
            this.OwnerBox.Controls.Add(this.labelPhone);
            this.OwnerBox.Controls.Add(this.labelMail);
            this.OwnerBox.Controls.Add(this.textBoxName);
            this.OwnerBox.Controls.Add(this.textBoxPhone);
            this.OwnerBox.Controls.Add(this.textBoxMail);
            this.OwnerBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OwnerBox.Location = new System.Drawing.Point(216, 0);
            this.OwnerBox.Name = "OwnerBox";
            this.OwnerBox.Size = new System.Drawing.Size(232, 184);
            this.OwnerBox.TabIndex = 19;
            this.OwnerBox.TabStop = false;
            this.OwnerBox.Text = "Owner";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(512, 208);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(125, 32);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Visible = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // RoomBox
            // 
            this.RoomBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoomBox.FormattingEnabled = true;
            this.RoomBox.Location = new System.Drawing.Point(55, 65);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(148, 25);
            this.RoomBox.TabIndex = 21;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(222)))));
            this.panel.Controls.Add(this.comboBoxType);
            this.panel.Controls.Add(this.RoomBox);
            this.panel.Controls.Add(this.textBoxAddress);
            this.panel.Controls.Add(this.OwnerBox);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.labelAddress);
            this.panel.Controls.Add(this.labelRooms);
            this.panel.Controls.Add(this.labelArea);
            this.panel.Controls.Add(this.labelType);
            this.panel.Controls.Add(this.labelPrice);
            this.panel.Controls.Add(this.textBoxArea);
            this.panel.Controls.Add(this.comboBoxDistrict);
            this.panel.Controls.Add(this.textBoxPrice);
            this.panel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel.Location = new System.Drawing.Point(8, 8);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(448, 184);
            this.panel.TabIndex = 22;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(56, 155);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(146, 25);
            this.comboBoxType.TabIndex = 22;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(0, 160);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(37, 17);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Type";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 260);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.CustomerBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "ItemForm";
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.CustomerBox.ResumeLayout(false);
            this.CustomerBox.PerformLayout();
            this.OwnerBox.ResumeLayout(false);
            this.OwnerBox.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonArchive;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxCustMail;
        private System.Windows.Forms.TextBox textBoxCustPhone;
        private System.Windows.Forms.Label labelCustSurname;
        private System.Windows.Forms.TextBox textBoxCustSurname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCustName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox OwnerBox;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ComboBox RoomBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.GroupBox CustomerBox;
    }
}