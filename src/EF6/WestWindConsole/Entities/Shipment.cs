﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Shipments")]
    public class Shipment
    {
        [Key]
        public int ShipmentID { get; set; }
        public int OrderID { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; } // FK to the Shipper entity/table
        public decimal FreightCharge { get; set; }
        public string TrackingCode { get; set; }

        [ForeignKey(nameof(ShipVia))]
        public virtual Shipper Shipper { get; set; }
        [ForeignKey(nameof(OrderID))]
        public virtual Order Order { get; set; }

        public virtual ICollection<ManifestItem> ManifestItems { get; set; } = new HashSet<ManifestItem>();
    }
}
