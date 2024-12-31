using System;
using System.Web.UI;

namespace WebApplication1
{
    public partial class advatise : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // No additional setup required as AdRotator handles XML file binding automatically.
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            // The Timer will automatically refresh the UpdatePanel, causing the AdRotator to cycle through ads.
        }
    }
}
