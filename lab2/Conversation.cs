using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Conversation
    {
        public int Id { get; set; }
        public int AbonentId { get; set; }
        public int CityId { get; set; }
        public DateTime DateConversation { get; set; }
        public int Duration { get; set; }
        public Abonent Abonent { get; set; }
        public City City { get; set; }
    }
}
