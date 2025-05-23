using exchangeApp.ViewModels;
using exchangeApp.Pages;

namespace exchangeApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        Loaded += MainPage_Loaded;
    }

    private async void MainPage_Loaded(object sender, EventArgs e)
    {
        var vm = (MainPageViewModel)BindingContext;
        await vm.LoadRates();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        /*count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);*/
    }

    private async void OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
        {
            var selectedItem = e.CurrentSelection.FirstOrDefault();
            if (selectedItem == null) return;

            // Переходимо на сторінку деталей, передаючи модель валюти
            await Navigation.PushAsync(new DetailsPage(selectedItem));
        
            // Знімаємо виділення, щоб можна було знов вибрати
            ((CollectionView)sender).SelectedItem = null;
        }

    }
}