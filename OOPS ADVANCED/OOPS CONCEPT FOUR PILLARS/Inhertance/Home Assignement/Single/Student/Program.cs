using System;
namespace Student{
class Program{
    public static void Main(string[] args)
    {
        PersonDetails jai = new PersonDetails("jai","yvuvi",87676776567,"jai@444",new DateTime(2022,11,22),Gender.Male);
        jai.ShowPersonDetail();
       


        // show student details

        StudentDetails jaic = new StudentDetails("jai","jc",994959595,"jjai@",new DateTime(2011,12,22),Gender.Male,"2nd",Branch.Science);
        jaic.ShowStudentDetails();
    }
}
}
