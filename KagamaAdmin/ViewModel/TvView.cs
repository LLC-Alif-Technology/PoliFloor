using KagamaModels.Entities;
using System.Collections.Generic;

namespace KagamaAdmin.ViewModel
{
    public class TvView
    {
        public Page Page { get; set; }

        public IEnumerable<Tv> Tvs { get; set; }

        public Tv Tv { get; set; }

        public IEnumerable<GalleryItem> GalleryItems { get; set; }

        public Tv PrevTv { get; set; }

        public Tv NextTv { get; set; }
    }
}
