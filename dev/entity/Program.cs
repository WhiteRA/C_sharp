

namespace entity
{
 
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MessagingContext())
            {
                
                context.Database.EnsureCreated();

                
                if (!context.Users.Any())
                {
                    var user = new User { Username = "JohnDoe" };
                    context.Users.Add(user);
                    context.Messages.Add(new Message { Content = "Hello, John!", IsRead = false, SentDate = DateTime.Now, User = user });
                    context.Messages.Add(new Message { Content = "New update available.", IsRead = false, SentDate = DateTime.Now, User = user });
                    context.SaveChanges();
                }

                
                var service = new MessageService(context);

                
                var unreadMessages = service.GetUnreadMessages(1);

                
                Console.WriteLine("Unread Messages:");
                foreach (var message in unreadMessages)
                {
                    Console.WriteLine($"{message.MessageId}: {message.Content} (Sent: {message.SentDate})");
                }

               
                service.MarkMessagesAsRead(unreadMessages);

                
                var unreadMessagesAfterMarkingAsRead = service.GetUnreadMessages(1);
                Console.WriteLine("Unread Messages after marking as read: " + unreadMessagesAfterMarkingAsRead.Count);
            }
        }
    }

}
