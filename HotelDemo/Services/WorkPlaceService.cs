using HotelDemo.EmployeControl;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HotelDemo.Services
{
    public class WorkPlaceService
    {
        EmployeService employeService = new EmployeService();
        public List<WorkPlace> workPlaceList = new List<WorkPlace>();
        public List<WorkPlace> GetAllWorkPlace()
        {
            NpgsqlConnection conn = new NpgsqlConnection(employeService.connectionString);
            conn.Open();
            var sql = "SELECT * FROM workplace ORDER BY id";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                WorkPlace workPlace = new WorkPlace
                {
                    Id = reader.GetInt32(0),
                    Type = reader.GetString(1),
                    Price = reader.GetInt32(2)
                };
                workPlaceList.Add(workPlace);
            }
            cmd.Dispose();
            return workPlaceList;
        }
        public List<string> GetAllType()
        {
            List<string> types = new List<string>();
            foreach(WorkPlace workPlace in workPlaceList)
            {
                types.Add(workPlace.Type);
            }
            return types;
        }
        public int GetPrice(string employeType)
        {
            foreach(WorkPlace workPlace in workPlaceList)
            {
                if(employeType == workPlace.Type)
                {
                    return workPlace.Price;
                }
            }
            return 0;
        }
    }
}
