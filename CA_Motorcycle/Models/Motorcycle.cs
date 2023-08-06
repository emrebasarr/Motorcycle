using System;
using System.Collections.Generic;

namespace CA_Motorcycle.Models;

public partial class Motorcycle
{
    public int Id { get; set; }

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Colour { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Year { get; set; } = null!;
}
