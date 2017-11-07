using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XIF.Game;

namespace FirstLife
{
    public partial class FirstLifePage : ContentPage
    {
        public FirstLifePage()
        {
            InitializeComponent();
        }

        public void StartGameClicked(object o, EventArgs e) {
            var pg = new XIF.UI.GameViewPortalPage();

            var game = new FirstLifeGame();


            pg.ActiveGame = game;

            Application.Current.MainPage = pg;
        }
    }
}
