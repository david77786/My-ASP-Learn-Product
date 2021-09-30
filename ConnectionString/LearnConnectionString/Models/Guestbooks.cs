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
        //編號
        public int id { get; set; }

        [DisplayName("姓名:")]
        //名字
        public string Name { get; set; }

        [DisplayName("內容:")]
        //留言內容
        public string Content { get; set; }

        //新增時間
        public DateTime CreateTime { get; set; }

        //回覆內容
        public string Reply { get; set; }

        //回復時間
        //DataTime ? 資料型態，允許DataTime 有Null產生
        public DateTime? ReplyTime { get; set; }

    }
}