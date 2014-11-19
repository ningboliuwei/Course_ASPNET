using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataGenerator : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void btnGenerate_Click(object sender, EventArgs e)
	{
		string[] firstNames = { "赵", "钱", "孙", "李", "周", "吴", "郑", "王" };
		string[] lastNames = { "一", "二", "三", "四", "五", "大", "小", "胖", "瘦", "明", "毛" };
		string[] genders = { "男", "女" };
		string[] departments = { "1", "2", "3", "4" };
		string[] cities = { "北京市", "上海市", "宁波市", "杭州市" };
		string[] roads = { "人民路", "解放路", "中山路", "和平路", "民主路" };

		Random random = new Random();

		int count = 20;
		for (int i = 0; i < count; i++)
		{
			//Random.Next(x, y) 随机产生一个大于等于 x 且小于 y 的带符号整数
			string randomStudentID = random.Next(1, 99999).ToString("#####");
			string randomName = firstNames[Convert.ToInt32(random.Next(0, firstNames.Length))] +
								lastNames[Convert.ToInt32(random.Next(0, lastNames.Length))];
			string randomGender = genders[Convert.ToInt32(random.Next(0, genders.Length))];
			string randomDepartment = departments[Convert.ToInt32(random.Next(0, departments.Length))];
			string randomAddress = cities[Convert.ToInt32(random.Next(0, cities.Length))] + roads[Convert.ToInt32(random.Next(0, roads.Length))] +
								   (Convert.ToInt32(random.Next(0, 1000))) + "号";
			string randomPhoto = random.Next(1, 11) + ".png";
			string randomDayOfBirth = Convert.ToDateTime("1990-1-1").AddDays(random.Next(0, 1500)).ToString();

			string commandText =
				String.Format(
					"INSERT INTO Student(StudentID, Name, Gender, DayOfBirth, Address, DepartmentID, Photo) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
					randomStudentID, randomName, randomGender, randomDayOfBirth, randomAddress, randomDepartment,
					randomPhoto);
			using (SqlConnection connection = SqlHelper.GetConnection())
			{
				try
				{
					if (connection.State != ConnectionState.Open)
					{
						connection.Open();
					}

					SqlCommand command = new SqlCommand(commandText, connection);
					command.ExecuteNonQuery();
					Response.Write("成功生成" + count.ToString() + "条数据。");
				}
				catch (Exception ex)
				{

					throw new Exception(ex.Message);
				}
				finally
				{
					if (connection != null)
					{
						connection.Close();
					}
				}

			}

		}
	}
}