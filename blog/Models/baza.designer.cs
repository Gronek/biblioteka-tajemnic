﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace blog.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="rafdam.studentlive.pl")]
	public partial class bazaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKomentarz(Komentarz instance);
    partial void UpdateKomentarz(Komentarz instance);
    partial void DeleteKomentarz(Komentarz instance);
    partial void InsertPost(Post instance);
    partial void UpdatePost(Post instance);
    partial void DeletePost(Post instance);
    partial void InsertTag(Tag instance);
    partial void UpdateTag(Tag instance);
    partial void DeleteTag(Tag instance);
    #endregion
		
		public bazaDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["rafdam_studentlive_plConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public bazaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bazaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bazaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public bazaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Komentarz> Komentarzs
		{
			get
			{
				return this.GetTable<Komentarz>();
			}
		}
		
		public System.Data.Linq.Table<Post> Posts
		{
			get
			{
				return this.GetTable<Post>();
			}
		}
		
		public System.Data.Linq.Table<Tag> Tags
		{
			get
			{
				return this.GetTable<Tag>();
			}
		}
		
		public System.Data.Linq.Table<Ustawienia> Ustawienias
		{
			get
			{
				return this.GetTable<Ustawienia>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Komentarze")]
	public partial class Komentarz : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _id_posta;
		
		private string _tresc;
		
		private string _autor;
		
		private System.DateTime _data_dodania;
		
		private int _status;
		
		private EntityRef<Post> _Post;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_postaChanging(int value);
    partial void Onid_postaChanged();
    partial void OntrescChanging(string value);
    partial void OntrescChanged();
    partial void OnautorChanging(string value);
    partial void OnautorChanged();
    partial void Ondata_dodaniaChanging(System.DateTime value);
    partial void Ondata_dodaniaChanged();
    partial void OnstatusChanging(int value);
    partial void OnstatusChanged();
    #endregion
		
		public Komentarz()
		{
			this._Post = default(EntityRef<Post>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_posta", DbType="Int NOT NULL")]
		public int id_posta
		{
			get
			{
				return this._id_posta;
			}
			set
			{
				if ((this._id_posta != value))
				{
					if (this._Post.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_postaChanging(value);
					this.SendPropertyChanging();
					this._id_posta = value;
					this.SendPropertyChanged("id_posta");
					this.Onid_postaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tresc", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string tresc
		{
			get
			{
				return this._tresc;
			}
			set
			{
				if ((this._tresc != value))
				{
					this.OntrescChanging(value);
					this.SendPropertyChanging();
					this._tresc = value;
					this.SendPropertyChanged("tresc");
					this.OntrescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_autor", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string autor
		{
			get
			{
				return this._autor;
			}
			set
			{
				if ((this._autor != value))
				{
					this.OnautorChanging(value);
					this.SendPropertyChanging();
					this._autor = value;
					this.SendPropertyChanged("autor");
					this.OnautorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_dodania", DbType="DateTime NOT NULL")]
		public System.DateTime data_dodania
		{
			get
			{
				return this._data_dodania;
			}
			set
			{
				if ((this._data_dodania != value))
				{
					this.Ondata_dodaniaChanging(value);
					this.SendPropertyChanging();
					this._data_dodania = value;
					this.SendPropertyChanged("data_dodania");
					this.Ondata_dodaniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int NOT NULL")]
		public int status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Posty_Komentarze", Storage="_Post", ThisKey="id_posta", OtherKey="id", IsForeignKey=true)]
		public Post Post
		{
			get
			{
				return this._Post.Entity;
			}
			set
			{
				Post previousValue = this._Post.Entity;
				if (((previousValue != value) 
							|| (this._Post.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Post.Entity = null;
						previousValue.Komentarzs.Remove(this);
					}
					this._Post.Entity = value;
					if ((value != null))
					{
						value.Komentarzs.Add(this);
						this._id_posta = value.id;
					}
					else
					{
						this._id_posta = default(int);
					}
					this.SendPropertyChanged("Post");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Posty")]
	public partial class Post : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.DateTime _data_dodania;
		
		private string _tytul;
		
		private string _tresc;
		
		private int _status;
		
		private System.Nullable<System.DateTime> _data_modyfikacji;
		
		private EntitySet<Komentarz> _Komentarzs;
		
		private EntityRef<Tag> _Tag;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Ondata_dodaniaChanging(System.DateTime value);
    partial void Ondata_dodaniaChanged();
    partial void OntytulChanging(string value);
    partial void OntytulChanged();
    partial void OntrescChanging(string value);
    partial void OntrescChanged();
    partial void OnstatusChanging(int value);
    partial void OnstatusChanged();
    partial void Ondata_modyfikacjiChanging(System.Nullable<System.DateTime> value);
    partial void Ondata_modyfikacjiChanged();
    #endregion
		
		public Post()
		{
			this._Komentarzs = new EntitySet<Komentarz>(new Action<Komentarz>(this.attach_Komentarzs), new Action<Komentarz>(this.detach_Komentarzs));
			this._Tag = default(EntityRef<Tag>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_dodania", DbType="DateTime NOT NULL")]
		public System.DateTime data_dodania
		{
			get
			{
				return this._data_dodania;
			}
			set
			{
				if ((this._data_dodania != value))
				{
					this.Ondata_dodaniaChanging(value);
					this.SendPropertyChanging();
					this._data_dodania = value;
					this.SendPropertyChanged("data_dodania");
					this.Ondata_dodaniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tytul", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string tytul
		{
			get
			{
				return this._tytul;
			}
			set
			{
				if ((this._tytul != value))
				{
					this.OntytulChanging(value);
					this.SendPropertyChanging();
					this._tytul = value;
					this.SendPropertyChanged("tytul");
					this.OntytulChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tresc", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string tresc
		{
			get
			{
				return this._tresc;
			}
			set
			{
				if ((this._tresc != value))
				{
					this.OntrescChanging(value);
					this.SendPropertyChanging();
					this._tresc = value;
					this.SendPropertyChanged("tresc");
					this.OntrescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int NOT NULL")]
		public int status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_modyfikacji", DbType="DateTime")]
		public System.Nullable<System.DateTime> data_modyfikacji
		{
			get
			{
				return this._data_modyfikacji;
			}
			set
			{
				if ((this._data_modyfikacji != value))
				{
					this.Ondata_modyfikacjiChanging(value);
					this.SendPropertyChanging();
					this._data_modyfikacji = value;
					this.SendPropertyChanged("data_modyfikacji");
					this.Ondata_modyfikacjiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Posty_Komentarze", Storage="_Komentarzs", ThisKey="id", OtherKey="id_posta")]
		public EntitySet<Komentarz> Komentarzs
		{
			get
			{
				return this._Komentarzs;
			}
			set
			{
				this._Komentarzs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Posty_Tagi", Storage="_Tag", ThisKey="id", OtherKey="id_posta", IsUnique=true, IsForeignKey=false)]
		public Tag Tag
		{
			get
			{
				return this._Tag.Entity;
			}
			set
			{
				Tag previousValue = this._Tag.Entity;
				if (((previousValue != value) 
							|| (this._Tag.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tag.Entity = null;
						previousValue.Post = null;
					}
					this._Tag.Entity = value;
					if ((value != null))
					{
						value.Post = this;
					}
					this.SendPropertyChanged("Tag");
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
		
		private void attach_Komentarzs(Komentarz entity)
		{
			this.SendPropertyChanging();
			entity.Post = this;
		}
		
		private void detach_Komentarzs(Komentarz entity)
		{
			this.SendPropertyChanging();
			entity.Post = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tagi")]
	public partial class Tag : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_posta;
		
		private string _keywords;
		
		private string _description;
		
		private EntityRef<Post> _Post;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_postaChanging(int value);
    partial void Onid_postaChanged();
    partial void OnkeywordsChanging(string value);
    partial void OnkeywordsChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public Tag()
		{
			this._Post = default(EntityRef<Post>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_posta", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_posta
		{
			get
			{
				return this._id_posta;
			}
			set
			{
				if ((this._id_posta != value))
				{
					if (this._Post.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_postaChanging(value);
					this.SendPropertyChanging();
					this._id_posta = value;
					this.SendPropertyChanged("id_posta");
					this.Onid_postaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_keywords", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string keywords
		{
			get
			{
				return this._keywords;
			}
			set
			{
				if ((this._keywords != value))
				{
					this.OnkeywordsChanging(value);
					this.SendPropertyChanging();
					this._keywords = value;
					this.SendPropertyChanged("keywords");
					this.OnkeywordsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Posty_Tagi", Storage="_Post", ThisKey="id_posta", OtherKey="id", IsForeignKey=true)]
		public Post Post
		{
			get
			{
				return this._Post.Entity;
			}
			set
			{
				Post previousValue = this._Post.Entity;
				if (((previousValue != value) 
							|| (this._Post.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Post.Entity = null;
						previousValue.Tag = null;
					}
					this._Post.Entity = value;
					if ((value != null))
					{
						value.Tag = this;
						this._id_posta = value.id;
					}
					else
					{
						this._id_posta = default(int);
					}
					this.SendPropertyChanged("Post");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ustawienia")]
	public partial class Ustawienia
	{
		
		private string _grupa;
		
		private string _nazwa;
		
		private string _wartosc;
		
		public Ustawienia()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grupa", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string grupa
		{
			get
			{
				return this._grupa;
			}
			set
			{
				if ((this._grupa != value))
				{
					this._grupa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nazwa", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nazwa
		{
			get
			{
				return this._nazwa;
			}
			set
			{
				if ((this._nazwa != value))
				{
					this._nazwa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wartosc", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string wartosc
		{
			get
			{
				return this._wartosc;
			}
			set
			{
				if ((this._wartosc != value))
				{
					this._wartosc = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
