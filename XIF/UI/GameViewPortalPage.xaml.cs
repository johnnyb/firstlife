using System;
using System.Collections.Generic;
using XIF.Game;
using Xamarin.Forms;

namespace XIF.UI
{
    public partial class GameViewPortalPage : MasterDetailPage
    {
        public Game.Game ActiveGame { get; set; }

        public GameViewPortalPage()
        {
            InitializeComponent();
            Appearing += (s, e) =>
            {
                ResetPage();
            };
        }

        // This function resets the view of the page based on the current game state
        public void ResetPage() {
            // Basic player / location data
            var ch = ActiveGame.MainCharacter;
            var loc = ch.Location;
            CharacterName.Text = ch.Name;
            LocationName.Text = loc.Name;
            LocationDescription.Text = loc.Description;
            LocationImage.Source = loc.DisplayImage;

            // Show visible items in the room
            VisibleItems.Children.Clear();
            VisibleItemsLabel.IsVisible = false;
            foreach(var itm in loc.GetVisibleItems()) {
                var lbl = new Label();
                lbl.Text = itm.Name;
                VisibleItems.Children.Add(lbl);
                VisibleItemsLabel.IsVisible = true;
            }

            // Show exits from the room
            DestinationDoorways.Children.Clear();
            DestinationDoorwaysLabel.IsVisible = false;
            foreach(var doorway in loc.Doorways) {
                var btn = new Button();
                btn.Text = doorway.Direction;
                btn.Clicked += (s, e) => {
                    ch.Location = doorway.Destination;
                    ResetPage();
                };
                DestinationDoorways.Children.Add(btn);
                DestinationDoorwaysLabel.IsVisible = true;
            }
        }

        public void ShowInventoryClicked(object o, EventArgs e) {
            
        }
    }
}
