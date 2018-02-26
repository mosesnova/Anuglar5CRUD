using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Angular5CRUD.Models
{
    public class EmployeeDataAccessLayer
    {
        string connectionString = "Data Source = NAOMI; Initial Catalog = Employee; Integrated Security = True";

        public IEnumerable<Employee> GetAllEmployee()
        {
            List<Employee> empList = new List<Employee>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                
                SqlCommand cmd = new SqlCommand("select * from Employee", con);
                cmd.CommandType = System.Data.CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    Employee emp = new Employee();
                    emp.Emp_Name = rdr["Emp_Name"].ToString();
                    empList.Add(emp);
                }

            }
            return empList;
        }
    }
}
