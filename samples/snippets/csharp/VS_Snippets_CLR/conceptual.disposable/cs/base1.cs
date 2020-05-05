﻿// <Snippet9>
using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Runtime.InteropServices;

public class DisposableStreamResource : IDisposable
{
    // Define constants.
    protected const uint GENERIC_READ = 0x80000000;
    protected const uint FILE_SHARE_READ = 0x00000001;
    protected const uint OPEN_EXISTING = 3;
    protected const uint FILE_ATTRIBUTE_NORMAL = 0x80;
    protected IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
    const int INVALID_FILE_SIZE = unchecked((int)0xFFFFFFFF);

    // Define Windows APIs.
    [DllImport("kernel32.dll", EntryPoint = "CreateFileW", CharSet = CharSet.Unicode)]
    protected static extern IntPtr CreateFile(
        string lpFileName, uint dwDesiredAccess,
        uint dwShareMode, IntPtr lpSecurityAttributes,
        uint dwCreationDisposition, uint dwFlagsAndAttributes,
        IntPtr hTemplateFile);

    [DllImport("kernel32.dll")]
    static extern int GetFileSize(SafeFileHandle hFile, out int lpFileSizeHigh);

    // Define locals.
    bool _disposed = false;
    readonly SafeFileHandle _safeHandle;
    readonly int _upperWord;

    public DisposableStreamResource(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            throw new ArgumentException("The fileName cannot be null or an empty string");
        }

        IntPtr handle = CreateFile(
            fileName, GENERIC_READ, FILE_SHARE_READ, IntPtr.Zero,
            OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, IntPtr.Zero);

        if (handle == INVALID_HANDLE_VALUE)
        {
            throw new FileNotFoundException($"Cannot open '{fileName}'");
        }

        _safeHandle = new SafeFileHandle(handle, true);

        // Get file size.
        Size = GetFileSize(_safeHandle, out _upperWord);
        if (Size == INVALID_FILE_SIZE)
        {
            Size = -1;
        }
        else if (_upperWord > 0)
        {
            Size = (((long)_upperWord) << 32) + Size;
        }
    }

    public long Size { get; }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        // Dispose of managed resources here.
        if (disposing)
        {
            _safeHandle.Dispose();
        }

        // Dispose of any unmanaged resources not wrapped in safe handles.

        _disposed = true;
    }
}
// </Snippet9>