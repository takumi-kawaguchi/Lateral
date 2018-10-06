using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lateral.Models.Entity
{
	public class Project
	{
		public int Id { get; set; }

		/// <summary>名前</summary>
		public string Name { get; set; }

		/// <summary>概要</summary>
		public string Description { get; set; }

		/// <summary>リリース予定日</summary>
		public DateTime ReleaseDate { get; set; }

		/// <summary>開発ステータス</summary>
		public DevelopmentStatus Status { get; set; }
	}
}