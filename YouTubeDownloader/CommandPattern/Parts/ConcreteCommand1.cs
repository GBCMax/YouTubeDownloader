using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownloader.CommandPattern.Parts
{
  internal class ConcreteCommand1 : Command
  {
    CancellationTokenSource cts = new CancellationTokenSource();
    CancellationToken _ct;
    Receiver _receiver;
    public ConcreteCommand1(Receiver receiver)
    {
      this._receiver = receiver;
      this._ct = cts.Token;
    }
    public override async Task Cancel()
    {
      Console.WriteLine("Отмена операции");

      await cts.CancelAsync();
    }

    public override async Task Run()
    {
      await this._receiver.GetVideoDescription(this._ct);
      await this._receiver.DownloadVideo(this._ct);
    }
  }
}
