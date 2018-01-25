using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Northwind northwind = new Northwind();
            #region firstExample
            //var allOrders = northwind.Orders.ToList();
            //DateTime? oldOrder = new DateTime();
            //DateTime? newOrder = new DateTime();
            //var result = allOrders.OrderBy(p => p.OrderDate);
            //var oldOrd = result.First();
            //var newOrd = result.Last();
            //oldOrder = oldOrd.OrderDate;
            //newOrder = newOrd.OrderDate;
            //Console.WriteLine(oldOrder);
            #endregion
            #region secondExample
            //var allOrders = northwind.Orders.ToList();
            //TimeSpan? orderLong = new TimeSpan();
            //var result = allOrders.OrderBy(p => p.OrderDate);
            //var order = result.First();
            //foreach (var item in result)
            //{
            //    if((item.RequiredDate - item.OrderDate) >= orderLong)
            //    {
            //        orderLong = (item.RequiredDate - item.OrderDate);
            //        order = item;
            //    }
            //}
            //Console.WriteLine(order.OrderID);
            //Console.ReadLine();
            #endregion
            #region thirdExample
            //var allEmployees = northwind.Employees.ToList();
            //var result = allEmployees.OrderBy(p => p.PostalCode);
            //bool found = false;
            //foreach (var item in result)
            //{
            //    for (int i = 0; i < item.PostalCode.Length; i++)
            //    {
            //        if (((item.PostalCode[i] >= 'a') && (item.PostalCode[i] <= 'z')) || ((item.PostalCode[i] >= 'A') && (item.PostalCode[i] <= 'Z'))) { found = true; }
            //    }
            //    if (found == false)
            //    {
            //        Console.WriteLine(item.EmployeeID);
            //    }
            //    else if(found == true)
            //    {
            //        found = false;
            //    }
            //}
            //Console.ReadLine();
            #endregion
            #region FouthExample
            //var allCustomers = northwind.Customers.ToList();
            //var result = allCustomers.OrderBy(p => p.Country);
            //var resultWithDistinct = result.Select(p=>p.Country).Distinct();
            //List<string> allCountry = new List<string>();
            //foreach (var item in resultWithDistinct)
            //{
            //    allCountry.Add(item);
            //}
            //for (int i = 0; i < allCountry.Count(); i++)
            //{
            //    Console.WriteLine( allCountry[i] + " : " + result.Where(p => p.Country == allCountry[i]).Count() );

            //}
            //Console.ReadLine();
            #endregion
            #region fifthExample
            //var allOrder = northwind.Orders.ToList();

            //var result = allOrder.OrderBy(p => p.EmployeeID);
            //var resultWithDistinct = result.Select(p => p.EmployeeID).Distinct();
            //List<int?> idEmployeers = new List<int?>();
            //foreach (var item in resultWithDistinct)
            //{
            //    idEmployeers.Add(item);
            //}
            //for (int i = 0; i < idEmployeers.Count(); i++)
            //{
            //    Console.WriteLine(idEmployeers[i] + " : " + result.Where(p=>p.EmployeeID == idEmployeers[i]).Count());
            //}

            #endregion
            #region sixExample
            //var allOrderDetails = northwind.Order_Details.ToList();
            //var result = from ord in allOrderDetails group ord by ((ord.Quantity * ord.UnitPrice) >= 5000) ? "дороже 5000$" : ((ord.Quantity * ord.UnitPrice) >= 1000 && (ord.Quantity * ord.UnitPrice) <= 4999) ? "от 1000$ до 4999$" : "от 1$ до 999$";
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var inner in item)
            //    {
            //        Console.WriteLine(inner.OrderID);
            //    }
            //}
            #endregion
            #region sevenExample
            //var allOrderDetails = northwind.Order_Details.ToList();
            //var allProducts = northwind.Products.ToList();
            //var result = from od in allOrderDetails
            //             join pr in allProducts on od.ProductID equals pr.ProductID
            //             select pr.ProductName;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}          

            #endregion
            #region eightExample
            //var allCustomers = northwind.Customers.ToList();
            //var allOrder = northwind.Orders.ToList();
            //var result = from cus in allCustomers
            //             join ord in allOrder on cus.CustomerID equals ord.CustomerID
            //             select new {ord.EmployeeID , cus.CustomerID};
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CustomerID} - {item.EmployeeID}");
            //}
            #endregion
            #region nineExample
            //var allProducts = northwind.Products.ToList();
            //var allOrderDetails = northwind.Order_Details.ToList();
            //var allOrders = northwind.Orders.ToList();
            //var allCustomers = northwind.Customers.ToList();
            //var result = from prod in allProducts
            //             join ordet in allOrderDetails on prod.ProductID equals ordet.ProductID
            //             join ord in allOrders on ordet.OrderID equals ord.OrderID
            //             join cus in allCustomers on ord.CustomerID equals cus.CustomerID
            //             select new { cus.CustomerID, prod.ProductName, prod.ProductID };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.CustomerID}");
            //}

            #endregion
            #region tenExample
            //var allEmployeers = northwind.Employees.ToList();
            //var allOrders = northwind.Orders.ToList();
            //var allOrderDetails = northwind.Order_Details.ToList();
            //var result = from emp in allEmployeers
            //             join ord in allOrders on emp.EmployeeID equals ord.EmployeeID
            //             join ordet in allOrderDetails on ord.OrderID equals ordet.OrderID
            //             select new { emp.EmployeeID, ordet.Quantity, ordet.UnitPrice };
            //var resultWithDistinct = result.Select(p => p.EmployeeID).Distinct();
            //List<int?> idEmployeers = new List<int?>();
            //foreach (var item in resultWithDistinct)
            //{
            //    idEmployeers.Add(item);
            //}
            //for (int i = 0; i < idEmployeers.Count(); i++)
            //{
            //    Console.WriteLine(idEmployeers[i] + " : " + result.Where(p => p.EmployeeID == idEmployeers[i]).Select(p => p.UnitPrice * p.Quantity).Sum() + "$");
            //}

            #endregion
            #region elevenExample
            //var allProducts = northwind.Products.ToList();
            //var allOrderDetails = northwind.Order_Details.ToList();
            //var result = from prod in allProducts
            //             join ordet in allOrderDetails on prod.ProductID equals ordet.ProductID
            //             orderby ordet.OrderID descending
            //             select new { prod.ProductName };
            //var resultTop = result.Take(3);
            //foreach (var item in resultTop)
            //{
            //    Console.WriteLine(item.ProductName);
            //}
            #endregion
            #region TwelveExample
            //var allOrder = northwind.Orders.ToList();
            //var result = from ord in allOrder
            //             group ord by ord.ShipCountry;
            //var resultTop = result.Take(3);
            //foreach (var item in resultTop)
            //{
            //    Console.WriteLine(item.Key);
            //}
            #endregion
            Console.ReadLine();
        }
    }
}
