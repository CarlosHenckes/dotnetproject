using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotnetproject.Models
{
    public class MyModels
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
    }
}