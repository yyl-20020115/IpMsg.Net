using System;

namespace FSLib.IPMessager.Core;

/// <summary>
/// 包含收到的文件的数据
/// </summary>
/// <remarks>
/// 创建 <see cref="FileReceivedEventArgs" /> 的新实例
/// </remarks>
public class FileReceivedEventArgs(Entity.Host host, Entity.Message message, Entity.FileTaskInfo file) : EventArgs
{
    public Entity.Host Host { get; private set; } = host;

    public Entity.Message Message { get; private set; } = message;

    public Entity.FileTaskInfo File { get; private set; } = file;
}
