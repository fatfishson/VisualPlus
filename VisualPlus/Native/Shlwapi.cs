#region Namespace

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

#endregion

namespace VisualPlus.Native
{
    [SuppressUnmanagedCodeSecurity]
    internal static class Shlwapi
    {
        #region Methods

        [Description("Truncates a path to fit within a certain number of characters by replacing path components with ellipses.")]
        [DllImport("shlwapi.dll", CharSet = CharSet.Auto)]
        public static extern bool PathCompactPath(IntPtr hDc, [In] [Out] StringBuilder pszPath, int dx);

        #endregion
    }
}