﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebShop.ViewModels
{
    public class SignupViewModel : IValidatableObject 
    {
        [StringLength(10), Required, Display(Name = "用户名")]
        public string Title { get; set; }

        [StringLength(255), Required, DataType(DataType.EmailAddress), Display(Name = "邮箱")]
        public string Email { get; set; }

        [StringLength(255), Required, DataType(DataType.Password), Display(Name = "密码")]
        public string Password { get; set; }

        [StringLength(255), Required, DataType(DataType.Password), Compare("Password"), Display(Name = "确认密码")]
        public string RepeatPassword { get; set; }

        public bool ReceiveNewsletter { get; set; }
        public bool AcceptTerms { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!AcceptTerms)
                yield return new ValidationResult("你必须接受条款");
        }

    }
}