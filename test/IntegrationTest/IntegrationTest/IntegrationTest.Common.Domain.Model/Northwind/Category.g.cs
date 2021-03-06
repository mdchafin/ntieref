﻿//------------------------------------------------------------------------------
// <auto-generated>
//   This file was generated by T4 code generator Northwind.tt.
//   Any changes made to this file manually may cause incorrect behavior
//   and will be lost next time the file is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using NTier.Common.Domain.Model;

namespace IntegrationTest.Common.Domain.Model.Northwind
{
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(Product))]
    public partial class Category : Entity, INotifyPropertyChanged, INotifyPropertyChanging, IDataErrorInfo
    {
        #region Constructor and Initialization

        // partial method for initialization
        partial void Initialize();

        public Category()
        {
            Initialize();
        }

        #endregion Constructor and Initialization

        #region Simple Properties

        [DataMember]
        [Key]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [ServerGeneration(ServerGenerationTypes.Insert)]
        [SimpleProperty]
        public global::System.Int32 CategoryID
        {
            get { return _categoryID; }
            set
            {
                if (_categoryID != value)
                {
                    if (!IsDeserializing && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'CategoryID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    CategoryIDChanging(value);
                    OnPropertyChanging("CategoryID", value);
                    var previousValue = _categoryID;
                    _categoryID = value;
                    OnPropertyChanged("CategoryID", previousValue, value);
                    CategoryIDChanged(previousValue);
                }
            }
        }
        private global::System.Int32 _categoryID;

        partial void CategoryIDChanging(global::System.Int32 newValue);
        partial void CategoryIDChanged(global::System.Int32 previousValue);

        [DataMember]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public global::System.String CategoryName
        {
            get { return _categoryName; }
            set
            {
                if (_categoryName != value)
                {
                    CategoryNameChanging(value);
                    OnPropertyChanging("CategoryName", value);
                    var previousValue = _categoryName;
                    _categoryName = value;
                    OnPropertyChanged("CategoryName", previousValue, value);
                    CategoryNameChanged(previousValue);
                }
            }
        }
        private global::System.String _categoryName;

        partial void CategoryNameChanging(global::System.String newValue);
        partial void CategoryNameChanged(global::System.String previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public global::System.String Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    DescriptionChanging(value);
                    OnPropertyChanging("Description", value);
                    var previousValue = _description;
                    _description = value;
                    OnPropertyChanged("Description", previousValue, value);
                    DescriptionChanged(previousValue);
                }
            }
        }
        private global::System.String _description;

        partial void DescriptionChanging(global::System.String newValue);
        partial void DescriptionChanged(global::System.String previousValue);

        [DataMember]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public global::System.Byte[] Picture
        {
            get { return _picture; }
            set
            {
                if (_picture != value)
                {
                    PictureChanging(value);
                    OnPropertyChanging("Picture", value);
                    var previousValue = _picture;
                    _picture = value;
                    OnPropertyChanged("Picture", previousValue, value);
                    PictureChanged(previousValue);
                }
            }
        }
        private global::System.Byte[] _picture;

        partial void PictureChanging(global::System.Byte[] newValue);
        partial void PictureChanged(global::System.Byte[] previousValue);

        #endregion Simple Properties

        #region Complex Properties

        #endregion Complex Properties

        #region Navigation Properties

        [DataMember]
        [NavigationProperty]
        public TrackableCollection<Product> Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new TrackableCollection<Product>();
                    _products.CollectionChanged += FixupProducts;
                }
                return _products;
            }
            set
            {
                if (!ReferenceEquals(_products, value))
                {
                    if (!IsDeserializing && ChangeTracker.IsChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }

                    if (_products != null)
                    {
                       _products.CollectionChanged -= FixupProducts;
                    }

                    _products = value;

                    if (_products != null)
                    {
                        _products.CollectionChanged += FixupProducts;
                    }

                    OnPropertyChanged("Products", trackInChangeTracker: false);
                }
            }
        }
        private TrackableCollection<Product> _products;

        #endregion Navigation Properties

        #region ChangeTracking

        protected override void ClearNavigationProperties()
        {
            Products.Clear();
        }

        #endregion ChangeTracking

        #region Association Fixup

        private void FixupProducts(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }

            if (e.NewItems != null)
            {
                foreach (Product item in e.NewItems)
                {
                    item.Category = this;
                    if (ChangeTracker.IsChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.IsChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        RecordAdditionToCollectionProperties("Products", item);
                    }
                }
            }

            if (e.OldItems != null)
            {
                foreach (Product item in e.OldItems)
                {
                    if (ReferenceEquals(item.Category, this))
                    {
                        item.Category = null;
                    }
                    if (ChangeTracker.IsChangeTrackingEnabled)
                    {
                        RecordRemovalFromCollectionProperties("Products", item);
                    }
                }
            }
        }

        #endregion Association Fixup

        protected override bool IsKeyEqual(Entity other)
        {
            var entity = other as Category;
            if (ReferenceEquals(null, entity)) return false;
            return this.CategoryID == entity.CategoryID;
        }

        protected override int GetKeyHashCode()
        {
            return this.CategoryID.GetHashCode();
        }
    }
}
