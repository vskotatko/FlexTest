using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FlexTest.Nodes
{
  public class ImageData : NodeData
  {
    public string FileName { get; set; }

    public ImageSource Path
    {
      get
      {
        ImageSource path = ImageSource.FromResource("flextest.Assets." + FileName);
        return path;
      }
    }
  }
}
