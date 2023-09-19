using Scraper;
public class Tests
{


	[Test]
	public void LoadHtmlLinkTest()
	{
			ScraperLink scrap = new ScraperLink("https://html-agility-pack.net/");
			scrap.LoadUrl();
	}
}