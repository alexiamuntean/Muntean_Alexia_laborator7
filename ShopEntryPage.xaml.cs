using Muntean_Alexia_laborator7.Models;
namespace Muntean_Alexia_laborator7;

public partial class ShopEntryPage : ContentPage
{
	public ShopEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetShopsAsync();
    }
    async void OnShopAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ShopPage
        {
            BindingContext = new Shop()
        });
    }
    async void OnListViewItemSelected(object sender,
   SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ShopPage
            {
                BindingContext = e.SelectedItem as Shop
            });
        }
    }

}