using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace LearnConnectionString.Models
{
    public class Guestbooks
    {
        [DisplayName("編號:")]
        public int id { get; set; }

        [DisplayName("姓名:")]
        public string Name { get; set; }

        [DisplayName("內容:")]
        public string Content { get; set; }
    }
}