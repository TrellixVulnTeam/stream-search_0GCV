﻿using StreamSearch.Common.Models.Entities;

namespace StreamSearch.Web.Views.Application
{
    public class SearchViewModel
    {

    }

    public class EpisodesViewModel
    {
        public Show Show { get; set; }
    }

    public class WatchViewModel
    {
        public Video Video { get; set; }
    }
}