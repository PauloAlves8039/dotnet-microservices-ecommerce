﻿using BusinessLogicLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validators;

public class OrderItemUpdateRequestValidator : AbstractValidator<OrderItemUpdateRequest>
{
    public OrderItemUpdateRequestValidator()
    {
        RuleFor(temp => temp.ProductID)
          .NotEmpty().WithErrorCode("Product ID can't be blank");

        RuleFor(temp => temp.UnitPrice)
          .NotEmpty().WithErrorCode("Unit Price can't be blank")
          .GreaterThan(0).WithErrorCode("Unit Price can't be less than or equal to zero");

        RuleFor(temp => temp.Quantity)
          .NotEmpty().WithErrorCode("Quantity can't be blank")
          .GreaterThan(0).WithErrorCode("Quantity can't be less than or equal to zero");
    }
}
