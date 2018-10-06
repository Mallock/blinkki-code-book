using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Globalization;
using System.Text;

namespace Blinkki_CB.api.internet
{
    class SearchSuggestionsAPI
    {
        
        public void StartSearchSuggestions(string query, web_view frm)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(query))
                {
                    string[] emptyStringArray = new string[0];
                    frm.BeginInvoke(((Action)(() => frm.UpdateSearchSuggestions(emptyStringArray.ToArray()))));
                }

                string _suggestSearchUrl = "http://www.google.com/complete/search?output=toolbar&q=" + Uri.EscapeDataString(query) + "&hl=" + CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

                string result = String.Empty;
                List<string> resultList = new List<string> { };

                HttpWebRequest http = (HttpWebRequest)HttpWebRequest.Create(_suggestSearchUrl);
                http.Timeout = 1000;
                HttpWebResponse response = (HttpWebResponse)http.GetResponse();
                Encoding encoding = Encoding.UTF8;
                try
                {
                    if (response != null && !string.IsNullOrEmpty(response.CharacterSet))
                        encoding = Encoding.GetEncoding(response.CharacterSet);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    encoding = Encoding.UTF8;
                }

                using (StreamReader sr = new StreamReader(response.GetResponseStream(), encoding))
                {
                    result = sr.ReadToEnd();
                }

                XDocument doc = XDocument.Parse(result);

                var suggestions = from suggestion in doc.Descendants("CompleteSuggestion")
                                  select new GoogleSuggestion
                                  {
                                      Phrase = suggestion.Element("suggestion").Attribute("data").Value
                                  };
                foreach (var pharse in suggestions)
                {
                    resultList.Add(pharse.Phrase);
                }
                frm.BeginInvoke(((Action)(() => frm.UpdateSearchSuggestions(resultList.ToArray()))));
            }
            catch
            {
                string[] emptyStringArray = new string[0];
                frm.BeginInvoke(((Action)(() => frm.UpdateSearchSuggestions(emptyStringArray.ToArray()))));
            }

        }
    }

    
    public class GoogleSuggestion
    {
        
        public string Phrase { get; set; }

        
        public override string ToString()
        {
            return this.Phrase;
        }
    }

}

