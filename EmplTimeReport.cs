using System;

namespace exam2review
{
    public class EmplTimeReport
    {
        private EmplTime[] emplTimes;

        public EmplTimeReport(EmplTime[] emplTimes){
            this.emplTimes = emplTimes;
        }
        public void RangeReport(){
            // Sample Case Question 2 goes here
            double min = emplTimes[0].GetBillTime();
            double max = emplTimes[0].GetBillTime();
            double sum = emplTimes[0].GetBillTime();
            double count = 1;

            for(int i = 1; i<EmplTime.GetCount(); i++){
                if(emplTimes[i].GetBillTime() < min){
                    min = emplTimes[i].GetBillTime();
                }
                if(emplTimes[i].GetBillTime() > max){
                    max = emplTimes[i].GetBillTime();
                }
                sum += emplTimes[i].GetBillTime();
                count++;
            }
            double range = max - min;
            double average = sum / count;
            Console.WriteLine($"The range is {range}.  The average is {average}");

        }

        public void BillPercentByDept(){
            //Sample Case Question 3 goes here
            double sum = emplTimes[0].GetBillPercent();
            int count = 1;
            string currDept = emplTimes[0].GetDept();

            for(int i = 1; i < EmplTime.GetCount(); i++){
                if(emplTimes[i].GetDept() == currDept){
                    sum += emplTimes[i].GetBillPercent();
                    count++;
                } else{
                    ProcessBreak(ref currDept, ref sum, ref count, i);
                }
            }

            ProcessBreak(ref currDept, ref sum, ref count, 0);

        }

        public void ProcessBreak(ref string currDept, ref double sum, ref int count, int i){
            double average = sum/count;
            Console.WriteLine($"The average for department {currDept} is {average}");

            currDept = emplTimes[i].GetDept();
            sum = emplTimes[i].GetBillPercent();
            count = 1;

        }
    }
}