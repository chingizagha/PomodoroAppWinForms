using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class TimeCounter
    {
        public int Seconds { get; set; }

        public DateTime LeftTime { get; set; }

        public void AddSecondsToLeftTime()
        {
            LeftTime = DateTime.Now.AddMinutes(Seconds);
        }
    }
}
