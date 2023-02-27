using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarPWinForm
{
    class FileManager
    {
        public static void Load(string file, List<Event> events)
        {
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string yez = line.Substring(0).Split(';')[0];
                DateTime zez = DateTime.Parse(line.Substring(1).Split(';')[1]);
                Event newEvent = new Event(yez, zez);
                events.Add(newEvent);
            }
        }

        public static void Export(string file, List<Event> events)
        {
            List<string> eventsToString = new List<string>();
            foreach (Event x in events)
            {
                eventsToString.Add(x.GetNote() + ";" + x.GetDate().ToString("D"));
            }

            File.WriteAllLines(file, eventsToString);
        }

    }
}
