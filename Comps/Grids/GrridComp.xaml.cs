namespace PracticeApp.Comps.Grids;

public partial class GrridComp : Grid
{
	public static readonly BindableProperty TextChangeProperty = BindableProperty.Create(nameof(TextChange), typeof(bool), typeof(GrridComp),  false, propertyChanged: OnChange);
    public static readonly BindableProperty Label1ChangeProperty = BindableProperty.Create(nameof(Label1Change), typeof(string), typeof(GrridComp), null, propertyChanged: OnLabelChange);

    public string Label1Change { get => (string)GetValue(Label1ChangeProperty); set => SetValue(Label1ChangeProperty, value); }
    public bool TextChange {  get =>(bool) GetValue(TextChangeProperty); set => SetValue(TextChangeProperty, value); }
	public GrridComp()
	{
		InitializeComponent();
	}

	private static void OnChange(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (GrridComp)bindable;
        if (control != null)
		{
			var IsChnaged = (bool)newValue;
			if (IsChnaged)
			{
                control.lbl1.Text = "Merhaba";
                control.lbl2.TextColor = Color.FromHex("#e81010");
			}
			
        }
	}

    private static void OnLabelChange(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (GrridComp)bindable;
        if (control != null)
        {
            control.lbl1.Text = (string)newValue;
            control.lbl2.TextColor = Color.FromHex("#eb4034");
            if (control.lbl1.Text != "")
            {
                control.lbl2.TextColor = Color.FromHex("#42f57b");
            }

        }

    }
}