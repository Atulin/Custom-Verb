using Microsoft.AspNetCore.Mvc.Routing;

namespace CustomVerb.Infrastructure;

public class HttpQueryAttribute : HttpMethodAttribute
{
    private static readonly IEnumerable<string> SupportedMethods = new [] { "Query" };

    /// <summary>
    /// Creates a new <see cref="HttpQueryAttribute"/>.
    /// </summary>
    public HttpQueryAttribute()
        : base(SupportedMethods)
    {
    }

    /// <summary>
    /// Creates a new <see cref="HttpQueryAttribute"/> with the given route template.
    /// </summary>
    /// <param name="template">The route template. May not be null.</param>
    public HttpQueryAttribute(string template)
        : base(SupportedMethods, template)
    {
        if (template == null)
        {
            throw new ArgumentNullException(nameof(template));
        }
    }
}