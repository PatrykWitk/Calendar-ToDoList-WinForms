using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarPWinForm
{
    class Event
    {
        public Event( string note, DateTime dateofMeet)
        {
            this.note = note;
            this.dateofMeet = dateofMeet;
        }

        public Event()
        {
            this.note = note;
            this.dateofMeet = dateofMeet;
        }
        public string note { get; set; }

        public DateTime dateofMeet { get; set; }

        public string GetNote()
        {
            return note;
        }
        public void SetNote(string note)
        {
            this.note = note;
        }

        public DateTime GetDate()
        {
            return dateofMeet;
        }
        public void SetDate(DateTime dateofMeet)
        {
            this.dateofMeet = dateofMeet;
        }
    }
}
