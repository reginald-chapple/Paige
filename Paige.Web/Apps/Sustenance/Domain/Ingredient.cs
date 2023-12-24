using Microsoft.EntityFrameworkCore;
using Paige.Web.Domain;

namespace Paige.Web.Apps.Sustenance.Domain;

public class Ingredient
{
    public string Name { get; set; } = string.Empty;

    public double Quantity { get; set; }

    public string Unit { get; set; } = string.Empty;

    [Precision(8, 2)]
    public decimal Cost { get; set; }
}