﻿namespace CodePulseProject.Model.Domain
{
    public class Blogpost
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Content { get; set; }

        public string UrlHandel { get; set; }

        public string FeatureImageUrl { get; set; }

        public DateTime DateCreaed { get; set; }    

        public string Author {  get; set; }

        public string IsVisible { get; set; }


    }
}