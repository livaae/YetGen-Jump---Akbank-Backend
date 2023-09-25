using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2_4.Abstract;
using Week2_4.Common;

namespace Week2_4.Entities
{
    internal class Todo :Event, INotification
    {
   
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time to make this To-Do: {Title}");
        }
    }
}
