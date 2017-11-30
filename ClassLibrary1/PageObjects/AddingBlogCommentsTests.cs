using PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PageObjects
{
    public class AddingBlogCommentsTests : IDisposable
    {
        [Fact]
        public void CanAddCommentToTheBlogNote()
        {
            
            MainPage.Open();
            MainPage.OpenFirstNote();
            Notepage.AddComment(new Comment
            {
                Text = "lorem ipsum",
                Mail = "test@test.pl",
                User = Guid.NewGuid().ToString()
            });
  
           //wejdź na stronę bloga
            //otwóz pierwszą notkę
            //dodaj komentarz
            //sprawdź ze komentarz został dodany
        }
        [Fact]
        public void CanAddCommentToComment()
        {
            MainPage.Open();
            MainPage.OpenFirstNote();
            MainPage.OpenSecondNote();
            Notepage.AddCommentToComment(new Comment
            {
                Text = "drugi komentarz",
                Mail = "test2@test.pl",
                User = Guid.NewGuid().ToString()
            }); 
        }


        public void Dispose()
        {
            Browser.Close();
        }

    }

}