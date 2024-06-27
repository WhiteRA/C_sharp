using MessageService.Data;
using MessageService.Dtos;
using MessageService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MessageService.Services
{
    public class MessageService : IMessageService
    {
        private readonly MessageDbContext _context;

        public MessageService(MessageDbContext context)
        {
            _context = context;
        }

        public ServiceResult SendMessage(MessageDto messageDto)
        {
            var message = new Message
            {
                Id = Guid.NewGuid(),
                SenderId = messageDto.SenderId,
                ReceiverId = messageDto.ReceiverId,
                Content = messageDto.Content,
                Timestamp = DateTime.UtcNow,
                IsRead = false
            };

            _context.Messages.Add(message);
            _context.SaveChanges();

            return new ServiceResult { Success = true, Message = "Message sent successfully" };
        }

        public IEnumerable<Message> GetMessages(Guid userId)
        {
            return _context.Messages
                .Where(m => m.ReceiverId == userId && !m.IsRead)
                .ToList();
        }
    }
}
