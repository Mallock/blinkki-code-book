using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Blinkki_CB
{


    class Favourites
    {
        public DataTable favTable = new DataTable("Favourites");

        public void LoadFavTable()
        {
            favTable.Columns.Add("url", typeof(String));
            favTable.Columns.Add("name", typeof(String));
            favTable.Columns.Add("icon", typeof(byte[]));
            favTable.Columns.Add("clicks", typeof(int));
            if (blinkki.Default.favouritePages == "")
            {
                StringWriter writer = new StringWriter();
                favTable.WriteXml(writer);
                blinkki.Default.favouritePages = writer.ToString();
                blinkki.Default.Save();
            }
            else
            {
                StringReader reader = new StringReader(blinkki.Default.favouritePages);
                favTable.ReadXml(reader);
                WriteFavPage(favTable);
            }
        }

        public void WriteFavPage(DataTable favs)
        {

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory() + "/fav.html"))
            {
                file.WriteLine("<!DOCTYPE html>");
                file.WriteLine("<html>");
                file.WriteLine("<head>");
                file.WriteLine("<title>helmi</title>");
                file.WriteLine("<meta http-equiv=\"content-type\" content=\"text/html;charset=utf-8\" />");
                file.WriteLine("<style>");
                file.WriteLine(@"html, body
        {
            background-color:  #F4F3F2;
            -webkit-font-smoothing: antialiased;
            font-smooth: always;
            font-family: 'Oxygen', sans-serif;
            font-weight: normal;
            font-size: 12px;
            line-height: 140%;
            word-spacing: normal;
            letter-spacing: normal;
            color: black;
            text-decoration: none;
            text-transform: none;
            text-align: left;
            text-indent: 0ex;
            margin-left : auto;
            margin-right: auto;
            height:100%;
            width:100%;
        }
        a:link { color:black;
                 text-decoration: none;
        }
        a:hover {
            cursor: pointer;
            color: black;
        }
        
        .title:hover {
            text-decoration: underline;
        }

        a:visited { color:black;}

        a img {
            border: none;    
            
        }

        .page_img {     
            box-shadow: 0px 1px 2px 0px rgba(0, 0, 0, 0.22);
            border-radius: 8px;
            -moz-border-radius: 8px;
            -webkit-border-radius: 8px;  
            
            
            background: #202020;
            background-color: rgba(0, 0, 0, 0.3);          
            overflow: hidden;           
            margin-left : auto;
            margin-right: auto;
            width: 100%;
            text-align: center;
            
        }

        .favservice {
            border-radius: 8px;
            -moz-border-radius: 8px;
            -webkit-border-radius: 8px;  

            background: #202020;
            

            background-color: #F4F3F2;

            overflow: hidden;
            margin-left : auto;
            margin-right: auto;
            padding: 0px;

            color: black;   
            margin-left : auto;
            margin-right: auto;

            max-width:225px;   
            width: 100%;
            

            display: -moz-inline-stack;
            vertical-align: top;
            display: inline-block;
            position: relative;
            margin: 14px;       
            text-align: center;
            
        }

       #sitedisplay{

            height: 100%;
            width: 100%;
            text-align: center;
            margin-left : auto;
            margin-right: auto;            
            break-inside: auto;
            padding-bottom:140px;
            position:relative;


        }

.title {   
            padding:0px 5px;
            -webkit-font-smoothing: antialiased;    
            
            
            line-height: 150%;
            font-size: 12px;
            padding-top: 2px;
            
            font-weight:bold;   
            vertical-align: middle;
            letter-spacing: .05em;
           
            display: block;

        }
        h2 {
            font-size: 12px;
        }
        A.title {color:white; text-overflow: ellipsis; display: block;}
        A.title:link  {text-decoration: none; color: white; text-overflow: ellipsis;}
        A.title:visited {text-decoration: none; color: white; text-overflow: ellipsis;}
        A.title:hover {text-decoration: none; color: white; text-overflow: ellipsis;}
        A.title:active {text-decoration: none; color: white; text-overflow: ellipsis;}
         ");
                file.WriteLine("</style>");
                file.WriteLine("</head>");
                file.WriteLine("<body>");
                file.WriteLine("<div id=\"sitedisplay\">");
                
                DataRowCollection rc = GetFavs();
                foreach (DataRow r in rc)
                {
                    file.WriteLine("<div class=\"favservice\">");
                    file.WriteLine(
                    "<div class='page_img'>" +
                    "<a href='" + r[0].ToString() + "'>" +
                    "<img src='http://api.pagepeeker.com/v2/thumbs.php?size=x&amp;url=" + r[0].ToString() + "' style='width:100%; height:auto; margin: 0 auto; display: block;\'></a></div>");
                    file.WriteLine("<div class=\"title\"><h2><a href='" + r[0].ToString() + "'><span itemprop='name'>" + truncateString(r[1].ToString(), 100) + "</span></a></h2></div>");
                    file.WriteLine("</div>");
                    
                }

                file.WriteLine("</div>");
                file.WriteLine("</div>");
                file.WriteLine("</body>");
                file.WriteLine("</html>");
            }
        }

        public static string truncateString(string originalString, int length)
        {
            if (string.IsNullOrEmpty(originalString))
            {
                return originalString;
            }
            if (originalString.Length > length)
            {
                return originalString.Substring(0, length) + "...";
            }
            else
            {
                return originalString;
            }
        }

        public void SaveFavTable()
        {
            StringWriter writer = new StringWriter();
            favTable.WriteXml(writer);
            blinkki.Default.favouritePages = writer.ToString();
            blinkki.Default.Save();
            WriteFavPage(favTable);
        }

        public bool IsFav(string url)
        {
            bool result = false;
            try
            {
                String searchUrl = url;
                DataRow[] drr = favTable.Select("url='" + searchUrl + "' ");
                if (drr.Length > 0)
                {
                    result = true;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public void SaveFavLink(string url, string name, Icon icon, int clicks)
        {
            if (!IsFav(url))
            {
                DataRow dr = favTable.NewRow();
                dr[0] = url;
                dr[1] = name;
                dr[2] = IconToBytes(icon);
                dr[3] = clicks;
                favTable.Rows.Add(dr);
            }
            else
            {
                DataRow[] drr = favTable.Select("url='" + url + "' ");
                for (int i = 0; i < drr.Length; i++)
                    drr[i].Delete();
            }
        }

        public void UpdateFavLink(string url)
        {
            if (IsFav(url))
            {
                DataRow[] drr = favTable.Select("url='" + url + "' ");
                for (int i = 0; i < drr.Length; i++)
                {
                    drr[i][3] = (int)drr[i][3] + 1;
                    drr[i].AcceptChanges();
                }

            }
        }

        public byte[] IconToBytes(Icon icon)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Image img = icon.ToBitmap();
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Bitmap BytesToBitmap(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return new Bitmap(ms);
            }
        }

        public DataRowCollection GetFavs()
        {
            DataView dv = favTable.DefaultView;
            dv.Sort = "clicks" + " DESC";
            DataTable sortedDT = dv.ToTable();
            return sortedDT.Rows;
        }

    }
}
