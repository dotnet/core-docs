﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1366
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



[System.Data.Linq.Mapping.DatabaseAttribute(Name="C:\\USERFILES\\TOMFITZ\\VISUAL STUDIO CODENAME ORCAS\\WEBSITES\\WEBSITE6\\APP_DATA\\EXAM" +
  "PLE.MDF")]
public partial class ExampleDataContext : System.Data.Linq.DataContext {
  
  private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
  
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertProduct(Product instance);
  partial void UpdateProduct(Product instance);
  partial void DeleteProduct(Product instance);
  #endregion
  
  static ExampleDataContext() {
  }
  
  public ExampleDataContext(string connection) : 
      base(connection, mappingSource) {
    OnCreated();
  }
  
  public ExampleDataContext(System.Data.IDbConnection connection) : 
      base(connection, mappingSource) {
    OnCreated();
  }
  
  public ExampleDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
      base(connection, mappingSource) {
    OnCreated();
  }
  
  public ExampleDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
      base(connection, mappingSource) {
    OnCreated();
  }
  
  public ExampleDataContext() : 
      base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ExampleConnectionString"].ConnectionString, mappingSource) {
    OnCreated();
  }
  
  public System.Data.Linq.Table<Product> Products {
    get {
      return this.GetTable<Product>();
    }
  }
}

[Table(Name="dbo.Products")]
public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged {
  
  private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
  
  private int _ProductID;
  
  private string _ProductName;
  
  private string _ProductCategory;
  
  private string _Color;
  
  private System.Nullable<decimal> _ListPrice;
  
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate();
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnProductCategoryChanging(string value);
    partial void OnProductCategoryChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnListPriceChanging(System.Nullable<decimal> value);
    partial void OnListPriceChanged();
    #endregion
  
  public Product() {
    OnCreated();
  }
  
  [Column(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
  public int ProductID {
    get {
      return this._ProductID;
    }
    set {
      if ((this._ProductID != value)) {
        this.OnProductIDChanging(value);
        this.SendPropertyChanging();
        this._ProductID = value;
        this.SendPropertyChanged("ProductID");
        this.OnProductIDChanged();
      }
    }
  }
  
  [Column(Storage="_ProductName", DbType="NVarChar(50)")]
  public string ProductName {
    get {
      return this._ProductName;
    }
    set {
      if ((this._ProductName != value)) {
        this.OnProductNameChanging(value);
        this.SendPropertyChanging();
        this._ProductName = value;
        this.SendPropertyChanged("ProductName");
        this.OnProductNameChanged();
      }
    }
  }
  
  [Column(Storage="_ProductCategory", DbType="NVarChar(50)")]
  public string ProductCategory {
    get {
      return this._ProductCategory;
    }
    set {
      if ((this._ProductCategory != value)) {
        this.OnProductCategoryChanging(value);
        this.SendPropertyChanging();
        this._ProductCategory = value;
        this.SendPropertyChanged("ProductCategory");
        this.OnProductCategoryChanged();
      }
    }
  }
  
  [Column(Storage="_Color", DbType="NVarChar(50)")]
  public string Color {
    get {
      return this._Color;
    }
    set {
      if ((this._Color != value)) {
        this.OnColorChanging(value);
        this.SendPropertyChanging();
        this._Color = value;
        this.SendPropertyChanged("Color");
        this.OnColorChanged();
      }
    }
  }
  
  [Column(Storage="_ListPrice", DbType="Money")]
  public System.Nullable<decimal> ListPrice {
    get {
      return this._ListPrice;
    }
    set {
      if ((this._ListPrice != value)) {
        this.OnListPriceChanging(value);
        this.SendPropertyChanging();
        this._ListPrice = value;
        this.SendPropertyChanged("ListPrice");
        this.OnListPriceChanged();
      }
    }
  }
  
  public event PropertyChangingEventHandler PropertyChanging;
  
  public event PropertyChangedEventHandler PropertyChanged;
  
  protected virtual void SendPropertyChanging() {
    if ((this.PropertyChanging != null)) {
      this.PropertyChanging(this, emptyChangingEventArgs);
    }
  }
  
  protected virtual void SendPropertyChanged(String propertyName) {
    if ((this.PropertyChanged != null)) {
      this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
