using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User
    {
        public String username { set; get; }
        public String pwd { set; get; }
        public String sex { set; get; }
        public String province { set; get; }
        public String city { set; get; }
        public String email { set; get; }
        public String pic { set; get; }
        public String tel { set; get; }
        public String[] master { set; get; }
        public String[] habit { set; get; }
        public String birthday { set; get; }
        public String other { set; get; }
    }
}