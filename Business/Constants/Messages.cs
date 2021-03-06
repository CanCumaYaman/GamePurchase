using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car Added";
        public static string CarNameInvalid = "Car name invalid";
        public static string MaintenanceTime = "System is in maintenance";
        public static string CarsListed = "Cars are listed";
        public static string CampaignEndDateExpired = "This campaign has expired";
        public static string AuthorizationDenied = "You dont have authorization";
        
        public static string AccessTokenCreated = "Token is created";
        public static string UserAlreadyExists = "This user already exist";
        public static string InValidUser = "Invalid user";
        public static string SuccessfullyRegister = "Registeration is successfull";
        public static string PasswordError = "Password wrong";
        public static string SuccessfullyLogin = "Successfully login";
        public static string ValidUser = "Valid user";

        public static string UserNotFound = "User not found";
    }
}
