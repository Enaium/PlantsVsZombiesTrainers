﻿using System;
using System.Text;

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PlantsVsZombiesTool.classes
{

    public abstract class Memory
    {
        [DllImportAttribute("kernel32.dll", EntryPoint = "ReadProcessMemory")]
        public static extern bool ReadProcessMemory
            (
                IntPtr hProcess,
                IntPtr lpBaseAddress,
                IntPtr lpBuffer,
                int nSize,
                IntPtr lpNumberOfBytesRead
            );

        [DllImportAttribute("kernel32.dll", EntryPoint = "OpenProcess")]
        public static extern IntPtr OpenProcess
            (
                int dwDesiredAccess,
                bool bInheritHandle,
                int dwProcessId
            );

        [DllImport("kernel32.dll")]
        private static extern void CloseHandle
            (
                IntPtr hObject
            );

        //写内存
        [DllImportAttribute("kernel32.dll", EntryPoint = "WriteProcessMemory")]
        public static extern bool WriteProcessMemory
            (
                IntPtr hProcess,
                IntPtr lpBaseAddress,
                int[] lpBuffer,
                int nSize,
                IntPtr lpNumberOfBytesWritten
            );

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory
            (
                IntPtr handle,
                IntPtr baseAddress,
                byte[] buffer,
                int size, 
                out int length
            );

        //获取窗体的进程标识ID
        public static int GetPid(string windowTitle)
        {
            int rs = 0;
            Process[] arrayProcess = Process.GetProcesses();
            foreach (Process p in arrayProcess)
            {
                if (p.MainWindowTitle.IndexOf(windowTitle) != -1)
                {
                    rs = p.Id;
                    break;
                }
            }

            return rs;
        }

        //根据进程名获取PID
        public static int GetPidByProcessName(string processName)
        {
            Process[] arrayProcess = Process.GetProcessesByName(processName);

            foreach (Process p in arrayProcess)
            {
                return p.Id;
            }
            return 0;
        }

        //根据窗体标题查找窗口句柄（支持模糊匹配）
        public static IntPtr FindWindow(string title)
        {
            Process[] ps = Process.GetProcesses();
            foreach (Process p in ps)
            {
                if (p.MainWindowTitle.IndexOf(title) != -1)
                {
                    return p.MainWindowHandle;
                }
            }
            return IntPtr.Zero;
        }

        //读取内存中的值
        public static int ReadMemoryValue(int baseAddress, string processName)
        {

            byte[] buffer = new byte[4];
            IntPtr byteAddress = Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0); //获取缓冲区地址
            IntPtr hProcess = OpenProcess(0x1F0FFF, false, GetPidByProcessName(processName));
            ReadProcessMemory(hProcess, (IntPtr)baseAddress, byteAddress, 4, IntPtr.Zero); //将制定内存中的值读入缓冲区
            CloseHandle(hProcess);
            try
            {
                return Marshal.ReadInt32(byteAddress);
            }
            catch
            {
                return 0;
            }

        }

        //将值写入指定内存地址中
        public static void WriteMemoryValue(int baseAddress, string processName, int value)
        {
            IntPtr hProcess = OpenProcess(0x1F0FFF, false, GetPidByProcessName(processName)); //0x1F0FFF 最高权限
            WriteProcessMemory(hProcess, (IntPtr)baseAddress, new int[] { value }, 4, IntPtr.Zero);
            CloseHandle(hProcess);
        }


        public static void WriteMemoryValue(int address, string processName, byte[] data)
        {
            IntPtr _handle = OpenProcess(1080, false, GetPidByProcessName(processName));

            if (_handle == IntPtr.Zero)
                throw new InvalidOperationException("Cannot write process memory at " + address.ToString() + ". No process loaded.");

            if (new IntPtr(address) == IntPtr.Zero)
                throw new ArgumentOutOfRangeException("Cannot write process memory. Invalid memory address.");

            if (data.Length < 1)
                throw new ArgumentOutOfRangeException("Cannot write process memory of size " + data.Length + ".");

            int bytesWritten;

            if (!WriteProcessMemory(_handle, new IntPtr(address), data, data.Length, out bytesWritten))
                throw new Exception("Failed to write process memory at " + address.ToString() + ". Error code: " + Marshal.GetLastWin32Error().ToString());
        }

    }
}
