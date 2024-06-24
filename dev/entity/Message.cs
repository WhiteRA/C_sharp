using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Message
{
    [Key]
    public int MessageId { get; set; }
    public string Content { get; set; }
    public bool IsRead { get; set; }
    public DateTime SentDate { get; set; }

    [ForeignKey("User")]
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
