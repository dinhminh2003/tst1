using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace tst1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string BornDate { get; set; }
        public float WaveDay { get; set; }
        public int WorkDay { get; set; }
        public float Total
        {
            get
            {
                if(WorkDay <=24)
                {
                    return WaveDay * WorkDay;
                }
                else
                {
                    return WaveDay * (WorkDay + (WorkDay - 24) * 2);
                }
            }
        }
        public void nhapTT(int id, string name,string gender , DatePicker borndate, float waveday, int workday )  
        {
            Id = id;
            Name = name;
            Gender = gender;
            BornDate = borndate.ToString();
            WaveDay = waveday;
            WorkDay = workday;

        }
    }
}
