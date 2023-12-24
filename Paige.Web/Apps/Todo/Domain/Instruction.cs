namespace Paige.Web.Apps.Todo.Domain;

public class Instruction
{
    public string Task { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
    public DateTime? FinishTime { get; set; }
    public bool IsComplete { get; set; } = false;
}