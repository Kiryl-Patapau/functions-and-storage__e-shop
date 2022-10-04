using BlazorShared.Models;

namespace Microsoft.eShopWeb.Web.Interfaces;

public interface IOrderReservator
{
    Task Reserve(OrderDto order);
}
