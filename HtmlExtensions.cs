using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;

namespace Rasputil
{
	public static class HtmlExtensions
	{
		public static IHtmlContent Inline(this IHtmlHelper html, string path) => html.Raw(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), path)));
	}
}