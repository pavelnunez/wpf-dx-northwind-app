﻿using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using DXNorthwindApp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DXNorthwindApp.NorthwindEntitiesDataModel {

    /// <summary>
    /// A NorthwindEntitiesUnitOfWork instance that represents the run-time implementation of the INorthwindEntitiesUnitOfWork interface.
    /// </summary>
    public class NorthwindEntitiesUnitOfWork : DbUnitOfWork<NorthwindEntities>, INorthwindEntitiesUnitOfWork {

        public NorthwindEntitiesUnitOfWork(Func<NorthwindEntities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Category, int> INorthwindEntitiesUnitOfWork.Categories {
            get { return GetRepository(x => x.Set<Category>(), (Category x) => x.CategoryID); }
        }

        IRepository<CustomerDemographic, string> INorthwindEntitiesUnitOfWork.CustomerDemographics {
            get { return GetRepository(x => x.Set<CustomerDemographic>(), (CustomerDemographic x) => x.CustomerTypeID); }
        }

        IRepository<Customer, string> INorthwindEntitiesUnitOfWork.Customers {
            get { return GetRepository(x => x.Set<Customer>(), (Customer x) => x.CustomerID); }
        }

        IRepository<Employee, int> INorthwindEntitiesUnitOfWork.Employees {
            get { return GetRepository(x => x.Set<Employee>(), (Employee x) => x.EmployeeID); }
        }

        IRepository<Order_Detail, Tuple<int, int>> INorthwindEntitiesUnitOfWork.Order_Details {
            get { return GetRepository(x => x.Set<Order_Detail>(), (Order_Detail x) => Tuple.Create(x.OrderID, x.ProductID)); }
        }

        IRepository<Order, int> INorthwindEntitiesUnitOfWork.Orders {
            get { return GetRepository(x => x.Set<Order>(), (Order x) => x.OrderID); }
        }

        IRepository<Product, int> INorthwindEntitiesUnitOfWork.Products {
            get { return GetRepository(x => x.Set<Product>(), (Product x) => x.ProductID); }
        }

        IRepository<Region, int> INorthwindEntitiesUnitOfWork.Regions {
            get { return GetRepository(x => x.Set<Region>(), (Region x) => x.RegionID); }
        }

        IRepository<Shipper, int> INorthwindEntitiesUnitOfWork.Shippers {
            get { return GetRepository(x => x.Set<Shipper>(), (Shipper x) => x.ShipperID); }
        }

        IRepository<Supplier, int> INorthwindEntitiesUnitOfWork.Suppliers {
            get { return GetRepository(x => x.Set<Supplier>(), (Supplier x) => x.SupplierID); }
        }

        IRepository<Territory, string> INorthwindEntitiesUnitOfWork.Territories {
            get { return GetRepository(x => x.Set<Territory>(), (Territory x) => x.TerritoryID); }
        }

        IReadOnlyRepository<Alphabetical_list_of_product> INorthwindEntitiesUnitOfWork.Alphabetical_list_of_products {
            get { return GetReadOnlyRepository(x => x.Set<Alphabetical_list_of_product>()); }
        }

        IReadOnlyRepository<Category_Sales_for_1997> INorthwindEntitiesUnitOfWork.Category_Sales_for_1997 {
            get { return GetReadOnlyRepository(x => x.Set<Category_Sales_for_1997>()); }
        }

        IReadOnlyRepository<Current_Product_List> INorthwindEntitiesUnitOfWork.Current_Product_Lists {
            get { return GetReadOnlyRepository(x => x.Set<Current_Product_List>()); }
        }

        IReadOnlyRepository<Customer_and_Suppliers_by_City> INorthwindEntitiesUnitOfWork.Customer_and_Suppliers_by_Cities {
            get { return GetReadOnlyRepository(x => x.Set<Customer_and_Suppliers_by_City>()); }
        }

        IReadOnlyRepository<Invoice> INorthwindEntitiesUnitOfWork.Invoices {
            get { return GetReadOnlyRepository(x => x.Set<Invoice>()); }
        }

        IReadOnlyRepository<Order_Details_Extended> INorthwindEntitiesUnitOfWork.Order_Details_Extendeds {
            get { return GetReadOnlyRepository(x => x.Set<Order_Details_Extended>()); }
        }

        IReadOnlyRepository<Order_Subtotal> INorthwindEntitiesUnitOfWork.Order_Subtotals {
            get { return GetReadOnlyRepository(x => x.Set<Order_Subtotal>()); }
        }

        IReadOnlyRepository<Orders_Qry> INorthwindEntitiesUnitOfWork.Orders_Qries {
            get { return GetReadOnlyRepository(x => x.Set<Orders_Qry>()); }
        }

        IReadOnlyRepository<Product_Sales_for_1997> INorthwindEntitiesUnitOfWork.Product_Sales_for_1997 {
            get { return GetReadOnlyRepository(x => x.Set<Product_Sales_for_1997>()); }
        }

        IReadOnlyRepository<Products_Above_Average_Price> INorthwindEntitiesUnitOfWork.Products_Above_Average_Prices {
            get { return GetReadOnlyRepository(x => x.Set<Products_Above_Average_Price>()); }
        }

        IReadOnlyRepository<Products_by_Category> INorthwindEntitiesUnitOfWork.Products_by_Categories {
            get { return GetReadOnlyRepository(x => x.Set<Products_by_Category>()); }
        }

        IReadOnlyRepository<Sales_by_Category> INorthwindEntitiesUnitOfWork.Sales_by_Categories {
            get { return GetReadOnlyRepository(x => x.Set<Sales_by_Category>()); }
        }

        IReadOnlyRepository<Sales_Totals_by_Amount> INorthwindEntitiesUnitOfWork.Sales_Totals_by_Amounts {
            get { return GetReadOnlyRepository(x => x.Set<Sales_Totals_by_Amount>()); }
        }

        IReadOnlyRepository<Summary_of_Sales_by_Quarter> INorthwindEntitiesUnitOfWork.Summary_of_Sales_by_Quarters {
            get { return GetReadOnlyRepository(x => x.Set<Summary_of_Sales_by_Quarter>()); }
        }

        IReadOnlyRepository<Summary_of_Sales_by_Year> INorthwindEntitiesUnitOfWork.Summary_of_Sales_by_Years {
            get { return GetReadOnlyRepository(x => x.Set<Summary_of_Sales_by_Year>()); }
        }
    }
}
