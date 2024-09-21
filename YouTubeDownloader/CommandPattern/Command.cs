using YouTubeDownloader.Interfaces;

namespace YouTubeDownloader.CommandPattern
{
  internal abstract class Command : ICommand
  {
    public abstract Task Cancel();

    public abstract Task Run();
  }
}
