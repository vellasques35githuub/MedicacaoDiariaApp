namespace MedicacaoDiariaApp.VIews;

public partial class EditarMedicamento : ContentPage
{
	public EditarMedicamento()
	{
		InitializeComponent();
	}
 private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        try
        {
            Medicamento medicamento_anexado = BindingContext as Medicamento;

            Medicamento m = new Medicamento
            {
                Id = medicamento_anexado.Id,
                Descricao = txt_descricao.Text,
               
	    };

            await App.Db.Update(p);
            await DisplayAlert("Sucesso!", "Resgistro Atualizado", "OK");
            await Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}
