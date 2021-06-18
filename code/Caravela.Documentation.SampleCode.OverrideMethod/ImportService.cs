﻿using System;

namespace Caravela.Documentation.SampleCode.OverrideMethod.ImportService
{
    class TargetCode
    {
        //readonly IServiceProvider _serviceProvider;

        [ImportServiceAspect]
        private IFormatProvider FormatProvider { get; }

        public string Format(object? o)
        {
            return ((ICustomFormatter)this.FormatProvider.GetFormat(typeof(ICustomFormatter)))
                .Format(null, o, this.FormatProvider);
        }
    }
}