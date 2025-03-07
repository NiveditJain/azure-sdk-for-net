// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Validation for inquired protectable items under a given container. </summary>
    public partial class InquiryValidation
    {
        /// <summary> Initializes a new instance of InquiryValidation. </summary>
        public InquiryValidation()
        {
        }

        /// <summary> Initializes a new instance of InquiryValidation. </summary>
        /// <param name="status"> Status for the Inquiry Validation. </param>
        /// <param name="errorDetail"> Error Detail in case the status is non-success. </param>
        /// <param name="additionalDetail"> Error Additional Detail in case the status is non-success. </param>
        internal InquiryValidation(string status, ErrorDetail errorDetail, string additionalDetail)
        {
            Status = status;
            ErrorDetail = errorDetail;
            AdditionalDetail = additionalDetail;
        }

        /// <summary> Status for the Inquiry Validation. </summary>
        public string Status { get; set; }
        /// <summary> Error Detail in case the status is non-success. </summary>
        public ErrorDetail ErrorDetail { get; set; }
        /// <summary> Error Additional Detail in case the status is non-success. </summary>
        public string AdditionalDetail { get; }
    }
}
