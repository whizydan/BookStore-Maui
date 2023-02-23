using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.ViewModel
{
    public class IntroScreenViewModel
    {
        #region
        public ObservableCollection<IntroScreenModel> IntroScreens { get; set; } = new ObservableCollection<IntroScreenModel>();
        #endregion

        public IntroScreenViewModel()
        {
            IntroScreens.Add(new IntroScreenModel {
                IntroScreenTitle = "Increase Productivity",
                IntroScreenDescription = "You can efficiently use this app without hussles",
                IntroScreenImage = "intro1"
            });
            IntroScreens.Add(new IntroScreenModel
            {
                IntroScreenTitle = "Run Efficiently",
                IntroScreenDescription = "easily runs on windows 10 and android API level 29 and higher",
                IntroScreenImage = "run"
            });
            IntroScreens.Add(new IntroScreenModel
            {
                IntroScreenTitle = "School oriented",
                IntroScreenDescription = "Test out your skill by building this in the dotnet MAUI framework",
                IntroScreenImage = "school"
            });
        }
    }
}
