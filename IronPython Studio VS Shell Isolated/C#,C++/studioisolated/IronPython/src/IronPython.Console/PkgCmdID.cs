﻿// MUST match the VSCT file
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Samples.VisualStudio.IronPython.Console
{
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
    [SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase")]
    public static class PkgCmdIDList
    {
        public const uint IPConsoleContextMenu = 0x2100;

        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        public const uint cmdidIronPythonConsole = 0x101;
    };
}