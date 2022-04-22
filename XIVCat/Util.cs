namespace XIVCat;

public static class Util
{
    public static string GetIconUrl(uint iconId)
    {
        var folder = (Math.Floor(iconId / 1000d) * 1000).ToString("000000");
        return $"https://xivapi.com/i/{folder}/{iconId:000000}.png";
    }

    public static string GetItemPageUrl(uint itemId)
    {
        return $"item/{itemId}";
    }
}