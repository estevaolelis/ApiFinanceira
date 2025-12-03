using Supabase;

public static class SupabaseConfig
{
    public static Client Initialize(string url, string key)
    {
        var options = new SupabaseOptions
        {
            AutoConnectRealtime = true
        };

        return new Client(url, key, options);
    }
}
