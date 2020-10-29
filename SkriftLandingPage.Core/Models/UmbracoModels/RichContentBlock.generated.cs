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
	/// <summary>Rich content block</summary>
	[PublishedModel("richContentBlock")]
	public partial class RichContentBlock : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public new const string ModelTypeAlias = "richContentBlock";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<RichContentBlock, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public RichContentBlock(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Column one
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		[ImplementPropertyType("columnOne")]
		public global::System.Web.IHtmlString ColumnOne => this.Value<global::System.Web.IHtmlString>("columnOne");

		///<summary>
		/// Column two
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		[ImplementPropertyType("columnTwo")]
		public global::System.Web.IHtmlString ColumnTwo => this.Value<global::System.Web.IHtmlString>("columnTwo");

		///<summary>
		/// Tag line
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		[ImplementPropertyType("tagLine")]
		public string TagLine => this.Value<string>("tagLine");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		[ImplementPropertyType("title")]
		public string Title => this.Value<string>("title");
	}
}
