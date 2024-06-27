using MessageService.Dtos;
using MessageService.Models;
using System.Collections.Generic;

namespace MessageService.Services
{
    public interface IMessageService
    {
        ServiceResult SendMessage(MessageDto messageDto);
        IEnumerable<Message> GetMessages(Guid userId);
    }
}

