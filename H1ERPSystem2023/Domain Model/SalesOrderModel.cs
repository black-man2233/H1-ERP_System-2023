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
        public int       OrderNumber  { get; set; }
        public DateTime  CreationDate { get; set; }
        public DateTime? CompleteDate { get; set; }

        private CustomerModel _customer;
        public string CustomerID { get; set; }

        public string CustomerName
        {
            get
            {
                //Loops through all the customers
                foreach (CustomerModel customer in Database.Instance.GetAllCustomerModels())
                {
                    //returns the customers name, if the this.CustomerId matches the customerid
                    if (this.CustomerID == customer.PersonID)
                    {
                        return customer.FullName;
                    }
                }

                return null!;
            }
        }

        public string CustomerStreet
        {
            get
            {
                try
                {
                   return _customer.Address.Street;
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
                    if (CustomerID == Database.Instance.GetAllCustomerModels()[i].PersonID)
                    {
                        Database.Instance.GetAllCustomerModels()[i].Address.Street = value;
                        this._customer.Address.Street = value;
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
                    return _customer.Address.Street;
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
                    if (CustomerID == Database.Instance.GetAllCustomerModels()[i].PersonID)
                    {
                        Database.Instance.GetAllCustomerModels()[i].Address.StreetNumber = value;
                        this._customer.Address.StreetNumber = value;
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
                    return _customer.Address.PostalCode;
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
                    if (CustomerID == Database.Instance.GetAllCustomerModels()[i].PersonID)
                    {
                        Database.Instance.GetAllCustomerModels()[i].Address.PostalCode = value;
                        this._customer.Address.PostalCode = value;
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
                    return _customer.Address.City;
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
                    if (CustomerID == Database.Instance.GetAllCustomerModels()[i].PersonID)
                    {
                        Database.Instance.GetAllCustomerModels()[i].Address.City = value;
                        this._customer.Address.City = value;
                        break;
                    }
                }
            }
        }

        public string CustomerPhoneNumbers
        {
            get
            {
                try
                {
                    return _customer.PhoneNumber;
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
                    if (CustomerID == Database.Instance.GetAllCustomerModels()[i].PersonID)
                    {
                        Database.Instance.GetAllCustomerModels()[i].PhoneNumber = value;
                        this._customer.PhoneNumber = value;
                        break;
                    }
                }
            }
        }
        public string CustomerEmailAddress
        {
            get
            {
                try
                {
                    return _customer.EmailAddress;
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
                    if (CustomerID == Database.Instance.GetAllCustomerModels()[i].PersonID)
                    {
                        Database.Instance.GetAllCustomerModels()[i].EmailAddress = value;
                        this._customer.EmailAddress = value;
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
            this.CustomerID = salesOrder.CustomerID;
            this.Condition = salesOrder.Condition;
            this.OrderLines = salesOrder.OrderLines;
        }

        public SalesOrderModel(int orderNumber, string customerId, Condition condition,
            List<OrderLineModel>? orderLines)
        {
            this.OrderNumber = orderNumber;
            this.CreationDate = DateTime.Today;
            this.CompleteDate = null;
            this.CustomerID = customerId;
            this._customer = Database.Instance.GetCustomer(CustomerID);
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
    }
}