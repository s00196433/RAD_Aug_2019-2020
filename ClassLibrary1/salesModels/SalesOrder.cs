using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary1.salesModels
{
    [Table("SalesOrder")]
    public  class SalesOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("associatedCustomer")]
        public int CustomerID { get; set; }

        public DateTime orderDate { get; set; }

        public virtual Customer associatedCustomer { get; set; }

    }
}
