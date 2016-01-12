using System.Collections.Generic;

namespace Lab1
{
    public class NameDay
    {
        public string Date { get; set; }
        public List<string> Names { get; set; }
        public NameDay(string date, List<string> names)
        {
            Date = date;
            Names = names; 
        }
    }
}