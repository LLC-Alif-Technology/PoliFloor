using KagamaModels.Entities;
using System.Collections.Generic;

namespace KagamaAdmin.ViewModel
{
    public class ProjectsView
    {
        public IEnumerable<Project> Projects { get; set; }

        public Page Page { get; set; }

        public Project Project { get; set; }

        public Project PrevProject { get; set; }

        public Project NextProject { get; set; }

        public IEnumerable<GalleryItem> GalleryItems { get; set; }
    }
}
