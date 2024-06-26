using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public interface IMessageService
    {
        List<Message> GetUnreadMessages(int userId);
        void MarkMessagesAsRead(List<Message> messages);
    }
}
