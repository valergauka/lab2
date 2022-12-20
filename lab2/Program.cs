using System;

namespace lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (ConversationContext db = new ConversationContext())
            {
                var conversations = from conversation in db.Conversations
                                    join abonent in db.Abonents on conversation.AbonentId equals abonent.Id
                                    join city in db.Cities on conversation.CityId equals city.Id
                                    select new
                                    {
                                        Abonent = abonent.FisrtName,
                                        City = city.Name,
                                        DateConversation = conversation.DateConversation,
                                        Duration = conversation.Duration,
                                    };
                Console.WriteLine("{0,-30} {1,-15} {2,-20} {3,-15}\n", "Abonent", "City", "Date of Conversation", "Durate");
                foreach (var conversation in conversations)
                {
                    Console.WriteLine("{0,-30} {1,-15} {2,-20} {3,-15}", conversation.Abonent, conversation.City, conversation.DateConversation, conversation.Duration);
                }
            }
            Console.Read();
        }
    }
}
