using System;

namespace exam2review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Populate array of objects
            EmplTimeFile emplTimeFile = new EmplTimeFile("input.txt");
            EmplTime[] emplTimes = emplTimeFile.GetAllEmplTime();

            //sort
            EmplTimeUtility emplTimeUtility = new EmplTimeUtility(emplTimes);
            emplTimeUtility.SortByDepartment();

            //run reports
            EmplTimeReport emplTimeReport = new EmplTimeReport(emplTimes);
            emplTimeReport.RangeReport();
            emplTimeReport.BillPercentByDept();
        }
    }
}
