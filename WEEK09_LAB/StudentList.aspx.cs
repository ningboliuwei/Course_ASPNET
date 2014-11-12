using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace 基本ADONET对象的使用
{
    public partial class StudentList : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string connectionString = "data source=127.0.0.1;database=school;uid=sa;pwd=liuxiaozeng";


                string commandText =
                    string.Format(
                        @"SELECT StudentID, Name, Gender, DayOfBirth, Address, Department FROM Student");

                try
                {
                    var connection = new SqlConnection(connectionString);
                    var command = new SqlCommand(commandText, connection);

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    SqlDataReader reader = command.ExecuteReader();

                    var dataTable = new DataTable();
                    dataTable.Columns.Add("No", typeof (int));
                    dataTable.Columns.Add("StudentID", typeof (string));
                    dataTable.Columns.Add("Name", typeof (string));
                    dataTable.Columns.Add("Gender", typeof (string));
                    dataTable.Columns.Add("DayOfBirth", typeof (string));
                    dataTable.Columns.Add("Address", typeof (string));
                    dataTable.Columns.Add("Department", typeof (string));


                    int i = 1;

                    while (reader.Read())
                    {
                        DataRow row = dataTable.NewRow();
                        row["No"] = i;
                        row["StudentID"] = reader["StudentID"];
                        row["Name"] = reader["Name"];
                        row["Gender"] = reader["Gender"];
                        row["DayOfBirth"] = Convert.ToDateTime(reader["DayOfBirth"]).ToString("yyyy-MM-dd");
                        row["Address"] = reader["Address"];
                        row["Department"] = reader["Department"];
                        dataTable.Rows.Add(row);
                        i++;
                    }
                    connection.Close();

                    gridStudent.DataSource = dataTable;
                    gridStudent.DataBind();
                }
                catch (Exception exception)
                {
                    Response.Write(exception.Message);
                    throw;
                }
            }
        }
    }
}