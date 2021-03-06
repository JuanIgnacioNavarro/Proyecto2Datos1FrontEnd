﻿using CookTime.FileHelpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace CookTime.Models
{
    /*
     * This class is the model of a recipe, it has all its characteristics
     */
    public class Recipe
    {
        private ImageSource recipeImage;


        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "portions")]
        public int Portions { get; set; }

        [JsonProperty(PropertyName = "cookingSpan")]
        public string CookingSpan { get; set; }

        [JsonProperty(PropertyName = "eatingTime")]
        public string EatingTime { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }

        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        [JsonProperty(PropertyName = "ingredients")]
        public string Ingredients { get; set; }

        [JsonProperty(PropertyName = "steps")]
        public string Steps { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public List<Comment> Comments { get; set; }

        [JsonProperty(PropertyName = "likers")]
        public string[] Likers { get; set; }

        [JsonProperty(PropertyName = "price")]
        public object Price { get; set; }

        [JsonProperty(PropertyName = "difficulty")]
        public int Difficulty { get; set; }

        [JsonProperty(PropertyName = "punctuation")]
        public int Punctuation { get; set; }

        [JsonProperty(PropertyName = "shares")]
        public int Shares { get; set; }


        //INTERNAL PROPERTIES
        public ImageSource UserImage { get; set; }

        public ImageSource RecipeImage { get { return ConvertImage(Image); } set { recipeImage = value; } }

        public MemoryStream RecipeImageStream { get; set; }


        #region METHODS

        public ImageSource ConvertImage(string imageValue)
        {

            ImageSource retSource = "DefaultRecipeIcon";
            if (!string.IsNullOrEmpty(imageValue))
            {
                try
                {
                    byte[] imageAsBytes = Convert.FromBase64String(imageValue);
                    retSource = ImageSource.FromStream(() => new MemoryStream(imageAsBytes));
                }
                catch (Exception)
                {
                    return retSource;
                }

            }
            return retSource;
        }
        #endregion
    }
}
