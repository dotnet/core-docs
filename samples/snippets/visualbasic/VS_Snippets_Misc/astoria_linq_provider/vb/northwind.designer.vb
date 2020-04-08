﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30306.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Northwind")>  _
Partial Public Class NorthwindDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertCustomer(instance As Customer)
    End Sub
  Partial Private Sub UpdateCustomer(instance As Customer)
    End Sub
  Partial Private Sub DeleteCustomer(instance As Customer)
    End Sub
  Partial Private Sub InsertOrder(instance As [Order])
    End Sub
  Partial Private Sub UpdateOrder(instance As [Order])
    End Sub
  Partial Private Sub DeleteOrder(instance As [Order])
    End Sub
  Partial Private Sub InsertOrder_Detail(instance As Order_Detail)
    End Sub
  Partial Private Sub UpdateOrder_Detail(instance As Order_Detail)
    End Sub
  Partial Private Sub DeleteOrder_Detail(instance As Order_Detail)
    End Sub
  Partial Private Sub InsertProduct(instance As Product)
    End Sub
  Partial Private Sub UpdateProduct(instance As Product)
    End Sub
  Partial Private Sub DeleteProduct(instance As Product)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("NorthwindConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Customers() As System.Data.Linq.Table(Of Customer)
		Get
			Return Me.GetTable(Of Customer)
		End Get
	End Property
	
	Public ReadOnly Property Orders() As System.Data.Linq.Table(Of [Order])
		Get
			Return Me.GetTable(Of [Order])
		End Get
	End Property
	
	Public ReadOnly Property Order_Details() As System.Data.Linq.Table(Of Order_Detail)
		Get
			Return Me.GetTable(Of Order_Detail)
		End Get
	End Property
	
	Public ReadOnly Property Products() As System.Data.Linq.Table(Of Product)
		Get
			Return Me.GetTable(Of Product)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Customers")>  _
Partial Public Class Customer
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _CustomerID As String
	
	Private _CompanyName As String
	
	Private _ContactName As String
	
	Private _ContactTitle As String
	
	Private _Address As String
	
	Private _City As String
	
	Private _Region As String
	
	Private _PostalCode As String
	
	Private _Country As String
	
	Private _Phone As String
	
	Private _Fax As String
	
	Private _Orders As EntitySet(Of [Order])
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCustomerIDChanging(value As String)
    End Sub
    Partial Private Sub OnCustomerIDChanged()
    End Sub
    Partial Private Sub OnCompanyNameChanging(value As String)
    End Sub
    Partial Private Sub OnCompanyNameChanged()
    End Sub
    Partial Private Sub OnContactNameChanging(value As String)
    End Sub
    Partial Private Sub OnContactNameChanged()
    End Sub
    Partial Private Sub OnContactTitleChanging(value As String)
    End Sub
    Partial Private Sub OnContactTitleChanged()
    End Sub
    Partial Private Sub OnAddressChanging(value As String)
    End Sub
    Partial Private Sub OnAddressChanged()
    End Sub
    Partial Private Sub OnCityChanging(value As String)
    End Sub
    Partial Private Sub OnCityChanged()
    End Sub
    Partial Private Sub OnRegionChanging(value As String)
    End Sub
    Partial Private Sub OnRegionChanged()
    End Sub
    Partial Private Sub OnPostalCodeChanging(value As String)
    End Sub
    Partial Private Sub OnPostalCodeChanged()
    End Sub
    Partial Private Sub OnCountryChanging(value As String)
    End Sub
    Partial Private Sub OnCountryChanged()
    End Sub
    Partial Private Sub OnPhoneChanging(value As String)
    End Sub
    Partial Private Sub OnPhoneChanged()
    End Sub
    Partial Private Sub OnFaxChanging(value As String)
    End Sub
    Partial Private Sub OnFaxChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Orders = New EntitySet(Of [Order])(AddressOf Me.attach_Orders, AddressOf Me.detach_Orders)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustomerID", DbType:="NChar(5) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property CustomerID() As String
		Get
			Return Me._CustomerID
		End Get
		Set
			If (String.Equals(Me._CustomerID, value) = false) Then
				Me.OnCustomerIDChanging(value)
				Me.SendPropertyChanging
				Me._CustomerID = value
				Me.SendPropertyChanged("CustomerID")
				Me.OnCustomerIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CompanyName", DbType:="NVarChar(40) NOT NULL", CanBeNull:=false)>  _
	Public Property CompanyName() As String
		Get
			Return Me._CompanyName
		End Get
		Set
			If (String.Equals(Me._CompanyName, value) = false) Then
				Me.OnCompanyNameChanging(value)
				Me.SendPropertyChanging
				Me._CompanyName = value
				Me.SendPropertyChanged("CompanyName")
				Me.OnCompanyNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContactName", DbType:="NVarChar(30)")>  _
	Public Property ContactName() As String
		Get
			Return Me._ContactName
		End Get
		Set
			If (String.Equals(Me._ContactName, value) = false) Then
				Me.OnContactNameChanging(value)
				Me.SendPropertyChanging
				Me._ContactName = value
				Me.SendPropertyChanged("ContactName")
				Me.OnContactNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContactTitle", DbType:="NVarChar(30)")>  _
	Public Property ContactTitle() As String
		Get
			Return Me._ContactTitle
		End Get
		Set
			If (String.Equals(Me._ContactTitle, value) = false) Then
				Me.OnContactTitleChanging(value)
				Me.SendPropertyChanging
				Me._ContactTitle = value
				Me.SendPropertyChanged("ContactTitle")
				Me.OnContactTitleChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="NVarChar(60)")>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If (String.Equals(Me._Address, value) = false) Then
				Me.OnAddressChanging(value)
				Me.SendPropertyChanging
				Me._Address = value
				Me.SendPropertyChanged("Address")
				Me.OnAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_City", DbType:="NVarChar(15)")>  _
	Public Property City() As String
		Get
			Return Me._City
		End Get
		Set
			If (String.Equals(Me._City, value) = false) Then
				Me.OnCityChanging(value)
				Me.SendPropertyChanging
				Me._City = value
				Me.SendPropertyChanged("City")
				Me.OnCityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Region", DbType:="NVarChar(15)")>  _
	Public Property Region() As String
		Get
			Return Me._Region
		End Get
		Set
			If (String.Equals(Me._Region, value) = false) Then
				Me.OnRegionChanging(value)
				Me.SendPropertyChanging
				Me._Region = value
				Me.SendPropertyChanged("Region")
				Me.OnRegionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PostalCode", DbType:="NVarChar(10)")>  _
	Public Property PostalCode() As String
		Get
			Return Me._PostalCode
		End Get
		Set
			If (String.Equals(Me._PostalCode, value) = false) Then
				Me.OnPostalCodeChanging(value)
				Me.SendPropertyChanging
				Me._PostalCode = value
				Me.SendPropertyChanged("PostalCode")
				Me.OnPostalCodeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Country", DbType:="NVarChar(15)")>  _
	Public Property Country() As String
		Get
			Return Me._Country
		End Get
		Set
			If (String.Equals(Me._Country, value) = false) Then
				Me.OnCountryChanging(value)
				Me.SendPropertyChanging
				Me._Country = value
				Me.SendPropertyChanged("Country")
				Me.OnCountryChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Phone", DbType:="NVarChar(24)")>  _
	Public Property Phone() As String
		Get
			Return Me._Phone
		End Get
		Set
			If (String.Equals(Me._Phone, value) = false) Then
				Me.OnPhoneChanging(value)
				Me.SendPropertyChanging
				Me._Phone = value
				Me.SendPropertyChanged("Phone")
				Me.OnPhoneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Fax", DbType:="NVarChar(24)")>  _
	Public Property Fax() As String
		Get
			Return Me._Fax
		End Get
		Set
			If (String.Equals(Me._Fax, value) = false) Then
				Me.OnFaxChanging(value)
				Me.SendPropertyChanging
				Me._Fax = value
				Me.SendPropertyChanged("Fax")
				Me.OnFaxChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Customer_Order", Storage:="_Orders", ThisKey:="CustomerID", OtherKey:="CustomerID")>  _
	Public Property Orders() As EntitySet(Of [Order])
		Get
			Return Me._Orders
		End Get
		Set
			Me._Orders.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Orders(ByVal entity As [Order])
		Me.SendPropertyChanging
		entity.Customer = Me
	End Sub
	
	Private Sub detach_Orders(ByVal entity As [Order])
		Me.SendPropertyChanging
		entity.Customer = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Orders")>  _
