﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added.";
        public static string ProductNameInvalid = "Product name is invalid.";
        public static string MaintenanceTime = "System in maintenance.";
        public static string ProductsListed = "Products listed";
        public static string ProductOfCountCategoryError = "Category count limit reached.";
        public static string ProductNameAlreadyExists = "This name is already used for another.";
        public static string CategoryLimitExceded = "Category limit exceded.";
        public static string AuthorizationDenied = "You don't have authorization.";
    }
}
