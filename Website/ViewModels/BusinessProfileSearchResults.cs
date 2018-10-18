using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Website.Models;

namespace Website.ViewModels
{
    public class BusinessProfileSearchResults
    {
        [Display(Name = "Search")]
        public string Search { get; set; }
        [Display(Name = "Industry#")]
        public Guid? IndustryId { get; set; }

        public IEnumerable<Industry> Industries { get; set; }
        public IPagedList<BusinessProfile> Results { get; set; }
    }
}