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
using MySQLCatalog.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQLCatalog.Model	
{
	public partial class Vendor
	{
		private int _vendorId;
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
		public virtual int VendorId
		{
			get
			{
				return this._vendorId;
			}
			set
			{
				this._vendorId = value;
			}
		}
		
		private string _name;
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		
		private IList<Product> _products = new List<Product>();
		public virtual IList<Product> Products
		{
			get
			{
				return this._products;
			}
		}
		
	}
}
#pragma warning restore 1591
