namespace exchangeApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    private async void OnAboutClicked(object? sender, EventArgs e)
    {
        await Shell.Current.DisplayAlert("Про програму", "Це приклад бічного меню у .NET MAUI.", "OK");
    }

    private async void OnExitClicked(object? sender, EventArgs e)
    {
        bool answer = await Shell.Current.DisplayAlert(
            "Підтвердження", 
            "Ви дійсно бажаєте вийти з додатку?", 
            "Так", 
            "Ні");

        if (answer)
        {
#if ANDROID
        Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
#elif IOS
        // На iOS додатки не можна програмно закрити, але можна закрити активні сторінки, якщо потрібно:
        // System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        // або просто нічого не виконувати
#elif WINDOWS
        Application.Current.Quit();
#endif
        }
    }
}