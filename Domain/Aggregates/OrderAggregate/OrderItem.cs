using System;
using Domain.SeedWork;

namespace Domain.Aggregates.OrderAggregate;

public class OrderItem : Entity
{
    public Guid FlightId { get; private set; }
    public int Quantity { get; private set; }
    public decimal UnitPrice { get; private set; }
    public decimal TotalPrice => Quantity * UnitPrice;
    
    public OrderItem(Guid flightId, int quantity, decimal unitPrice)
    {
        FlightId = flightId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }
    
    public void UpdateQuantity(int quantity)
    {
        Quantity = quantity;
    }

    public void UpdatePrice(decimal price)
    {
        UnitPrice = price;
    }
}