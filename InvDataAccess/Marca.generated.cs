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
	public partial class Marca
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
		
		private string _marca1;
		public virtual string Marca1
		{
			get
			{
				return this._marca1;
			}
			set
			{
				this._marca1 = value;
			}
		}
		
		private IList<Producto> _productos = new List<Producto>();
		public virtual IList<Producto> Productos
		{
			get
			{
				return this._productos;
			}
		}
		
	}
}
#pragma warning restore 1591
