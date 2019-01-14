/***************************************************************************

Copyright (c) Microsoft Corporation. All rights reserved.
This code is licensed under the Visual Studio SDK license terms.
THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.

***************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio;

namespace Microsoft.Samples.VisualStudio.CodeSweep.UnitTests
{
    class MockTextManager : IVsTextManager
    {
        readonly Dictionary<string, MockTextView> _views = new Dictionary<string, MockTextView>();

        public MockTextView AddView(string fileName)
        {
            MockTextView view = new MockTextView();
            _views.Add(fileName, view);
            return view;
        }

        #region IVsTextManager Members

        public int AdjustFileChangeIgnoreCount(IVsTextBuffer pBuffer, int fIgnore)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int AttemptToCheckOutBufferFromScc(IVsUserData pBufData, out int pfCheckoutSucceeded)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int AttemptToCheckOutBufferFromScc2(string pszFileName, out int pfCheckoutSucceeded, out int piStatusFlags)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int CreateSelectionAction(IVsTextBuffer pBuffer, out IVsTextSelectionAction ppAction)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int EnumBuffers(out IVsEnumTextBuffers ppEnum)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int EnumIndependentViews(IVsTextBuffer pBuffer, out IVsEnumIndependentViews ppEnum)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int EnumLanguageServices(out IVsEnumGUID ppEnum)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int EnumViews(IVsTextBuffer pBuffer, out IVsEnumTextViews ppEnum)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int GetActiveView(int fMustHaveFocus, IVsTextBuffer pBuffer, out IVsTextView ppView)
        {
            string fileName = ((MockTextLines)pBuffer).FileName;

            if (_views.ContainsKey(fileName))
            {
                ppView = _views[fileName];
                return VSConstants.S_OK;
            }
            else
            {
                ppView = null;
                return VSConstants.E_INVALIDARG;
            }
        }

        public int GetBufferSccStatus(IVsUserData pBufData, out int pbNonEditable)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int GetBufferSccStatus2(string pszFileName, out int pbNonEditable, out int piStatusFlags)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int GetMarkerTypeCount(out int piMarkerTypeCount)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int GetMarkerTypeInterface(int iMarkerTypeID, out IVsTextMarkerType ppMarkerType)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int GetPerLanguagePreferences(LANGPREFERENCES[] pLangPrefs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int GetRegisteredMarkerTypeID(ref Guid pguidMarker, out int piMarkerTypeID)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int GetShortcutManager(out IVsShortcutManager ppShortcutMgr)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int GetUserPreferences(VIEWPREFERENCES[] pViewPrefs, FRAMEPREFERENCES[] pFramePrefs, LANGPREFERENCES[] pLangPrefs, FONTCOLORPREFERENCES[] pColorPrefs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int IgnoreNextFileChange(IVsTextBuffer pBuffer)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int MapFilenameToLanguageSID(string pszFileName, out Guid pguidLangSID)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int NavigateToLineAndColumn(IVsTextBuffer pBuffer, ref Guid guidDocViewType, int iStartRow, int iStartIndex, int iEndRow, int iEndIndex)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int NavigateToPosition(IVsTextBuffer pBuffer, ref Guid guidDocViewType, int iPos, int iLen)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int RegisterBuffer(IVsTextBuffer pBuffer)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int RegisterIndependentView(object pUnk, IVsTextBuffer pBuffer)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int RegisterView(IVsTextView pView, IVsTextBuffer pBuffer)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int SetFileChangeAdvise(string pszFileName, int fStart)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int SetPerLanguagePreferences(LANGPREFERENCES[] pLangPrefs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int SetUserPreferences(VIEWPREFERENCES[] pViewPrefs, FRAMEPREFERENCES[] pFramePrefs, LANGPREFERENCES[] pLangPrefs, FONTCOLORPREFERENCES[] pColorPrefs)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int SuspendFileChangeAdvise(string pszFileName, int fSuspend)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int UnregisterBuffer(IVsTextBuffer pBuffer)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int UnregisterIndependentView(object pUnk, IVsTextBuffer pBuffer)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int UnregisterView(IVsTextView pView)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
