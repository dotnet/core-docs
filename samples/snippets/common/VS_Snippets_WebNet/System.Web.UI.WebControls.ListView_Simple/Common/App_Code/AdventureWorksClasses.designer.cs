﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[System.Data.Linq.Mapping.DatabaseAttribute(Name="AdventureWorks_Data")]
public partial class AdventureWorksClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertVendor(Vendor instance);
  partial void UpdateVendor(Vendor instance);
  partial void DeleteVendor(Vendor instance);
  #endregion
	
	static AdventureWorksClassesDataContext()
	{
	}
	
	public AdventureWorksClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AdventureWorks_DataConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public AdventureWorksClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public AdventureWorksClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public AdventureWorksClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public AdventureWorksClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Vendor> Vendors
	{
		get
		{
			return this.GetTable<Vendor>();
		}
	}
}

[Table(Name="Purchasing.Vendor")]
public partial class Vendor : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _VendorID = default(int);
	
	private string _AccountNumber;
	
	private string _Name;
	
	private byte _CreditRating;
	
	private bool _PreferredVendorStatus;
	
	private bool _ActiveFlag;
	
	private string _PurchasingWebServiceURL;
	
	private System.DateTime _ModifiedDate;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    partial void OnAccountNumberChanging(string value);
    partial void OnAccountNumberChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCreditRatingChanging(byte value);
    partial void OnCreditRatingChanged();
    partial void OnPreferredVendorStatusChanging(bool value);
    partial void OnPreferredVendorStatusChanged();
    partial void OnActiveFlagChanging(bool value);
    partial void OnActiveFlagChanged();
    partial void OnPurchasingWebServiceURLChanging(string value);
    partial void OnPurchasingWebServiceURLChanged();
    partial void OnModifiedDateChanging(System.DateTime value);
    partial void OnModifiedDateChanged();
    #endregion
	
	public Vendor()
	{
		OnCreated();
	}
	
	[Column(Storage="_VendorID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
	public int VendorID
	{
		get
		{
			return this._VendorID;
		}
	}
	
	[Column(Storage="_AccountNumber", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
	public string AccountNumber
	{
		get
		{
			return this._AccountNumber;
		}
		set
		{
			if ((this._AccountNumber != value))
			{
				this.OnAccountNumberChanging(value);
				this.SendPropertyChanging();
				this._AccountNumber = value;
				this.SendPropertyChanged("AccountNumber");
				this.OnAccountNumberChanged();
			}
		}
	}
	
	[Column(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[Column(Storage="_CreditRating", DbType="TinyInt NOT NULL")]
	public byte CreditRating
	{
		get
		{
			return this._CreditRating;
		}
		set
		{
			if ((this._CreditRating != value))
			{
				this.OnCreditRatingChanging(value);
				this.SendPropertyChanging();
				this._CreditRating = value;
				this.SendPropertyChanged("CreditRating");
				this.OnCreditRatingChanged();
			}
		}
	}
	
	[Column(Storage="_PreferredVendorStatus", DbType="Bit NOT NULL")]
	public bool PreferredVendorStatus
	{
		get
		{
			return this._PreferredVendorStatus;
		}
		set
		{
			if ((this._PreferredVendorStatus != value))
			{
				this.OnPreferredVendorStatusChanging(value);
				this.SendPropertyChanging();
				this._PreferredVendorStatus = value;
				this.SendPropertyChanged("PreferredVendorStatus");
				this.OnPreferredVendorStatusChanged();
			}
		}
	}
	
	[Column(Storage="_ActiveFlag", DbType="Bit NOT NULL")]
	public bool ActiveFlag
	{
		get
		{
			return this._ActiveFlag;
		}
		set
		{
			if ((this._ActiveFlag != value))
			{
				this.OnActiveFlagChanging(value);
				this.SendPropertyChanging();
				this._ActiveFlag = value;
				this.SendPropertyChanged("ActiveFlag");
				this.OnActiveFlagChanged();
			}
		}
	}
	
	[Column(Storage="_PurchasingWebServiceURL", DbType="NVarChar(1024)")]
	public string PurchasingWebServiceURL
	{
		get
		{
			return this._PurchasingWebServiceURL;
		}
		set
		{
			if ((this._PurchasingWebServiceURL != value))
			{
				this.OnPurchasingWebServiceURLChanging(value);
				this.SendPropertyChanging();
				this._PurchasingWebServiceURL = value;
				this.SendPropertyChanged("PurchasingWebServiceURL");
				this.OnPurchasingWebServiceURLChanged();
			}
		}
	}
	
	[Column(Storage="_ModifiedDate", DbType="DateTime NOT NULL")]
	public System.DateTime ModifiedDate
	{
		get
		{
			return this._ModifiedDate;
		}
		set
		{
			if ((this._ModifiedDate != value))
			{
				this.OnModifiedDateChanging(value);
				this.SendPropertyChanging();
				this._ModifiedDate = value;
				this.SendPropertyChanged("ModifiedDate");
				this.OnModifiedDateChanged();
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
