﻿

namespace Final.Project.BL;

public class ProductChildDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Image { get; set; } = string.Empty;
    public decimal Discount { get; set; }
    public decimal PriceAfter => Price - (Price * Discount / 100);
}
