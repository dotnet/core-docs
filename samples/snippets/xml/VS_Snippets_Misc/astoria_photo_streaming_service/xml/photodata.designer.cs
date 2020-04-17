﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace PhotoService
{
    #region Contexts

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PhotoDataContainer : ObjectContext
    {
        #region Constructors

        /// <summary>
        /// Initializes a new PhotoDataContainer object using the connection string found in the 'PhotoDataContainer' section of the application configuration file.
        /// </summary>
        public PhotoDataContainer() : base("name=PhotoDataContainer", "PhotoDataContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new PhotoDataContainer object.
        /// </summary>
        public PhotoDataContainer(string connectionString) : base(connectionString, "PhotoDataContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new PhotoDataContainer object.
        /// </summary>
        public PhotoDataContainer(EntityConnection connection) : base(connection, "PhotoDataContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        #endregion

        #region Partial Methods

        partial void OnContextCreated();

        #endregion

        #region ObjectSet Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PhotoInfo> PhotoInfo
        {
            get
            {
                if ((_PhotoInfo == null))
                {
                    _PhotoInfo = base.CreateObjectSet<PhotoInfo>("PhotoInfo");
                }
                return _PhotoInfo;
            }
        }
        private ObjectSet<PhotoInfo> _PhotoInfo;

        #endregion
        #region AddTo Methods

        /// <summary>
        /// Deprecated Method for adding a new object to the PhotoInfo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPhotoInfo(PhotoInfo photoInfo)
        {
            base.AddObject("PhotoInfo", photoInfo);
        }

        #endregion
    }


    #endregion

    #region Entities

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PhotoData", Name="PhotoInfo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PhotoInfo : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new PhotoInfo object.
        /// </summary>
        /// <param name="photoId">Initial value of the PhotoId property.</param>
        /// <param name="fileName">Initial value of the FileName property.</param>
        /// <param name="dateAdded">Initial value of the DateAdded property.</param>
        /// <param name="exposure">Initial value of the Exposure property.</param>
        /// <param name="dimensions">Initial value of the Dimensions property.</param>
        /// <param name="dateModified">Initial value of the DateModified property.</param>
        public static PhotoInfo CreatePhotoInfo(global::System.Int32 photoId, global::System.String fileName, global::System.DateTime dateAdded, Exposure exposure, Dimensions dimensions, global::System.DateTime dateModified)
        {
            PhotoInfo photoInfo = new PhotoInfo();
            photoInfo.PhotoId = photoId;
            photoInfo.FileName = fileName;
            photoInfo.DateAdded = dateAdded;
            photoInfo.Exposure = StructuralObject.VerifyComplexObjectIsNotNull(exposure, "Exposure");
            photoInfo.Dimensions = StructuralObject.VerifyComplexObjectIsNotNull(dimensions, "Dimensions");
            photoInfo.DateModified = dateModified;
            return photoInfo;
        }

        #endregion
        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PhotoId
        {
            get
            {
                return _PhotoId;
            }
            set
            {
                if (_PhotoId != value)
                {
                    OnPhotoIdChanging(value);
                    ReportPropertyChanging("PhotoId");
                    _PhotoId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PhotoId");
                    OnPhotoIdChanged();
                }
            }
        }
        private global::System.Int32 _PhotoId;
        partial void OnPhotoIdChanging(global::System.Int32 value);
        partial void OnPhotoIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FileName
        {
            get
            {
                return _FileName;
            }
            set
            {
                OnFileNameChanging(value);
                ReportPropertyChanging("FileName");
                _FileName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FileName");
                OnFileNameChanged();
            }
        }
        private global::System.String _FileName;
        partial void OnFileNameChanging(global::System.String value);
        partial void OnFileNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> FileSize
        {
            get
            {
                return _FileSize;
            }
            set
            {
                OnFileSizeChanging(value);
                ReportPropertyChanging("FileSize");
                _FileSize = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FileSize");
                OnFileSizeChanged();
            }
        }
        private Nullable<global::System.Int32> _FileSize;
        partial void OnFileSizeChanging(Nullable<global::System.Int32> value);
        partial void OnFileSizeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DateTaken
        {
            get
            {
                return _DateTaken;
            }
            set
            {
                OnDateTakenChanging(value);
                ReportPropertyChanging("DateTaken");
                _DateTaken = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateTaken");
                OnDateTakenChanged();
            }
        }
        private Nullable<global::System.DateTime> _DateTaken;
        partial void OnDateTakenChanging(Nullable<global::System.DateTime> value);
        partial void OnDateTakenChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TakenBy
        {
            get
            {
                return _TakenBy;
            }
            set
            {
                OnTakenByChanging(value);
                ReportPropertyChanging("TakenBy");
                _TakenBy = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TakenBy");
                OnTakenByChanged();
            }
        }
        private global::System.String _TakenBy;
        partial void OnTakenByChanging(global::System.String value);
        partial void OnTakenByChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateAdded
        {
            get
            {
                return _DateAdded;
            }
            set
            {
                OnDateAddedChanging(value);
                ReportPropertyChanging("DateAdded");
                _DateAdded = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateAdded");
                OnDateAddedChanged();
            }
        }
        private global::System.DateTime _DateAdded;
        partial void OnDateAddedChanging(global::System.DateTime value);
        partial void OnDateAddedChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateModified
        {
            get
            {
                return _DateModified;
            }
            set
            {
                OnDateModifiedChanging(value);
                ReportPropertyChanging("DateModified");
                _DateModified = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateModified");
                OnDateModifiedChanged();
            }
        }
        private global::System.DateTime _DateModified;
        partial void OnDateModifiedChanging(global::System.DateTime value);
        partial void OnDateModifiedChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Comments
        {
            get
            {
                return _Comments;
            }
            set
            {
                OnCommentsChanging(value);
                ReportPropertyChanging("Comments");
                _Comments = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Comments");
                OnCommentsChanged();
            }
        }
        private global::System.String _Comments;
        partial void OnCommentsChanging(global::System.String value);
        partial void OnCommentsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContentType
        {
            get
            {
                return _ContentType;
            }
            set
            {
                OnContentTypeChanging(value);
                ReportPropertyChanging("ContentType");
                _ContentType = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ContentType");
                OnContentTypeChanged();
            }
        }
        private global::System.String _ContentType;
        partial void OnContentTypeChanging(global::System.String value);
        partial void OnContentTypeChanged();

        #endregion
        #region Complex Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmComplexPropertyAttribute()]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [XmlElement(IsNullable=true)]
        [SoapElement(IsNullable=true)]
        [DataMemberAttribute()]
        public Exposure Exposure
        {
            get
            {
                _Exposure = GetValidValue(_Exposure, "Exposure", false, _ExposureInitialized);
                _ExposureInitialized = true;
                return _Exposure;
            }
            set
            {
                OnExposureChanging(value);
                ReportPropertyChanging("Exposure");
                _Exposure = SetValidValue(_Exposure, value, "Exposure");
                _ExposureInitialized = true;
                ReportPropertyChanged("Exposure");
                OnExposureChanged();
            }
        }
        private Exposure _Exposure;
        private bool _ExposureInitialized;
        partial void OnExposureChanging(Exposure value);
        partial void OnExposureChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmComplexPropertyAttribute()]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [XmlElement(IsNullable=true)]
        [SoapElement(IsNullable=true)]
        [DataMemberAttribute()]
        public Dimensions Dimensions
        {
            get
            {
                _Dimensions = GetValidValue(_Dimensions, "Dimensions", false, _DimensionsInitialized);
                _DimensionsInitialized = true;
                return _Dimensions;
            }
            set
            {
                OnDimensionsChanging(value);
                ReportPropertyChanging("Dimensions");
                _Dimensions = SetValidValue(_Dimensions, value, "Dimensions");
                _DimensionsInitialized = true;
                ReportPropertyChanged("Dimensions");
                OnDimensionsChanged();
            }
        }
        private Dimensions _Dimensions;
        private bool _DimensionsInitialized;
        partial void OnDimensionsChanging(Dimensions value);
        partial void OnDimensionsChanged();

        #endregion

    }

    #endregion
    #region ComplexTypes

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="PhotoData", Name="Dimensions")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class Dimensions : ComplexObject
    {
        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> Height
        {
            get
            {
                return _Height;
            }
            set
            {
                OnHeightChanging(value);
                ReportPropertyChanging("Height");
                _Height = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Height");
                OnHeightChanged();
            }
        }
        private Nullable<global::System.Int16> _Height;
        partial void OnHeightChanging(Nullable<global::System.Int16> value);
        partial void OnHeightChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> Width
        {
            get
            {
                return _Width;
            }
            set
            {
                OnWidthChanging(value);
                ReportPropertyChanging("Width");
                _Width = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Width");
                OnWidthChanged();
            }
        }
        private Nullable<global::System.Int16> _Width;
        partial void OnWidthChanging(Nullable<global::System.Int16> value);
        partial void OnWidthChanged();

        #endregion
    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="PhotoData", Name="Exposure")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class Exposure : ComplexObject
    {
        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Aperature
        {
            get
            {
                return _Aperature;
            }
            set
            {
                OnAperatureChanging(value);
                ReportPropertyChanging("Aperature");
                _Aperature = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Aperature");
                OnAperatureChanged();
            }
        }
        private Nullable<global::System.Decimal> _Aperature;
        partial void OnAperatureChanging(Nullable<global::System.Decimal> value);
        partial void OnAperatureChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> ShutterSpeed
        {
            get
            {
                return _ShutterSpeed;
            }
            set
            {
                OnShutterSpeedChanging(value);
                ReportPropertyChanging("ShutterSpeed");
                _ShutterSpeed = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ShutterSpeed");
                OnShutterSpeedChanged();
            }
        }
        private Nullable<global::System.Int16> _ShutterSpeed;
        partial void OnShutterSpeedChanging(Nullable<global::System.Int16> value);
        partial void OnShutterSpeedChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> FilmSpeed
        {
            get
            {
                return _FilmSpeed;
            }
            set
            {
                OnFilmSpeedChanging(value);
                ReportPropertyChanging("FilmSpeed");
                _FilmSpeed = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FilmSpeed");
                OnFilmSpeedChanged();
            }
        }
        private Nullable<global::System.Int16> _FilmSpeed;
        partial void OnFilmSpeedChanging(Nullable<global::System.Int16> value);
        partial void OnFilmSpeedChanged();

        #endregion
    }

    #endregion

}
