using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lateral.Models.Entity
{
	public class Comment
	{
		public int Id { get; set; }

		/// <summary>コメント内容</summary>
		public string Content { get; set; }

		/// <summary>質問者ID</summary>
		public int QuestionerId { get; set; }

		/// <summary>回答者ID</summary>
		public int AnswerId { get; set; }

		/// <summary>ステータス</summary>
		public CommentStatus Status { get; set; }

		/// <summary>プロジェクトID</summary>
		public int ProjectId { get; set; }
	}
}