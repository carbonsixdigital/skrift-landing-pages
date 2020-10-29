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
	// Mixin Content Type with alias "hero"
	/// <summary>Hero</summary>
	public partial interface IHero : IPublishedElement
	{
		/// <summary>Hero area</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		global::Umbraco.Core.Models.Blocks.BlockListModel HeroArea { get; }
	}

	/// <summary>Hero</summary>
	[PublishedModel("hero")]
	public partial class Hero : PublishedElementModel, IHero
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public new const string ModelTypeAlias = "hero";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Hero, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Hero(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Hero area
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		[ImplementPropertyType("heroArea")]
		public global::Umbraco.Core.Models.Blocks.BlockListModel HeroArea => GetHeroArea(this);

		/// <summary>Static getter for Hero area</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.7.0")]
		public static global::Umbraco.Core.Models.Blocks.BlockListModel GetHeroArea(IHero that) => that.Value<global::Umbraco.Core.Models.Blocks.BlockListModel>("heroArea");
	}
}