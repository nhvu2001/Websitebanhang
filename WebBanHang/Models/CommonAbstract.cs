using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    public class CommonAbstract
    {
        
        public String CreatedBy { get; set; }
        public DateTime CeatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public String ModifiedBy{ get; set; } 
    }
}