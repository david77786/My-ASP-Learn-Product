using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Leaning_Product.Models
{
    public class Guestbook
    {
        [DisplayName("編號")]
        public int id{get;set;}

        [DisplayName("姓名")]
        public string name { get; set; }

        [DisplayName("內容")]
        public string content { get; set; }
    }
}