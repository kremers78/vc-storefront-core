﻿using VirtoCommerce.Storefront.Model.Common.Events;
using VirtoCommerce.Storefront.Model.Customer;

namespace VirtoCommerce.Storefront.Model.Customer.Events
{
    /// <summary>
    /// Event generated when user logged in to the storefront
    /// </summary>
    public partial class UserLoginEvent : DomainEvent
    {
        public UserLoginEvent(WorkContext workContext, CustomerInfo user)
        {
            WorkContext = workContext;
            User = user;
        }

        public WorkContext WorkContext { get; set; }
        public CustomerInfo User { get; set; }
    }
}