﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.5.20604.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindService
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Northwind")]
	public partial class NorthwindDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertOrder_Detail(Order_Detail instance);
    partial void UpdateOrder_Detail(Order_Detail instance);
    partial void DeleteOrder_Detail(Order_Detail instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    #endregion
		
		public NorthwindDataContext() :
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDataContext(string connection) :
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDataContext(System.Data.IDbConnection connection) :
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<Order_Detail> Order_Details
		{
			get
			{
				return this.GetTable<Order_Detail>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customers")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CustomerID;
		
		private string _CompanyName;
		
		private string _ContactName;
		
		private string _ContactTitle;
		
		private string _Address;
		
		private string _City;
		
		private string _Region;
		
		private string _PostalCode;
		
		private string _Country;
		
		private string _Phone;
		
		private string _Fax;
		
		private EntitySet<Order> _Orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(string value);
    partial void OnCustomerIDChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnContactNameChanging(string value);
    partial void OnContactNameChanged();
    partial void OnContactTitleChanging(string value);
    partial void OnContactTitleChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnRegionChanging(string value);
    partial void OnRegionChanged();
    partial void OnPostalCodeChanging(string value);
    partial void OnPostalCodeChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnFaxChanging(string value);
    partial void OnFaxChanged();
    #endregion
		
		public Customer()
		{
			this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="NChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactName", DbType="NVarChar(30)")]
		public string ContactName
		{
			get
			{
				return this._ContactName;
			}
			set
			{
				if ((this._ContactName != value))
				{
					this.OnContactNameChanging(value);
					this.SendPropertyChanging();
					this._ContactName = value;
					this.SendPropertyChanged("ContactName");
					this.OnContactNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactTitle", DbType="NVarChar(30)")]
		public string ContactTitle
		{
			get
			{
				return this._ContactTitle;
			}
			set
			{
				if ((this._ContactTitle != value))
				{
					this.OnContactTitleChanging(value);
					this.SendPropertyChanging();
					this._ContactTitle = value;
					this.SendPropertyChanged("ContactTitle");
					this.OnContactTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(60)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(15)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region", DbType="NVarChar(15)")]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this.OnRegionChanging(value);
					this.SendPropertyChanging();
					this._Region = value;
					this.SendPropertyChanged("Region");
					this.OnRegionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalCode", DbType="NVarChar(10)")]
		public string PostalCode
		{
			get
			{
				return this._PostalCode;
			}
			set
			{
				if ((this._PostalCode != value))
				{
					this.OnPostalCodeChanging(value);
					this.SendPropertyChanging();
					this._PostalCode = value;
					this.SendPropertyChanged("PostalCode");
					this.OnPostalCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="NVarChar(15)")]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(24)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fax", DbType="NVarChar(24)")]
		public string Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this.OnFaxChanging(value);
					this.SendPropertyChanging();
					this._Fax = value;
					this.SendPropertyChanged("Fax");
					this.OnFaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Order", Storage="_Orders", ThisKey="CustomerID", OtherKey="CustomerID")]
		public EntitySet<Order> Orders
		{
			get
			{
				return this._Orders;
			}
			set
			{
				this._Orders.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Orders(Order entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderID;
		
		private string _CustomerID;
		
		private System.Nullable<int> _EmployeeID;
		
		private System.Nullable<System.DateTime> _OrderDate;
		
		private System.Nullable<System.DateTime> _RequiredDate;
		
		private System.Nullable<System.DateTime> _ShippedDate;
		
		private System.Nullable<int> _ShipVia;
		
		private System.Nullable<decimal> _Freight;
		
		private string _ShipName;
		
		private string _ShipAddress;
		
		private string _ShipCity;
		
		private string _ShipRegion;
		
		private string _ShipPostalCode;
		
		private string _ShipCountry;
		
		private EntitySet<Order_Detail> _Order_Details;
		
		private EntityRef<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(int value);
    partial void OnOrderIDChanged();
    partial void OnCustomerIDChanging(string value);
    partial void OnCustomerIDChanged();
    partial void OnEmployeeIDChanging(System.Nullable<int> value);
    partial void OnEmployeeIDChanged();
    partial void OnOrderDateChanging(System.Nullable<System.DateTime> value);
    partial void OnOrderDateChanged();
    partial void OnRequiredDateChanging(System.Nullable<System.DateTime> value);
    partial void OnRequiredDateChanged();
    partial void OnShippedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnShippedDateChanged();
    partial void OnShipViaChanging(System.Nullable<int> value);
    partial void OnShipViaChanged();
    partial void OnFreightChanging(System.Nullable<decimal> value);
    partial void OnFreightChanged();
    partial void OnShipNameChanging(string value);
    partial void OnShipNameChanged();
    partial void OnShipAddressChanging(string value);
    partial void OnShipAddressChanged();
    partial void OnShipCityChanging(string value);
    partial void OnShipCityChanged();
    partial void OnShipRegionChanging(string value);
    partial void OnShipRegionChanged();
    partial void OnShipPostalCodeChanging(string value);
    partial void OnShipPostalCodeChanged();
    partial void OnShipCountryChanging(string value);
    partial void OnShipCountryChanged();
    #endregion
		
		public Order()
		{
			this._Order_Details = new EntitySet<Order_Detail>(new Action<Order_Detail>(this.attach_Order_Details), new Action<Order_Detail>(this.detach_Order_Details));
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="NChar(5)")]
		public string CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="Int")]
		public System.Nullable<int> EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RequiredDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> RequiredDate
		{
			get
			{
				return this._RequiredDate;
			}
			set
			{
				if ((this._RequiredDate != value))
				{
					this.OnRequiredDateChanging(value);
					this.SendPropertyChanging();
					this._RequiredDate = value;
					this.SendPropertyChanged("RequiredDate");
					this.OnRequiredDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShippedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ShippedDate
		{
			get
			{
				return this._ShippedDate;
			}
			set
			{
				if ((this._ShippedDate != value))
				{
					this.OnShippedDateChanging(value);
					this.SendPropertyChanging();
					this._ShippedDate = value;
					this.SendPropertyChanged("ShippedDate");
					this.OnShippedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipVia", DbType="Int")]
		public System.Nullable<int> ShipVia
		{
			get
			{
				return this._ShipVia;
			}
			set
			{
				if ((this._ShipVia != value))
				{
					this.OnShipViaChanging(value);
					this.SendPropertyChanging();
					this._ShipVia = value;
					this.SendPropertyChanged("ShipVia");
					this.OnShipViaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Freight", DbType="Money")]
		public System.Nullable<decimal> Freight
		{
			get
			{
				return this._Freight;
			}
			set
			{
				if ((this._Freight != value))
				{
					this.OnFreightChanging(value);
					this.SendPropertyChanging();
					this._Freight = value;
					this.SendPropertyChanged("Freight");
					this.OnFreightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipName", DbType="NVarChar(40)")]
		public string ShipName
		{
			get
			{
				return this._ShipName;
			}
			set
			{
				if ((this._ShipName != value))
				{
					this.OnShipNameChanging(value);
					this.SendPropertyChanging();
					this._ShipName = value;
					this.SendPropertyChanged("ShipName");
					this.OnShipNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipAddress", DbType="NVarChar(60)")]
		public string ShipAddress
		{
			get
			{
				return this._ShipAddress;
			}
			set
			{
				if ((this._ShipAddress != value))
				{
					this.OnShipAddressChanging(value);
					this.SendPropertyChanging();
					this._ShipAddress = value;
					this.SendPropertyChanged("ShipAddress");
					this.OnShipAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipCity", DbType="NVarChar(15)")]
		public string ShipCity
		{
			get
			{
				return this._ShipCity;
			}
			set
			{
				if ((this._ShipCity != value))
				{
					this.OnShipCityChanging(value);
					this.SendPropertyChanging();
					this._ShipCity = value;
					this.SendPropertyChanged("ShipCity");
					this.OnShipCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipRegion", DbType="NVarChar(15)")]
		public string ShipRegion
		{
			get
			{
				return this._ShipRegion;
			}
			set
			{
				if ((this._ShipRegion != value))
				{
					this.OnShipRegionChanging(value);
					this.SendPropertyChanging();
					this._ShipRegion = value;
					this.SendPropertyChanged("ShipRegion");
					this.OnShipRegionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipPostalCode", DbType="NVarChar(10)")]
		public string ShipPostalCode
		{
			get
			{
				return this._ShipPostalCode;
			}
			set
			{
				if ((this._ShipPostalCode != value))
				{
					this.OnShipPostalCodeChanging(value);
					this.SendPropertyChanging();
					this._ShipPostalCode = value;
					this.SendPropertyChanged("ShipPostalCode");
					this.OnShipPostalCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipCountry", DbType="NVarChar(15)")]
		public string ShipCountry
		{
			get
			{
				return this._ShipCountry;
			}
			set
			{
				if ((this._ShipCountry != value))
				{
					this.OnShipCountryChanging(value);
					this.SendPropertyChanging();
					this._ShipCountry = value;
					this.SendPropertyChanged("ShipCountry");
					this.OnShipCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Order_Detail", Storage="_Order_Details", ThisKey="OrderID", OtherKey="OrderID")]
		public EntitySet<Order_Detail> Order_Details
		{
			get
			{
				return this._Order_Details;
			}
			set
			{
				this._Order_Details.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Order", Storage="_Customer", ThisKey="CustomerID", OtherKey="CustomerID", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value)
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Orders.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Orders.Add(this);
						this._CustomerID = value.CustomerID;
					}
					else
					{
						this._CustomerID = default(string);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Order_Details(Order_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_Order_Details(Order_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order Details]")]
	public partial class Order_Detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderID;
		
		private int _ProductID;
		
		private decimal _UnitPrice;
		
		private short _Quantity;
		
		private float _Discount;
		
		private EntityRef<Order> _Order;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(int value);
    partial void OnOrderIDChanged();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnUnitPriceChanging(decimal value);
    partial void OnUnitPriceChanged();
    partial void OnQuantityChanging(short value);
    partial void OnQuantityChanged();
    partial void OnDiscountChanging(float value);
    partial void OnDiscountChanged();
    #endregion
		
		public Order_Detail()
		{
			this._Order = default(EntityRef<Order>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="Money NOT NULL")]
		public decimal UnitPrice
		{
			get
			{
				return this._UnitPrice;
			}
			set
			{
				if ((this._UnitPrice != value))
				{
					this.OnUnitPriceChanging(value);
					this.SendPropertyChanging();
					this._UnitPrice = value;
					this.SendPropertyChanged("UnitPrice");
					this.OnUnitPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="SmallInt NOT NULL")]
		public short Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount", DbType="Real NOT NULL")]
		public float Discount
		{
			get
			{
				return this._Discount;
			}
			set
			{
				if ((this._Discount != value))
				{
					this.OnDiscountChanging(value);
					this.SendPropertyChanging();
					this._Discount = value;
					this.SendPropertyChanged("Discount");
					this.OnDiscountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Order_Detail", Storage="_Order", ThisKey="OrderID", OtherKey="OrderID", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value)
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.Order_Details.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.Order_Details.Add(this);
						this._OrderID = value.OrderID;
					}
					else
					{
						this._OrderID = default(int);
					}
					this.SendPropertyChanged("Order");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Order_Detail", Storage="_Product", ThisKey="ProductID", OtherKey="ProductID", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value)
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Order_Details.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Order_Details.Add(this);
						this._ProductID = value.ProductID;
					}
					else
					{
						this._ProductID = default(int);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _ProductName;
		
		private System.Nullable<int> _SupplierID;
		
		private System.Nullable<int> _CategoryID;
		
		private string _QuantityPerUnit;
		
		private System.Nullable<decimal> _UnitPrice;
		
		private System.Nullable<short> _UnitsInStock;
		
		private System.Nullable<short> _UnitsOnOrder;
		
		private System.Nullable<short> _ReorderLevel;
		
		private bool _Discontinued;
		
		private EntitySet<Order_Detail> _Order_Details;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnSupplierIDChanging(System.Nullable<int> value);
    partial void OnSupplierIDChanged();
    partial void OnCategoryIDChanging(System.Nullable<int> value);
    partial void OnCategoryIDChanged();
    partial void OnQuantityPerUnitChanging(string value);
    partial void OnQuantityPerUnitChanged();
    partial void OnUnitPriceChanging(System.Nullable<decimal> value);
    partial void OnUnitPriceChanged();
    partial void OnUnitsInStockChanging(System.Nullable<short> value);
    partial void OnUnitsInStockChanged();
    partial void OnUnitsOnOrderChanging(System.Nullable<short> value);
    partial void OnUnitsOnOrderChanged();
    partial void OnReorderLevelChanging(System.Nullable<short> value);
    partial void OnReorderLevelChanged();
    partial void OnDiscontinuedChanging(bool value);
    partial void OnDiscontinuedChanged();
    #endregion
		
		public Product()
		{
			this._Order_Details = new EntitySet<Order_Detail>(new Action<Order_Detail>(this.attach_Order_Details), new Action<Order_Detail>(this.detach_Order_Details));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupplierID", DbType="Int")]
		public System.Nullable<int> SupplierID
		{
			get
			{
				return this._SupplierID;
			}
			set
			{
				if ((this._SupplierID != value))
				{
					this.OnSupplierIDChanging(value);
					this.SendPropertyChanging();
					this._SupplierID = value;
					this.SendPropertyChanged("SupplierID");
					this.OnSupplierIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int")]
		public System.Nullable<int> CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuantityPerUnit", DbType="NVarChar(20)")]
		public string QuantityPerUnit
		{
			get
			{
				return this._QuantityPerUnit;
			}
			set
			{
				if ((this._QuantityPerUnit != value))
				{
					this.OnQuantityPerUnitChanging(value);
					this.SendPropertyChanging();
					this._QuantityPerUnit = value;
					this.SendPropertyChanged("QuantityPerUnit");
					this.OnQuantityPerUnitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="Money")]
		public System.Nullable<decimal> UnitPrice
		{
			get
			{
				return this._UnitPrice;
			}
			set
			{
				if ((this._UnitPrice != value))
				{
					this.OnUnitPriceChanging(value);
					this.SendPropertyChanging();
					this._UnitPrice = value;
					this.SendPropertyChanged("UnitPrice");
					this.OnUnitPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitsInStock", DbType="SmallInt")]
		public System.Nullable<short> UnitsInStock
		{
			get
			{
				return this._UnitsInStock;
			}
			set
			{
				if ((this._UnitsInStock != value))
				{
					this.OnUnitsInStockChanging(value);
					this.SendPropertyChanging();
					this._UnitsInStock = value;
					this.SendPropertyChanged("UnitsInStock");
					this.OnUnitsInStockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitsOnOrder", DbType="SmallInt")]
		public System.Nullable<short> UnitsOnOrder
		{
			get
			{
				return this._UnitsOnOrder;
			}
			set
			{
				if ((this._UnitsOnOrder != value))
				{
					this.OnUnitsOnOrderChanging(value);
					this.SendPropertyChanging();
					this._UnitsOnOrder = value;
					this.SendPropertyChanged("UnitsOnOrder");
					this.OnUnitsOnOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReorderLevel", DbType="SmallInt")]
		public System.Nullable<short> ReorderLevel
		{
			get
			{
				return this._ReorderLevel;
			}
			set
			{
				if ((this._ReorderLevel != value))
				{
					this.OnReorderLevelChanging(value);
					this.SendPropertyChanging();
					this._ReorderLevel = value;
					this.SendPropertyChanged("ReorderLevel");
					this.OnReorderLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discontinued", DbType="Bit NOT NULL")]
		public bool Discontinued
		{
			get
			{
				return this._Discontinued;
			}
			set
			{
				if ((this._Discontinued != value))
				{
					this.OnDiscontinuedChanging(value);
					this.SendPropertyChanging();
					this._Discontinued = value;
					this.SendPropertyChanged("Discontinued");
					this.OnDiscontinuedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Order_Detail", Storage="_Order_Details", ThisKey="ProductID", OtherKey="ProductID")]
		public EntitySet<Order_Detail> Order_Details
		{
			get
			{
				return this._Order_Details;
			}
			set
			{
				this._Order_Details.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Order_Details(Order_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Order_Details(Order_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
}
#pragma warning restore 1591
