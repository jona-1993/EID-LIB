
using System;
using System.Runtime.InteropServices;
namespace Net.Sf.Pkcs11.Wrapper
{
	/// <summary>
	/// Description of LibraryManager.
	/// </summary>
	public class KernelUtilUNIX : IKernelUtil
	{
        public IntPtr LoadLibrary(string fileName)
        {
            return dlopen(fileName, RTLD_NOW);
        }

        public void FreeLibrary(IntPtr handle)
        {
            dlclose(handle);
        }

        public IntPtr GetProcAddress(IntPtr dllHandle, dynamic name)
        {
            // clear previous errors if any
            dlerror();
            var res = dlsym(dllHandle, (string)name);
            var errPtr = dlerror();
            if (errPtr != IntPtr.Zero)
            {
                throw new Exception("dlsym: " + Marshal.PtrToStringAnsi(errPtr));
            }
            return res;
        }

        

        #region KernelCalls
        const int RTLD_NOW = 2;

        [DllImport("libdl")]
        private static extern IntPtr dlopen(String fileName, int flags);

        [DllImport("libdl")]
        private static extern IntPtr dlsym(IntPtr handle, String symbol);

        [DllImport("libdl")]
        private static extern int dlclose(IntPtr handle);

        [DllImport("libdl")]
        private static extern IntPtr dlerror();
        #endregion

    }
}
