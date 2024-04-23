using System;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        srv.WebExempleSoapClient ws;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ws = new srv.WebExempleSoapClient();
            grd.DataSource = ws.GetArticles(); 
        }
    }
}
