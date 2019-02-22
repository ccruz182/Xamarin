using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecords
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
   
    private void LoginButton_Clicked(object sender, EventArgs e)
    {
      bool emailValidation = string.IsNullOrEmpty(emailEntry.Text);
      bool passValidation = string.IsNullOrEmpty(passwordEntry.Text);

      if (emailValidation || passValidation)
      {
        errorMsgLabel.Text = "You must enter something in each one of the entries";
        errorMsgLabel.TextColor = Color.Red;

      }
      else {
        Navigation.PushAsync(new HomePage());
      }
    }
  }
}
