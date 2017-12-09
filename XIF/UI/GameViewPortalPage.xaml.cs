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
                var item_layout = new StackLayout();
                item_layout.Orientation = StackOrientation.Horizontal;

                var lbl = new Label();
                lbl.Text = itm.Name;
                lbl.HorizontalOptions = LayoutOptions.FillAndExpand;
                item_layout.Children.Add(lbl);

                var btn = new Button();
                btn.Text = "Actions";
                item_layout.Children.Add(btn);
                btn.Clicked += async (s, e) =>
                {
                    var action_list = itm.GetAvailableActions(ch);
                    if (itm.CanBeTaken)
                    {
                        action_list.Add("Take");
                    }

                    var result = await DisplayActionSheet("Choose Action", "Cancel", null, action_list.ToArray());

                    if (!string.IsNullOrWhiteSpace(result))
                    {
                        if (result == "Take")
                        {
                            loc.Items.Remove(itm);
                            ch.InventoryItems.Add(itm);
                            await DisplayAlert("Item Taken", "This item has been taken and added to your inventory", "OK");
                        }
                        else
                        {
                        }
                    }

                    ResetPage();
                };

                VisibleItems.Children.Add(item_layout);
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
            var items = new List<string>();
            foreach (var itm in ActiveGame.MainCharacter.InventoryItems)
            {
                items.Add(itm.Name);
            }

            DisplayAlert("Inventory Items", "Your inventor items are: " + string.Join(", ", items), "OK");
        }
    }
}
