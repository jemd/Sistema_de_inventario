#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using InvDataAccess;

namespace InvDataAccess	
{
	public partial class Cotizacionesdetalle
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private int _cotizaciones_Id;
		public virtual int Cotizaciones_Id
		{
			get
			{
				return this._cotizaciones_Id;
			}
			set
			{
				this._cotizaciones_Id = value;
			}
		}
		
		private int _productos_Id;
		public virtual int Productos_Id
		{
			get
			{
				return this._productos_Id;
			}
			set
			{
				this._productos_Id = value;
			}
		}
		
		private int _cantidad;
		public virtual int Cantidad
		{
			get
			{
				return this._cantidad;
			}
			set
			{
				this._cantidad = value;
			}
		}
		
		private decimal _psi;
		public virtual decimal Psi
		{
			get
			{
				return this._psi;
			}
			set
			{
				this._psi = value;
			}
		}
		
		private decimal _pci;
		public virtual decimal Pci
		{
			get
			{
				return this._pci;
			}
			set
			{
				this._pci = value;
			}
		}
		
		private decimal _tsi;
		public virtual decimal Tsi
		{
			get
			{
				return this._tsi;
			}
			set
			{
				this._tsi = value;
			}
		}
		
		private decimal _tci;
		public virtual decimal Tci
		{
			get
			{
				return this._tci;
			}
			set
			{
				this._tci = value;
			}
		}
		
		private Cotizacione _cotizacione;
		public virtual Cotizacione Cotizacione
		{
			get
			{
				return this._cotizacione;
			}
			set
			{
				this._cotizacione = value;
			}
		}
		
		private Producto _producto;
		public virtual Producto Producto
		{
			get
			{
				return this._producto;
			}
			set
			{
				this._producto = value;
			}
		}
		
	}
}
#pragma warning restore 1591
