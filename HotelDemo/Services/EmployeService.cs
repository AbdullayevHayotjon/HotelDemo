using HotelDemo.EmployeControl;
using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDemo.Services
{
    public class EmployeService
    {
        public string connectionString = "Server = localhost; Port = 5432; Username = postgres; Password = 300304; Database = postgres";
        public List<Employe> employes = new List<Employe>();
        public List<Employe> GetAllEmployes()
        {
            List<Employe> employes1 = new List<Employe>();
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            var sql = "SELECT * FROM employe ORDER BY id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employe employe = new Employe
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    LastName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    SureName = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    Age = reader.GetInt32(4),
                    EmpType = reader.GetString(5),
                    Salary = reader.GetInt32(6),
                    Login = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                    Password = reader.IsDBNull(8) ? string.Empty : reader.GetString(8)
                };
                employes1.Add(employe);
                employes.Add(employe);
            }
            cmd.Dispose();
            return employes1;
        }
        public List<Employe> GetSeachList(string search)
        {
            List<Employe> employesList = new List<Employe>();
            foreach (Employe employeItem in employes)
            {
                if (employeItem.Id.ToString().Contains(search) || employeItem.FirstName.ToLower().Contains(search.ToLower()) || employeItem.LastName.ToLower().Contains(search.ToLower()) || employeItem.SureName.ToLower().Contains(search.ToLower()) || employeItem.Age.ToString().Contains(search) || employeItem.EmpType.ToLower().Contains(search.ToLower()) || employeItem.Salary.ToString().Contains(search) || employeItem.Login.ToLower().Contains(search.ToLower()) || employeItem.Password.ToLower().Contains(search.ToLower()))
                {
                    employesList.Add(new Employe() { Id = employeItem.Id, FirstName = employeItem.FirstName, LastName = employeItem.LastName, SureName = employeItem.SureName, Age = employeItem.Age, EmpType = employeItem.EmpType, Salary = employeItem.Salary, Login = employeItem.Login, Password = employeItem.Password });
                }
            }
            return employesList;
        }
        public void EmployeAdd(Employe employe)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            var sql = "INSERT INTO employe (firstname, lastname, surename, age, employetype, salary, login, password) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("value1", employe.FirstName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("value2", employe.LastName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("value3", employe.SureName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("value4", employe.Age);
            cmd.Parameters.AddWithValue("value5", employe.EmpType);
            cmd.Parameters.AddWithValue("value6", employe.Salary);
            cmd.Parameters.AddWithValue("value7", employe.Login ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("value8", employe.Password ?? (object)DBNull.Value);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public void EmployeUpdate(Employe employe)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            var sql = "UPDATE employe SET firstname = @firstname, lastname = @lastname, surename = @surename, age = @age, employetype = @employetype, salary = @salary, login = @login, password = @password WHERE id = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("firstname", employe.FirstName);
            cmd.Parameters.AddWithValue("lastname", employe.LastName);
            cmd.Parameters.AddWithValue("surename", employe.SureName);
            cmd.Parameters.AddWithValue("age", employe.Age);
            cmd.Parameters.AddWithValue("employetype", employe.EmpType);
            cmd.Parameters.AddWithValue("salary", employe.Salary);
            cmd.Parameters.AddWithValue("login", employe.Login);
            cmd.Parameters.AddWithValue("password", employe.Password);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public void EmployeDelete(Employe employe)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            var sql = "DELETE FROM employe WHERE id = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", employe.Id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public bool CheckNumber(string str)
        {
            if (str.Length > 0)
            {
                int sanoq = 0;
                char FirstChar = '1';
                for (int i = 0; i < str.Length; i++)
                {
                    FirstChar = str[0];
                    if (str[i] >= 48 && str[i] <= 57)
                    {
                        sanoq++;
                    }
                }
                if (FirstChar != '0' && sanoq == str.Length)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckProbel(string str)
        {
            if (str.Length > 0)
            {
                int sanoq = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        sanoq++;
                    }
                }
                if (sanoq != str.Length)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckLogin(string login)
        {
            foreach(Employe employe in employes)
            {
                if(login == employe.Login)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
