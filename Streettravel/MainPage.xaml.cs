namespace Streettravel;

public partial class MainPage : ContentPage
{

    WebView webView = new WebView
    {
        Source = new UrlWebViewSource { Url = "https://streettravel.net/" },
    };
    public MainPage()
	{
		InitializeComponent();
        Content = webView;

    }
    protected override bool OnBackButtonPressed()
    {
        if (webView.CanGoBack)
        {
            webView.GoBack();
            return true;
        }

        return false;
    }
    /*
    public void onBackPressed()
    {
        if (webView.canGoBack())
        {
            webView.goBack()
        }
    }
    */

}
/*
class StartPage : ContentPage
{
    WebView webView = new WebView
    {
        Source = new UrlWebViewSource { Url = "https://streettravel.net/" },
    };
    public StartPage()
    {
       
        Content = webView;

    }
    protected override bool OnBackButtonPressed()
    {
        if (webView.CanGoBack)
        {
            webView.GoBack();
            return true;
        }

        return false;
    }
}
/*
class StartPage : ContentPage
{
    WebView webView = new WebView
    {
        Source = new UrlWebViewSource { Url = "https://streettravel.net/" },
    };
    Label statusLabel = new Label() { Padding = 8, FontSize = 20 };
    public StartPage()
    {
        Grid grid = new Grid();
        grid.RowDefinitions.Add(new RowDefinition { Height = 60 });
        grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
        /*WebView webView = new WebView
        {
            Source = new UrlWebViewSource { Url = "https://streettravel.net/" },
        };
*/

// если можно перейти назад, переходим назад
 /*    if (webView.CanGoBack)
     {
         webView.GoBack();
     }

     // если можно перейти вперед, переходим вперед
     if (webView.CanGoForward)
     {
         webView.GoForward();
     }
     //Content = webView;
     webView.Navigated += WebView_Navigated; // подключаем обработчик события

     grid.Add(statusLabel, 0, 0);
     grid.Add(webView, 0, 1);
     Content = grid;
 }

 public void onBackPressed()
 {
     if (webView.CanGoBack)
     {
         webView.GoBack();
     }

 }
 // обрабатываем завершение перехода
 void WebView_Navigated(object sender, WebNavigatedEventArgs e)
 {
     if (e.Result == WebNavigationResult.Success)
         statusLabel.Text = "Запрос завершился успешно";
     else
         statusLabel.Text = "В процессе запроса возникли проблемы";
 }





}

*/