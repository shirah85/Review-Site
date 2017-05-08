using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

//added this model

namespace TravelReview.Controllers
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Location { get; set; }
        public int Cost { get; set; }
        public string Events { get; set; }        
        public string Distance { get; set; }
        

        [ForeignKey("Category")]
        public int CategotyID { get; set; }
        public virtual Category Category { get; set; }
    }
}