using System;
using System.Collections.Generic;
using YouTubeSearch;
using static System.Console;

namespace YoutubeUtility
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Write("輸入youtube要查的關鍵字 : ");
            string searchTxt = ReadLine();
            int searchPage = 1;
            VideoSearch items = new VideoSearch();
            var videoIists = await items.GetVideos(searchTxt, searchPage);
            foreach (var item in videoIists)
            {
                WriteLine("-----------");
                WriteLine($"網址:{item.getUrl()}，作者:{item.getAuthor()}，標題是 {item.getTitle()}");
            }
            WriteLine("結束");
        }
    }
}
