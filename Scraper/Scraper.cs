using HtmlAgilityPack;
namespace Scraper
{
	public class ScraperLink
	{
		string?  _url;
		HtmlWeb? _web;
		
		
		public ScraperLink(string url)
		{
			_url = url;		
		}
		public void LoadUrl()
		{	
			_web = new HtmlWeb();
			var htmlDoc = _web.Load(_url);
			var node = htmlDoc.DocumentNode.SelectNodes(@"//a");
			Console.WriteLine(node);
		}
	}
}
