using TabViewBug.LazyViews;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace TabViewBug
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();

      //InitTabs(); // Works
    }

    protected override void OnAppearing()
    {
      InitTabs(); // Doesn't work
    }

    private void InitTabs()
    {
      var smileIcon = new FontImageSource { Glyph = Application.Current.Resources["smile"].ToString(), FontFamily = "fa", Color = Color.DarkGray };
      var bookIcon = new FontImageSource { Glyph = Application.Current.Resources["smile"].ToString(), FontFamily = "fa", Color = Color.DarkGray };

      this.MainTabs.TabItems.Add(new TabViewItem { Icon = smileIcon, Text = "Tab 1", Content = new Tab1LazyView() });
      this.MainTabs.TabItems.Add(new TabViewItem { Icon = bookIcon, Text = "Tab 2", Content = new Tab2LazyView() });
    }
  }
}
