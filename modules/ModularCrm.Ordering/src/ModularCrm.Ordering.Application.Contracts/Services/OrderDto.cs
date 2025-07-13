using System;
using ModularCrm.Ordering.Enums;

namespace ModularCrm.Ordering;

public class OrderDto
{
    public Guid Id { get; set; }
    public string CustomerName { get; set; }
    public Guid ProductId { get; set; }
    public string ProductName { get; set; } // New property

    public OrderState State { get; set; }

}