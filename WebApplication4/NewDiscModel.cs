using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4
{
    public class NewDiscModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string UserID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string GoodID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string percents { get; set; }

        [HiddenInput]
        public string ReturnUrl { get; set; }
    }
}