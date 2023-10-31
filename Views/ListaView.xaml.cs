using MVVM_API_SampleProject.Models;
using MVVM_API_SampleProject.ViewModels;

namespace MVVM_API_SampleProject.Views;

public partial class ListaView : ContentPage
{
	public ListaView()
	{
		InitializeComponent();
		BindingContext = new ListaViewModel();
        void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            // Perform required operation after examining e.Value
        }
    }
}