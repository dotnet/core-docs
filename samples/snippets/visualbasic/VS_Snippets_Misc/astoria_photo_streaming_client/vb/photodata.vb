﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


'Original file name: PhotoData.vb
'Generation date: 12/19/2010 11:57:22 PM
Namespace PhotoData
    '''<summary>
    '''There are no comments for PhotoDataContainer in the schema.
    '''</summary>
    Partial Public Class PhotoDataContainer
        Inherits Global.System.Data.Services.Client.DataServiceContext
        '''<summary>
        '''Initialize a new PhotoDataContainer object.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Sub New(ByVal serviceRoot As Global.System.Uri)
            MyBase.New(serviceRoot, Global.System.Data.Services.Common.DataServiceProtocolVersion.V3)
            Me.OnContextCreated
        End Sub
        Partial Private Sub OnContextCreated()
        End Sub
        '''<summary>
        '''There are no comments for PhotoInfo in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public ReadOnly Property PhotoInfo() As Global.System.Data.Services.Client.DataServiceQuery(Of PhotoInfo)
            Get
                If (Me._PhotoInfo Is Nothing) Then
                    Me._PhotoInfo = MyBase.CreateQuery(Of PhotoInfo)("PhotoInfo")
                End If
                Return Me._PhotoInfo
            End Get
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _PhotoInfo As Global.System.Data.Services.Client.DataServiceQuery(Of PhotoInfo)
        '''<summary>
        '''There are no comments for PhotoInfo in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Sub AddToPhotoInfo(ByVal photoInfo As PhotoInfo)
            MyBase.AddObject("PhotoInfo", photoInfo)
        End Sub
    End Class
    '''<summary>
    '''There are no comments for ComplexType PhotoData.Exposure in the schema.
    '''</summary>
    Partial Public Class Exposure
        Implements Global.System.ComponentModel.INotifyPropertyChanged
        '''<summary>
        '''There are no comments for Property Aperature in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Aperature() As Global.System.Nullable(Of Decimal)
            Get
                Return Me._Aperature
            End Get
            Set
                Me.OnAperatureChanging(value)
                Me._Aperature = value
                Me.OnAperatureChanged
                Me.OnPropertyChanged("Aperature")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Aperature As Global.System.Nullable(Of Decimal)
        Partial Private Sub OnAperatureChanging(ByVal value As Global.System.Nullable(Of Decimal))
        End Sub
        Partial Private Sub OnAperatureChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property ShutterSpeed in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property ShutterSpeed() As Global.System.Nullable(Of Short)
            Get
                Return Me._ShutterSpeed
            End Get
            Set
                Me.OnShutterSpeedChanging(value)
                Me._ShutterSpeed = value
                Me.OnShutterSpeedChanged
                Me.OnPropertyChanged("ShutterSpeed")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _ShutterSpeed As Global.System.Nullable(Of Short)
        Partial Private Sub OnShutterSpeedChanging(ByVal value As Global.System.Nullable(Of Short))
        End Sub
        Partial Private Sub OnShutterSpeedChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property FilmSpeed in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property FilmSpeed() As Global.System.Nullable(Of Short)
            Get
                Return Me._FilmSpeed
            End Get
            Set
                Me.OnFilmSpeedChanging(value)
                Me._FilmSpeed = value
                Me.OnFilmSpeedChanged
                Me.OnPropertyChanged("FilmSpeed")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _FilmSpeed As Global.System.Nullable(Of Short)
        Partial Private Sub OnFilmSpeedChanging(ByVal value As Global.System.Nullable(Of Short))
        End Sub
        Partial Private Sub OnFilmSpeedChanged()
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Event PropertyChanged As Global.System.ComponentModel.PropertyChangedEventHandler Implements Global.System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Protected Overridable Sub OnPropertyChanged(ByVal [property] As String)
            If (Not (Me.PropertyChangedEvent) Is Nothing) Then
                RaiseEvent PropertyChanged(Me, New Global.System.ComponentModel.PropertyChangedEventArgs([property]))
            End If
        End Sub
    End Class
    '''<summary>
    '''There are no comments for ComplexType PhotoData.Dimensions in the schema.
    '''</summary>
    Partial Public Class Dimensions
        Implements Global.System.ComponentModel.INotifyPropertyChanged
        '''<summary>
        '''There are no comments for Property Height in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Height() As Global.System.Nullable(Of Short)
            Get
                Return Me._Height
            End Get
            Set
                Me.OnHeightChanging(value)
                Me._Height = value
                Me.OnHeightChanged
                Me.OnPropertyChanged("Height")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Height As Global.System.Nullable(Of Short)
        Partial Private Sub OnHeightChanging(ByVal value As Global.System.Nullable(Of Short))
        End Sub
        Partial Private Sub OnHeightChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Width in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Width() As Global.System.Nullable(Of Short)
            Get
                Return Me._Width
            End Get
            Set
                Me.OnWidthChanging(value)
                Me._Width = value
                Me.OnWidthChanged
                Me.OnPropertyChanged("Width")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Width As Global.System.Nullable(Of Short)
        Partial Private Sub OnWidthChanging(ByVal value As Global.System.Nullable(Of Short))
        End Sub
        Partial Private Sub OnWidthChanged()
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Event PropertyChanged As Global.System.ComponentModel.PropertyChangedEventHandler Implements Global.System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Protected Overridable Sub OnPropertyChanged(ByVal [property] As String)
            If (Not (Me.PropertyChangedEvent) Is Nothing) Then
                RaiseEvent PropertyChanged(Me, New Global.System.ComponentModel.PropertyChangedEventArgs([property]))
            End If
        End Sub
    End Class
    '''<summary>
    '''There are no comments for PhotoData.PhotoInfo in the schema.
    '''</summary>
    '''<KeyProperties>
    '''PhotoId
    '''</KeyProperties>
    <Global.System.Data.Services.Common.EntitySetAttribute("PhotoInfo"),  _
     Global.System.Data.Services.Common.HasStreamAttribute(),  _
     Global.System.Data.Services.Common.DataServiceKeyAttribute("PhotoId")>  _
    Partial Public Class PhotoInfo
        Implements Global.System.ComponentModel.INotifyPropertyChanged
        '''<summary>
        '''Create a new PhotoInfo object.
        '''</summary>
        '''<param name="photoId">Initial value of PhotoId.</param>
        '''<param name="fileName">Initial value of FileName.</param>
        '''<param name="dateAdded">Initial value of DateAdded.</param>
        '''<param name="exposure">Initial value of Exposure.</param>
        '''<param name="dimensions">Initial value of Dimensions.</param>
        '''<param name="dateModified">Initial value of DateModified.</param>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Shared Function CreatePhotoInfo(ByVal photoId As Integer, ByVal fileName As String, ByVal dateAdded As Date, ByVal exposure As Exposure, ByVal dimensions As Dimensions, ByVal dateModified As Date) As PhotoInfo
            Dim photoInfo As PhotoInfo = New PhotoInfo()
            photoInfo.PhotoId = photoId
            photoInfo.FileName = fileName
            photoInfo.DateAdded = dateAdded
            If (exposure Is Nothing) Then
                Throw New Global.System.ArgumentNullException("exposure")
            End If
            photoInfo.Exposure = exposure
            If (dimensions Is Nothing) Then
                Throw New Global.System.ArgumentNullException("dimensions")
            End If
            photoInfo.Dimensions = dimensions
            photoInfo.DateModified = dateModified
            Return photoInfo
        End Function
        '''<summary>
        '''There are no comments for Property PhotoId in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property PhotoId() As Integer
            Get
                Return Me._PhotoId
            End Get
            Set
                Me.OnPhotoIdChanging(value)
                Me._PhotoId = value
                Me.OnPhotoIdChanged
                Me.OnPropertyChanged("PhotoId")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _PhotoId As Integer
        Partial Private Sub OnPhotoIdChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnPhotoIdChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property FileName in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property FileName() As String
            Get
                Return Me._FileName
            End Get
            Set
                Me.OnFileNameChanging(value)
                Me._FileName = value
                Me.OnFileNameChanged
                Me.OnPropertyChanged("FileName")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _FileName As String
        Partial Private Sub OnFileNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnFileNameChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property FileSize in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property FileSize() As Global.System.Nullable(Of Integer)
            Get
                Return Me._FileSize
            End Get
            Set
                Me.OnFileSizeChanging(value)
                Me._FileSize = value
                Me.OnFileSizeChanged
                Me.OnPropertyChanged("FileSize")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _FileSize As Global.System.Nullable(Of Integer)
        Partial Private Sub OnFileSizeChanging(ByVal value As Global.System.Nullable(Of Integer))
        End Sub
        Partial Private Sub OnFileSizeChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property DateTaken in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property DateTaken() As Global.System.Nullable(Of Date)
            Get
                Return Me._DateTaken
            End Get
            Set
                Me.OnDateTakenChanging(value)
                Me._DateTaken = value
                Me.OnDateTakenChanged
                Me.OnPropertyChanged("DateTaken")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _DateTaken As Global.System.Nullable(Of Date)
        Partial Private Sub OnDateTakenChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
        Partial Private Sub OnDateTakenChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property TakenBy in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property TakenBy() As String
            Get
                Return Me._TakenBy
            End Get
            Set
                Me.OnTakenByChanging(value)
                Me._TakenBy = value
                Me.OnTakenByChanged
                Me.OnPropertyChanged("TakenBy")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _TakenBy As String
        Partial Private Sub OnTakenByChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnTakenByChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property DateAdded in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property DateAdded() As Date
            Get
                Return Me._DateAdded
            End Get
            Set
                Me.OnDateAddedChanging(value)
                Me._DateAdded = value
                Me.OnDateAddedChanged
                Me.OnPropertyChanged("DateAdded")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _DateAdded As Date
        Partial Private Sub OnDateAddedChanging(ByVal value As Date)
        End Sub
        Partial Private Sub OnDateAddedChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Exposure in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Exposure() As Exposure
            Get
                If ((Me._Exposure Is Nothing)  _
                            AndAlso (Me._ExposureInitialized <> true)) Then
                    Me._Exposure = New Exposure()
                    Me._ExposureInitialized = true
                End If
                Return Me._Exposure
            End Get
            Set
                Me.OnExposureChanging(value)
                Me._Exposure = value
                Me._ExposureInitialized = true
                Me.OnExposureChanged
                Me.OnPropertyChanged("Exposure")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Exposure As Exposure
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _ExposureInitialized As Boolean
        Partial Private Sub OnExposureChanging(ByVal value As Exposure)
        End Sub
        Partial Private Sub OnExposureChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Dimensions in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Dimensions() As Dimensions
            Get
                If ((Me._Dimensions Is Nothing)  _
                            AndAlso (Me._DimensionsInitialized <> true)) Then
                    Me._Dimensions = New Dimensions()
                    Me._DimensionsInitialized = true
                End If
                Return Me._Dimensions
            End Get
            Set
                Me.OnDimensionsChanging(value)
                Me._Dimensions = value
                Me._DimensionsInitialized = true
                Me.OnDimensionsChanged
                Me.OnPropertyChanged("Dimensions")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Dimensions As Dimensions
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _DimensionsInitialized As Boolean
        Partial Private Sub OnDimensionsChanging(ByVal value As Dimensions)
        End Sub
        Partial Private Sub OnDimensionsChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property DateModified in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property DateModified() As Date
            Get
                Return Me._DateModified
            End Get
            Set
                Me.OnDateModifiedChanging(value)
                Me._DateModified = value
                Me.OnDateModifiedChanged
                Me.OnPropertyChanged("DateModified")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _DateModified As Date
        Partial Private Sub OnDateModifiedChanging(ByVal value As Date)
        End Sub
        Partial Private Sub OnDateModifiedChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Comments in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Comments() As String
            Get
                Return Me._Comments
            End Get
            Set
                Me.OnCommentsChanging(value)
                Me._Comments = value
                Me.OnCommentsChanged
                Me.OnPropertyChanged("Comments")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Comments As String
        Partial Private Sub OnCommentsChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnCommentsChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property ContentType in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property ContentType() As String
            Get
                Return Me._ContentType
            End Get
            Set
                Me.OnContentTypeChanging(value)
                Me._ContentType = value
                Me.OnContentTypeChanged
                Me.OnPropertyChanged("ContentType")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _ContentType As String
        Partial Private Sub OnContentTypeChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnContentTypeChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Thumbnail in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Property Thumbnail() As Global.System.Data.Services.Client.DataServiceStreamLink
            Get
                Return Me._Thumbnail
            End Get
            Set
                Me.OnThumbnailChanging(value)
                Me._Thumbnail = value
                Me.OnThumbnailChanged
                Me.OnPropertyChanged("Thumbnail")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Private _Thumbnail As Global.System.Data.Services.Client.DataServiceStreamLink
        Partial Private Sub OnThumbnailChanging(ByVal value As Global.System.Data.Services.Client.DataServiceStreamLink)
        End Sub
        Partial Private Sub OnThumbnailChanged()
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Public Event PropertyChanged As Global.System.ComponentModel.PropertyChangedEventHandler Implements Global.System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")>  _
        Protected Overridable Sub OnPropertyChanged(ByVal [property] As String)
            If (Not (Me.PropertyChangedEvent) Is Nothing) Then
                RaiseEvent PropertyChanged(Me, New Global.System.ComponentModel.PropertyChangedEventArgs([property]))
            End If
        End Sub
    End Class
End Namespace
