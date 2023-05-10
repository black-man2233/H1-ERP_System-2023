using H1_ERP_System_2023.Screens;
using H1ERPSystem2023.Databasefiles;
#pragma warning disable
using Org.BouncyCastle.Asn1.Mozilla;

namespace H1ERPSystem2023.DomainModel
{
    public enum Condition
    {
        None,
        Created,
        Confirmed,
        Packed,
        Done
    }

    public class SalesOrderModel
    {
        public int OrderNumber { get; set; }
        public DateTime CreationDate { get; set; }

        public string CreationDateString
        {
            get
            {
                return CreationDate.ToString("dd/mm/yyyy");
            }
        }
        public DateTime? CompleteDate { get; set; }

        public CustomerModel OrderCustomer = new();

        public string CustomerID
        {
            get
            {
                return OrderCustomer.PersonID;
            }
            set
            {

            }
        }

        public string CustomerName
        {
            get
            {
                //Loops through all the customers
                foreach (CustomerModel customer in Database.Instance.GetAllCustomerModels())
                {
                    //returns the customers name, if the this.CustomerId matches the customerid
                    if (this.OrderCustomer.PersonID == customer.PersonID)
                    {
                        return customer.FullName;
                    }
                }

                return null!;
            }
            set
            {

            }
        }

        public string CustomerStreet
        {
            get
            {
                try
                {
                    return OrderCustomer.Address.Street;
                }
                catch
                {
                    return "";
                }

            }

            set
            {
                for (int i = 0; i < Database.Instance.GetAllCustomerModels().Count() - 1; i++)
                {
                    if (OrderCustomer.PersonID == Database.Instance.GetAllCustomerModels()[i].PersonID)
                    {
                        Database.Instance.GetAllCustomerModels()[i].Address.Street = value;
                        this.OrderCustomer.Address.Street = value;
                        break;
                    }
                }
            }
        }

        public string CustomerStreetNumber
        {
            get
            {
                try
                {
                    return OrderCustomer.Address.Street;
                }
                catch
                {
                    return "";
                }

            }
            set
            {
                for (int i = 0; i < Database.Instance.GetAllCustomerModels().Count() - 1; i++)
                {
                    if (OrderCustomer.PersonID == Database.Instance.GetAllCustomerModels()[i].PersonID)
                    {
                        Database.Instance.GetAllCustomerModels()[i].Address.StreetNumber = value;
                        this.OrderCustomer.Address.StreetNumber = value;
                        break;
                    }
                }
            }
        }

        public string CustomerPostalCode
        {
            get
            {
                try
                {
                    return OrderCustomer.Address.PostalCode;
                }
                catch
                {
                    return "";
                }

            }
            set
            {
                for (int i = 0; i < Database.Instance.GetAllCustomerModels().Count() - 1; i++)
                {
                    if (OrderCustomer.PersonID == Database.Instance.GetAllCustomerModels()[i].PersonID)
                    {
                        Database.Instance.GetAllCustomerModels()[i].Address.PostalCode = value;
                        this.OrderCustomer.Address.PostalCode = value;
                        break;
                    }
                }
            }
        }

        public string CustomerCity
        {
            get
            {
                try
                {
                    return OrderCustomer.Address.City;
                }
                catch
                {
                    return "";
                }

            }
            set
            {
                for (int i = 0; i < Database.Instance.GetAllCustomerModels().Count() - 1; i++)
                {
                    if (OrderCustomer.PersonID == Database.Instance.GetAllCustomerModels()[i].PersonID)
                    {
                        Database.Instance.GetAllCustomerModels()[i].Address.City = value;
                        this.OrderCustomer.Address.City = value;
                        break;
                    }
                }
            }
        }

        public string CustomerPhoneNumbers
        {
            get
            {
                return OrderCustomer.PhoneNumber;
            }
            set
            {
                //ValueSetter<string>(value, OrderCustomer, OrderCustomer.PhoneNumber);
            }
        }
        public string CustomerEmailAddress
        {
            get
            {
                try
                {
                    return OrderCustomer.EmailAddress;
                }
                catch
                {
                    return "";
                }

            }
            set
            {
                for (int i = 0; i < Database.Instance.GetAllCustomerModels().Count() - 1; i++)
                {
                    if (OrderCustomer.PersonID == Database.Instance.GetAllCustomerModels()[i].PersonID)
                    {
                        Database.Instance.GetAllCustomerModels()[i].EmailAddress = value;
                        this.OrderCustomer.EmailAddress = value;
                        break;
                    }
                }
            }
        }
        public Condition Condition { get; set; }
        public List<OrderLineModel>? OrderLines { get; }

        public double Amount
        {
            get => sum();
        }

        // <summary>
        // Gives a sum of Product
        // </summary>
        // <returns>The sum of all the product chosen</returns>

        #region Constructors

        public SalesOrderModel(SalesOrderModel salesOrder)
        {
            this.OrderNumber = salesOrder.OrderNumber;
            this.CreationDate = salesOrder.CreationDate;
            this.CompleteDate = salesOrder.CompleteDate;
            this.OrderCustomer.PersonID = salesOrder.OrderCustomer.PersonID;
            this.Condition = salesOrder.Condition;
            this.OrderLines = salesOrder.OrderLines;
        }

        public SalesOrderModel(int orderNumber, string personID, Condition condition,
            List<OrderLineModel>? orderLines)
        {
            this.OrderNumber = orderNumber;
            this.CreationDate = DateTime.Now;
            this.CompleteDate = null;
            this.OrderCustomer.PersonID = personID;
            this.OrderCustomer = Database.Instance.GetCustomer(OrderCustomer.PersonID);
            this.Condition = condition;
            this.OrderLines = orderLines;
        }

        public SalesOrderModel()
        {
        }

        #endregion

        private double sum()
        {
            if (OrderLines is not null)
            {
                double sum = 0;
                foreach (OrderLineModel line in OrderLines)
                {
                    sum += line.Product.SellPrice;
                }

                return sum;
            }

            //returns 0 if the Orderlines is either empty or null
            return 0;
        }
        /*
        private void ValueSetter<T>(T value, CustomerModel customer, T property)
        {

            if (customer.PersonID == Database.Instance.GetAllCustomerModels()[i].PersonID)
            {
                //                                          EXAMPLE
                Database.Instance.GetAllCustomerModels()[i].property = value;
                //                 EXAMPLE
                this.OrderCustomer.property = value;
                break;
            }

        }
        */
    }
}