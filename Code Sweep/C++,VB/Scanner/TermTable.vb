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
Imports System.Xml
Imports System.Globalization

Namespace Microsoft.Samples.VisualStudio.CodeSweep.Scanner
    Friend Class TermTable
        Implements ITermTable
        Private ReadOnly _filePath As String
        Private ReadOnly _terms As New List(Of ISearchTerm)()

        Public Sub New(ByVal filePath As String)
            _filePath = filePath

            Dim document As New XmlDocument()
            document.Load(filePath)

            For Each node As XmlNode In document.SelectNodes("xmldata/PLCKTT/Lang/Term")
                Dim text As String = node.Attributes("Term").InnerText
                Dim severity As Integer = Int32.Parse(node.Attributes("Severity").InnerText, CultureInfo.InvariantCulture)
                Dim termClass As String = node.Attributes("TermClass").InnerText
                Dim comment As String = node.SelectSingleNode("Comment").InnerText

                Dim recommended As String = Nothing
                Dim recommendedNode As XmlNode = node.SelectSingleNode("RecommendedTerm")
                If recommendedNode IsNot Nothing Then
                    recommended = recommendedNode.InnerText
                End If

                Dim term As New SearchTerm(Me, text, severity, termClass, comment, recommended)

                For Each exclusionNode As XmlNode In node.SelectNodes("Exclusion")
                    term.AddExclusion(exclusionNode.InnerText)
                Next exclusionNode
                For Each exclusionNode As XmlNode In node.SelectNodes("ExclusionContext")
                    term.AddExclusion(exclusionNode.InnerText)
                Next exclusionNode

                _terms.Add(term)
            Next node

            If _terms.Count = 0 Then
                Throw New ArgumentException("The file did not specify a valid term table.", "filePath")
            End If
        End Sub

#Region "ITermTable Members"

        Public ReadOnly Property SourceFile() As String Implements ITermTable.SourceFile
            Get
                Return _filePath
            End Get
        End Property

        Public ReadOnly Property Terms() As IEnumerable(Of ISearchTerm) Implements ITermTable.Terms
            Get
                Return _terms
            End Get
        End Property

#End Region
    End Class
End Namespace
