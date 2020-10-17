using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U044.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public String Category { get; set; }
        public String Headline { get; set; }
        public String Subhead { get; set; }
        public String DateLine { get; set; }
        public String Image { get; set; }
    }

    public class Newsmanager
    {

        public static void GetNews(
            string category,
            ObservableCollection<NewsItem> newsItems)
        {
            var allItems = GetNewsItems();

            var fillteredNewsItems = allItems
                .Where(p => p.Category == category)
                .ToList();

            newsItems.Clear();

            fillteredNewsItems.ForEach(p => newsItems.Add(p));
        }

        private static List<NewsItem> GetNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id =1 , Category = "Huy", Headline = "Quang", Subhead = "Vũ", DateLine = "20/02/2021", Image = "1.jpg" });
            items.Add(new NewsItem() { Id =2 , Category = "Huy", Headline = "Quang", Subhead = "Vũ", DateLine = "20/02/2021", Image = "2.jpg" });
            items.Add(new NewsItem() { Id =3 , Category = "Huy", Headline = "Quang", Subhead = "Vũ", DateLine = "20/02/2021", Image = "3.jpeg" });
            items.Add(new NewsItem() { Id =4 , Category = "Huy", Headline = "Quang", Subhead = "Vũ", DateLine = "20/02/2021", Image = "4.jpg" });
            items.Add(new NewsItem() { Id =5 , Category = "Huy", Headline = "Quang", Subhead = "Vũ", DateLine = "20/02/2021", Image = "5.jpg" });
            items.Add(new NewsItem() { Id =6 , Category = "Huy", Headline = "Quang", Subhead = "Vũ", DateLine = "20/02/2021", Image = "6.jpg" });
            items.Add(new NewsItem() { Id =7 , Category = "Huy", Headline = "Quang", Subhead = "Vũ", DateLine = "20/02/2021", Image = "7.jpg" });
            items.Add(new NewsItem() { Id =8 , Category = "Huy", Headline = "Quang", Subhead = "Vũ", DateLine = "20/02/2021", Image = "8.png" });
            items.Add(new NewsItem() { Id =9 , Category = "Huy", Headline = "Quang", Subhead = "Vũ", DateLine = "20/02/2021", Image = "9.jpg" });
            items.Add(new NewsItem() { Id =10 , Category = "Huy", Headline = "Quang", Subhead = "Vũ", DateLine = "20/02/2021", Image = "10.jpg" });
            items.Add(new NewsItem() { Id =11 , Category = "Huy", Headline = "Quang", Subhead = "Vũ", DateLine = "20/02/2021", Image = "11.jpg" });
            items.Add(new NewsItem() { Id =12 , Category = "Huy", Headline = "Quang", Subhead = "Vũ", DateLine = "20/02/2021", Image = "12.jpg" });
            return items;
        }
    }
}
