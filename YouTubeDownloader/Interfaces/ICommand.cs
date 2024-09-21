﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownloader.Interfaces
{
  internal interface ICommand
  {
    Task Run();
    Task Cancel();
  }
}
