using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyRecipeBox.Models;
using MyRecipeBox.ViewModels;
using Xamarin.Forms;

namespace MyRecipeBox.Views
{
    public partial class RecipeListPage
    {
        public RecipeListPage()
        {
            InitializeComponent();

            this.BindingContext = new RecipeListViewModel( );
        }

        public void OnItemSelected(object sender, ItemTappedEventArgs args)
        {
            var recipe = args.Item as Recipe;
            if (recipe == null)
                return;

            Navigation.PushAsync(new RecipeSummaryPage(new RecipeViewModel(recipe)));
            // Reset the selected item
            recipeList.SelectedItem = null;
        }
    }
}
