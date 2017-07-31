using System.Windows.Forms;

namespace PendenzenSetuper
{
    public partial class Register : Form
    {
        private bool register = false;

        public Register()
        {
            InitializeComponent();
        }





        private void weiterButtonTextChange(object sender, System.EventArgs e)
        {
            switch (register)
            {
                case true:
                    weiter.Text = "Ja, weiter";
                    break;
                case false:
                    weiter.Text = "Nein, weiter";
                    break;
            }
        }
    }
}
