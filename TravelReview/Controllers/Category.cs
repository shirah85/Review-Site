using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

//added this model

namespace TravelReview.Controllers
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        //[Display(Name = "Category Name")]
        [Display(Name = "Rating on 5 star scale")]
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}