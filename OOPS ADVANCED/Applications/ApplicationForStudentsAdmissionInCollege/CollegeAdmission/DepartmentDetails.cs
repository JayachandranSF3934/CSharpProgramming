using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
        public class DepartmentDetails
    {
        private static int s_departmnetId = 100;
        public string DepartmentId { get; }
        public string DepartmentName { get; set; }
        public int NumberOfSeats { get; set; }

        public DepartmentDetails(string name, int seats)
        {
            s_departmnetId++;
            DepartmentId = "DID"+s_departmnetId;
            DepartmentName = name;
            NumberOfSeats = seats;
        }

        public DepartmentDetails(string dept)
        {
            string [] values = dept.Split(',');
            s_departmnetId = int.Parse(values[0].Remove(0,3));
            DepartmentId = values[0];
            DepartmentName = values[1];
            NumberOfSeats = int.Parse(values[2]);
        }

       
    }
}