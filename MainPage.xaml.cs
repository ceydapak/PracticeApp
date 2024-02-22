using CommunityToolkit.Maui.Views;
using PracticeApp.Comps.PopAlert;

namespace PracticeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        private void entry1_EntryChanged(object sender, EventArgs e)
        {
            //entry2.Text = entry1.Text;
            grid2.Label1Change = entry1.Text;
        }
        private void OKBtn_Click(object sender, EventArgs e)
        {
            string inputText = entry1.Text;
            if (string.IsNullOrWhiteSpace(inputText))
            {
                Validate.Text = "Metin girişi boş olamaz.";
            }
            else
                Validate.Text = "Metin girişi geçerli.";
            }

        private void PopUp_Click(object sender, EventArgs e)
        {
            PopupComp popup1 = new PopupComp();
            popup1.Message = "Popup mesaj!";
            this.ShowPopup(popup1);

        }
    }

       

       
    }


