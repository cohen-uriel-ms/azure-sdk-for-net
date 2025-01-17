// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary> A class representing the SecurityContact data model. </summary>
    public partial class SecurityContactData : ResourceData
    {
        /// <summary> Initializes a new instance of SecurityContactData. </summary>
        public SecurityContactData()
        {
        }

        /// <summary> Initializes a new instance of SecurityContactData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="email"> The email of this security contact. </param>
        /// <param name="phone"> The phone number of this security contact. </param>
        /// <param name="alertNotifications"> Whether to send security alerts notifications to the security contact. </param>
        /// <param name="alertsToAdmins"> Whether to send security alerts notifications to subscription admins. </param>
        internal SecurityContactData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string email, string phone, AlertNotification? alertNotifications, AlertsToAdmin? alertsToAdmins) : base(id, name, resourceType, systemData)
        {
            Email = email;
            Phone = phone;
            AlertNotifications = alertNotifications;
            AlertsToAdmins = alertsToAdmins;
        }

        /// <summary> The email of this security contact. </summary>
        public string Email { get; set; }
        /// <summary> The phone number of this security contact. </summary>
        public string Phone { get; set; }
        /// <summary> Whether to send security alerts notifications to the security contact. </summary>
        public AlertNotification? AlertNotifications { get; set; }
        /// <summary> Whether to send security alerts notifications to subscription admins. </summary>
        public AlertsToAdmin? AlertsToAdmins { get; set; }
    }
}
