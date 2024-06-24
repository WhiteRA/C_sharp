using System;
using System.Collections.Generic;
using System.Linq;

public class MessageService
{
    private readonly MessagingContext _context;

    public MessageService(MessagingContext context)
    {
        _context = context;
    }

    public List<Message> GetUnreadMessages(int userId)
    {
        return _context.Messages
                       .Where(m => m.UserId == userId && !m.IsRead)
                       .ToList();
    }

    public void MarkMessagesAsRead(List<Message> messages)
    {
        foreach (var message in messages)
        {
            message.IsRead = true;
        }
        _context.SaveChanges();
    }
}

