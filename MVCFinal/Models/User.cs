//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCFinalpractice.Models
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public partial class User
    {
        [Required(ErrorMessage = "Please FillUp")]
        [DisplayName("User ID")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please FillUp")]
        [DisplayName("User Name")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please FillUp")]
        [DisplayName("Password")]
        public string Password { get; set; }
        public Nullable<int> DepartmentId { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
