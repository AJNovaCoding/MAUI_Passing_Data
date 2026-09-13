namespace MauiPassingData;

public partial class DisplayPage : ContentPage
{
    public DisplayPage(double firstValue, double secondValue, double result, string operation)
    {
        InitializeComponent();

        Numbers.Text = $"The numbers entered are {firstValue} and {secondValue}.";

        if (operation == "Addition")
        {
            ResultInput.Text = $"The sum of the numbers is {result}.";
        }
        else if (operation == "Subtraction")
        {
            ResultInput.Text = $"The difference between the numbers is {result}.";
        }

    }
        private void OnGoBackClicked(object sender, EventArgs e)
    {
        // Navigate back to the previous page
        Navigation.PopAsync();
    }
}

