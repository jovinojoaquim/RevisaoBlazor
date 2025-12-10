using System;

namespace BlazingPizza.Model.Core;

public class PizzaTopping
{
    public Topping Topping { get; set; }

    public int ToppingId { get; set; }

    public int PizzaId { get; set; }
}
