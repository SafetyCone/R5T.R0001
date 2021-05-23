using System;


namespace R5T.R0001.TailwindUI
{
    public static class TagHelperPartialViewLocationFormats
    {
        public const string Base = "/Razor/TagHelpers/TailwindUI/{0}.cshtml";


        public static string[] All => new[]
        {
            TagHelperPartialViewLocationFormats.Base,
        };
    }
}
