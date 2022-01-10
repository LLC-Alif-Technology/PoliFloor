using System;
using System.Collections.Generic;
using System.Text;

namespace KagamaModels.Entities
{
    public class ServiceFloor
    {
        public int Id { get; set; }

        public int ServiceId { get; set; }

        public int FloorId { get; set; }
    }
}
