using CommunityToolkit.Maui.Views;

namespace PracticeApp.Comps.PopAlert;

public partial class PopupComp : Popup
{
	public event EventHandler OKClick;
	public static readonly BindableProperty MessageProperty = BindableProperty.Create(nameof(Message), typeof(string), typeof(PopupComp), null,
		propertyChanged: OnChange); 
	public string Message
	{
		get => (string)GetValue(MessageProperty); set => SetValue(MessageProperty, value);
	}
	public PopupComp()
	{
		InitializeComponent();
	}
	
  

	private static void OnChange(BindableObject bindable, object oldValue, object newValue)
	{
		var control = bindable as PopupComp;
		if (control != null)
		{
			control.message.Text = (string)newValue;
		}
	}

    private void close_Click(object sender, EventArgs e)
    {
        OKClick.Invoke(this, EventArgs.Empty);
		this.Close();
    }
}