using System.Collections.Generic;

namespace BlazorShared.Models;

public class OrderDto
{
    public string BuyerId { get; set; }

    public IEnumerable<OrderItemDto> Items { get; set; }
}
