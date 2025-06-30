using CommunityToolkit.Mvvm.ComponentModel;

namespace SampleMauiApp.ViewModels;

public partial class SecondViewModel(IDetectPlatform platform) : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    string _displayText = "";

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("username", out var username))
        {
            DisplayText = $"Hello {username} from {platform.GetPlatform()}.";
        }
    }
}
