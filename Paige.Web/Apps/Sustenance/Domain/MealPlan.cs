using System.ComponentModel.DataAnnotations;
using Paige.Web.Domain;

namespace Paige.Web.Apps.Sustenance.Domain;

public class MealPlan : Entity
{
    public long Id { get; set; }

    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }

    [DataType(DataType.Date)]
    public DateTime EndDate { get; set; }

    public virtual ICollection<Meal> Meals { get; set; } = new List<Meal>();
    
}