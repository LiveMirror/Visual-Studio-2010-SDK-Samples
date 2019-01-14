'**************************************************************************

'Copyright (c) Microsoft Corporation. All rights reserved.
'This code is licensed under the Visual Studio SDK license terms.
'THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.

'**************************************************************************


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Microsoft.Samples.VisualStudio.CodeSweep.Scanner
Imports Microsoft.Build.Framework

Namespace Microsoft.Samples.VisualStudio.CodeSweep.BuildTask
    ''' <summary>
    ''' The interface implemented by the host object the CodeSweep VS package sets for the scanner
    ''' build tasks.
    ''' </summary>
    Public Interface IScannerHost
        Inherits ITaskHost
        ''' <summary>
        ''' Adds the results of a file scan to the task list.
        ''' </summary>
        ''' <param name="result">The results of the file scan.</param>
        ''' <param name="projectFile">The full path of the project file.</param>
        Sub AddResult(ByVal result As IScanResult, ByVal projectFile As String)

        ''' <summary>
        ''' Returns the text of the specified file, or null if it is not open in the IDE.
        ''' </summary>
        ''' <param name="filePath">The full path of the file.</param>
        ''' <returns>The text of the file, or null.</returns>
        Function GetTextOfFileIfOpenInIde(ByVal filePath As String) As String
    End Interface
End Namespace
