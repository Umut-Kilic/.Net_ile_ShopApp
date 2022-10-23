using EntityLayer;
using System;
using System.Collections.Generic;

namespace Goksell_WebApp.Models
{
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentCategory { get; set; }
        public int TotalPages()
        {
            return (int)Math.Ceiling(Convert.ToDouble(TotalItems / ItemsPerPage)) + 1;
        }
    }
    public class ProductListViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
    }
}
