using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOO_lab1
{
    public class Event
    {
        private string name;
        private DateTime dateTime;
        private string adressee;

        public Event(string Name, DateTime dateTime, string adressee)
        {
            this.name = Name;
            this.dateTime = dateTime;
            this.adressee = adressee;
        }

        public string getName() => name;
        public DateTime getDateTime() => dateTime;
        public string getAdressee() => adressee;

    }
}
