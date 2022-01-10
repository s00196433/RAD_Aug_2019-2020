using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary1.salesModels
{
    [Table("OrderLine")]
    public class OrderLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }


        [ForeignKey("associatedSalesOrder")]
        public int SalesOrderID { get; set; }

        [ForeignKey("associatedProduct")]
        public int ProductID { get; set; }
        public int QtyOrder { get; set; }


        public virtual SalesOrder associatedSalesOrder { get; set; }
        public virtual Product associatedProduct { get; set; }


    }
}
