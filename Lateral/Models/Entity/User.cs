using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lateral.Models.Entity
{
	public class User
	{
		public int Id { get; set; }

		/// <summary>名前</summary>
		public string Name { get; set; }

		/// <summary>Adminフラグ</summary>
		public bool IsAdmin { get; set; }

		/// <summary>パスワード</summary>
		public string Password { get; set; }

		/// <summary>メールアドレス</summary>
		public string Email { get; set; }
	}
}