using System;
using System.Collections.Generic;
using KagamaModels.Entities;
using Microsoft.AspNetCore.Http;

namespace KagamaAdmin.ViewModel
{
    public class ReviewView
    {
        public Page Page { get; set; }
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public int Rating { get; set; }

        public string Title { get; set; }
        public bool IsAllowed { get; set; }
        public  List<Review> Review { get; set; }
        public  List<Service> Services { get; set; }

        public IFormFileCollection Images { get; set; }
        
        
        public string Img2 { get; set; }

        public string Img3 { get; set; }
        
        public string Img4 { get; set; }
        

        public DateTime CreationData { get; set; }
        
        public Service Service { get; set; }
    }
}