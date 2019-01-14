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

namespace Microsoft.Samples.VisualStudio.CodeSweep.Scanner
{
    class MultiFileScanResult : IMultiFileScanResult
    {
        List<IScanResult> _fileResults = new List<IScanResult>();

        /// <summary>
        /// Creates a new MultiFileScanResult object with default values indicating no files have
        /// been scanned.
        /// </summary>
        public MultiFileScanResult()
        {
        }

        /// <summary>
        /// Appends the results of a single-file scan to this multi-file result.
        /// </summary>
        /// <param name="fileResult">The results of the single-file scan.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <c>fileResult</c> is null.</exception>
        /// <remarks>
        /// As a result of a successfull call to this method:
        ///   * 'Attempted' will be incremented by one.
        ///   * One of 'PassedScan', 'FailedScan', or 'UnableToScan' will be incremented by one.
        ///   * An entry will be added to 'Results'.
        /// </remarks>
        public void Append(IScanResult fileResult)
        {
            if (fileResult == null)
            {
                throw new ArgumentNullException("fileResult");
            }

            _fileResults.Add(fileResult);
        }

        #region IMultiFileScanResult Members

        /// <summary>
        /// Gets the number of files on which a scan has been attempted.
        /// </summary>
        public int Attempted
        {
            get
            {
                return _fileResults.Count;
            }
        }

        /// <summary>
        /// Gets the number of files that have passed the scan.
        /// </summary>
        public int PassedScan
        {
            get
            {
                int total = 0;
                _fileResults.ForEach(new Action<IScanResult>(delegate(IScanResult result) { if (result.Passed) ++total; }));
                return total;
            }
        }

        /// <summary>
        /// Gets the number of files that have failed the scan.
        /// </summary>
        public int FailedScan
        {
            get
            {
                int total = 0;
                _fileResults.ForEach(new Action<IScanResult>(delegate(IScanResult result) { if (result.Scanned && !result.Passed) ++total; }));
                return total;
            }
        }

        /// <summary>
        /// Gets the number of files that could not be scanned, due to invalid file paths,
        /// insufficient permissions, etc.
        /// </summary>
        public int UnableToScan
        {
            get
            {
                int total = 0;
                _fileResults.ForEach(new Action<IScanResult>(delegate(IScanResult result) { if (!result.Scanned) ++total; }));
                return total;
            }
        }

        /// <summary>
        /// Gets the results of the scan of each file.
        /// </summary>
        public IEnumerable<IScanResult> Results
        {
            get { return _fileResults; }
        }

        #endregion
    }
}
