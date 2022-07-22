// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtScenarioTest.Models
{
    /// <summary> The error code compose of code and message. </summary>
    public partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        public Error()
        {
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> The code of error. </param>
        /// <param name="message"> The message of error. </param>
        internal Error(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> The code of error. </summary>
        public string Code { get; set; }
        /// <summary> The message of error. </summary>
        public string Message { get; set; }
    }
}
