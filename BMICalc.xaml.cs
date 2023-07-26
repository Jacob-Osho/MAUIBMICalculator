namespace BMICalculator;

public partial class BMICalc : ContentPage
{
    public BMICalc()
    {
        InitializeComponent();
    }
    protected void TapMale_Tapped(object sender, EventArgs e)
    {
        MaleFrame.BorderColor = Color.FromArgb("#FF000000");
        FemaleFrame.BorderColor = Color.FromArgb("#FFFFFFFF");
        
        heightSlider.ThumbColor = Color.FromArgb("FF0000FF");
        WeighttSlider.ThumbColor = Color.FromArgb("FF0000FF");
        CalculateButton.BackgroundColor = Color.FromArgb("FF0000FF");

    }
    protected void CalculateButton_Click(object sender, EventArgs e)
    {
        double height =Convert.ToInt32( LblHeight.Text);
        double weight =Convert.ToInt32( LblWeight.Text);

        double bmiResult = (weight / height / height) * 10000;
        //DisplayAlert("Your  BMI is - ", bmiResult.ToString(),"cancel");
        Navigation.PushAsync(new BMIResultPage(bmiResult));
    }
    protected void TapFemale_Tapped(object sender, EventArgs e)
    {
        FemaleFrame.BorderColor = Color.FromArgb("#FF000000");
        MaleFrame.BorderColor = Color.FromArgb("#FFFFFFFF");
        heightSlider.ThumbColor = Color.FromArgb("FFFFC0CB");
        WeighttSlider.ThumbColor = Color.FromArgb("FFFFC0CB");
        CalculateButton.BackgroundColor = Color.FromArgb("FFFFC0CB");
    }
}