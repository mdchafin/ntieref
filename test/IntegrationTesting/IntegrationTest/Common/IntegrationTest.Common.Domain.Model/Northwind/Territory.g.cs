﻿//------------------------------------------------------------------------------
// <autogenerated>
//   This file was generated by T4 code generator NorthwindModel.tt.
//   Any changes made to this file manually may cause incorrect behavior
//   and will be lost next time the file is regenerated.
// </autogenerated>
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
    [DataContract(IsReference = true)]
    [KnownType(typeof(Region))]
    public partial class Territory : Entity<Territory>, INotifyPropertyChanged, INotifyPropertyChanging, IDataErrorInfo
    {
        #region Constructor and Initialization

        // partial method for initialization
        partial void Initialize();

        public Territory()
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
        [SimpleProperty]
        public global::System.String TerritoryID
        {
            get { return _territoryID; }
            set
            {
                if (_territoryID != value)
                {
                    //if (!IsDeserializing && ChangeTracker.IsChangeTrackingEnabled)
                    if (!IsDeserializing && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'TerritoryID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    TerritoryIDChanging(value);
                    OnPropertyChanging("TerritoryID", value);
                    var previousValue = _territoryID;
                    _territoryID = value;
                    OnPropertyChanged("TerritoryID", previousValue, value);
                    TerritoryIDChanged(previousValue);
                }
            }
        }
        private global::System.String _territoryID;

        partial void TerritoryIDChanging(global::System.String newValue);
        partial void TerritoryIDChanged(global::System.String previousValue);

        [DataMember]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public global::System.String TerritoryDescription
        {
            get { return _territoryDescription; }
            set
            {
                if (_territoryDescription != value)
                {
                    TerritoryDescriptionChanging(value);
                    OnPropertyChanging("TerritoryDescription", value);
                    var previousValue = _territoryDescription;
                    _territoryDescription = value;
                    OnPropertyChanged("TerritoryDescription", previousValue, value);
                    TerritoryDescriptionChanged(previousValue);
                }
            }
        }
        private global::System.String _territoryDescription;

        partial void TerritoryDescriptionChanging(global::System.String newValue);
        partial void TerritoryDescriptionChanged(global::System.String previousValue);

        [DataMember]
        [Required]
#if !CLIENT_PROFILE
        [RoundtripOriginal]
#endif
        [SimpleProperty]
        public global::System.Int32 RegionID
        {
            get { return _regionID; }
            set
            {
                if (_regionID != value)
                {
                    //RecordOriginalValue("RegionID", _regionID);
                    RegionIDChanging(value);
                    OnPropertyChanging("RegionID", value);
                    if (!IsDeserializing)
                    {
                        if (Region != null && Region.RegionID != value)
                        {
                            Region = null;
                        }
                    }
                    var previousValue = _regionID;
                    _regionID = value;
                    OnPropertyChanged("RegionID", previousValue, value);
                    RegionIDChanged(previousValue);
                }
            }
        }
        private global::System.Int32 _regionID;

        partial void RegionIDChanging(global::System.Int32 newValue);
        partial void RegionIDChanged(global::System.Int32 previousValue);

        #endregion Simple Properties

        #region Complex Properties

        #endregion Complex Properties

        #region Navigation Properties

        [DataMember]
        [NavigationProperty]
        public Region Region
        {
            get { return _region; }
            set
            {
                if (!object.ReferenceEquals(_region, value))
                {
                    RegionChanging(value);
                    OnPropertyChanging("Region", value);
                    var previousValue = _region;
                    _region = value;
                    FixupRegion(previousValue);
                    OnPropertyChanged("Region", previousValue, value, isNavigationProperty: true);
                    RegionChanged(previousValue);
                }
            }
        }
        private Region _region;

        partial void RegionChanging(Region newValue);
        partial void RegionChanged(Region previousValue);

        #endregion Navigation Properties

        #region ChangeTracking

        protected override void ClearNavigationProperties()
        {
            Region = null;
        }

        #endregion ChangeTracking

        #region Association Fixup

        private void FixupRegion(Region previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }

            if (previousValue != null && previousValue.Territories.Contains(this))
            {
                previousValue.Territories.Remove(this);
            }

            if (Region != null)
            {
                if (!Region.Territories.Contains(this))
                {
                    Region.Territories.Add(this);
                }

                RegionID = Region.RegionID;
            }
            if (ChangeTracker.IsChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Region")
                    && object.ReferenceEquals(ChangeTracker.OriginalValues["Region"], Region))
                {
                    //ChangeTracker.OriginalValues.Remove("Region");
                }
                else
                {
                    //RecordOriginalValue("Region", previousValue);
                }
                if (Region != null && !Region.ChangeTracker.IsChangeTrackingEnabled)
                {
                    Region.StartTracking();
                }
            }
        }

        #endregion Association Fixup

        protected override bool IsKeyEqual(Territory entity)
        {
            return this.TerritoryID == entity.TerritoryID;
        }

        protected override int GetKeyHashCode()
        {
            return ReferenceEquals(this.TerritoryID, null) ? 0 : this.TerritoryID.GetHashCode();
        }
    }
}
