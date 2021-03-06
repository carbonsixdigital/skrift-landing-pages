//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.7.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "metaData"
	/// <summary>Meta data</summary>
	public partial interface IMetaData : IPublishedContent
	{
		/// <summary>Meta description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		string MetaDescription { get; }

		/// <summary>Meta title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		string MetaTitle { get; }
	}

	/// <summary>Meta data</summary>
	[PublishedModel("metaData")]
	public partial class MetaData : PublishedContentModel, IMetaData
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public new const string ModelTypeAlias = "metaData";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MetaData, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public MetaData(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Meta description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => GetMetaDescription(this);

		/// <summary>Static getter for Meta description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public static string GetMetaDescription(IMetaData that) => that.Value<string>("metaDescription");

		///<summary>
		/// Meta title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle => GetMetaTitle(this);

		/// <summary>Static getter for Meta title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public static string GetMetaTitle(IMetaData that) => that.Value<string>("metaTitle");
	}
}
