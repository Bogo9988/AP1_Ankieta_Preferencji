using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AnkietaPreferencji2.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ZatwierdzButton.Click += ZatwierdzKlik;
        PodsumowanieButton.Click += PokazPodsumowanie;
    }

    private void ZatwierdzKlik(object? sender, RoutedEventArgs e)
    {
        string imie = ImieTextBox.Text;
        string kategoria = KategoriaComboBox.SelectedItem?.ToString() ?? "Nie wybrano";

        PodsumowanieTextBlock.Text = $"Imię: {imie}\nZainteresowania: {kategoria}";
        PodsumowaniePanel.IsVisible = false;
    }

    private void PokazPodsumowanie(object? sender, RoutedEventArgs e)
    {
        int liczbaTak = 0;
        if (Pytanie1CheckBox.IsChecked == true) liczbaTak++;
        if (Pytanie2CheckBox.IsChecked == true) liczbaTak++;
        if (Pytanie3CheckBox.IsChecked == true) liczbaTak++;

        PodsumowanieTextBlock.Text += $"\nLiczba odpowiedzi 'Tak': {liczbaTak}";
        PodsumowaniePanel.IsVisible = true;
    }
}
