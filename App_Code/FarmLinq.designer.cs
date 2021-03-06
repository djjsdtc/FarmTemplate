﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18034
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FarmTemplate")]
public partial class FarmLinqDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region 可扩展性方法定义
  partial void OnCreated();
  partial void Insertfarmtable(farmtable instance);
  partial void Updatefarmtable(farmtable instance);
  partial void Deletefarmtable(farmtable instance);
  partial void Insertuserinfo(userinfo instance);
  partial void Updateuserinfo(userinfo instance);
  partial void Deleteuserinfo(userinfo instance);
  partial void Insertfoodstorage(foodstorage instance);
  partial void Updatefoodstorage(foodstorage instance);
  partial void Deletefoodstorage(foodstorage instance);
  partial void Insertseedinfo(seedinfo instance);
  partial void Updateseedinfo(seedinfo instance);
  partial void Deleteseedinfo(seedinfo instance);
  partial void Insertseedstorage(seedstorage instance);
  partial void Updateseedstorage(seedstorage instance);
  partial void Deleteseedstorage(seedstorage instance);
  #endregion
	
	public FarmLinqDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["FarmConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public FarmLinqDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public FarmLinqDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public FarmLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public FarmLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<farmtable> farmtable
	{
		get
		{
			return this.GetTable<farmtable>();
		}
	}
	
	public System.Data.Linq.Table<userinfo> userinfo
	{
		get
		{
			return this.GetTable<userinfo>();
		}
	}
	
	public System.Data.Linq.Table<foodstorage> foodstorage
	{
		get
		{
			return this.GetTable<foodstorage>();
		}
	}
	
	public System.Data.Linq.Table<seedinfo> seedinfo
	{
		get
		{
			return this.GetTable<seedinfo>();
		}
	}
	
	public System.Data.Linq.Table<seedstorage> seedstorage
	{
		get
		{
			return this.GetTable<seedstorage>();
		}
	}
	
	public System.Data.Linq.Table<onfarm> onfarm
	{
		get
		{
			return this.GetTable<onfarm>();
		}
	}
	
	public System.Data.Linq.Table<stoleinfo> stoleinfo
	{
		get
		{
			return this.GetTable<stoleinfo>();
		}
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sowseed")]
	public ISingleResult<sowseedResult> sowseed([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(256)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NChar(6)")] string seedid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> fieldno)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, seedid, fieldno);
		return ((ISingleResult<sowseedResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.harvest")]
	public ISingleResult<harvestResult> harvest([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(256)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> fieldno)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, fieldno);
		return ((ISingleResult<harvestResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sell")]
	public ISingleResult<sellResult> sell([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NChar(6)")] string seedid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(256)")] string username)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), seedid, username);
		return ((ISingleResult<sellResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buyseed")]
	public int buyseed([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(256)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NChar(6)")] string seedid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> amount)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, seedid, amount);
		return ((int)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stole")]
	public int stole([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(256)")] string source_user, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(256)")] string target_user, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> fieldid)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), source_user, target_user, fieldid);
		return ((int)(result.ReturnValue));
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.farmtable")]
public partial class farmtable : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _seedid;
	
	private string _UserName;
	
	private int _FieldNo;
	
	private System.Nullable<System.DateTime> _addedtime;
	
	private System.Nullable<int> _leftgoods;
	
	private EntityRef<userinfo> _userinfo;
	
	private EntityRef<seedinfo> _seedinfo;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnseedidChanging(string value);
    partial void OnseedidChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnFieldNoChanging(int value);
    partial void OnFieldNoChanged();
    partial void OnaddedtimeChanging(System.Nullable<System.DateTime> value);
    partial void OnaddedtimeChanged();
    partial void OnleftgoodsChanging(System.Nullable<int> value);
    partial void OnleftgoodsChanged();
    #endregion
	
	public farmtable()
	{
		this._userinfo = default(EntityRef<userinfo>);
		this._seedinfo = default(EntityRef<seedinfo>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_seedid", DbType="NChar(6)")]
	public string seedid
	{
		get
		{
			return this._seedid;
		}
		set
		{
			if ((this._seedid != value))
			{
				if (this._seedinfo.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnseedidChanging(value);
				this.SendPropertyChanging();
				this._seedid = value;
				this.SendPropertyChanged("seedid");
				this.OnseedidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(256) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string UserName
	{
		get
		{
			return this._UserName;
		}
		set
		{
			if ((this._UserName != value))
			{
				if (this._userinfo.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUserNameChanging(value);
				this.SendPropertyChanging();
				this._UserName = value;
				this.SendPropertyChanged("UserName");
				this.OnUserNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FieldNo", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int FieldNo
	{
		get
		{
			return this._FieldNo;
		}
		set
		{
			if ((this._FieldNo != value))
			{
				this.OnFieldNoChanging(value);
				this.SendPropertyChanging();
				this._FieldNo = value;
				this.SendPropertyChanged("FieldNo");
				this.OnFieldNoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_addedtime", DbType="DateTime")]
	public System.Nullable<System.DateTime> addedtime
	{
		get
		{
			return this._addedtime;
		}
		set
		{
			if ((this._addedtime != value))
			{
				this.OnaddedtimeChanging(value);
				this.SendPropertyChanging();
				this._addedtime = value;
				this.SendPropertyChanged("addedtime");
				this.OnaddedtimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_leftgoods", DbType="Int")]
	public System.Nullable<int> leftgoods
	{
		get
		{
			return this._leftgoods;
		}
		set
		{
			if ((this._leftgoods != value))
			{
				this.OnleftgoodsChanging(value);
				this.SendPropertyChanging();
				this._leftgoods = value;
				this.SendPropertyChanged("leftgoods");
				this.OnleftgoodsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="userinfo_farmtable", Storage="_userinfo", ThisKey="UserName", OtherKey="UserName", IsForeignKey=true)]
	public userinfo userinfo
	{
		get
		{
			return this._userinfo.Entity;
		}
		set
		{
			userinfo previousValue = this._userinfo.Entity;
			if (((previousValue != value) 
						|| (this._userinfo.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._userinfo.Entity = null;
					previousValue.farmtable.Remove(this);
				}
				this._userinfo.Entity = value;
				if ((value != null))
				{
					value.farmtable.Add(this);
					this._UserName = value.UserName;
				}
				else
				{
					this._UserName = default(string);
				}
				this.SendPropertyChanged("userinfo");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="seedinfo_farmtable", Storage="_seedinfo", ThisKey="seedid", OtherKey="seedid", IsForeignKey=true)]
	public seedinfo seedinfo
	{
		get
		{
			return this._seedinfo.Entity;
		}
		set
		{
			seedinfo previousValue = this._seedinfo.Entity;
			if (((previousValue != value) 
						|| (this._seedinfo.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._seedinfo.Entity = null;
					previousValue.farmtable.Remove(this);
				}
				this._seedinfo.Entity = value;
				if ((value != null))
				{
					value.farmtable.Add(this);
					this._seedid = value.seedid;
				}
				else
				{
					this._seedid = default(string);
				}
				this.SendPropertyChanged("seedinfo");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.userinfo")]
public partial class userinfo : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _UserName;
	
	private System.Nullable<int> _fieldnum;
	
	private System.Nullable<int> _usermoney;
	
	private EntitySet<farmtable> _farmtable;
	
	private EntitySet<foodstorage> _foodstorage;
	
	private EntitySet<seedstorage> _seedstorage;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnfieldnumChanging(System.Nullable<int> value);
    partial void OnfieldnumChanged();
    partial void OnusermoneyChanging(System.Nullable<int> value);
    partial void OnusermoneyChanged();
    #endregion
	
	public userinfo()
	{
		this._farmtable = new EntitySet<farmtable>(new Action<farmtable>(this.attach_farmtable), new Action<farmtable>(this.detach_farmtable));
		this._foodstorage = new EntitySet<foodstorage>(new Action<foodstorage>(this.attach_foodstorage), new Action<foodstorage>(this.detach_foodstorage));
		this._seedstorage = new EntitySet<seedstorage>(new Action<seedstorage>(this.attach_seedstorage), new Action<seedstorage>(this.detach_seedstorage));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(256) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string UserName
	{
		get
		{
			return this._UserName;
		}
		set
		{
			if ((this._UserName != value))
			{
				this.OnUserNameChanging(value);
				this.SendPropertyChanging();
				this._UserName = value;
				this.SendPropertyChanged("UserName");
				this.OnUserNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fieldnum", DbType="Int")]
	public System.Nullable<int> fieldnum
	{
		get
		{
			return this._fieldnum;
		}
		set
		{
			if ((this._fieldnum != value))
			{
				this.OnfieldnumChanging(value);
				this.SendPropertyChanging();
				this._fieldnum = value;
				this.SendPropertyChanged("fieldnum");
				this.OnfieldnumChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usermoney", DbType="Int")]
	public System.Nullable<int> usermoney
	{
		get
		{
			return this._usermoney;
		}
		set
		{
			if ((this._usermoney != value))
			{
				this.OnusermoneyChanging(value);
				this.SendPropertyChanging();
				this._usermoney = value;
				this.SendPropertyChanged("usermoney");
				this.OnusermoneyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="userinfo_farmtable", Storage="_farmtable", ThisKey="UserName", OtherKey="UserName")]
	public EntitySet<farmtable> farmtable
	{
		get
		{
			return this._farmtable;
		}
		set
		{
			this._farmtable.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="userinfo_foodstorage", Storage="_foodstorage", ThisKey="UserName", OtherKey="UserName")]
	public EntitySet<foodstorage> foodstorage
	{
		get
		{
			return this._foodstorage;
		}
		set
		{
			this._foodstorage.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="userinfo_seedstorage", Storage="_seedstorage", ThisKey="UserName", OtherKey="UserName")]
	public EntitySet<seedstorage> seedstorage
	{
		get
		{
			return this._seedstorage;
		}
		set
		{
			this._seedstorage.Assign(value);
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
	
	private void attach_farmtable(farmtable entity)
	{
		this.SendPropertyChanging();
		entity.userinfo = this;
	}
	
	private void detach_farmtable(farmtable entity)
	{
		this.SendPropertyChanging();
		entity.userinfo = null;
	}
	
	private void attach_foodstorage(foodstorage entity)
	{
		this.SendPropertyChanging();
		entity.userinfo = this;
	}
	
	private void detach_foodstorage(foodstorage entity)
	{
		this.SendPropertyChanging();
		entity.userinfo = null;
	}
	
	private void attach_seedstorage(seedstorage entity)
	{
		this.SendPropertyChanging();
		entity.userinfo = this;
	}
	
	private void detach_seedstorage(seedstorage entity)
	{
		this.SendPropertyChanging();
		entity.userinfo = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.foodstorage")]
public partial class foodstorage : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _seedid;
	
	private string _UserName;
	
	private System.Nullable<int> _foodamount;
	
	private EntityRef<userinfo> _userinfo;
	
	private EntityRef<seedinfo> _seedinfo;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnseedidChanging(string value);
    partial void OnseedidChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnfoodamountChanging(System.Nullable<int> value);
    partial void OnfoodamountChanged();
    #endregion
	
	public foodstorage()
	{
		this._userinfo = default(EntityRef<userinfo>);
		this._seedinfo = default(EntityRef<seedinfo>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_seedid", DbType="NChar(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string seedid
	{
		get
		{
			return this._seedid;
		}
		set
		{
			if ((this._seedid != value))
			{
				if (this._seedinfo.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnseedidChanging(value);
				this.SendPropertyChanging();
				this._seedid = value;
				this.SendPropertyChanged("seedid");
				this.OnseedidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(256) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string UserName
	{
		get
		{
			return this._UserName;
		}
		set
		{
			if ((this._UserName != value))
			{
				if (this._userinfo.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUserNameChanging(value);
				this.SendPropertyChanging();
				this._UserName = value;
				this.SendPropertyChanged("UserName");
				this.OnUserNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foodamount", DbType="Int")]
	public System.Nullable<int> foodamount
	{
		get
		{
			return this._foodamount;
		}
		set
		{
			if ((this._foodamount != value))
			{
				this.OnfoodamountChanging(value);
				this.SendPropertyChanging();
				this._foodamount = value;
				this.SendPropertyChanged("foodamount");
				this.OnfoodamountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="userinfo_foodstorage", Storage="_userinfo", ThisKey="UserName", OtherKey="UserName", IsForeignKey=true)]
	public userinfo userinfo
	{
		get
		{
			return this._userinfo.Entity;
		}
		set
		{
			userinfo previousValue = this._userinfo.Entity;
			if (((previousValue != value) 
						|| (this._userinfo.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._userinfo.Entity = null;
					previousValue.foodstorage.Remove(this);
				}
				this._userinfo.Entity = value;
				if ((value != null))
				{
					value.foodstorage.Add(this);
					this._UserName = value.UserName;
				}
				else
				{
					this._UserName = default(string);
				}
				this.SendPropertyChanged("userinfo");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="seedinfo_foodstorage", Storage="_seedinfo", ThisKey="seedid", OtherKey="seedid", IsForeignKey=true)]
	public seedinfo seedinfo
	{
		get
		{
			return this._seedinfo.Entity;
		}
		set
		{
			seedinfo previousValue = this._seedinfo.Entity;
			if (((previousValue != value) 
						|| (this._seedinfo.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._seedinfo.Entity = null;
					previousValue.foodstorage.Remove(this);
				}
				this._seedinfo.Entity = value;
				if ((value != null))
				{
					value.foodstorage.Add(this);
					this._seedid = value.seedid;
				}
				else
				{
					this._seedid = default(string);
				}
				this.SendPropertyChanged("seedinfo");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.seedinfo")]
public partial class seedinfo : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _seedid;
	
	private string _seedname;
	
	private string _describe;
	
	private System.Nullable<int> _buyprice;
	
	private System.Nullable<int> _mature_minute;
	
	private System.Nullable<int> _outamount;
	
	private System.Nullable<int> _sellprice;
	
	private System.Nullable<bool> _isselling;
	
	private string _pic_location;
	
	private EntitySet<farmtable> _farmtable;
	
	private EntitySet<foodstorage> _foodstorage;
	
	private EntitySet<seedstorage> _seedstorage;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnseedidChanging(string value);
    partial void OnseedidChanged();
    partial void OnseednameChanging(string value);
    partial void OnseednameChanged();
    partial void OndescribeChanging(string value);
    partial void OndescribeChanged();
    partial void OnbuypriceChanging(System.Nullable<int> value);
    partial void OnbuypriceChanged();
    partial void Onmature_minuteChanging(System.Nullable<int> value);
    partial void Onmature_minuteChanged();
    partial void OnoutamountChanging(System.Nullable<int> value);
    partial void OnoutamountChanged();
    partial void OnsellpriceChanging(System.Nullable<int> value);
    partial void OnsellpriceChanged();
    partial void OnissellingChanging(System.Nullable<bool> value);
    partial void OnissellingChanged();
    partial void Onpic_locationChanging(string value);
    partial void Onpic_locationChanged();
    #endregion
	
	public seedinfo()
	{
		this._farmtable = new EntitySet<farmtable>(new Action<farmtable>(this.attach_farmtable), new Action<farmtable>(this.detach_farmtable));
		this._foodstorage = new EntitySet<foodstorage>(new Action<foodstorage>(this.attach_foodstorage), new Action<foodstorage>(this.detach_foodstorage));
		this._seedstorage = new EntitySet<seedstorage>(new Action<seedstorage>(this.attach_seedstorage), new Action<seedstorage>(this.detach_seedstorage));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_seedid", DbType="NChar(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string seedid
	{
		get
		{
			return this._seedid;
		}
		set
		{
			if ((this._seedid != value))
			{
				this.OnseedidChanging(value);
				this.SendPropertyChanging();
				this._seedid = value;
				this.SendPropertyChanged("seedid");
				this.OnseedidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_seedname", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string seedname
	{
		get
		{
			return this._seedname;
		}
		set
		{
			if ((this._seedname != value))
			{
				this.OnseednameChanging(value);
				this.SendPropertyChanging();
				this._seedname = value;
				this.SendPropertyChanged("seedname");
				this.OnseednameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_describe", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string describe
	{
		get
		{
			return this._describe;
		}
		set
		{
			if ((this._describe != value))
			{
				this.OndescribeChanging(value);
				this.SendPropertyChanging();
				this._describe = value;
				this.SendPropertyChanged("describe");
				this.OndescribeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_buyprice", DbType="Int")]
	public System.Nullable<int> buyprice
	{
		get
		{
			return this._buyprice;
		}
		set
		{
			if ((this._buyprice != value))
			{
				this.OnbuypriceChanging(value);
				this.SendPropertyChanging();
				this._buyprice = value;
				this.SendPropertyChanged("buyprice");
				this.OnbuypriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mature_minute", DbType="Int")]
	public System.Nullable<int> mature_minute
	{
		get
		{
			return this._mature_minute;
		}
		set
		{
			if ((this._mature_minute != value))
			{
				this.Onmature_minuteChanging(value);
				this.SendPropertyChanging();
				this._mature_minute = value;
				this.SendPropertyChanged("mature_minute");
				this.Onmature_minuteChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_outamount", DbType="Int")]
	public System.Nullable<int> outamount
	{
		get
		{
			return this._outamount;
		}
		set
		{
			if ((this._outamount != value))
			{
				this.OnoutamountChanging(value);
				this.SendPropertyChanging();
				this._outamount = value;
				this.SendPropertyChanged("outamount");
				this.OnoutamountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sellprice", DbType="Int")]
	public System.Nullable<int> sellprice
	{
		get
		{
			return this._sellprice;
		}
		set
		{
			if ((this._sellprice != value))
			{
				this.OnsellpriceChanging(value);
				this.SendPropertyChanging();
				this._sellprice = value;
				this.SendPropertyChanged("sellprice");
				this.OnsellpriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isselling", DbType="Bit")]
	public System.Nullable<bool> isselling
	{
		get
		{
			return this._isselling;
		}
		set
		{
			if ((this._isselling != value))
			{
				this.OnissellingChanging(value);
				this.SendPropertyChanging();
				this._isselling = value;
				this.SendPropertyChanged("isselling");
				this.OnissellingChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pic_location", DbType="Text", UpdateCheck=UpdateCheck.Never)]
	public string pic_location
	{
		get
		{
			return this._pic_location;
		}
		set
		{
			if ((this._pic_location != value))
			{
				this.Onpic_locationChanging(value);
				this.SendPropertyChanging();
				this._pic_location = value;
				this.SendPropertyChanged("pic_location");
				this.Onpic_locationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="seedinfo_farmtable", Storage="_farmtable", ThisKey="seedid", OtherKey="seedid")]
	public EntitySet<farmtable> farmtable
	{
		get
		{
			return this._farmtable;
		}
		set
		{
			this._farmtable.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="seedinfo_foodstorage", Storage="_foodstorage", ThisKey="seedid", OtherKey="seedid")]
	public EntitySet<foodstorage> foodstorage
	{
		get
		{
			return this._foodstorage;
		}
		set
		{
			this._foodstorage.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="seedinfo_seedstorage", Storage="_seedstorage", ThisKey="seedid", OtherKey="seedid")]
	public EntitySet<seedstorage> seedstorage
	{
		get
		{
			return this._seedstorage;
		}
		set
		{
			this._seedstorage.Assign(value);
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
	
	private void attach_farmtable(farmtable entity)
	{
		this.SendPropertyChanging();
		entity.seedinfo = this;
	}
	
	private void detach_farmtable(farmtable entity)
	{
		this.SendPropertyChanging();
		entity.seedinfo = null;
	}
	
	private void attach_foodstorage(foodstorage entity)
	{
		this.SendPropertyChanging();
		entity.seedinfo = this;
	}
	
	private void detach_foodstorage(foodstorage entity)
	{
		this.SendPropertyChanging();
		entity.seedinfo = null;
	}
	
	private void attach_seedstorage(seedstorage entity)
	{
		this.SendPropertyChanging();
		entity.seedinfo = this;
	}
	
	private void detach_seedstorage(seedstorage entity)
	{
		this.SendPropertyChanging();
		entity.seedinfo = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.seedstorage")]
public partial class seedstorage : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _seedid;
	
	private string _UserName;
	
	private System.Nullable<int> _seedamount;
	
	private EntityRef<seedinfo> _seedinfo;
	
	private EntityRef<userinfo> _userinfo;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnseedidChanging(string value);
    partial void OnseedidChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnseedamountChanging(System.Nullable<int> value);
    partial void OnseedamountChanged();
    #endregion
	
	public seedstorage()
	{
		this._seedinfo = default(EntityRef<seedinfo>);
		this._userinfo = default(EntityRef<userinfo>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_seedid", DbType="NChar(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string seedid
	{
		get
		{
			return this._seedid;
		}
		set
		{
			if ((this._seedid != value))
			{
				if (this._seedinfo.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnseedidChanging(value);
				this.SendPropertyChanging();
				this._seedid = value;
				this.SendPropertyChanged("seedid");
				this.OnseedidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(256) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string UserName
	{
		get
		{
			return this._UserName;
		}
		set
		{
			if ((this._UserName != value))
			{
				if (this._userinfo.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUserNameChanging(value);
				this.SendPropertyChanging();
				this._UserName = value;
				this.SendPropertyChanged("UserName");
				this.OnUserNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_seedamount", DbType="Int")]
	public System.Nullable<int> seedamount
	{
		get
		{
			return this._seedamount;
		}
		set
		{
			if ((this._seedamount != value))
			{
				this.OnseedamountChanging(value);
				this.SendPropertyChanging();
				this._seedamount = value;
				this.SendPropertyChanged("seedamount");
				this.OnseedamountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="seedinfo_seedstorage", Storage="_seedinfo", ThisKey="seedid", OtherKey="seedid", IsForeignKey=true)]
	public seedinfo seedinfo
	{
		get
		{
			return this._seedinfo.Entity;
		}
		set
		{
			seedinfo previousValue = this._seedinfo.Entity;
			if (((previousValue != value) 
						|| (this._seedinfo.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._seedinfo.Entity = null;
					previousValue.seedstorage.Remove(this);
				}
				this._seedinfo.Entity = value;
				if ((value != null))
				{
					value.seedstorage.Add(this);
					this._seedid = value.seedid;
				}
				else
				{
					this._seedid = default(string);
				}
				this.SendPropertyChanged("seedinfo");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="userinfo_seedstorage", Storage="_userinfo", ThisKey="UserName", OtherKey="UserName", IsForeignKey=true)]
	public userinfo userinfo
	{
		get
		{
			return this._userinfo.Entity;
		}
		set
		{
			userinfo previousValue = this._userinfo.Entity;
			if (((previousValue != value) 
						|| (this._userinfo.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._userinfo.Entity = null;
					previousValue.seedstorage.Remove(this);
				}
				this._userinfo.Entity = value;
				if ((value != null))
				{
					value.seedstorage.Add(this);
					this._UserName = value.UserName;
				}
				else
				{
					this._UserName = default(string);
				}
				this.SendPropertyChanged("userinfo");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.onfarm")]
public partial class onfarm
{
	
	private string _username;
	
	private int _FieldNo;
	
	private string _seedname;
	
	private System.Nullable<int> _leftgoods;
	
	private string _pic_location;
	
	private System.Nullable<int> _lefttime;
	
	public onfarm()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
	public string username
	{
		get
		{
			return this._username;
		}
		set
		{
			if ((this._username != value))
			{
				this._username = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FieldNo", DbType="Int NOT NULL")]
	public int FieldNo
	{
		get
		{
			return this._FieldNo;
		}
		set
		{
			if ((this._FieldNo != value))
			{
				this._FieldNo = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_seedname", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string seedname
	{
		get
		{
			return this._seedname;
		}
		set
		{
			if ((this._seedname != value))
			{
				this._seedname = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_leftgoods", DbType="Int")]
	public System.Nullable<int> leftgoods
	{
		get
		{
			return this._leftgoods;
		}
		set
		{
			if ((this._leftgoods != value))
			{
				this._leftgoods = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pic_location", DbType="Text", UpdateCheck=UpdateCheck.Never)]
	public string pic_location
	{
		get
		{
			return this._pic_location;
		}
		set
		{
			if ((this._pic_location != value))
			{
				this._pic_location = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lefttime", DbType="Int")]
	public System.Nullable<int> lefttime
	{
		get
		{
			return this._lefttime;
		}
		set
		{
			if ((this._lefttime != value))
			{
				this._lefttime = value;
			}
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.stoleinfo")]
public partial class stoleinfo
{
	
	private string _source_user;
	
	private string _target_user;
	
	private System.Nullable<int> _fieldno;
	
	private string _seedname;
	
	private System.Nullable<System.DateTime> _stoledate;
	
	public stoleinfo()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_source_user", DbType="NVarChar(256)")]
	public string source_user
	{
		get
		{
			return this._source_user;
		}
		set
		{
			if ((this._source_user != value))
			{
				this._source_user = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_target_user", DbType="NVarChar(256)")]
	public string target_user
	{
		get
		{
			return this._target_user;
		}
		set
		{
			if ((this._target_user != value))
			{
				this._target_user = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fieldno", DbType="Int")]
	public System.Nullable<int> fieldno
	{
		get
		{
			return this._fieldno;
		}
		set
		{
			if ((this._fieldno != value))
			{
				this._fieldno = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_seedname", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string seedname
	{
		get
		{
			return this._seedname;
		}
		set
		{
			if ((this._seedname != value))
			{
				this._seedname = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stoledate", DbType="Date")]
	public System.Nullable<System.DateTime> stoledate
	{
		get
		{
			return this._stoledate;
		}
		set
		{
			if ((this._stoledate != value))
			{
				this._stoledate = value;
			}
		}
	}
}

public partial class sowseedResult
{
	
	private System.Nullable<int> _outamount;
	
	public sowseedResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_outamount", DbType="Int")]
	public System.Nullable<int> outamount
	{
		get
		{
			return this._outamount;
		}
		set
		{
			if ((this._outamount != value))
			{
				this._outamount = value;
			}
		}
	}
}

public partial class harvestResult
{
	
	private string _seedid;
	
	private System.Nullable<int> _leftgoods;
	
	public harvestResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_seedid", DbType="NChar(6)")]
	public string seedid
	{
		get
		{
			return this._seedid;
		}
		set
		{
			if ((this._seedid != value))
			{
				this._seedid = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_leftgoods", DbType="Int")]
	public System.Nullable<int> leftgoods
	{
		get
		{
			return this._leftgoods;
		}
		set
		{
			if ((this._leftgoods != value))
			{
				this._leftgoods = value;
			}
		}
	}
}

public partial class sellResult
{
	
	private System.Nullable<int> _foodamount;
	
	public sellResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foodamount", DbType="Int")]
	public System.Nullable<int> foodamount
	{
		get
		{
			return this._foodamount;
		}
		set
		{
			if ((this._foodamount != value))
			{
				this._foodamount = value;
			}
		}
	}
}
#pragma warning restore 1591
