﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using Splat;

namespace Wabbajack
{
    public static class ConverterRegistration
    {
        public static void Register()
        {
            Locator.CurrentMutable.RegisterConstant(
                new CommandConverter(),
                typeof(IBindingTypeConverter)
            );
            Locator.CurrentMutable.RegisterConstant(
                new IntDownCastConverter(),
                typeof(IBindingTypeConverter)
            );
            Locator.CurrentMutable.RegisterConstant(
                new PercentToDoubleConverter(),
                typeof(IBindingTypeConverter)
            );
        }
    }
}
