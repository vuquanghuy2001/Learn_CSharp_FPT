using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Models
{
    public class NewsItem
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }

    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();

            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

        private static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();
            items.Add(new NewsItem() { ID = 1, Category = "Book", Headline = "Đắc nhân tâm", Subhead = "attained human mind", DateLine = "Nunc tristique nec", Image = "Assets/1.jpg" });
            items.Add(new NewsItem() { ID = 1, Category = "Book", Headline = "Đọc sách cộng hưởng", Subhead = "Read resonance", DateLine = "Nunc tristique nec", Image = "/Assets/7.jpg" });
            items.Add(new NewsItem() { ID = 1, Category = "Book", Headline = "Mắt biếc", Subhead = "Blue eyes", DateLine = "Nunc tristique nec", Image = "/Assets/4.jpg" });
            items.Add(new NewsItem() { ID = 1, Category = "Book", Headline = "Thời đại", Subhead = "Age", DateLine = "Nunc tristique nec", Image = "/Assets/9.jpg" });
            items.Add(new NewsItem() { ID = 1, Category = "Book", Headline = "Xin được nói thẳng", Subhead = "Please be blunt", DateLine = "Nunc tristique nec", Image = "/Assets/6.jpg" });
            items.Add(new NewsItem() { ID = 6, Category = "Learning Tools", Headline = "Hộp bút", Subhead = "Pencil case", DateLine = "Nunc tristique nec", Image = "/Assets/13.jpg" });
            items.Add(new NewsItem() { ID = 7, Category = "Learning Tools", Headline = "Bút", Subhead = "Pen", DateLine = "Nunc tristique nec", Image = "/Assets/14.jpg" });
            items.Add(new NewsItem() { ID = 8, Category = "Learning Tools", Headline = "Màu sáp", Subhead = "Waxen", DateLine = "Nunc tristique nec", Image = "/Assets/15.jpg" });
            items.Add(new NewsItem() { ID = 8, Category = "Learning Tools", Headline = "Thước kẻ", Subhead = "Ruler", DateLine = "Nunc tristique nec", Image = "/Assets/16.jpg" });
            return items;
        }
    }
}
