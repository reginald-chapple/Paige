using Paige.Web.Domain;

namespace Paige.Web.Apps.Sustenance.Domain;

public class Recipe : Entity
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public List<Step> Steps { get; set; } = [];

    public List<Ingredient> Ingredients { get; set; } = [];

    public virtual ICollection<Meal> Meals { get; set; } = new List<Meal>();
}