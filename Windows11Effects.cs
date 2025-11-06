using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Windows11Effects
{
    /// <summary>
    /// Provides Windows 11 visual effects for Windows Forms applications
    /// Mica, Acrylic, and Dark Mode effects for modern UI styling
    /// </summary>
    public class Windows11Effects
    {
        private readonly Form _targetForm;

        // DWMWA constants
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        private const int DWMWA_SYSTEMBACKDROP_TYPE = 38;

        /// <summary>
        /// DWM system backdrop types for different visual effects
        /// </summary>
        public enum DWM_SYSTEMBACKDROP_TYPE
        {
            DWMSBT_AUTO = 0,
            DWMSBT_NONE = 1,
            DWMSBT_MAINWINDOW = 2,      // Mica effect
            DWMSBT_TRANSIENTWINDOW = 3, // Acrylic effect
            DWMSBT_TABBEDWINDOW = 4
        }

        // Margins structure for extending frame into client area
        [StructLayout(LayoutKind.Sequential)]
        private struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        // Windows DWM API imports
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        /// <summary>
        /// Initializes a new instance of Windows11Effects for the specified form
        /// </summary>
        /// <param name="targetForm">The Windows Form to apply visual effects to</param>
        /// <exception cref="ArgumentNullException">Thrown when targetForm is null</exception>
        public Windows11Effects(Form targetForm)
        {
            _targetForm = targetForm ?? throw new ArgumentNullException(nameof(targetForm));
            
            // Enable double buffering for smoother visual effects
            SetDoubleBuffering(_targetForm, true);
        }

        /// <summary>
        /// Checks if the current operating system is Windows 11 or greater
        /// </summary>
        /// <returns>True if Windows 11 or greater, otherwise false</returns>
        public static bool IsWindows11OrGreater()
        {
            var version = Environment.OSVersion.Version;
            return version.Major >= 10 && version.Build >= 22000;
        }

        /// <summary>
        /// Enables or disables dark mode for the form
        /// </summary>
        /// <param name="enable">True to enable dark mode, false to disable</param>
        public void SetDarkMode(bool enable)
        {
            if (!IsWindows11OrGreater())
            {
                Console.WriteLine("Dark mode requires Windows 11 or greater");
                return;
            }

            try
            {
                int darkMode = enable ? 1 : 0;
                int result = DwmSetWindowAttribute(_targetForm.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE,
                    ref darkMode, sizeof(int));

                if (result == 0)
                {
                    Console.WriteLine($"Dark mode {(enable ? "enabled" : "disabled")} successfully");
                }
                else
                {
                    Console.WriteLine($"Failed to set dark mode. Error code: {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Dark mode error: {ex.Message}");
            }
        }

        /// <summary>
        /// Applies the Mica material effect to the form (Windows 11 signature effect)
        /// </summary>
        public void EnableMicaEffect()
        {
            if (!IsWindows11OrGreater())
            {
                Console.WriteLine("Mica effect requires Windows 11 or greater");
                return;
            }

            if (!IsDwmCompositionEnabled())
            {
                Console.WriteLine("DWM composition is not enabled. Mica effect requires DWM.");
                return;
            }

            try
            {
                int micaValue = (int)DWM_SYSTEMBACKDROP_TYPE.DWMSBT_MAINWINDOW;
                int result = DwmSetWindowAttribute(_targetForm.Handle, DWMWA_SYSTEMBACKDROP_TYPE,
                    ref micaValue, sizeof(int));

                if (result == 0)
                {
                    // Extend frame into client area for proper Mica effect
                    MARGINS margins = new MARGINS { topHeight = _targetForm.Height };
                    DwmExtendFrameIntoClientArea(_targetForm.Handle, ref margins);
                    
                    Console.WriteLine("Mica effect applied successfully");
                }
                else
                {
                    Console.WriteLine($"Failed to apply Mica effect. Error code: {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mica effect error: {ex.Message}");
            }
        }

        /// <summary>
        /// Applies the Acrylic blur effect to the form
        /// </summary>
        public void EnableAcrylicEffect()
        {
            if (!IsWindows11OrGreater())
            {
                Console.WriteLine("Acrylic effect requires Windows 11 or greater");
                return;
            }

            try
            {
                int acrylicValue = (int)DWM_SYSTEMBACKDROP_TYPE.DWMSBT_TRANSIENTWINDOW;
                int result = DwmSetWindowAttribute(_targetForm.Handle, DWMWA_SYSTEMBACKDROP_TYPE,
                    ref acrylicValue, sizeof(int));

                if (result == 0)
                {
                    Console.WriteLine("Acrylic effect applied successfully");
                }
                else
                {
                    Console.WriteLine($"Failed to apply Acrylic effect. Error code: {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Acrylic effect error: {ex.Message}");
            }
        }

        /// <summary>
        /// Removes all background effects from the form
        /// </summary>
        public void DisableEffects()
        {
            if (!IsWindows11OrGreater()) return;

            try
            {
                int noneValue = (int)DWM_SYSTEMBACKDROP_TYPE.DWMSBT_NONE;
                int result = DwmSetWindowAttribute(_targetForm.Handle, DWMWA_SYSTEMBACKDROP_TYPE,
                    ref noneValue, sizeof(int));

                if (result == 0)
                {
                    Console.WriteLine("All effects disabled successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Disable effects error: {ex.Message}");
            }
        }

        /// <summary>
        /// Applies all Windows 11 effects (Mica + Dark Mode) in one call
        /// </summary>
        public void ApplyFullWindows11Theme()
        {
            if (!IsWindows11OrGreater())
            {
                Console.WriteLine("Windows 11 theme requires Windows 11 or greater");
                return;
            }

            EnableMicaEffect();
            SetDarkMode(true);
            
            // Set recommended form properties for best appearance
            _targetForm.FormBorderStyle = FormBorderStyle.Sizable;
            _targetForm.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        }

        /// <summary>
        /// Checks if DWM composition is enabled (required for visual effects)
        /// </summary>
        /// <returns>True if DWM composition is enabled</returns>
        private bool IsDwmCompositionEnabled()
        {
            try
            {
                int isEnabled = 0;
                int result = DwmIsCompositionEnabled(ref isEnabled);
                return result == 0 && isEnabled == 1;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Enables double buffering for smoother rendering
        /// </summary>
        private void SetDoubleBuffering(Control control, bool enable)
        {
            try
            {
                var doubleBufferPropertyInfo = control.GetType().GetProperty("DoubleBuffered", 
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                doubleBufferPropertyInfo?.SetValue(control, enable, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Double buffering error: {ex.Message}");
            }
        }
    }
}
