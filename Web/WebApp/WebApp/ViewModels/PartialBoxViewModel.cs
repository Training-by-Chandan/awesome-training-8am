using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.ViewModels
{
    public class PartialBoxViewModel
    {
        public double Numbers { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
    }
    public class PartialCardViewModel
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
    public class IndexPageViewModel
    {
        public List<PartialCardViewModel> Cards { get; set; }
    }
}