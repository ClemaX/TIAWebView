using System.Windows.Forms;

namespace TIAWebView
{
    public partial class TIAWebView : UserControl
    {
        private string m_source;

        public string Source
        {
            set
            {
                bool success = false;
                try
                {
                    webBrowser.LoadUrl(value);
                    success = true;
                }
                catch
                {
                
                }
                
                if (success)
                {
                    m_source = value;
                }
            }
            get
            {
                return m_source;
            }
        }
        
        public TIAWebView()
        {
            InitializeComponent();

            if (Source != null)
            {
                webBrowser.LoadUrl(Source);
            }
        }
    }
}
