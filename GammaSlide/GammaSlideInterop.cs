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

        [DllImport("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hdc);

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

        public static RAMP CalcRampFromGamma(float gamma)
        {
            RAMP ramp = new RAMP();
            ramp.Red = new ushort[256];
            ramp.Green = new ushort[256];
            ramp.Blue = new ushort[256];

            for (int i = 0; i < ramp.Red.Length; i++)
            {
                var val = (ushort)Math.Min(65535, Math.Max(0, Math.Pow((double)((float)((double)(i + 1) / 256)), (double)((float)gamma)) * 65535 + 0.5));
                ramp.Red[i] = ramp.Blue[i] = ramp.Green[i] = val;
            }
            return ramp;
        }

        public static float GetGammaFromRamp(RAMP ramp)
        {
            float single = 0f;
            int num = 0;
            int num1 = 0;
            int num2 = num1 + 256;
            for (int i = 0; i < 256; i++)
            {
                double num3 = (double)(i % 256) / 256;
                double num4 = (double)ramp.Red[i] / 65536;
                float single1 = (float)(Math.Log(num4) / Math.Log(num3));
                single = single + single1;
                num++;
            }
            return single / (float)num;
        }

        public static RAMP GetCurrentGamma()
        {
            RAMP ramp = new RAMP();
            IntPtr dc = GetDC(IntPtr.Zero);
            GetDeviceGammaRamp(dc, ref ramp);
            ReleaseDC(IntPtr.Zero, dc);
            return ramp;
        }

        public static bool SetGamma(RAMP ramp)
        {
            bool result = false;
            IntPtr dc = GetDC(IntPtr.Zero);
            result = SetDeviceGammaRamp(dc, ref ramp);
            ReleaseDC(IntPtr.Zero, dc);
            return result;
        }

        #endregion Public Methods
    }
}
