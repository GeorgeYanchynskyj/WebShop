using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4
{
    public class DelDiscModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string DiscountID { get; set; }       

        [HiddenInput]
        public string ReturnUrl { get; set; }
    }
}