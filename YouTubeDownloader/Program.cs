using YouTubeDownloader;
using YouTubeDownloader.CommandPattern;
using YouTubeDownloader.CommandPattern.Parts;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

internal class Program
{
  private static async Task Main(string[] args)
  {
    if(args.Length != 0)
    {
      Consts.Link = args[0];
    }
    else
    {
      Consts.Link = "https://youtu.be/ByYyk8eMG6c?si=SykyOmi6c_pk2NmQ";
    }

    var sender = new Sender();

    var receiver = new Receiver();

    var commandOne = new ConcreteCommand1(receiver);

    sender.SetCommand(commandOne);

    await sender.Run();
  }
}