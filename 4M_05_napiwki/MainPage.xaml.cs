namespace _4M_05_napiwki
{
    public partial class MainPage : ContentPage
    {
        private double kwota = 0;
        private double napiwekProcent = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn10Napiwek(object sender, EventArgs e)
        {
            if(entKwota.Text!=null)
                kwota = double.Parse(entKwota.Text);
            else 
                kwota = 0;
            napiwekProcent = 0.1;
            double napiwek = kwota * napiwekProcent;
            lblNapiwek.Text = napiwek.ToString("0.00");
            SemanticScreenReader.Announce(lblNapiwek.Text);
            double suma = kwota + napiwek;
            lblsuma.Text = suma.ToString("0.00");
            SemanticScreenReader.Announce(lblsuma.Text);
            lblNapiwekProcent.Text = (napiwekProcent*100).ToString("0")+"%";
            SemanticScreenReader.Announce(lblNapiwekProcent.Text);


        }
        private void btn7Napiwek(object sender, EventArgs e)
        {
            if (entKwota.Text != null)
                kwota = double.Parse(entKwota.Text);
            else
                kwota = 0;
            napiwekProcent = 0.07;
            double napiwek = kwota * napiwekProcent;
            lblNapiwek.Text = napiwek.ToString("0.00");
            SemanticScreenReader.Announce(lblNapiwek.Text);
            double suma = kwota + napiwek;
            lblsuma.Text = suma.ToString("0.00");
            SemanticScreenReader.Announce(lblsuma.Text);
            lblNapiwekProcent.Text = (napiwekProcent * 100).ToString("0") + "%";
            SemanticScreenReader.Announce(lblNapiwekProcent.Text);


        }

        private void sldNapiwekChanged(object sender, EventArgs e)
        {
            string n = (sldNapiwekProc.Value/100).ToString("0%");
            lblSliderValue.Text = n;
            SemanticScreenReader.Announce(lblSliderValue.Text);

            // pozostaje tylko przeliczyć wartości jak w powyższych metodach

        }


    }
}