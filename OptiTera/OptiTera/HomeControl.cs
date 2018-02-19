using System;
using System.Windows.Forms;

namespace OptiTera
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private string GetRandomQuote()
        {
            richQuotes.SelectionAlignment = HorizontalAlignment.Center;
            string[] quotes = { "Oh! Why hello there!", "OptiTera! OptiTera!", "Terable fps no more!", "(. u .)", "Have a great day!", "*Dances*", "github.com/KhalidDiriye/OptiTrra", "What next?", "FPS FPS!"};
            Random random = new Random();
            int i = random.Next(0, quotes.Length);
            return quotes[i];
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            richQuotes.Text = GetRandomQuote();
        }

    }
}