Partial Public Class [Order]
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _OrderID As Integer
	
	Private _CustomerID As String
	
	Private _EmployeeID As System.Nullable(Of Integer)
	
	Private _OrderDate As System.Nullable(Of Date)
	
	Private _RequiredDate As System.Nullable(Of Date)
	
	Private _ShippedDate As System.Nullable(Of Date)
	
	Private _ShipVia As System.Nullable(Of Integer)
	
	Private _Freight As System.Nullable(Of Decimal)
	
	Private _ShipName As String
	
	Private _ShipAddress As String
	
	Private _ShipCity As String
	
	Private _ShipRegion As String
	
	Private _ShipPostalCode As String
	
	Private _ShipCountry As String
	
	Private _Order_Details As EntitySet(Of Order_Detail)
	
	Private _Customer As EntityRef(Of Customer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnOrderIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnOrderIDChanged()
    End Sub
    Partial Private Sub OnCustomerIDChanging(value As String)
    End Sub
    Partial Private Sub OnCustomerIDChanged()
    End Sub
    Partial Private Sub OnEmployeeIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnEmployeeIDChanged()
    End Sub
    Partial Private Sub OnOrderDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnOrderDateChanged()
    End Sub
    Partial Private Sub OnRequiredDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnRequiredDateChanged()
    End Sub
    Partial Private Sub OnShippedDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnShippedDateChanged()
    End Sub
    Partial Private Sub OnShipViaChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnShipViaChanged()
    End Sub
    Partial Private Sub OnFreightChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnFreightChanged()
    End Sub
    Partial Private Sub OnShipNameChanging(value As String)
    End Sub
    Partial Private Sub OnShipNameChanged()
    End Sub
    Partial Private Sub OnShipAddressChanging(value As String)
    End Sub
    Partial Private Sub OnShipAddressChanged()
    End Sub
    Partial Private Sub OnShipCityChanging(value As String)
    End Sub
    Partial Private Sub OnShipCityChanged()
    End Sub
    Partial Private Sub OnShipRegionChanging(value As String)
    End Sub
    Partial Private Sub OnShipRegionChanged()
    End Sub
    Partial Private Sub OnShipPostalCodeChanging(value As String)
    End Sub
    Partial Private Sub OnShipPostalCodeChanged()
    End Sub
    Partial Private Sub OnShipCountryChanging(value As String)
    End Sub
    Partial Private Sub OnShipCountryChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Order_Details = New EntitySet(Of Order_Detail)(AddressOf Me.attach_Order_Details, AddressOf Me.detach_Order_Details)
		Me._Customer = CType(Nothing, EntityRef(Of Customer))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property OrderID() As Integer
		Get
			Return Me._OrderID
		End Get
		Set
			If ((Me._OrderID = value)  _
						= false) Then
				Me.OnOrderIDChanging(value)
				Me.SendPropertyChanging
				Me._OrderID = value
				Me.SendPropertyChanged("OrderID")
				Me.OnOrderIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustomerID", DbType:="NChar(5)")>  _
	Public Property CustomerID() As String
		Get
			Return Me._CustomerID
		End Get
		Set
			If (String.Equals(Me._CustomerID, value) = false) Then
				If Me._Customer.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnCustomerIDChanging(value)
				Me.SendPropertyChanging
				Me._CustomerID = value
				Me.SendPropertyChanged("CustomerID")
				Me.OnCustomerIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EmployeeID", DbType:="Int")>  _
	Public Property EmployeeID() As System.Nullable(Of Integer)
		Get
			Return Me._EmployeeID
		End Get
		Set
			If (Me._EmployeeID.Equals(value) = false) Then
				Me.OnEmployeeIDChanging(value)
				Me.SendPropertyChanging
				Me._EmployeeID = value
				Me.SendPropertyChanged("EmployeeID")
				Me.OnEmployeeIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderDate", DbType:="DateTime")>  _
	Public Property OrderDate() As System.Nullable(Of Date)
		Get
			Return Me._OrderDate
		End Get
		Set
			If (Me._OrderDate.Equals(value) = false) Then
				Me.OnOrderDateChanging(value)
				Me.SendPropertyChanging
				Me._OrderDate = value
				Me.SendPropertyChanged("OrderDate")
				Me.OnOrderDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_RequiredDate", DbType:="DateTime")>  _
	Public Property RequiredDate() As System.Nullable(Of Date)
		Get
			Return Me._RequiredDate
		End Get
		Set
			If (Me._RequiredDate.Equals(value) = false) Then
				Me.OnRequiredDateChanging(value)
				Me.SendPropertyChanging
				Me._RequiredDate = value
				Me.SendPropertyChanged("RequiredDate")
				Me.OnRequiredDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShippedDate", DbType:="DateTime")>  _
	Public Property ShippedDate() As System.Nullable(Of Date)
		Get
			Return Me._ShippedDate
		End Get
		Set
			If (Me._ShippedDate.Equals(value) = false) Then
				Me.OnShippedDateChanging(value)
				Me.SendPropertyChanging
				Me._ShippedDate = value
				Me.SendPropertyChanged("ShippedDate")
				Me.OnShippedDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipVia", DbType:="Int")>  _
	Public Property ShipVia() As System.Nullable(Of Integer)
		Get
			Return Me._ShipVia
		End Get
		Set
			If (Me._ShipVia.Equals(value) = false) Then
				Me.OnShipViaChanging(value)
				Me.SendPropertyChanging
				Me._ShipVia = value
				Me.SendPropertyChanged("ShipVia")
				Me.OnShipViaChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Freight", DbType:="Money")>  _
	Public Property Freight() As System.Nullable(Of Decimal)
		Get
			Return Me._Freight
		End Get
		Set
			If (Me._Freight.Equals(value) = false) Then
				Me.OnFreightChanging(value)
				Me.SendPropertyChanging
				Me._Freight = value
				Me.SendPropertyChanged("Freight")
				Me.OnFreightChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipName", DbType:="NVarChar(40)")>  _
	Public Property ShipName() As String
		Get
			Return Me._ShipName
		End Get
		Set
			If (String.Equals(Me._ShipName, value) = false) Then
				Me.OnShipNameChanging(value)
				Me.SendPropertyChanging
				Me._ShipName = value
				Me.SendPropertyChanged("ShipName")
				Me.OnShipNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipAddress", DbType:="NVarChar(60)")>  _
	Public Property ShipAddress() As String
		Get
			Return Me._ShipAddress
		End Get
		Set
			If (String.Equals(Me._ShipAddress, value) = false) Then
				Me.OnShipAddressChanging(value)
				Me.SendPropertyChanging
				Me._ShipAddress = value
				Me.SendPropertyChanged("ShipAddress")
				Me.OnShipAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipCity", DbType:="NVarChar(15)")>  _
	Public Property ShipCity() As String
		Get
			Return Me._ShipCity
		End Get
		Set
			If (String.Equals(Me._ShipCity, value) = false) Then
				Me.OnShipCityChanging(value)
				Me.SendPropertyChanging
				Me._ShipCity = value
				Me.SendPropertyChanged("ShipCity")
				Me.OnShipCityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipRegion", DbType:="NVarChar(15)")>  _
	Public Property ShipRegion() As String
		Get
			Return Me._ShipRegion
		End Get
		Set
			If (String.Equals(Me._ShipRegion, value) = false) Then
				Me.OnShipRegionChanging(value)
				Me.SendPropertyChanging
				Me._ShipRegion = value
				Me.SendPropertyChanged("ShipRegion")
				Me.OnShipRegionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipPostalCode", DbType:="NVarChar(10)")>  _
	Public Property ShipPostalCode() As String
		Get
			Return Me._ShipPostalCode
		End Get
		Set
			If (String.Equals(Me._ShipPostalCode, value) = false) Then
				Me.OnShipPostalCodeChanging(value)
				Me.SendPropertyChanging
				Me._ShipPostalCode = value
				Me.SendPropertyChanged("ShipPostalCode")
				Me.OnShipPostalCodeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ShipCountry", DbType:="NVarChar(15)")>  _
	Public Property ShipCountry() As String
		Get
			Return Me._ShipCountry
		End Get
		Set
			If (String.Equals(Me._ShipCountry, value) = false) Then
				Me.OnShipCountryChanging(value)
				Me.SendPropertyChanging
				Me._ShipCountry = value
				Me.SendPropertyChanged("ShipCountry")
				Me.OnShipCountryChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Order_Order_Detail", Storage:="_Order_Details", ThisKey:="OrderID", OtherKey:="OrderID")>  _
	Public Property Order_Details() As EntitySet(Of Order_Detail)
		Get
			Return Me._Order_Details
		End Get
		Set
			Me._Order_Details.Assign(value)
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Customer_Order", Storage:="_Customer", ThisKey:="CustomerID", OtherKey:="CustomerID", IsForeignKey:=true)>  _
	Public Property Customer() As Customer
		Get
			Return Me._Customer.Entity
		End Get
		Set
			Dim previousValue As Customer = Me._Customer.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Customer.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Customer.Entity = Nothing
					previousValue.Orders.Remove(Me)
				End If
				Me._Customer.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Orders.Add(Me)
					Me._CustomerID = value.CustomerID
				Else
					Me._CustomerID = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("Customer")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Order_Details(ByVal entity As Order_Detail)
		Me.SendPropertyChanging
		entity.[Order] = Me
	End Sub
	
	Private Sub detach_Order_Details(ByVal entity As Order_Detail)
		Me.SendPropertyChanging
		entity.[Order] = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.[Order Details]")>  _
Partial Public Class Order_Detail
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _OrderID As Integer
	
	Private _ProductID As Integer
	
	Private _UnitPrice As Decimal
	
	Private _Quantity As Short
	
	Private _Discount As Single
	
	Private _Order As EntityRef(Of [Order])
	
	Private _Product As EntityRef(Of Product)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnOrderIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnOrderIDChanged()
    End Sub
    Partial Private Sub OnProductIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnProductIDChanged()
    End Sub
    Partial Private Sub OnUnitPriceChanging(value As Decimal)
    End Sub
    Partial Private Sub OnUnitPriceChanged()
    End Sub
    Partial Private Sub OnQuantityChanging(value As Short)
    End Sub
    Partial Private Sub OnQuantityChanged()
    End Sub
    Partial Private Sub OnDiscountChanging(value As Single)
    End Sub
    Partial Private Sub OnDiscountChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Order = CType(Nothing, EntityRef(Of [Order]))
		Me._Product = CType(Nothing, EntityRef(Of Product))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property OrderID() As Integer
		Get
			Return Me._OrderID
		End Get
		Set
			If ((Me._OrderID = value)  _
						= false) Then
				If Me._Order.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnOrderIDChanging(value)
				Me.SendPropertyChanging
				Me._OrderID = value
				Me.SendPropertyChanged("OrderID")
				Me.OnOrderIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property ProductID() As Integer
		Get
			Return Me._ProductID
		End Get
		Set
			If ((Me._ProductID = value)  _
						= false) Then
				If Me._Product.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnProductIDChanging(value)
				Me.SendPropertyChanging
				Me._ProductID = value
				Me.SendPropertyChanged("ProductID")
				Me.OnProductIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UnitPrice", DbType:="Money NOT NULL")>  _
	Public Property UnitPrice() As Decimal
		Get
			Return Me._UnitPrice
		End Get
		Set
			If ((Me._UnitPrice = value)  _
						= false) Then
				Me.OnUnitPriceChanging(value)
				Me.SendPropertyChanging
				Me._UnitPrice = value
				Me.SendPropertyChanged("UnitPrice")
				Me.OnUnitPriceChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Quantity", DbType:="SmallInt NOT NULL")>  _
	Public Property Quantity() As Short
		Get
			Return Me._Quantity
		End Get
		Set
			If ((Me._Quantity = value)  _
						= false) Then
				Me.OnQuantityChanging(value)
				Me.SendPropertyChanging
				Me._Quantity = value
				Me.SendPropertyChanged("Quantity")
				Me.OnQuantityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Discount", DbType:="Real NOT NULL")>  _
	Public Property Discount() As Single
		Get
			Return Me._Discount
		End Get
		Set
			If ((Me._Discount = value)  _
						= false) Then
				Me.OnDiscountChanging(value)
				Me.SendPropertyChanging
				Me._Discount = value
				Me.SendPropertyChanged("Discount")
				Me.OnDiscountChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Order_Order_Detail", Storage:="_Order", ThisKey:="OrderID", OtherKey:="OrderID", IsForeignKey:=true)>  _
	Public Property [Order]() As [Order]
		Get
			Return Me._Order.Entity
		End Get
		Set
			Dim previousValue As [Order] = Me._Order.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Order.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Order.Entity = Nothing
					previousValue.Order_Details.Remove(Me)
				End If
				Me._Order.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Order_Details.Add(Me)
					Me._OrderID = value.OrderID
				Else
					Me._OrderID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("[Order]")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Product_Order_Detail", Storage:="_Product", ThisKey:="ProductID", OtherKey:="ProductID", IsForeignKey:=true)>  _
	Public Property Product() As Product
		Get
			Return Me._Product.Entity
		End Get
		Set
			Dim previousValue As Product = Me._Product.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Product.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Product.Entity = Nothing
					previousValue.Order_Details.Remove(Me)
				End If
				Me._Product.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Order_Details.Add(Me)
					Me._ProductID = value.ProductID
				Else
					Me._ProductID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Product")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Products")>  _
