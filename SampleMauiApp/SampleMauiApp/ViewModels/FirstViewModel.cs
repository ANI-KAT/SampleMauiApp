using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SampleMauiApp.ViewModels;

public partial class FirstViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(GoToSecondScreenCommand))]
    string _username = "";

    [RelayCommand(CanExecute = nameof(CanGoToSecondScreen))]
    async Task GoToSecondScreen() => await Shell.Current.GoToAsync($"SecondScreen?username={Username}");

    private bool CanGoToSecondScreen() => !string.IsNullOrWhiteSpace(Username);
}
