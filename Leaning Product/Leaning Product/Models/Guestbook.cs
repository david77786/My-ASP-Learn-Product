using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Leaning_Product.Models
{
    [Table ("MyGuestbook")]
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