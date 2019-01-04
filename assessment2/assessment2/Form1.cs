using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment2
{
    public partial class Form1 : Form
    {
        Employee employee;
        int ID = 0;
        SqlDataAdapter adapt;    // sqldataadapter object to to get the datafrom data source
        SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.44\MSSQLSERVER_2017;Initial Catalog=CDAC;Persist Security Info=True;User ID=cdacdev;Password=cdacdev123#");
        SqlCommand command;            //sql command object
        public Form1()
        {
            InitializeComponent();
            DisplayData();   //call function display data
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDACData.EmployeeDetails' table. You can move, or remove it, as needed.
            this.employeeDetailsTableAdapter.Fill(this.cDACData.EmployeeDetails);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)          //grid view function to display table data
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtempname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtempage.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdeapartment.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void DisplayData()   //defination of display data function
        {
            DataTable dt = new DataTable();  //creating object of data table
            adapt = new SqlDataAdapter("select * from EmployeeDetails", connection);  //query to display all records in data grid
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        { }
        private void txtName_TextChanged(object sender, EventArgs e)
        { }
        private void btninsert_Click(object sender, EventArgs e)
        {
            employee = new Employee(txtempname.Text.ToString(), Convert.ToInt32(txtempage.Text), txtdeapartment.Text.ToString()); //employee class constructor call
            connection.Open();    //to open connection with database
            string insert = "insert into EmployeeDetails(EmpName,EmpAge,Department) values(@empname,@empage,@empdepartment)"; //sql insert query
            command = new SqlCommand(insert, connection);
            command.Parameters.AddWithValue("@empname", employee.empName);// add parametre by specifying its name and value
            command.Parameters.AddWithValue("@empage", employee.empAge);
            command.Parameters.AddWithValue("@empdepartment", employee.deapartment);
            command.CommandType = CommandType.Text;
            int i = command.ExecuteNonQuery();    //sql stmt against the connection and returns the number of rows affected
            MessageBox.Show(i + " Row(s) Inserted ");
            DisplayData();         //to display data on grid
            connection.Close();      //close the connection with database after inserting data
        }
        private void txtampage_TextChanged(object sender, EventArgs e)
        { }
        private void btnupdate_Click(object sender, EventArgs e)    //method of update button
        {
            SqlCommand command;
            employee = new Employee(txtempname.Text.ToString(), Convert.ToInt32(txtempage.Text), txtdeapartment.Text.ToString());
            string update = "update EmployeeDetails set EmpName=@empname,EmpAge=@empage,Department=@empdepartment where EmpId=@empId";
            connection.Open();    //open connection with database
            command = new SqlCommand(update, connection);
            command.Parameters.AddWithValue("@empId", ID);
            command.Parameters.AddWithValue("@empname", employee.empName);  // add parametre by specifying its name and value
            command.Parameters.AddWithValue("@empage", employee.empAge);
            command.Parameters.AddWithValue("@empdepartment", employee.deapartment);
            command.CommandType = CommandType.Text;
            int i = command.ExecuteNonQuery();//sql stmt against the connection and returns the number of rows affected
            DisplayData();//to display data on grid
            MessageBox.Show(i + " Row(s) updated ");
            connection.Close();//close the connection with database after updating  data
        }

        private void btndelete_Click(object sender, EventArgs e)   //method of delete button
        {
            command = new SqlCommand("delete EmployeeDetails where EmpId=@id", connection);   //delete query
            connection.Open();
            command.Parameters.AddWithValue("@id", ID);
            command.ExecuteNonQuery();//sql stmt against the connection and returns the number of rows affected
            connection.Close();//close the connection with database after deleting  data
            MessageBox.Show("Record Deleted Successfully!");
            DisplayData();//to display data on grid
        }
    }
}
