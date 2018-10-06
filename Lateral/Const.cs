using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lateral
{
	public class Const
	{
	}

	public enum CommentStatus
	{
		//エンジニアの回答待ち
		AssignedToEngineer,

		//デザイナーの回答待ち
		AssignedToDesigner,

		//企画の回答待ち
		AssginedToBusinessPlanner,

		//不明
		Unknown,

		//全員or関係者
		All,

		//完了
		Completed
	}

	public enum DevelopmentStatus
	{
		//要件定義中
		DefiningRequirement,

		//設計中
		Designing,

		//開発中
		HappyHacking,

		//テスト中
		Testing,

		//リリース準備中
		ReadyToRelease,

		//リリース完了
		Completed
	}
}