
using Xamarin.Forms;

namespace XFBindingTriggerBug
{
  internal class BoxInfo : BindableObject
  {

    private string _description;
    public string Description
    {
      get => this._description;
      set
      {
        if (this._description != value)
        {
          this._description = value;
          this.OnPropertyChanged();
        }
      }
    }

    private Color theColor;

    public BoxInfo(string desc, Color col)
    {
      this.TheColor = col;
      this.Description = desc;
    }

    public Color TheColor
    {
      get => this.theColor;
      set
      {
        if (this.theColor != value)
        {
          this.theColor = value;
          this.OnPropertyChanged();
        }
      }
    }



  }
}