Partial Public Class Product
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ProductID As Integer
	
	Private _ProductName As String
	
	Private _SupplierID As System.Nullable(Of Integer)
	
	Private _CategoryID As System.Nullable(Of Integer)
	
	Private _QuantityPerUnit As String
	
	Private _UnitPrice As System.Nullable(Of Decimal)
	
	Private _UnitsInStock As System.Nullable(Of Short)
	
	Private _UnitsOnOrder As System.Nullable(Of Short)
	
	Private _ReorderLevel As System.Nullable(Of Short)
	
	Private _Discontinued As Boolean
	
	Private _Order_Details As EntitySet(Of Order_Detail)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnProductIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnProductIDChanged()
    End Sub
    Partial Private Sub OnProductNameChanging(value As String)
    End Sub
    Partial Private Sub OnProductNameChanged()
    End Sub
    Partial Private Sub OnSupplierIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnSupplierIDChanged()
    End Sub
    Partial Private Sub OnCategoryIDChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnCategoryIDChanged()
    End Sub
    Partial Private Sub OnQuantityPerUnitChanging(value As String)
    End Sub
    Partial Private Sub OnQuantityPerUnitChanged()
    End Sub
    Partial Private Sub OnUnitPriceChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnUnitPriceChanged()
    End Sub
    Partial Private Sub OnUnitsInStockChanging(value As System.Nullable(Of Short))
    End Sub
    Partial Private Sub OnUnitsInStockChanged()
    End Sub
    Partial Private Sub OnUnitsOnOrderChanging(value As System.Nullable(Of Short))
    End Sub
    Partial Private Sub OnUnitsOnOrderChanged()
    End Sub
    Partial Private Sub OnReorderLevelChanging(value As System.Nullable(Of Short))
    End Sub
    Partial Private Sub OnReorderLevelChanged()
    End Sub
    Partial Private Sub OnDiscontinuedChanging(value As Boolean)
    End Sub
    Partial Private Sub OnDiscontinuedChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Order_Details = New EntitySet(Of Order_Detail)(AddressOf Me.attach_Order_Details, AddressOf Me.detach_Order_Details)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ProductID() As Integer
		Get
			Return Me._ProductID
		End Get
		Set
			If ((Me._ProductID = value)  _
						= false) Then
				Me.OnProductIDChanging(value)
				Me.SendPropertyChanging
				Me._ProductID = value
				Me.SendPropertyChanged("ProductID")
				Me.OnProductIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductName", DbType:="NVarChar(40) NOT NULL", CanBeNull:=false)>  _
	Public Property ProductName() As String
		Get
			Return Me._ProductName
		End Get
		Set
			If (String.Equals(Me._ProductName, value) = false) Then
				Me.OnProductNameChanging(value)
				Me.SendPropertyChanging
				Me._ProductName = value
				Me.SendPropertyChanged("ProductName")
				Me.OnProductNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SupplierID", DbType:="Int")>  _
	Public Property SupplierID() As System.Nullable(Of Integer)
		Get
			Return Me._SupplierID
		End Get
		Set
			If (Me._SupplierID.Equals(value) = false) Then
				Me.OnSupplierIDChanging(value)
				Me.SendPropertyChanging
				Me._SupplierID = value
				Me.SendPropertyChanged("SupplierID")
				Me.OnSupplierIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CategoryID", DbType:="Int")>  _
	Public Property CategoryID() As System.Nullable(Of Integer)
		Get
			Return Me._CategoryID
		End Get
		Set
			If (Me._CategoryID.Equals(value) = false) Then
				Me.OnCategoryIDChanging(value)
				Me.SendPropertyChanging
				Me._CategoryID = value
				Me.SendPropertyChanged("CategoryID")
				Me.OnCategoryIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_QuantityPerUnit", DbType:="NVarChar(20)")>  _
	Public Property QuantityPerUnit() As String
		Get
			Return Me._QuantityPerUnit
		End Get
		Set
			If (String.Equals(Me._QuantityPerUnit, value) = false) Then
				Me.OnQuantityPerUnitChanging(value)
				Me.SendPropertyChanging
				Me._QuantityPerUnit = value
				Me.SendPropertyChanged("QuantityPerUnit")
				Me.OnQuantityPerUnitChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UnitPrice", DbType:="Money")>  _
	Public Property UnitPrice() As System.Nullable(Of Decimal)
		Get
			Return Me._UnitPrice
		End Get
		Set
			If (Me._UnitPrice.Equals(value) = false) Then
				Me.OnUnitPriceChanging(value)
				Me.SendPropertyChanging
				Me._UnitPrice = value
				Me.SendPropertyChanged("UnitPrice")
				Me.OnUnitPriceChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UnitsInStock", DbType:="SmallInt")>  _
	Public Property UnitsInStock() As System.Nullable(Of Short)
		Get
			Return Me._UnitsInStock
		End Get
		Set
			If (Me._UnitsInStock.Equals(value) = false) Then
				Me.OnUnitsInStockChanging(value)
				Me.SendPropertyChanging
				Me._UnitsInStock = value
				Me.SendPropertyChanged("UnitsInStock")
				Me.OnUnitsInStockChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UnitsOnOrder", DbType:="SmallInt")>  _
	Public Property UnitsOnOrder() As System.Nullable(Of Short)
		Get
			Return Me._UnitsOnOrder
		End Get
		Set
			If (Me._UnitsOnOrder.Equals(value) = false) Then
				Me.OnUnitsOnOrderChanging(value)
				Me.SendPropertyChanging
				Me._UnitsOnOrder = value
				Me.SendPropertyChanged("UnitsOnOrder")
				Me.OnUnitsOnOrderChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ReorderLevel", DbType:="SmallInt")>  _
	Public Property ReorderLevel() As System.Nullable(Of Short)
		Get
			Return Me._ReorderLevel
		End Get
		Set
			If (Me._ReorderLevel.Equals(value) = false) Then
				Me.OnReorderLevelChanging(value)
				Me.SendPropertyChanging
				Me._ReorderLevel = value
				Me.SendPropertyChanged("ReorderLevel")
				Me.OnReorderLevelChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Discontinued", DbType:="Bit NOT NULL")>  _
	Public Property Discontinued() As Boolean
		Get
			Return Me._Discontinued
		End Get
		Set
			If ((Me._Discontinued = value)  _
						= false) Then
				Me.OnDiscontinuedChanging(value)
				Me.SendPropertyChanging
				Me._Discontinued = value
				Me.SendPropertyChanged("Discontinued")
				Me.OnDiscontinuedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Product_Order_Detail", Storage:="_Order_Details", ThisKey:="ProductID", OtherKey:="ProductID")>  _
	Public Property Order_Details() As EntitySet(Of Order_Detail)
		Get
			Return Me._Order_Details
		End Get
		Set
			Me._Order_Details.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Order_Details(ByVal entity As Order_Detail)
		Me.SendPropertyChanging
		entity.Product = Me
	End Sub
	
	Private Sub detach_Order_Details(ByVal entity As Order_Detail)
		Me.SendPropertyChanging
		entity.Product = Nothing
	End Sub
End Class
