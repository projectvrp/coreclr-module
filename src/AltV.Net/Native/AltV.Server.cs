using System;
using System.Runtime.InteropServices;
using AltV.Net.Data;

namespace AltV.Net.Native
{
    internal static partial class AltVNative
    {
        internal static class Server
        {
            [DllImport(_dllName, CharSet = CharSet.Ansi, CallingConvention = _callingConvention)]
            internal static extern void Server_LogInfo(IntPtr serverPointer, string message);

            [DllImport(_dllName, CharSet = CharSet.Ansi, CallingConvention = _callingConvention)]
            internal static extern void Server_LogDebug(IntPtr serverPointer, string message);

            [DllImport(_dllName, CharSet = CharSet.Ansi, CallingConvention = _callingConvention)]
            internal static extern void Server_LogWarning(IntPtr serverPointer, string message);

            [DllImport(_dllName, CharSet = CharSet.Ansi, CallingConvention = _callingConvention)]
            internal static extern void Server_LogError(IntPtr serverPointer, string message);

            [DllImport(_dllName, CharSet = CharSet.Ansi, CallingConvention = _callingConvention)]
            internal static extern void Server_LogColored(IntPtr serverPointer, string message);

            [DllImport(_dllName, CharSet = CharSet.Ansi, CallingConvention = _callingConvention)]
            internal static extern uint Server_Hash(IntPtr serverPointer, string hash);
            
            [DllImport(_dllName, CharSet = CharSet.Ansi, CallingConvention = _callingConvention)]
            internal static extern void Server_TriggerServerEvent(IntPtr serverPointer, string eventName, ref MValue args);
            
            [DllImport(_dllName, CharSet = CharSet.Ansi, CallingConvention = _callingConvention)]
            internal static extern void Server_TriggerClientEvent(IntPtr serverPointer, IntPtr playerPointer, string eventName, ref MValue args);

            [DllImport(_dllName, CharSet = CharSet.Ansi, CallingConvention = _callingConvention)]
            internal static extern IntPtr Server_CreateVehicle(IntPtr serverPointer, uint model, Position pos,
                float heading);

            [DllImport(_dllName, CharSet = CharSet.Ansi, CallingConvention = _callingConvention)]
            internal static extern void Server_RemoveEntity(IntPtr serverPointer, IntPtr entityPointer);
        }
    }
}