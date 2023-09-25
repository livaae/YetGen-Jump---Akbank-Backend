using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2_4.Abstract;
using Week2_4.Common;

namespace Week2_4.Entities
{
    internal class Meeting : Event, INotification
    {
     
        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (var guest in Guests)
            {
                Console.WriteLine($"Inviting: {guest}");
            }
        }
    }
}
