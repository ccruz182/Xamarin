using SQLite;
using System;
using TravelRecords.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecords
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class NewTravelPage : ContentPage
  {
    public NewTravelPage()
    {
      InitializeComponent();
    }

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
      Post newPost = new Post()
      {
        Experience = experienceEntry.Text
      };

      using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
      {
        conn.CreateTable<Post>();
        int rows = conn.Insert(newPost);

        if (rows > 0)
        {
          DisplayAlert("Success", "Experience succesfully inserted !!", "OK");
        }

        else
        {
          DisplayAlert("Failure", "Something went wrong", "OK");
        }
      }

    }
  }
}