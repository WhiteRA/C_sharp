using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Client
    {
        private readonly IMessageService _messageService;

        public Client(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public List<Message> GetUnreadMessages(int userId)
        {
            return _messageService.GetUnreadMessages(userId);
        }

        public void MarkMessagesAsRead(List<Message> messages)
        {
            _messageService.MarkMessagesAsRead(messages);
        }
    }
}
