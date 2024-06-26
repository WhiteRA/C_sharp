using Moq;
using System.Collections.Generic;
using Xunit;

namespace TDD
{
    public class ClientTests
    {
        [Fact]
        public void ShouldGetUnreadMessages()
        {
            // Arrange
            var mockService = new Mock<IMessageService>();
            mockService.Setup(s => s.GetUnreadMessages(It.IsAny<int>()))
                       .Returns(new List<Message>
                       {
                       new Message { MessageId = 1, Content = "Hello, John!", IsRead = false },
                       new Message { MessageId = 2, Content = "New update available.", IsRead = false }
                       });

            var client = new Client(mockService.Object);

            // Act
            var unreadMessages = client.GetUnreadMessages(1);

            // Assert
            Assert.Equal(2, unreadMessages.Count);
            Assert.False(unreadMessages[0].IsRead);
            Assert.False(unreadMessages[1].IsRead);
        }

        [Fact]
        public void ShouldMarkMessagesAsRead()
        {
            // Arrange
            var mockService = new Mock<IMessageService>();
            var messages = new List<Message>
        {
            new Message { MessageId = 1, Content = "Hello, John!", IsRead = false },
            new Message { MessageId = 2, Content = "New update available.", IsRead = false }
        };

            mockService.Setup(s => s.GetUnreadMessages(It.IsAny<int>())).Returns(messages);
            mockService.Setup(s => s.MarkMessagesAsRead(It.IsAny<List<Message>>()))
                       .Callback<List<Message>>(msgs => msgs.ForEach(m => m.IsRead = true));

            var client = new Client(mockService.Object);

            // Act
            var unreadMessages = client.GetUnreadMessages(1);
            client.MarkMessagesAsRead(unreadMessages);

            // Assert
            Assert.All(unreadMessages, m => Assert.True(m.IsRead));
        }
    }
}
