﻿using System;
namespace CookTime.ViewModels
{
    public class MainViewModel
    {
        #region VIEWMODELS
        public LoginViewModel Login { get; set; }

        public SignUpViewModel SignUp { get; set; }

        public CompanySignUpViewModel CompanySignUp { get; set; }

        public TabbedHomeViewModel TabbedHome { get; set; }

        public NewsFeedViewModel NewsFeed { get; set; }

        public SearchViewModel Search { get; set; }

        public AddRecipeViewModel AddRecipe { get; set; }

        public NotificationViewModel Notification { get; set; }

        public MyMenuViewModel MyMenu { get; set; }

        public RecipeDetailViewModel RecipeDetail { get; set; }

        #endregion

        #region ATTRIBUTES

        private static MainViewModel instance;

        #endregion

        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }

        //SINGLETON (instance is never null)
        public static MainViewModel getInstance()
        {
            return instance;
        }
    }
}