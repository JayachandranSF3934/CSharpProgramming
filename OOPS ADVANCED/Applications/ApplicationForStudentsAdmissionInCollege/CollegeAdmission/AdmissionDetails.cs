using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public enum AdmissionStatus {Default, Booked, Cancelled}
    public class AdmissionDetails
    {
        private static int s_admissionId = 1000;
        public string AdminssionId { get; }
        public string StudentId { get; }
        public string DepartmentID { get; set; }
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus { get; set; }

        //Paramerterized Constructor 
        public AdmissionDetails (string studentId, string departmentId , DateTime admisssionDate, AdmissionStatus admissionStatus)
        {
            s_admissionId++;
            AdminssionId = "AID" + s_admissionId;
            AdmissionDate = admisssionDate;
            AdmissionStatus = admissionStatus;
            DepartmentID = departmentId;
            StudentId = studentId;
        }


        // contructor for file classs
        public AdmissionDetails (string item)
        {
            string[] values = item.Split(',');
            s_admissionId = int.Parse(values[0].Remove(0,3));
            AdminssionId =values[0];
            AdmissionDate = DateTime.ParseExact(values[1],"dd/MM/yyyy",null);
            AdmissionStatus = Enum.Parse<AdmissionStatus>(values[2]);
            DepartmentID = values[3];
            StudentId = values[4];

        }

        
    }
}