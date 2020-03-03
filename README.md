# Text2HTML
A C# class to convert plain text to HTML
Say you have a text input form field that you want to send in an email. 
You could add HTML tags manually, but that's not user friendly. You could use a HTML editor component. Either way involves sending raw HTML to the server, which is a recipe for a XSS (cross site scripting) attack.
This is a very simple solution that picks apart your plain text, converts URL's into HREF tags and adds a break tag <br /> at the end of every newline.
The methodology uses regular expressions to recognise, and a MatchEvaluator to replace the url's and line breaks.
You could extend it to recognise emails using the same methodology. You could add tokens to create bulleted lists.
It does everything I want it to so I'm leaving it here. Feel free to run with ot if you want to add functionality.
Enjoy!
Ben
