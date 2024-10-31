using System;
using FSLib.IPMessager.Entity;

namespace FSLib.IPMessager.Core;

/// <summary>
/// 请求接收文件事件-用文件管理器和TCP线程调度信息
/// </summary>
/// <remarks>
/// 创建一个新的 FileReceiveEventArgs 对象.
/// </remarks>
public class FileReceiveRequiredEventArgs(FileTaskInfo task, FileTaskItem item) : EventArgs
{
    /// <summary>
    /// 任务信息
    /// </summary>
    public FileTaskInfo Task { get; set; } = task;

    /// <summary>
    /// 任务项目
    /// </summary>
    public FileTaskItem Item { get; set; } = item;

    /// <summary>
    /// 是否已经处理
    /// </summary>
    public bool IsHandled { get; set; } = false;
}
