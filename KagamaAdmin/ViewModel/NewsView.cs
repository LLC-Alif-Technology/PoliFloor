using KagamaModels.Entities;
using System.Collections.Generic;

namespace KagamaAdmin.ViewModel
{
    public class NewsView
    {
        public IEnumerable<Article> Articles { get; set; }

        public IEnumerable<ArticleCategory> ArticleCategories { get; set; }

        public Page Page { get; set; }

        public Article ArticleOpen { get; set; }
    }
}
