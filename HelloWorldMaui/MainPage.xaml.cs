using System.Diagnostics;

namespace HelloWorldMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void ConverterDecimalBinario(object sender, EventArgs e)
    {
        var decimalBinario = entry.Text;

        var binario = Convert.ToDecimal(decimalBinario);

        var arrayBinario = new List<int>();

        int numero;

        var valorBinarioAtual = binario;

        while(binario >= 1)
        {
            numero = (int)binario % 2;
            binario = Math.Floor(binario / 2);
            arrayBinario.Add(numero);
        }

        arrayBinario.Reverse();

        await DisplayAlert("Conversor", $"O número decimal {valorBinarioAtual} em binário é: {string.Join("", arrayBinario)}", "Ok.");

    }
}

