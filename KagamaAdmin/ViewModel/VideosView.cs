using System.Collections.Generic;
using KagamaModels.Entities;

namespace KagamaAdmin.ViewModel
{
    public class VideosView
    {
        public Page Page { get; set; }

        public IEnumerable<Video> Videos { get; set; }

        public IEnumerable<VideoCategory> VideoCategories { get; set; }

        public Video Video { get; set; }
    }
}
