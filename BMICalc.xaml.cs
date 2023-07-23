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
    protected void TapFemale_Tapped(object sender, EventArgs e)
    {
        FemaleFrame.BorderColor = Color.FromArgb("#FF000000");
        MaleFrame.BorderColor = Color.FromArgb("#FFFFFFFF");
        heightSlider.ThumbColor = Color.FromArgb("FFFFC0CB");
        WeighttSlider.ThumbColor = Color.FromArgb("FFFFC0CB");
        CalculateButton.BackgroundColor = Color.FromArgb("FFFFC0CB");
    }
}