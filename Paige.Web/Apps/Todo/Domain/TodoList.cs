using Paige.Web.Domain;

namespace Paige.Web.Apps.Todo.Domain;

public class TodoList : Entity
{
    public long Id { get; set; }

    public string Label { get; set; } = string.Empty;

    public DateTime? StartTime { get; set; }

    public DateTime? CompleteTime { get; set; }

    public ListType Type { get; set; } = ListType.General;

    public List<Instruction> Instructions { get; set; } = [];
}
