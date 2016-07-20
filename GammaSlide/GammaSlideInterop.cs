using System;
using System.Runtime.InteropServices;

namespace GammaSlide
{
    static class GammaSlideInterop
    {
        #region Interop DLLs

        [DllImport("gdi32.dll")]
        public static extern bool SetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

        [DllImport("gdi32.dll")]
        public static extern int GetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        #endregion Interop DLLs

        #region Interop Structs

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct RAMP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Blue;
        }

        #endregion Interop Structs

        #region Public Methods

        public static RAMP GetGamma()
        {
            RAMP ramp = new RAMP();
            GetDeviceGammaRamp(GetDC(IntPtr.Zero), ref ramp);
            return ramp;
        }

        public static bool SetGamma(RAMP ramp)
        {
            return SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref ramp);
        }

        #endregion Public Methods
    }
}
