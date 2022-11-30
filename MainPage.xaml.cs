namespace PerfectPay;

public partial class MainPage : ContentPage
{
	decimal bill;
	int tip;
	int noPersons = 1;
	public MainPage()
	{
		InitializeComponent();
	}

    private void txtBill_Completed(object sender, EventArgs e)
    {
		bill = decimal.Parse(txtBill.Text);
        CalculateTotal();
    }
	private void CalculateTotal()
	{

	}

    private void sldTip_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		tip = (int)sldTip.Value;
		lblTip.Text= $"Tip: {tip}";
		CalculateTotal();

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(sender is Button)
		{
			var btn = (Button)sender;
			var percentage =
			int.Parse(btn.Text.Replace("%", ""));
			sldTip.Value = percentage;
		}
    }
}


