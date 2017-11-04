﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using DXNorthwindApp.NorthwindEntitiesDataModel;
using DXNorthwindApp.Common;
using DXNorthwindApp;

namespace DXNorthwindApp.ViewModels {

    /// <summary>
    /// Represents the single Order_Detail object view model.
    /// </summary>
    public partial class Order_DetailViewModel : SingleObjectViewModel<Order_Detail, Tuple<int, int>, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Order_DetailViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Order_DetailViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Order_DetailViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Order_DetailViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Order_DetailViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Order_DetailViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Order_Details, x => x.OrderID) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrders {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Order_DetailViewModel x) => x.LookUpOrders,
                    getRepositoryFunc: x => x.Orders);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Products for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Product> LookUpProducts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (Order_DetailViewModel x) => x.LookUpProducts,
                    getRepositoryFunc: x => x.Products);
            }
        }

    }
}
