namespace BMICalculator;

public partial class BMIResultPage : ContentPage
{
    public BMIResultPage( double bmi)
    {
        InitializeComponent();
        BMIResult.Text = $"{bmi:F1}";
        BMIMsg.Text = $"You are - {GetResultBMIMsg(bmi)}";
    }

    private string GetResultBMIMsg(double bmi)
    {
        if (bmi >= 25)
            return "Overweight";
        else if (bmi > 18.5)
            return "Normal";
        else
            return "Underweight";
    }

    public BMIResultPage()
	{
		InitializeComponent();
	}
}