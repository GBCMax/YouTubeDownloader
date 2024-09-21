namespace YouTubeDownloader.CommandPattern
{
  internal class Sender
  {
    Command _command;
    public void SetCommand(Command command)
    {
      _command = command;
    }

    public async Task Run()
    {
      await _command.Run();
    }

    public async Task Cancel()
    {
      await _command.Cancel();
    }
  }
}
