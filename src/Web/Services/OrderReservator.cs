using Ardalis.GuardClauses;
using BlazorShared.Models;
using Microsoft.eShopWeb.Web.Interfaces;
using Microsoft.Extensions.Options;

namespace Microsoft.eShopWeb.Web.Services;

public class OrderReservator : IOrderReservator
{
    private readonly HttpClient _httpClient;
    private readonly OrderReservatorConfiguration _config;

    public OrderReservator(HttpClient httpClient, IOptions<OrderReservatorConfiguration> config)
    {
        _httpClient = httpClient;
        _config = config.Value;
    }

    public async Task Reserve(OrderDto order)
    {
        Guard.Against.Null(order, nameof(order));

        using var request = new HttpRequestMessage(HttpMethod.Post, _config.ReserveUri);
        request.Headers.Add(OrderReservatorConfiguration.KeyHeader, _config.Key);
        request.Content = JsonContent.Create(order);
        var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
    }
}
