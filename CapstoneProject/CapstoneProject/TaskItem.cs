using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    public class TaskItem
    {
        public string Location { get; set; }
        public string Time { get; set; }
        public string Workers { get; set; }

        public override string ToString()
        {
            return Location;
        }
    }
}
