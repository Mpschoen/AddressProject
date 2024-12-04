namespace AddressesProject
{
    partial class Window1
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.OrganizationsList = new Wisej.Web.DataGridView();
            this.OrgName = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Street = new Wisej.Web.DataGridViewTextBoxColumn();
            this.ZIP = new Wisej.Web.DataGridViewTextBoxColumn();
            this.City = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Country = new Wisej.Web.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.Names_TextBox = new Wisej.Web.TextBox();
            this.Street_TextBox = new Wisej.Web.TextBox();
            this.ZIP_Textbox = new Wisej.Web.TextBox();
            this.City_TextBox = new Wisej.Web.TextBox();
            this.Country_TextBox = new Wisej.Web.TextBox();
            this.AddOrganization = new Wisej.Web.Button();
            this.DeleteOrganization = new Wisej.Web.Button();
            this.StaffList = new Wisej.Web.DataGridView();
            this.Title = new Wisej.Web.DataGridViewTextBoxColumn();
            this.FName = new Wisej.Web.DataGridViewTextBoxColumn();
            this.LName = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Phone = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Email = new Wisej.Web.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new Wisej.Web.TableLayoutPanel();
            this.Title_Textbox = new Wisej.Web.TextBox();
            this.FName_Textbox = new Wisej.Web.TextBox();
            this.LName_Textbox = new Wisej.Web.TextBox();
            this.Phone_Textbox = new Wisej.Web.TextBox();
            this.Email_TextBox = new Wisej.Web.TextBox();
            this.Add_Staff_Button = new Wisej.Web.Button();
            this.Delete_Staff_Button = new Wisej.Web.Button();
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.dataGridView3 = new Wisej.Web.DataGridView();
            this.dataGridView4 = new Wisej.Web.DataGridView();
            this.dataGridView5 = new Wisej.Web.DataGridView();
            this.dataGridViewTextBoxColumn1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.contextMenu1 = new Wisej.Web.ContextMenu(this.components);
            this.tableLayoutPanel4 = new Wisej.Web.TableLayoutPanel();
            this.Show_Staff_R_Button = new Wisej.Web.Button();
            this.Show_Orgs_R_Button = new Wisej.Web.Button();
            this.End_Relationship_Button = new Wisej.Web.Button();
            this.Create_Relationship_Button = new Wisej.Web.Button();
            this.contextMenu2 = new Wisej.Web.ContextMenu(this.components);
            this.Organization_Relationships = new Wisej.Web.TextBox();
            this.contextMenu3 = new Wisej.Web.ContextMenu(this.components);
            this.Staff_Relationships = new Wisej.Web.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationsList)).BeginInit();
            this.OrganizationsList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffList)).BeginInit();
            this.StaffList.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrganizationsList
            // 
            this.OrganizationsList.AutoGenerateColumns = false;
            this.OrganizationsList.AutoSize = true;
            this.OrganizationsList.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.OrgName,
            this.Street,
            this.ZIP,
            this.City,
            this.Country});
            this.OrganizationsList.Controls.Add(this.tableLayoutPanel1);
            this.OrganizationsList.Controls.Add(this.AddOrganization);
            this.OrganizationsList.Controls.Add(this.DeleteOrganization);
            this.OrganizationsList.Dock = Wisej.Web.DockStyle.Left;
            this.OrganizationsList.KeepSameRowHeight = true;
            this.OrganizationsList.Location = new System.Drawing.Point(0, 0);
            this.OrganizationsList.Name = "OrganizationsList";
            this.OrganizationsList.ReadOnly = true;
            this.OrganizationsList.RowHeadersVisible = false;
            this.OrganizationsList.Selectable = true;
            this.OrganizationsList.Size = new System.Drawing.Size(502, 932);
            this.OrganizationsList.TabIndex = 4;
            this.OrganizationsList.Click += new System.EventHandler(this.Organizations_Click);
            // 
            // OrgName
            // 
            this.OrgName.DataPropertyName = "name";
            this.OrgName.HeaderText = "Name";
            this.OrgName.Name = "OrgName";
            this.OrgName.ValueType = typeof(string);
            // 
            // Street
            // 
            this.Street.DataPropertyName = "street";
            this.Street.HeaderText = "Street";
            this.Street.Name = "Street";
            this.Street.ValueType = typeof(string);
            // 
            // ZIP
            // 
            this.ZIP.DataPropertyName = "zip";
            this.ZIP.HeaderText = "ZIP";
            this.ZIP.Name = "ZIP";
            this.ZIP.ValueType = typeof(int);
            // 
            // City
            // 
            this.City.DataPropertyName = "city";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ValueType = typeof(string);
            // 
            // Country
            // 
            this.Country.DataPropertyName = "country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ValueType = typeof(string);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Names_TextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Street_TextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ZIP_Textbox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.City_TextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Country_TextBox, 4, 0);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 806);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 50);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.PanelCollapsed += new System.EventHandler(this.tableLayoutPanel1_PanelCollapsed);
            // 
            // Names_TextBox
            // 
            this.Names_TextBox.Dock = Wisej.Web.DockStyle.Fill;
            this.Names_TextBox.Location = new System.Drawing.Point(3, 3);
            this.Names_TextBox.Name = "Names_TextBox";
            this.Names_TextBox.Size = new System.Drawing.Size(94, 44);
            this.Names_TextBox.TabIndex = 0;
            // 
            // Street_TextBox
            // 
            this.Street_TextBox.Dock = Wisej.Web.DockStyle.Fill;
            this.Street_TextBox.Location = new System.Drawing.Point(103, 3);
            this.Street_TextBox.Name = "Street_TextBox";
            this.Street_TextBox.Size = new System.Drawing.Size(94, 44);
            this.Street_TextBox.TabIndex = 1;
            // 
            // ZIP_Textbox
            // 
            this.ZIP_Textbox.Dock = Wisej.Web.DockStyle.Fill;
            this.ZIP_Textbox.Location = new System.Drawing.Point(203, 3);
            this.ZIP_Textbox.Name = "ZIP_Textbox";
            this.ZIP_Textbox.Size = new System.Drawing.Size(94, 44);
            this.ZIP_Textbox.TabIndex = 2;
            // 
            // City_TextBox
            // 
            this.City_TextBox.Dock = Wisej.Web.DockStyle.Fill;
            this.City_TextBox.Location = new System.Drawing.Point(303, 3);
            this.City_TextBox.Name = "City_TextBox";
            this.City_TextBox.Size = new System.Drawing.Size(94, 44);
            this.City_TextBox.TabIndex = 3;
            // 
            // Country_TextBox
            // 
            this.Country_TextBox.Dock = Wisej.Web.DockStyle.Fill;
            this.Country_TextBox.Location = new System.Drawing.Point(403, 3);
            this.Country_TextBox.Name = "Country_TextBox";
            this.Country_TextBox.Size = new System.Drawing.Size(94, 44);
            this.Country_TextBox.TabIndex = 4;
            // 
            // AddOrganization
            // 
            this.AddOrganization.BackColor = System.Drawing.Color.FromArgb(0, 255, 111);
            this.AddOrganization.Dock = Wisej.Web.DockStyle.Bottom;
            this.AddOrganization.Font = new System.Drawing.Font("default, Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AddOrganization.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.AddOrganization.Location = new System.Drawing.Point(0, 856);
            this.AddOrganization.Name = "AddOrganization";
            this.AddOrganization.Size = new System.Drawing.Size(500, 37);
            this.AddOrganization.TabIndex = 6;
            this.AddOrganization.Text = "Add Organization";
            this.AddOrganization.Click += new System.EventHandler(this.AddOrganization_Click);
            // 
            // DeleteOrganization
            // 
            this.DeleteOrganization.BackColor = System.Drawing.Color.FromArgb(255, 46, 0);
            this.DeleteOrganization.Dock = Wisej.Web.DockStyle.Bottom;
            this.DeleteOrganization.Font = new System.Drawing.Font("default, Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DeleteOrganization.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.DeleteOrganization.Location = new System.Drawing.Point(0, 893);
            this.DeleteOrganization.Name = "DeleteOrganization";
            this.DeleteOrganization.Size = new System.Drawing.Size(500, 37);
            this.DeleteOrganization.TabIndex = 7;
            this.DeleteOrganization.Text = "Delete Organization";
            this.DeleteOrganization.Click += new System.EventHandler(this.DeleteOrganization_Click);
            // 
            // StaffList
            // 
            this.StaffList.AllowUserToResizeColumns = false;
            this.StaffList.AllowUserToResizeRows = false;
            this.StaffList.AutoGenerateColumns = false;
            this.StaffList.AutoSize = true;
            this.StaffList.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.Title,
            this.FName,
            this.LName,
            this.Phone,
            this.Email});
            this.StaffList.Controls.Add(this.tableLayoutPanel2);
            this.StaffList.Controls.Add(this.Add_Staff_Button);
            this.StaffList.Controls.Add(this.Delete_Staff_Button);
            this.StaffList.Dock = Wisej.Web.DockStyle.Right;
            this.StaffList.KeepSameRowHeight = true;
            this.StaffList.Location = new System.Drawing.Point(1090, 0);
            this.StaffList.Name = "StaffList";
            this.StaffList.ReadOnly = true;
            this.StaffList.RowHeadersVisible = false;
            this.StaffList.Selectable = true;
            this.StaffList.Size = new System.Drawing.Size(502, 932);
            this.StaffList.TabIndex = 5;
            this.StaffList.Click += new System.EventHandler(this.Staff_Click);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ValueType = typeof(string);
            // 
            // FName
            // 
            this.FName.DataPropertyName = "fName";
            this.FName.HeaderText = "First Name";
            this.FName.Name = "FName";
            this.FName.ValueType = typeof(string);
            // 
            // LName
            // 
            this.LName.DataPropertyName = "lName";
            this.LName.HeaderText = "Last Name";
            this.LName.Name = "LName";
            this.LName.ValueType = typeof(string);
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "phoneNumber";
            this.Phone.HeaderText = "Phone Number";
            this.Phone.Name = "Phone";
            this.Phone.ValueType = typeof(int);
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ValueType = typeof(string);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Title_Textbox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.FName_Textbox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LName_Textbox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Phone_Textbox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Email_TextBox, 4, 0);
            this.tableLayoutPanel2.Dock = Wisej.Web.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 806);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 50);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // Title_Textbox
            // 
            this.Title_Textbox.Dock = Wisej.Web.DockStyle.Fill;
            this.Title_Textbox.Location = new System.Drawing.Point(3, 3);
            this.Title_Textbox.Name = "Title_Textbox";
            this.Title_Textbox.Size = new System.Drawing.Size(94, 44);
            this.Title_Textbox.TabIndex = 0;
            // 
            // FName_Textbox
            // 
            this.FName_Textbox.Dock = Wisej.Web.DockStyle.Fill;
            this.FName_Textbox.Location = new System.Drawing.Point(103, 3);
            this.FName_Textbox.Name = "FName_Textbox";
            this.FName_Textbox.Size = new System.Drawing.Size(94, 44);
            this.FName_Textbox.TabIndex = 1;
            // 
            // LName_Textbox
            // 
            this.LName_Textbox.Dock = Wisej.Web.DockStyle.Fill;
            this.LName_Textbox.Location = new System.Drawing.Point(203, 3);
            this.LName_Textbox.Name = "LName_Textbox";
            this.LName_Textbox.Size = new System.Drawing.Size(94, 44);
            this.LName_Textbox.TabIndex = 2;
            // 
            // Phone_Textbox
            // 
            this.Phone_Textbox.Dock = Wisej.Web.DockStyle.Fill;
            this.Phone_Textbox.Location = new System.Drawing.Point(303, 3);
            this.Phone_Textbox.Name = "Phone_Textbox";
            this.Phone_Textbox.Size = new System.Drawing.Size(94, 44);
            this.Phone_Textbox.TabIndex = 3;
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Dock = Wisej.Web.DockStyle.Fill;
            this.Email_TextBox.Location = new System.Drawing.Point(403, 3);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(94, 44);
            this.Email_TextBox.TabIndex = 4;
            // 
            // Add_Staff_Button
            // 
            this.Add_Staff_Button.BackColor = System.Drawing.Color.FromArgb(0, 255, 111);
            this.Add_Staff_Button.Dock = Wisej.Web.DockStyle.Bottom;
            this.Add_Staff_Button.Font = new System.Drawing.Font("default, Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Add_Staff_Button.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.Add_Staff_Button.Location = new System.Drawing.Point(0, 856);
            this.Add_Staff_Button.Name = "Add_Staff_Button";
            this.Add_Staff_Button.Size = new System.Drawing.Size(500, 37);
            this.Add_Staff_Button.TabIndex = 8;
            this.Add_Staff_Button.Text = "Add Staff Member";
            this.Add_Staff_Button.Click += new System.EventHandler(this.Add_Staff_Button_Click);
            // 
            // Delete_Staff_Button
            // 
            this.Delete_Staff_Button.BackColor = System.Drawing.Color.FromArgb(255, 46, 0);
            this.Delete_Staff_Button.Dock = Wisej.Web.DockStyle.Bottom;
            this.Delete_Staff_Button.Font = new System.Drawing.Font("default, Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Delete_Staff_Button.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.Delete_Staff_Button.Location = new System.Drawing.Point(0, 893);
            this.Delete_Staff_Button.Name = "Delete_Staff_Button";
            this.Delete_Staff_Button.Size = new System.Drawing.Size(500, 37);
            this.Delete_Staff_Button.TabIndex = 8;
            this.Delete_Staff_Button.Text = "Delete Staff Member";
            this.Delete_Staff_Button.Click += new System.EventHandler(this.Delete_Staff_Button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Dock = Wisej.Web.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(198, 100);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Dock = Wisej.Web.DockStyle.Top;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(196, 12);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.Dock = Wisej.Web.DockStyle.Top;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(194, 100);
            this.dataGridView4.TabIndex = 0;
            // 
            // dataGridView5
            // 
            this.dataGridView5.Dock = Wisej.Web.DockStyle.Top;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(192, 100);
            this.dataGridView5.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // contextMenu1
            // 
            this.contextMenu1.Name = "contextMenu1";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.Staff_Relationships, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.Organization_Relationships, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.Show_Staff_R_Button, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.Show_Orgs_R_Button, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.End_Relationship_Button, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.Create_Relationship_Button, 0, 2);
            this.tableLayoutPanel4.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(502, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 8.78F));
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 91.22F));
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 115F));
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 110F));
            this.tableLayoutPanel4.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 342F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(588, 932);
            this.tableLayoutPanel4.TabIndex = 6;
            this.tableLayoutPanel4.PanelCollapsed += new System.EventHandler(this.tableLayoutPanel4_PanelCollapsed);
            // 
            // Show_Staff_R_Button
            // 
            this.Show_Staff_R_Button.Dock = Wisej.Web.DockStyle.Fill;
            this.Show_Staff_R_Button.Font = new System.Drawing.Font("default, Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Show_Staff_R_Button.Location = new System.Drawing.Point(297, 482);
            this.Show_Staff_R_Button.Name = "Show_Staff_R_Button";
            this.Show_Staff_R_Button.Size = new System.Drawing.Size(288, 104);
            this.Show_Staff_R_Button.TabIndex = 7;
            this.Show_Staff_R_Button.Text = "Show Staff Relationships";
            this.Show_Staff_R_Button.Click += new System.EventHandler(this.Show_Staff_R_Button_Click);
            // 
            // Show_Orgs_R_Button
            // 
            this.Show_Orgs_R_Button.Dock = Wisej.Web.DockStyle.Fill;
            this.Show_Orgs_R_Button.Font = new System.Drawing.Font("default, Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Show_Orgs_R_Button.Location = new System.Drawing.Point(3, 482);
            this.Show_Orgs_R_Button.Name = "Show_Orgs_R_Button";
            this.Show_Orgs_R_Button.Size = new System.Drawing.Size(288, 104);
            this.Show_Orgs_R_Button.TabIndex = 6;
            this.Show_Orgs_R_Button.Text = "Show Organization Relationships";
            this.Show_Orgs_R_Button.Click += new System.EventHandler(this.Show_orgs_R_Button_Click);
            // 
            // End_Relationship_Button
            // 
            this.End_Relationship_Button.Dock = Wisej.Web.DockStyle.Fill;
            this.End_Relationship_Button.Font = new System.Drawing.Font("default, Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.End_Relationship_Button.Location = new System.Drawing.Point(297, 367);
            this.End_Relationship_Button.Name = "End_Relationship_Button";
            this.End_Relationship_Button.Size = new System.Drawing.Size(288, 109);
            this.End_Relationship_Button.TabIndex = 5;
            this.End_Relationship_Button.Text = "End Relationship";
            this.End_Relationship_Button.Click += new System.EventHandler(this.End_Relationship_Button_Click);
            // 
            // Create_Relationship_Button
            // 
            this.Create_Relationship_Button.Dock = Wisej.Web.DockStyle.Fill;
            this.Create_Relationship_Button.Font = new System.Drawing.Font("default, Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Create_Relationship_Button.Location = new System.Drawing.Point(3, 367);
            this.Create_Relationship_Button.Name = "Create_Relationship_Button";
            this.Create_Relationship_Button.Size = new System.Drawing.Size(288, 109);
            this.Create_Relationship_Button.TabIndex = 0;
            this.Create_Relationship_Button.Text = "Create Relationship";
            this.Create_Relationship_Button.Click += new System.EventHandler(this.Create_Relationship_Button_Click);
            // 
            // contextMenu2
            // 
            this.contextMenu2.Name = "contextMenu2";
            // 
            // Organization_Relationships
            // 
            this.Organization_Relationships.Dock = Wisej.Web.DockStyle.Fill;
            this.Organization_Relationships.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Organization_Relationships.LabelText = "Organization Relationships";
            this.Organization_Relationships.Location = new System.Drawing.Point(3, 592);
            this.Organization_Relationships.Multiline = true;
            this.Organization_Relationships.Name = "Organization_Relationships";
            this.Organization_Relationships.ReadOnly = true;
            this.Organization_Relationships.Size = new System.Drawing.Size(288, 337);
            this.Organization_Relationships.TabIndex = 8;
            this.Organization_Relationships.TextAlign = Wisej.Web.HorizontalAlignment.Center;
            // 
            // contextMenu3
            // 
            this.contextMenu3.Name = "contextMenu3";
            // 
            // Staff_Relationships
            // 
            this.Staff_Relationships.Dock = Wisej.Web.DockStyle.Fill;
            this.Staff_Relationships.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Staff_Relationships.LabelText = "Staff Relationships";
            this.Staff_Relationships.Location = new System.Drawing.Point(297, 592);
            this.Staff_Relationships.Multiline = true;
            this.Staff_Relationships.Name = "Staff_Relationships";
            this.Staff_Relationships.ReadOnly = true;
            this.Staff_Relationships.Size = new System.Drawing.Size(288, 337);
            this.Staff_Relationships.TabIndex = 13;
            this.Staff_Relationships.TextAlign = Wisej.Web.HorizontalAlignment.Center;
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.StaffList);
            this.Controls.Add(this.OrganizationsList);
            this.Name = "Window1";
            this.Size = new System.Drawing.Size(1592, 932);
            this.Load += new System.EventHandler(this.Window1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationsList)).EndInit();
            this.OrganizationsList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffList)).EndInit();
            this.StaffList.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Wisej.Web.DataGridViewTextBoxColumn OrgName;
        private Wisej.Web.DataGridView OrganizationsList;
        private Wisej.Web.DataGridViewTextBoxColumn Street;
        private Wisej.Web.DataGridViewTextBoxColumn ZIP;
        private Wisej.Web.DataGridViewTextBoxColumn City;
        private Wisej.Web.DataGridViewTextBoxColumn Country;
        private Wisej.Web.DataGridView StaffList;
        private Wisej.Web.DataGridViewTextBoxColumn LName;
        private Wisej.Web.DataGridViewTextBoxColumn Phone;
        private Wisej.Web.DataGridViewTextBoxColumn Email;
        private Wisej.Web.DataGridViewTextBoxColumn Title;
        private Wisej.Web.DataGridViewTextBoxColumn FName;
        private Wisej.Web.DataGridView dataGridView2;
        private Wisej.Web.DataGridView dataGridView3;
        private Wisej.Web.DataGridView dataGridView4;
        private Wisej.Web.DataGridView dataGridView5;
        private Wisej.Web.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
        private Wisej.Web.ContextMenu contextMenu1;
        private Wisej.Web.Button AddOrganization;
        private Wisej.Web.Button DeleteOrganization;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel2;
        private Wisej.Web.TextBox Title_Textbox;
        private Wisej.Web.TextBox FName_Textbox;
        private Wisej.Web.TextBox LName_Textbox;
        private Wisej.Web.TextBox Phone_Textbox;
        private Wisej.Web.TextBox Email_TextBox;
        private Wisej.Web.Button Add_Staff_Button;
        private Wisej.Web.Button Delete_Staff_Button;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel4;
        private Wisej.Web.Button Show_Staff_R_Button;
        private Wisej.Web.Button Show_Orgs_R_Button;
        private Wisej.Web.Button End_Relationship_Button;
        private Wisej.Web.Button Create_Relationship_Button;
        private Wisej.Web.TextBox Names_TextBox;
        private Wisej.Web.TextBox Street_TextBox;
        private Wisej.Web.TextBox ZIP_Textbox;
        private Wisej.Web.TextBox City_TextBox;
        private Wisej.Web.TextBox Country_TextBox;
        private Wisej.Web.ContextMenu contextMenu2;
        private Wisej.Web.TextBox Organization_Relationships;
        private Wisej.Web.TextBox Staff_Relationships;
        private Wisej.Web.ContextMenu contextMenu3;
    }
}

