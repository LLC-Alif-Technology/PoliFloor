using System;
using System.Collections.Generic;
using System.Text;

namespace KagamaModels.Entities
{
    public class FloorProduct
    {
        public int Id { get; set; }

        public int FloorId { get; set; }

        public int ProductId { get; set; }
    }
}
