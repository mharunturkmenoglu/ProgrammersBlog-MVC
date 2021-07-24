using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc.Utilities
{
    public static class Messages
    {
        public static class Category
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hic bir kategori bulunamadi.";
                return "Boyle bir kategori bulunamadi.";
            }
            public static string Add(string categoryName)
            {
                return $"{categoryName} adli kategori basariyla eklendi.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} adli kategori basariyla guncellendi.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} adli kategori basariyla silindi.";
            }
            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} adli kategori veritabanindan basariyla silindi.";
            }
        }
        public static class Article
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Makaleler bulunamadi";
                return "Boyle bir makale bulunamadi";
            }
            public static string Add(string articleTitle)
            {
                return $"{articleTitle} adli makale basariyla eklendi.";
            }
            public static string Update(string articleTitle)
            {
                return $"{articleTitle} adli makale basariyla guncellendi.";
            }
            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} adli makale basariyla silindi.";
            }
            public static string HardDelete(string articleTitle)
            {
                return $"{articleTitle} adli makale veritabanindan basariyla silindi.";
            }
        }
    }
}
