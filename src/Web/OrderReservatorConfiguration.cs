namespace Microsoft.eShopWeb.Web;

public class OrderReservatorConfiguration
{
    public const string ConfigPath = "OrderReservator";
    public const string KeyHeader = "x-functions-key";

    public string? Url { get; set; }

    public string? Key { get; set; }

    public string ReserveUri => Url?.TrimEnd('/') + "/api/reserve";
}
