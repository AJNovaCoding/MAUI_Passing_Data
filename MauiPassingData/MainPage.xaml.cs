namespace MauiPassingData
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddClicked(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstValue.Text) || string.IsNullOrEmpty(SecondValue.Text))
            {
                ResultInput.Text = "Please enter both values to obtain sum.";
                return;
            }
            else
            {
                // Corrected variable names and ensured proper usage of Entry.Text property
                double firstValue = Convert.ToDouble(FirstValue.Text);
                double secondValue = Convert.ToDouble(SecondValue.Text);
                double result = firstValue + secondValue;

                Navigation.PushAsync(new DisplayPage(firstValue, secondValue, result, "Addition"));
            }
        }
        private void OnSubtractClicked(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstValue.Text) || string.IsNullOrEmpty(SecondValue.Text))
            {
                ResultInput.Text = "Please enter both values to obtain difference.";
                return;
            }
            else
            {
                // Corrected variable names and ensured proper usage of Entry.Text property
                double firstValue = Convert.ToDouble(FirstValue.Text);
                double secondValue = Convert.ToDouble(SecondValue.Text);
                double result = firstValue - secondValue;
                Navigation.PushAsync(new DisplayPage(firstValue, secondValue, result, "Subtraction"));
            }
        }
    }
}
