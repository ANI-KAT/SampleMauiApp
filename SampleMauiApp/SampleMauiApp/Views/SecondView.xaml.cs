using SampleMauiApp.ViewModels;

namespace SampleMauiApp.Views;

public partial class SecondView : ContentPage
{
	public SecondView(SecondViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}