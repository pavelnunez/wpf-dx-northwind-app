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
    /// Represents the Products collection view model.
    /// </summary>
    public partial class ProductCollectionViewModel : CollectionViewModel<Product, int, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ProductCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ProductCollectionViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ProductCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ProductCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProductCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProductCollectionViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Products) {
        }
    }
}