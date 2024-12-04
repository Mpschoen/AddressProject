
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using Wisej.Web;

namespace AddressesProject
{
    public partial class Window1 : Page
    {
        public Window1()
        {
            InitializeComponent();
        }

        BindingList<Organization> organizations = new BindingList<Organization>();
        BindingList<Staff> staffers = new BindingList<Staff>();
        BindingList<Relation> relationships = new BindingList<Relation>();

        private void Window1_Load(object sender, EventArgs e)
        {
            SQL_Backend.InitializeBackend();
            organizations = new BindingList<Organization>(SQL_Backend.RetrieveOrganizations());
            staffers = new BindingList<Staff>(SQL_Backend.RetrieveStaff());
            relationships = new BindingList<Relation>(SQL_Backend.RetrieveRelations());
            OrganizationsList.DataSource = organizations;
            StaffList.DataSource = staffers;

            foreach (Relation relation in relationships)
            {
                Organization org = null;
                Staff staff = null;

                foreach (Organization o in organizations)
                {
                    if (o.id == relation.orgID)
                    {
                        org = o;
                        break;
                    }
                }

                foreach (Staff s in staffers)
                {
                    if (s.id == relation.staffID)
                    {
                        staff = s;
                        break;
                    }
                }
                if (org != null && staff != null)
                {
                    relation.CreateRelationship(org, staff);
                }
            }

        }

        private void Organizations_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Organization org = new Organization("hehoo pingus", "streety mcStreetface", 27272727, "citysville", "The smack of the middle of the dab");
            organizations.Add(org);
            organizations.ResetBindings();
            SQL_Backend.AddOrganization(org);
        }

        private void tableLayoutPanel1_PanelCollapsed(object sender, EventArgs e)
        {

        }

        private void AddOrganization_Click(object sender, EventArgs e)
        {
            string name = Names_TextBox.Text;
            string street = Street_TextBox.Text;
            string zipString = ZIP_Textbox.Text;
            string city = City_TextBox.Text;
            string country = Country_TextBox.Text;

            int zip;

            if (name == "" || street == "" || !int.TryParse(zipString, out zip) || city == "" || country == "")
            {
                AlertBox.Show("Invalid input!");
                return;
            }

            Organization org = new Organization(name, street, zip, city, country);
            organizations.Add(org);
            organizations.ResetBindings();
            SQL_Backend.AddOrganization(org);
            
        }

        private void DeleteOrganization_Click(object sender, EventArgs e)
        {
            OrganizationsList.SelectedRows.ToList().ForEach(row =>
            {
                int index = row.Index;
                Organization org = organizations[index];
                if (org != null)
                {
                    organizations.Remove(org);
                    SQL_Backend.RemoveOrganization(org);
                }
            });

            Organization_Relationships.Text = "";
            Organization_Relationships.Update();
        }

        private void Add_Staff_Button_Click(object sender, EventArgs e)
        {
            string title = Title_Textbox.Text;
            string fName = FName_Textbox.Text;
            string lName = LName_Textbox.Text;
            string phone = Phone_Textbox.Text;
            string email = Email_TextBox.Text;

            if (title == "" || fName == "" || lName == "" || phone == "" || email == "")
            {
                AlertBox.Show("Invalid input!");
                return;
            }

            Staff newStaff = new Staff(title, fName, lName, phone, email);
            staffers.Add(newStaff);
            staffers.ResetBindings();
            SQL_Backend.AddStaff(newStaff);
        }

        private void Delete_Staff_Button_Click(object sender, EventArgs e)
        {
            StaffList.SelectedRows.ToList().ForEach(row =>
            {
                int index = row.Index;
                Staff removedStaff = staffers[index];
                if (removedStaff != null)
                {
                    staffers.Remove(removedStaff);
                    SQL_Backend.RemoveStaff(removedStaff);
                }
            });

            Staff_Relationships.Text = "";
            Staff_Relationships.Update();
        }

        private void tableLayoutPanel4_PanelCollapsed(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Create_Relationship_Button_Click(object sender, EventArgs e)
        {
            OrganizationsList.SelectedRows.ToList().ForEach(orgRow =>
            {
                Organization org = organizations[orgRow.Index];
                if (org != null)
                {
                    StaffList.SelectedRows.ToList().ForEach(staffRow =>
                    {
                        Staff selectedStaff = staffers[staffRow.Index];
                        if (selectedStaff != null)
                        {
                            Relation r = new Relation(org, selectedStaff);

                            if (!relationships.Contains(r))
                            {
                                r.ValidateRelation();
                                relationships.Add(r);
                                SQL_Backend.AddRelation(r);
                            }
                        }
                    });
                }
            });
            Staff_Relationships.Text = "";
            Organization_Relationships.Text = "";
            Organization_Relationships.Update();
            Staff_Relationships.Update();
        }

        private void End_Relationship_Button_Click(object sender, EventArgs e)
        {
            OrganizationsList.SelectedRows.ToList().ForEach(orgRow =>
            {
                Organization org = organizations[orgRow.Index];
                if (org != null)
                {
                    StaffList.SelectedRows.ToList().ForEach(staffRow =>
                    {
                        Staff selectedStaff = staffers[staffRow.Index];
                        if (selectedStaff != null)
                        {
                            Relation r = null;
                            foreach (Relation r2 in relationships)
                            {
                                if (r2.orgID == org.id && r2.staffID == selectedStaff.id)
                                {
                                    r = r2;
                                    break;
                                }
                            }

                            if (r != null)
                            {
                                AlertBox.Show(relationships.Remove(r).ToString());
                                SQL_Backend.RemoveRelation(r);
                            }
                        }
                    });
                }
            });
            Staff_Relationships.Text = "";
            Organization_Relationships.Text = "";
            Organization_Relationships.Update();
            Staff_Relationships.Update();
        }

        private void Show_orgs_R_Button_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> orgs = OrganizationsList.SelectedRows.ToList();
            if (orgs.Count != 1)
            {
                AlertBox.Show("Ensure you've selected exactly one organization!");
                return;
            }

            Organization org = organizations[orgs[0].Index];

            if (org != null)
            {
                Organization_Relationships.Text = "";
                foreach (Relation r in org.relations)
                {
                    if (relationships.Contains(r) && staffers.Contains(r.staff))
                    {
                        Organization_Relationships.Text += r.staff.fName + " " + r.staff.lName + "\n";
                        Organization_Relationships.Update();
                    }
                }
            }
        }

        private void Show_Staff_R_Button_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> staff = StaffList.SelectedRows.ToList();
            if (staff.Count != 1)
            {
                AlertBox.Show("Ensure you've selected exactly one staff member!");
                return;
            }

            Staff s = staffers[staff[0].Index];

            if (s != null)
            {
                Staff_Relationships.Text = "";
                foreach (Relation r in s.relations)
                {
                    if (relationships.Contains(r) && organizations.Contains(r.org))
                    {
                        Staff_Relationships.Text += r.org.name + " (" + r.org.zip.ToString() + ")" + "\n";
                        Staff_Relationships.Update();
                    }
                }
            }
        }
    }
}
