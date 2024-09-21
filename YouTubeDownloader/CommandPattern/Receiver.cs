using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace YouTubeDownloader.CommandPattern
{
  internal class Receiver
  {
    public async Task GetVideoDescription(CancellationToken ct)
    {
      ct.ThrowIfCancellationRequested();

      try
      {
        var videoDesc = await Consts.Videos.GetAsync(Consts.Link, cancellationToken: ct);

        Console.WriteLine(videoDesc);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    public async Task DownloadVideo(CancellationToken ct)
    {
      ct.ThrowIfCancellationRequested();

      var outputFilPath = Path.Combine("C:", "Users", "maks_", "Downloads");

      try
      {
        await Consts.Videos.DownloadAsync(Consts.Link, outputFilPath);
      }
      catch (Exception ex)
      {
        Console.WriteLine($"{ex.Message}");
      }
    }
  }
}
