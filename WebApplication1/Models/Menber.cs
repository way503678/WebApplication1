//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Menber
    {
        [DisplayName("User ID")]
        [Required(ErrorMessage ="帳號欄位必須輸入")]
        public string Account { get; set; }
        [DisplayName("Pass Word")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "密碼欄位必須輸入")]
        public string passwd { get; set; }

        public string LoginErrorMessage { get; set; }
    }
}
