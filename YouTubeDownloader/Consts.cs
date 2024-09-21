using YoutubeExplode.Videos;

namespace YouTubeDownloader
{
  internal class Consts
  {
    public static HttpClient Client = new()
    {
      BaseAddress = new Uri("https://www.youtube.com/?hl=RU")
    };

    public static VideoClient Videos = new(Client);
    public static string Link = "";
  }
}
