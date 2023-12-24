using System.ComponentModel.DataAnnotations;
using Paige.Web.Domain;

namespace Paige.Web.Apps.Poll.Domain;

[Serializable]
public class Choice : Entity
{
    public long Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public int Votes { get; set; } = 0;

    public double Percentage { get; set; } = 0.0;

    [Required]
    public long PollId { get; set; }
    public virtual Poll? Poll { get; set; }
}