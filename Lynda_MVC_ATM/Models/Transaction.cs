using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lynda_MVC_ATM.Models
{
    public class Transaction
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "交易金额")]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required]
        [Display(Name = "银行卡号")]
        public string CheckingAccountId { get; set; }

        //交易记录和银行卡号关联
        public virtual CheckingAccount CheckingAccount { get; set; }
    }
}

