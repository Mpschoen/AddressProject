using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using AddressesProject;
using Microsoft.Ajax.Utilities;

static class SQL_Backend
{
	static SQLiteConnection sql_Connection;
	static bool connected = false;
	//List<String> tables;

    public static void InitializeBackend()
	{
		//this.tables = tables;
		connected = CreateConnection();
		if (!connected)
		{
			Console.Error.WriteLine("Failed to connect to SQLite.");
			return;
		}
	}

	public static void Close()
	{
		if (connected)
		{
            sql_Connection.Close();
        }
	}

	public static List<Organization> RetrieveOrganizations()
	{
		List<Organization> ret = sql_Connection.Query<Organization>("SELECT * FROM organizations");
		return ret; 
	}

    public static List<Staff> RetrieveStaff()
    {
        List<Staff> ret = sql_Connection.Query<Staff>("SELECT * FROM staff");
        return ret;
    }

    public static List<Relation> RetrieveRelations()
    {
        List<Relation> ret = sql_Connection.Query<Relation>("SELECT * FROM relations");
        return ret;
    }

    public static void AddToTables(Var varToAdd)
    {
        sql_Connection.Insert(varToAdd);
    }

    public static void AddOrganization(Organization org)
    {

        sql_Connection.Insert(org);
    }

    public static void RemoveOrganization(Organization org)
    {
        sql_Connection.Delete(org);
    }

    public static void AddStaff(Staff staff)
    {
        sql_Connection.Insert(staff);
    }

    public static void RemoveStaff(Staff staff)
    {
        sql_Connection.Delete(staff);
    }

    public static void AddRelation(Relation relation)
    {
        sql_Connection.Insert(relation);
    }

    public static void RemoveRelation(Relation relation)
    {
        sql_Connection.Delete(relation);
    }

    private static bool CreateConnection()
	{
		try
		{
            string path = System.IO.Directory.GetCurrentDirectory().ToString() + "\\Databases\\database.db";
            sql_Connection = new SQLiteConnection(path);
            sql_Connection.CreateTable<Organization>();
            sql_Connection.CreateTable<Staff>();
            sql_Connection.CreateTable<Relation>();

            //if (sql_Connection.Table<Organization>() == null)
            //{
            //    sql_Connection.CreateTable<Organization>();
            //}

            //if (sql_Connection.Table<Staff>() == null)
            //{
            //    sql_Connection.CreateTable<Staff>();
            //}

            //if (sql_Connection.Table<Relation>() == null)
            //{
            //    sql_Connection.CreateTable<Relation>();
            //}
        }
		catch (Exception ex)
		{
            return false;
        }
		return true;

    }
}

[Table("Organizations")]
class Organization
{
    [Column("name")]
    public string name { get; set; }
    [Column("street")]
    public string street { get; set; }
    [Column("zip")]
    public int zip { get; set; }
    [Column("city")]
    public string city { get; set; }
    [Column("country")]
    public string country { get; set; }
    [PrimaryKey, Column("id")]
    public int id { get; set; }

    public List<Relation> relations { get; private set; } = new List<Relation>();

    public Organization()
    {

    }

    public Organization(string name, string street, int zip, string city, string country)
    {
        assignName(name);
        assignStreet(street);
        assignZip(zip);
        assignCity(city);
        assignCountry(country);

        string idString = name + street + zip.ToString() + city + country;
        id = idString.GetHashCode();
    }

    public void assignName(string name)
    {
        this.name = name;
    }

    public void assignStreet(string street)
    {
        this.street = street;
    }

    public void assignZip(int zip)
    {
        this.zip = zip;
    }

    public void assignCity(string city)
    {
        this.city = city;
    }

    public void assignCountry(string country)
    {
        this.country = country;
    }

    public string getNumEmployees()
    {
        string employees;
        int num = relations.Count;
        switch (num)
        {
            case 0:
                employees = "No employees";
                break;
            case 1:
                employees = "1 employee";
                break;
            default:
                employees = num.ToString() + " employees.";
                break;
        }
        return employees;
    }
}

[Table("Staff")]
class Staff
{
    [Column("title")]
    public string title { get; set; }
    [Column("fName")]
    public string fName { get; set; }
    [Column("lName")]
    public string lName { get; set; }
    [Column("phoneNumber")]
    public string phoneNumber { get; set; }
    [Column("email")]
    public string email { get; set; }
    [PrimaryKey, Column("id")]
    public int id { get; set; }

    public List<Relation> relations = new List<Relation>();

    public Staff()
    {

    }

    public Staff(string title, string fName, string lName, string phoneNumber, string email)
    {
        assignTitle(title);
        assignFName(fName);
        assignLName(lName);
        assignPhonenumber(phoneNumber);
        assignEmail(email);

        string idString = title + fName + lName + phoneNumber + email;
        id = idString.GetHashCode();
    }

    public void assignTitle(string title)
    {
        this.title = title;
    }
    public void assignFName(string name)
    {
        fName = name;
    }
    public void assignLName(string name)
    {
        lName = name;
    }
    public void assignPhonenumber(string num)
    {
        phoneNumber = num;
    }
    public void assignEmail(string email)
    {
        this.email = email;
    }
}

[Table("Relations")]
class Relation
{
    public Organization org { get; private set; }
    public Staff staff { get; private set; }

    [Column("organization_id")]
    public int orgID { get; set; }
    [Column("staff_id")]
    public int staffID { get; set; }
    [PrimaryKey, Column("id")]
    public int id { get; set; }
    
    public Relation()
    {

    }

    public Relation(Organization org, Staff staff)
    {
        this.org = org;
        this.staff = staff;
        //this.org.relations.Add(this);
        //this.staff.relations.Add(this);

        orgID = org.id;
        staffID = staff.id;

        string idString = orgID.ToString() + staffID.ToString();
        id = idString.GetHashCode();
    }

    public void CreateRelationship(Organization org, Staff staff)
    {
        this.org = org;
        this.staff = staff;
        orgID = org.id;
        staffID = staff.id;
        string idString = orgID.ToString() + staffID.ToString();
        id = idString.GetHashCode();
        ValidateRelation();
    }

    public void ValidateRelation()
    {
        org.relations.Add(this);
        staff.relations.Add(this);
    }
}

