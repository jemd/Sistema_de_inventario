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
	public partial class Clientesdireccione
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
		
		private int _clientes_Id;
		public virtual int Clientes_Id
		{
			get
			{
				return this._clientes_Id;
			}
			set
			{
				this._clientes_Id = value;
			}
		}
		
		private string _direccion;
		public virtual string Direccion
		{
			get
			{
				return this._direccion;
			}
			set
			{
				this._direccion = value;
			}
		}
		
		private Cliente _cliente;
		public virtual Cliente Cliente
		{
			get
			{
				return this._cliente;
			}
			set
			{
				this._cliente = value;
			}
		}
		
	}
}
#pragma warning restore 1591
