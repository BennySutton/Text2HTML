using System;
using System.Text.RegularExpressions;

class Text2Html
{
    static void Main(string[] args)
    {
        string sInput;

        // The string to search.
        sInput = "aab bccddeeff https://docs.microsoft.com cccg" +  Environment.NewLine + " ghhc https://www.sciencenews.org ccciij jcccckkcc";

        Text2Html c = new Text2Html();

        // Write out the original string.
        Console.WriteLine(sInput);

        // replace URL's with <a href="[URL]">[URL]<a/> HTML tag
        Regex regexHref = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
        MatchEvaluator hrefEvaluator = new MatchEvaluator(c.ReplaceUrlWithHref);
        sInput = regexHref.Replace(sInput, hrefEvaluator);

        // replace line breaks with <br /> HTML tag
        Regex regexNewLine = new Regex(@"^", RegexOptions.Multiline);
        MatchEvaluator newlineEvaluator = new MatchEvaluator(c.ReplaceNewLineWithBreak);
        sInput = regexNewLine.Replace(sInput, newlineEvaluator);

        // Write out the modified string.
        Console.WriteLine(sInput);
    }

    private string ReplaceNewLineWithBreak(Match m)
    {
        return "<br />";
    }

    private string ReplaceUrlWithHref(Match m)
    // Replace each Regex cc match with the number of the occurrence.
    {
        return "<a href='" + m.ToString() + "'>" + m.ToString() + "</a>";
    }
}
