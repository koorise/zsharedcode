﻿/*
 * wiki:
 * http://code.google.com/p/zsharedcode/wiki/JQueryUIEvent
 * http://code.google.com/p/zsharedcode/wiki/JQueryUIEventType
 * 如果您无法运行此文件, 可能由于缺少相关类文件, 请下载解决方案后重试, 具体请参考: http://code.google.com/p/zsharedcode/wiki/HowToDownloadAndUse
 * 原始代码: http://zsharedcode.googlecode.com/svn/trunk/zsharedcode/panzer/.class/web/jqueryui/Event.cs
 * 版本: .net 4.0, 其它版本可能有所不同
 * 
 * 使用许可: 此文件是开源共享免费的, 但您仍然需要遵守, 下载并将 panzer 许可证 http://zsharedcode.googlecode.com/svn/trunk/zsharedcode/panzer/panzer.license.txt 包含在你的产品中.
 * */

namespace zoyobar.shared.panzer.web.jqueryui
{

	#region " EventType "
	/// <summary>
	/// jQuery UI 的事件类型.
	/// </summary>
	public enum EventType
	{
		/// <summary>
		/// 没有任何事件.
		/// </summary>
		None = 0,
		/// <summary>
		/// 完成时.
		/// </summary>
		Complete = 1,
		/// <summary>
		/// 出错时.
		/// </summary>
		Error = 2,
		/// <summary>
		/// 成功时.
		/// </summary>
		Success = 3,
		/// <summary>
		/// 点击时.
		/// </summary>
		Click = 4,
	}
	#endregion

	#region " Event "
	/// <summary>
	/// jQuery UI 的事件.
	/// </summary>
	public sealed class Event
	{
		/// <summary>
		/// 事件类型.
		/// </summary>
		public readonly EventType Type;
		/// <summary>
		/// 事件内容.
		/// </summary>
		public readonly string Value;

		/// <summary>
		/// 创建一个 jQuery UI 事件.
		/// </summary>
		/// <param name="type">事件类型.</param>
		/// <param name="value">事件内容.</param>
		public Event ( EventType type, string value )
		{

			if ( null == value )
				value = string.Empty;

			this.Type = type;
			this.Value = value;
		}

	}
	#endregion

}
