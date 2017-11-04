﻿using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using DXNorthwindApp.NorthwindEntitiesDataModel;
using DXNorthwindApp.Common;
using DXNorthwindApp;

namespace DXNorthwindApp.ViewModels {

    /// <summary>
    /// Represents the Suppliers collection view model.
    /// </summary>
    public partial class SupplierCollectionViewModel : CollectionViewModel<Supplier, int, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SupplierCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SupplierCollectionViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SupplierCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SupplierCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SupplierCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SupplierCollectionViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Suppliers) {
        }
    }
}