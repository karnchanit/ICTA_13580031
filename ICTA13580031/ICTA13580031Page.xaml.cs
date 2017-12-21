using Xamarin.Forms;

namespace ICTA13580031
{
    public partial class ICTA13580031Page : ContentPage
    {


        public ICTA13580031Page()
        {
            InitializeComponent();

            okButton.Clicked += OkButton_Clicked;

        }


        void OkButton_Clicked(object sender, System.EventArgs e)
        {
            firstNameLabel.Text = firstNameEntry.Text;
        }
    }
}
