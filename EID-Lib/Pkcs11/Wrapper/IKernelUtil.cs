using System;
namespace Net.Sf.Pkcs11.Wrapper
{
    public interface IKernelUtil
    {
        IntPtr LoadLibrary(string fileName);
        void FreeLibrary(IntPtr handle);
        IntPtr GetProcAddress(IntPtr dllHandle, dynamic name);
    }
}
