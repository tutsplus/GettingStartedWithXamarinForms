using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyRecipeBox.Models;
using MyRecipeBox.ViewModels;
using MyRecipeBox.Views;
using Xamarin.Forms;

namespace MyRecipeBox
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new NavigationPage(new RecipeListPage());
        }
    }
}
