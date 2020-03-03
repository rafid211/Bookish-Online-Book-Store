﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_ATP2.Helper
{
    public class PagedData<T> where T : class
    {
        public IEnumerable<T> Data { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }
}