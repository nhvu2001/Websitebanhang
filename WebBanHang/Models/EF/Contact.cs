using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_Contact")]
    public class Contact : CommonAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Tên không được trống")]
        [StringLength(150,ErrorMessage ="Không được quá 150 kí tự")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        [StringLength(4000, ErrorMessage = "Không được quá 4000 kí tự")]
        public string Message { get; set; }
        public bool IsRead { get; set; }
    }
}