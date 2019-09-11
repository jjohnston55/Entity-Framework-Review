using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("ManifestItems")]
    public class ManifestItem
    {
        [Key]
        public int ManifestItemID { get; set; }
        public int ShipmentID { get; set; }
        public int ProductID { get; set; }
        public short ShipQuantity { get; set; }

        [ForeignKey(nameof(ShipmentID))]
        public virtual Shipment Shipment { get; set; }

        [ForeignKey(nameof(ProductID))]
        public virtual Product Product { get; set; }
    }
}
