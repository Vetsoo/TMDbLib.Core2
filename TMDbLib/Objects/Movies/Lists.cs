﻿using System.Collections.Generic;

namespace TMDbLib.Objects.Movies
{
    // TODO: Join this with SearchContainer, Lists, MovieResultContainer, ChangesListContainer
    public class Lists
    {
        public int Id { get; set; }
        public int Page { get; set; }
        public List<ListResult> Results { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }
    }
}