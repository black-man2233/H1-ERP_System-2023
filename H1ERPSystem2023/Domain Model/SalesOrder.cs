using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP_System_2023.Domain_Model
{

    public enum Condition
    {
        None,
        Created,
        Confirmed,
        Packed,
        Done
    }
    public class SalesOrder
    {
        public int OrderNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime CompleteDate { get; set; }
        public int CustomerID { get; set; }
        public Condition Condition { get; set; }


    }
    public class OrderSum
    {
        public double Sum { get; set; }

    }

}

