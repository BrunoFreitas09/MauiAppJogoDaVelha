namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        String vez = "O";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;
            if(vez == "O")
            {
                disparador.Text = "O"; 
                vez = "X";

            } else
            {
                disparador.Text="X";
                vez = "O";
            }
            //Fecha if


            //verificando se o x ganhou 
            if (btn10.Text == "X"
               && btn11.Text == "X"
               && btn12.Text == "X") ;
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn20.Text == "X"
                 && btn21.Text == "X"
                 && btn22.Text == "X") ;
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn30.Text == "X"
                 && btn31.Text == "X"
                 && btn32.Text == "X") ;
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn10.Text == "X"
                 && btn20.Text == "X"
                 && btn30.Text == "X") ;
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn11.Text == "X"
                 && btn21.Text == "X"
                 && btn31.Text == "X") ;
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn12.Text == "X"
                 && btn22.Text == "X"
                 && btn32.Text == "X") ;
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn12.Text == "X"
                 && btn21.Text == "X"
                 && btn30.Text == "X") ;
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn10.Text == "X"
                 && btn21.Text == "X"
                 && btn32.Text == "X") ;
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

        }//Fecha Button_Clicked

        private void limpar()
        {
            btn10.Text = "";
            btn10.IsEnabled = true;
        }
    }

}
