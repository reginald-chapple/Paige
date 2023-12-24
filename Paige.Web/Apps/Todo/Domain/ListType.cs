using System.ComponentModel;

namespace Paige.Web.Apps.Todo.Domain;

public enum ListType
{
    [Description("General")]
    General,
    [Description("Cleaning")]
    Cleaning,
    [Description("DYI")]
    DYI,
    [Description("Maintenance")]
    Maintenance,
    [Description("Shopping")]
    Shopping
}