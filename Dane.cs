using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace ConsoleApp1
{
    class Data
    {
        private string conString = "Data Source=10.2.11.101;Initial Catalog=Salon;Integrated Security=True";
        public void AddEmployee(Person Person)
        {
            string command = "INSERT INTO Pracownicy (Position, Name_Surname, Work_In_Experience_In_Years, Salary_zloty, Place_of_residence)" +
                $"VALUES('{Person.Position}','{Person.NameSurname}','{Person.WorkExp}','{Person.Salary}','{Person.Adress}')";
            ModData(command);
        }

        public void Delete(int nr)
        {
            string command = "DELETE FROM Pracownicy WHERE Id = '" + nr + "'";
            ModData(command);
        }

        public IEnumerable<Person> EmployesList()
        {
            string command = "SELECT Position, Name_Surname, Work_In_Experience_In_Years, Salary_zloty, Place_of_residence, Id FROM Pracownicy";
            DataRowCollection rows = Download(command);
            foreach (DataRow row in rows)
            {
                string position = row["Position"].ToString();
                string name = row["Name_Surname"].ToString();
                int exp = (int)row["Work_In_Experience_In_Years"];
                int salary = (int)row["Salary_zloty"];
                string adress = row["Place_of_residence"].ToString();

                Person person = new Person(position, name, exp, salary, adress)
                {
                    Id = (int)row["Id"]
                };

                yield return person;
            }
        }

        private DataRowCollection Download(string command)
        {
            using (SqlConnection sCon = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand(command, sCon);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds.Tables[0].Rows;
            }
        }

        private void ModData(string command)
        {
            SqlConnection sCon = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand(command, sCon);
            sCon.Open();
            cmd.ExecuteNonQuery();
            sCon.Close();
        }
    }
}