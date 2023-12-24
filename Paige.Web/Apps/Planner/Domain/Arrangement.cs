using Paige.Web.Domain;

namespace Paige.Web.Apps.Planner.Domain;

public class Arrangement : Entity
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Details { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; } = null;
}