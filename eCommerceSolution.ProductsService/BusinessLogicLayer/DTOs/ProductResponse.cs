﻿using BusinessLogicLayer.DTOs.Enums;

namespace BusinessLogicLayer.DTOs;

public record ProductResponse(Guid ProductID, string ProductName, CategoryOptions Category, double UnitPrice, int QuantityInStock)
{
    public ProductResponse() : this(default, default, default, default, default) { }
}
