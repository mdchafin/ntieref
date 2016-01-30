﻿//------------------------------------------------------------------------------
// <auto-generated>
//   This file was generated by T4 code generator ProductModel.tt.
//   Any changes made to this file manually may cause incorrect behavior
//   and will be lost next time the file is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using NTier.Common.Domain.Model;

namespace ProductManager.Common.Domain.Model.ProductManager
{
    [DataContract(IsReference = true)]
    public partial class ProductManagerChangeSet : IChangeSet
    {

        public ProductManagerChangeSet()
        {
        }

        protected ProductManagerChangeSet(ProductManagerChangeSet changeSet)
        {
            this.Products = changeSet.Products;
            this.ProductCategories = changeSet.ProductCategories;
        }

        [DataMember]
        public List<Product> Products { get; set; }

        [DataMember]
        public List<ProductCategory> ProductCategories { get; set; }


        public bool IsEmpty
        {
            get
            {
                return (ReferenceEquals(null, Products) || Products.Count == 0)
                    && (ReferenceEquals(null, ProductCategories) || ProductCategories.Count == 0);
            }
        }

        public IEnumerator<Entity> GetEnumerator()
        {
            if (Products != null && Products.Count > 0)
            {
                foreach (var item in Products)
                {
                    yield return item;
                }
            }

            if (ProductCategories != null && ProductCategories.Count > 0)
            {
                foreach (var item in ProductCategories)
                {
                    yield return item;
                }
            }

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}