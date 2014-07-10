using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using MyRecipeBox.ViewModels;

namespace MyRecipeBox.Views
{
    public partial class RecipeSummaryPage
    {
        public RecipeSummaryPage(RecipeViewModel recipeViewModel)
        {
            InitializeComponent();

            this.BindingContext = recipeViewModel;
        }
    }
}
