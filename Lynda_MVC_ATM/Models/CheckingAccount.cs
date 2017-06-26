using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Lynda_MVC_ATM.Models
{
    public class CheckingAccount
    {
        [Required]
        public int id { get; set; }

        [Required]
        [Display(Name = "账号")]
        [Column(TypeName="varchar")]
        [StringLength(10,MinimumLength =6, ErrorMessage = "卡号为6-10个数字")]
        //[RegularExpression(@"\d{6,10}", ErrorMessage = "卡号为6-10个数字")]
        public string AccountNo { get; set; }

        [Required]
        [Display(Name = "名字")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "姓")]
        public string LastName { get; set; }


        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }
        [DataType(DataType.Currency)]
        public decimal Balance
        {
            get; set;
        }

        //和User对象建立关联
        public virtual ApplicationUser User { get; set; }

        //当前用户ID
        [Required]
        public string AplicationUserID { get; set; }

    }
}