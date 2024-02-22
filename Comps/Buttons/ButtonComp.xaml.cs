namespace PracticeApp.Comps.Buttons;

public partial class ButtonComp : Button
{
	public event EventHandler Click;
	
	public ButtonComp()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Click?.Invoke(this, e);
    }
}