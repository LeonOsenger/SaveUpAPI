using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SaveUpAPI.Models;

public partial class Product
{
    [Key]
    public Guid Id { get; set; }

    public double? Price { get; set; }

    [MaxLength(50)]
    public string? Description { get; set; }
}
