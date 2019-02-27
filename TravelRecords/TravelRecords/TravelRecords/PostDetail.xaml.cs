using SQLite;
using System;
using TravelRecords.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecords
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class PostDetail : ContentPage
  {
    Post selectedPost;

    public PostDetail(Post selectedPost)
    {
      InitializeComponent();
      this.selectedPost = selectedPost;

      experienceLabel.Text = selectedPost.Experience;
    }

    private void updateButton_Clicked(object sender, EventArgs e)
    {
      selectedPost.Experience = experienceLabel.Text;

      using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
      {
        conn.CreateTable<Post>();
        int rows = conn.Update(selectedPost);

        if (rows > 0)
        {
          DisplayAlert("Success", "Experience succesfully updated !!", "OK");
        }

        else
        {
          DisplayAlert("Failure", "Something went wrong", "OK");
        }
      }
    }

    private void deleteButton_Clicked(object sender, EventArgs e)
    {

      using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
      {
        conn.CreateTable<Post>();
        int rows = conn.Delete(selectedPost);

        if (rows > 0)
        {
          DisplayAlert("Success", "Experience succesfully deleted !!", "OK");
        }

        else
        {
          DisplayAlert("Failure", "Something went wrong", "OK");
        }
      }

    }
  }
}