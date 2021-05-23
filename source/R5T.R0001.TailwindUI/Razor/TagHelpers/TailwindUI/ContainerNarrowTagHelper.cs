using System;

using Microsoft.AspNetCore.Razor.TagHelpers;

using R5T.D0061;


namespace R5T.R0001.TailwindUI
{
    /// <summary>
    /// Narrow constrained with padded content.
    /// </summary>
    /// <remarks>
    /// Tailwind UI component: https://tailwindui.com/components/application-ui/layout/containers#component-19e43f3ad1f1f984ec0c02bdb305353f
    /// </remarks>
    [HtmlTargetElement("tailwind-ui-container-narrow")]
    public class ContainerNarrowTagHelper : RazorViewContentWrappingTagHelperBase
    {
        protected override string ViewName => TagHelperViewNames.ContainerNarrow;
        protected override bool PreserveElement => false;


        public ContainerNarrowTagHelper(IRazorViewStringRenderer razorViewStringRenderer)
            : base(razorViewStringRenderer)
        {
        }
    }
}
