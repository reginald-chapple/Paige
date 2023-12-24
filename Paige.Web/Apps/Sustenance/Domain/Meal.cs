using System.ComponentModel.DataAnnotations;
using Paige.Web.Domain;

namespace Paige.Web.Apps.Sustenance.Domain;

public class Meal : Entity
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    public long? RecipeId { get; set; }
    public virtual Recipe? Recipe { get; set; }

    public long MealPlanId { get; set; }
    public virtual MealPlan? MealPlan { get; set; }
}