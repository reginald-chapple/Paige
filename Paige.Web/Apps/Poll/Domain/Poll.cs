using System.ComponentModel.DataAnnotations;
using Paige.Web.Domain;

namespace Paige.Web.Apps.Poll.Domain;

[Serializable]
public class Poll : Entity
{
    public long Id { get; set; }

    [Required]
    [StringLength(256)]
    public string Question { get; set; } = string.Empty;

    public DateTime? Closes { get; set; }
}