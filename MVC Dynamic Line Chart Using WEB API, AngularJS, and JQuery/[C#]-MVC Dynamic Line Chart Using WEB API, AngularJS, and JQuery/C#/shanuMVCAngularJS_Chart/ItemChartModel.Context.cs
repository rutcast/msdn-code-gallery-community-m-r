﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace shanuMVCAngularJS_Chart
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ItemsDBEntities : DbContext
    {
        public ItemsDBEntities()
            : base("name=ItemsDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ItemMaster> ItemMasters { get; set; }
    
        public virtual ObjectResult<string> USP_Item_Edit(string itemName, string saleCount)
        {
            var itemNameParameter = itemName != null ?
                new ObjectParameter("ItemName", itemName) :
                new ObjectParameter("ItemName", typeof(string));
    
            var saleCountParameter = saleCount != null ?
                new ObjectParameter("SaleCount", saleCount) :
                new ObjectParameter("SaleCount", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("USP_Item_Edit", itemNameParameter, saleCountParameter);
        }
    
        public virtual ObjectResult<USP_Item_Select_Result> USP_Item_Select(string itemName)
        {
            var itemNameParameter = itemName != null ?
                new ObjectParameter("ItemName", itemName) :
                new ObjectParameter("ItemName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_Item_Select_Result>("USP_Item_Select", itemNameParameter);
        }
    
        public virtual ObjectResult<USP_ItemMaxMin_Select_Result> USP_ItemMaxMin_Select(string itemName)
        {
            var itemNameParameter = itemName != null ?
                new ObjectParameter("ItemName", itemName) :
                new ObjectParameter("ItemName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_ItemMaxMin_Select_Result>("USP_ItemMaxMin_Select", itemNameParameter);
        }
    }
}