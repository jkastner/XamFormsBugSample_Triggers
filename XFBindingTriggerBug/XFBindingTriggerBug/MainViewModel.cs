using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace XFBindingTriggerBug
{
    class MainViewModel : BindableObject
    {

      private BoxInfo theBoxInfo;
      public BoxInfo TheBoxInfo
      {
        get => this.theBoxInfo;
        set
        {
          if (this.theBoxInfo != value)
          {
            this.theBoxInfo = value;
            this.OnPropertyChanged();
          }
        }
      }

      public ObservableCollection<BoxInfo> TheColors { get; } = new ObservableCollection<BoxInfo>();

      public MainViewModel()
      {
        TheColors.Add(new BoxInfo("Red", Color.Red));
        TheColors.Add(new BoxInfo("Blue", Color.Blue));
        TheColors.Add(new BoxInfo("Green", Color.Green));
        TheBoxInfo = TheColors.First();

      }

  }
}
