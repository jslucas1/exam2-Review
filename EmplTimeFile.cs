using System.Security.AccessControl;
using System.IO;

namespace exam2review
{
    public class EmplTimeFile
    {
        private string fileName;

        public EmplTimeFile(string fileName){
            this.fileName = fileName;
        }
        public string GetFileName(){
            return fileName;
        }
        public void SetFileName(string fileName){
            this.fileName = fileName;
        }

        public EmplTime[] GetAllEmplTime(){
            EmplTime[] myArray = new EmplTime[100];
            //Open
            StreamReader inFile = new StreamReader(fileName);

            //Process
            string input = inFile.ReadLine(); // priming read
            while(input != null){
                string[] temp = input.Split('#');
                double tempBillTime = double.Parse(temp[2]);
                double tempAdmimTime = double.Parse(temp[3]);
                double billPercent = tempBillTime / (tempBillTime + tempAdmimTime);
                myArray[EmplTime.GetCount()] = new EmplTime(temp[0], temp[1], tempBillTime, tempAdmimTime, billPercent);
                EmplTime.IncCount();

                //update Read
                input = inFile.ReadLine();
                
            }

            //Close
            inFile.Close();

            return myArray;

        }
    }
}