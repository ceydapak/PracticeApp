namespace PracticeApp.Comps.Entrys;

public partial class EntryComp : Entry
{
	public event EventHandler EntryCompleted;
    public event EventHandler EntryChanged;
    public event EventHandler Focus;
	public EntryComp()
	{
		InitializeComponent();
	}

    private void Entry_Completed(object sender, EventArgs e)
    {
		EntryCompleted?.Invoke(this, EventArgs.Empty);
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        EntryChanged?.Invoke(this, EventArgs.Empty);
    }

    private void Entry_Focused(object sender, FocusEventArgs e)
    {
        Focus?.Invoke(this, EventArgs.Empty);
    }
}