using SampleMauiApp.ViewModels;

namespace SampleMauiApp.Views;

public partial class FirstView : ContentPage
{
	public FirstView(FirstViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}