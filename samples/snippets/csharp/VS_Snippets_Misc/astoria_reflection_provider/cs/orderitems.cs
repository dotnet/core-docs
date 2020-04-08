﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name: OrderItems.cs
// Generation date: 7/27/2009 11:32:34 AM
namespace CustomDataService
{
    
    /// <summary>
    /// There are no comments for OrderItemData in the schema.
    /// </summary>
    public partial class OrderItemData : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new OrderItemData object.
        /// </summary>
        public OrderItemData(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Orders in the schema.
        /// </summary>
        public global::System.Data.Services.Client.DataServiceQuery<Order> Orders
        {
            get
            {
                if ((this._Orders == null))
                {
                    this._Orders = base.CreateQuery<Order>("Orders");
                }
                return this._Orders;
            }
        }
        private global::System.Data.Services.Client.DataServiceQuery<Order> _Orders;
        /// <summary>
        /// There are no comments for Items in the schema.
        /// </summary>
        public global::System.Data.Services.Client.DataServiceQuery<Item> Items
        {
            get
            {
                if ((this._Items == null))
                {
                    this._Items = base.CreateQuery<Item>("Items");
                }
                return this._Items;
            }
        }
        private global::System.Data.Services.Client.DataServiceQuery<Item> _Items;
        /// <summary>
        /// There are no comments for Orders in the schema.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }
        /// <summary>
        /// There are no comments for Items in the schema.
        /// </summary>
        public void AddToItems(Item item)
        {
            base.AddObject("Items", item);
        }
    }
    /// <summary>
    /// There are no comments for CustomDataService.Order in the schema.
    /// </summary>
    /// <KeyProperties>
    /// OrderId
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("OrderId")]
    public partial class Order
    {
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="orderId">Initial value of OrderId.</param>
        public static Order CreateOrder(int orderId)
        {
            Order order = new Order();
            order.OrderId = orderId;
            return order;
        }
        /// <summary>
        /// There are no comments for Property OrderId in the schema.
        /// </summary>
        public int OrderId
        {
            get
            {
                return this._OrderId;
            }
            set
            {
                this.OnOrderIdChanging(value);
                this._OrderId = value;
                this.OnOrderIdChanged();
            }
        }
        private int _OrderId;
        partial void OnOrderIdChanging(int value);
        partial void OnOrderIdChanged();
        /// <summary>
        /// There are no comments for Property Customer in the schema.
        /// </summary>
        public string Customer
        {
            get
            {
                return this._Customer;
            }
            set
            {
                this.OnCustomerChanging(value);
                this._Customer = value;
                this.OnCustomerChanged();
            }
        }
        private string _Customer;
        partial void OnCustomerChanging(string value);
        partial void OnCustomerChanged();
        /// <summary>
        /// There are no comments for Items in the schema.
        /// </summary>
        public global::System.Data.Services.Client.DataServiceCollection<Item> Items
        {
            get
            {
                return this._Items;
            }
            set
            {
                if ((value != null))
                {
                    this._Items = value;
                }
            }
        }
        private global::System.Data.Services.Client.DataServiceCollection<Item> _Items = System.Data.Services.Client.DataServiceCollection.Create<Item>();
    }
    /// <summary>
    /// There are no comments for CustomDataService.Item in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Product
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Product")]
    public partial class Item
    {
        /// <summary>
        /// Create a new Item object.
        /// </summary>
        /// <param name="product">Initial value of Product.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        public static Item CreateItem(string product, int quantity)
        {
            Item item = new Item();
            item.Product = product;
            item.Quantity = quantity;
            return item;
        }
        /// <summary>
        /// There are no comments for Property Product in the schema.
        /// </summary>
        public string Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this.OnProductChanging(value);
                this._Product = value;
                this.OnProductChanged();
            }
        }
        private string _Product;
        partial void OnProductChanging(string value);
        partial void OnProductChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        public int Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
            }
        }
        private int _Quantity;
        partial void OnQuantityChanging(int value);
        partial void OnQuantityChanged();
    }
}
