using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("EmployeeTerritories")]
    public class EmployeeTerritory
    {
        [Key, Column(Order = 1)]
        public int EmployeeID { get; set; }
        [Key, Column(Order = 2)]
        public string TerritoryID { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(TerritoryID)]
        public virtual Territory Territory { get; set; }
    }
}
