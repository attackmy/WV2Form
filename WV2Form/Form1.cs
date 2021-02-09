/// <summary>
/// Form sample.
/// </summary>
namespace WV2Form
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeAsync();
        }

        async void InitializeAsync()
        {
            var webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            var env = await Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateAsync("C:\\temp\\Microsoft.WebView2.FixedVersionRuntime.88.0.705.56.x64", "c:\\temp\\");
            await webView.EnsureCoreWebView2Async(env);
            webView.Source = new System.Uri("https://www.microsoft.com");

            webView.Dock = System.Windows.Forms.DockStyle.Fill;
            Controls.Add(webView);
        }
    }
}
