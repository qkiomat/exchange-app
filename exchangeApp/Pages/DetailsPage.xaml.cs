using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchangeApp.Pages;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(object selectedRate)
    {
        InitializeComponent();
        BindingContext = selectedRate;
    }

    private async void OnCloseButtonClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}