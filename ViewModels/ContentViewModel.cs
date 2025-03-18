﻿using GoshehArtWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.ViewModels
{

    public class ContentViewModel
    {

        public int Id { get; set; }

        [Display(Name = "Content Title")]
        public string? Title { get; set; }
        [Display(Name = "Container Body")]
        public string? Container { get; set; }
        public Page? Page { get; set; }
        public int PageId { get; set; }
        public List<int>? PageIds { get; set; } = new();
        public List<Page>? Pages { get; set; } = new();
        public List<Content>? Contents { get; set; } = new();

    }
}
