using System;
using System.Collections.Generic;

namespace Computer_Store.Entities;

public partial class ItemDetail
{
    public int Id { get; set; }

    public string? Product_Name { get; set; }

    public string? Company { get; set; }

    public int? Ram { get; set; }

    public string? Hardisk { get; set; }

    public string? Os { get; set; }

    public string? ProductType { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }
}
