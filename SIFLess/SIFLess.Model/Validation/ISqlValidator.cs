﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIFLess.Model.Profiles;

namespace SIFLess.Model.Validation
{
   public interface ISqlValidator
    {

        string ErrorMessage { get; set; }

        string Text { get; }

        bool Validate(SqlProfile profile);
    }
}
