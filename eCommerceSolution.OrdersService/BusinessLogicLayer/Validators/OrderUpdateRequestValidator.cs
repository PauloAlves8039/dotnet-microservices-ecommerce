﻿using BusinessLogicLayer.DTOs;
using FluentValidation;

namespace BusinessLogicLayer.Validators;

public class OrderUpdateRequestValidator : AbstractValidator<OrderUpdateRequest>
{
    public OrderUpdateRequestValidator()
    {
        RuleFor(temp => temp.OrderID)
          .NotEmpty().WithErrorCode("Order ID can't be blank");

        RuleFor(temp => temp.UserID)
          .NotEmpty().WithErrorCode("User ID can't be blank");

        RuleFor(temp => temp.OrderDate)
          .NotEmpty().WithErrorCode("Order Date can't be blank");

        RuleFor(temp => temp.OrderItems)
          .NotEmpty().WithErrorCode("Order Items can't be blank");
    }
}
