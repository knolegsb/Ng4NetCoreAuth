using FluentValidation.Attributes;
using Ng4NetCoreAuth.ViewModels.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ng4NetCoreAuth.ViewModels
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {
      public string UserName { get; set; }
      public string Password { get; set; }
    }
}