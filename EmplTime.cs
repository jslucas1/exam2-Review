using System.Globalization;
using System.Runtime.CompilerServices;
namespace exam2review
{
    public class EmplTime
    {
        private string emplID;
        private string dept;
        private double billTime;
        private double adminTime;
        private double billPercent;
        private static int count;
        //No Arg Constructor
        public EmplTime(){

        }
        //Overloaded Constructor
        public EmplTime(string emplID, string dept, double billTime, double adminTime, double billPercent)
        {
            this.emplID = emplID;
            this.dept = dept;
            this.billTime = billTime;
            this.adminTime = adminTime;
            this.billPercent = billPercent;
        }

        //Getters and Setters for each field
        public string GetEmplID(){
            return emplID;
        }
        public void SetEmplID(string emplID){
            this.emplID = emplID;
        }

        public string GetDept(){
            return dept;
        }
        public void SetDept(string dept){
            this.dept = dept;
        }

        public double GetBillTime(){
            return billTime;
        }
        public void SetBillTime(double billTime){
            this.billTime = billTime;
        }

        public double GetAdminTime(){
            return adminTime;
        }
        public void SetAdminTime(double adminTime){
            this.adminTime = adminTime;
        }

        public double GetBillPercent(){
            return billPercent;
        }
        public void SetBillPercent(double billPercent){
            this.billPercent = billPercent;
        }
        public static int GetCount(){
            return count;
        }

        public void SetCount(int tempCount){
            count = tempCount;
        }

        public static void IncCount(){
            count++;
        }

        public int CompareDept(EmplTime compareObj){
            return this.dept.CompareTo(compareObj.GetDept());
        }
    }
}