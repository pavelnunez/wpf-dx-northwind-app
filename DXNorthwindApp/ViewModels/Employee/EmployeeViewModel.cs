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
    /// Represents the single Employee object view model.
    /// </summary>
    public partial class EmployeeViewModel : SingleObjectViewModel<Employee, int, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EmployeeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EmployeeViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EmployeeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EmployeeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EmployeeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EmployeeViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Employees, x => x.LastName) {
                }


        protected override void RefreshLookUpCollections(bool raisePropertyChanged) {
            base.RefreshLookUpCollections(raisePropertyChanged);
                TerritoriesDetailEntities = CreateAddRemoveDetailEntitiesViewModel(x => x.Territories, x => x.Territories);
        }
        /// <summary>
        /// The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employee> LookUpEmployees {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EmployeeViewModel x) => x.LookUpEmployees,
                    getRepositoryFunc: x => x.Employees);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrders {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EmployeeViewModel x) => x.LookUpOrders,
                    getRepositoryFunc: x => x.Orders);
            }
        }

    public virtual AddRemoveDetailEntitiesViewModel<Employee, Int32, Territory, String, INorthwindEntitiesUnitOfWork> TerritoriesDetailEntities { get; protected set; }

        /// <summary>
        /// The view model for the EmployeeEmployees1 detail collection.
        /// </summary>
        public CollectionViewModelBase<Employee, Employee, int, INorthwindEntitiesUnitOfWork> EmployeeEmployees1Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EmployeeViewModel x) => x.EmployeeEmployees1Details,
                    getRepositoryFunc: x => x.Employees,
                    foreignKeyExpression: x => x.ReportsTo,
                    navigationExpression: x => x.Employee1);
            }
        }

        /// <summary>
        /// The view model for the EmployeeOrders detail collection.
        /// </summary>
        public CollectionViewModelBase<Order, Order, int, INorthwindEntitiesUnitOfWork> EmployeeOrdersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EmployeeViewModel x) => x.EmployeeOrdersDetails,
                    getRepositoryFunc: x => x.Orders,
                    foreignKeyExpression: x => x.EmployeeID,
                    navigationExpression: x => x.Employee);
            }
        }
    }
}
