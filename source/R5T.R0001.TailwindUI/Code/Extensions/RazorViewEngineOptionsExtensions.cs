using System;

using Microsoft.AspNetCore.Mvc.Razor;

using R5T.R0001.TailwindUI;


namespace Microsoft.Extensions.DependencyInjection
{
    public static class RazorViewEngineOptionsExtensions
    {
        public static RazorViewEngineOptions AddTailwindUITagHelperPartialViewLocationFormats(this RazorViewEngineOptions options)
        {
            options.AddTagHelperViewLocationFormats(TagHelperPartialViewLocationFormats.All);

            return options;
        }
    }
}
