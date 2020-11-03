namespace exam2review
{
    public class EmplTimeUtility
    {
        private EmplTime[] emplTimes;
        public EmplTimeUtility(EmplTime[] emplTimes){
            this.emplTimes = emplTimes;
        }
        public void SortByDepartment(){
            for(int i = 0; i < EmplTime.GetCount() - 1; i++){
                int minIndex = i;
                for(int j=i+1; j < EmplTime.GetCount(); j++){
                    if(emplTimes[minIndex].CompareDept(emplTimes[j]) < 0){
                        minIndex = j;
                    }
                }

                if(minIndex != i){
                    Swap(minIndex, i);
                }
            }
        }

        public void Swap(int x, int y){
            EmplTime temp = emplTimes[x];
            emplTimes[x] = emplTimes[y];
            emplTimes[y] = temp;
        }
    }
}