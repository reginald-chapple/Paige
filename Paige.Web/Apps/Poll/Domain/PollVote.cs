using System.ComponentModel.DataAnnotations;
using Paige.Web.Domain;

namespace Paige.Web.Apps.Poll.Domain;

[Serializable]
public class PollVote : Entity
{
    public long Id { get; set; }

    [Required]
    public long PollId { get; set; }
    public virtual Poll? Poll { get; set; }

    public string UserId { get; set; } = string.Empty;

    public long ChoiceId { get; set; }
}