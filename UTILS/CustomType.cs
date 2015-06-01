using System;
using System.Collections.Generic;

namespace UTILS
{

    public static class CustomType
    {
        public enum PartnerActionLogType
        {
            UpdateBalance = 1
        }
        public enum CustomerServiceType : int
        {
            Channel = 1,
            ChannelPackage = 2,
            Service = 3,
            VOD = 4,
            VODSet = 5,
            VODBundle = 6,
            ServicePackage = 7,
            ServiceSet = 8, //chưa dùng đến
            VODCredit = 9, //chưa dùng đến
            //Extend
            ChannelCategory = 10,
            ChannelProgram = 11,
            VODCategory = 12,
            SetTopBox = 13,
            Balance = 14
        }

        public enum CustomerApply : int
        {
            New = 0, // Khách hàng tạo mới
            Extend = 1, // Khách hàng gia hạn
            All = 2 //Cả hai trường hợp
        }

        public enum TransactionLogType : int
        {
            Rent = 1, //STB rent
            Buy = 2, //STB Buy
            Play = 3, //STB Play
            ResellerBuyBalance = 4,
            ResellerBuySTB = 5,
            ResellerBuyUpdateService = 6, //Gia han
            ResellerBuyNewService = 7, // Them moi
            Other = 0
        }

        public enum MessageType : int
        {
            AdminToMember = 1,
            ContentProviderToMember = 2
        }

        public enum CustomerAccountType : int
        {
            PrimaryAccount = 1,
            SubAccount = 2
        }

        public enum VODPackageType : int
        {
            Package = 1,
            Bundle = 2
        }

        public enum PermitActionType : int
        {
            View = 0,
            Insert = 1,
            Update = 2,
            Delele = 3,
            Special = 4
        }

        public enum UserType
        {
            RootAdmin = 0,
            Admin = 1,
            Reseller = 2,
            ContentProvider = 3,
            User = 4
        }

        public enum CustomerActiveStatus
        {
            Inactive = 0,
            Active = 1,
            Locked = 2
        }

        public enum ActionLogType
        {
            View = 0,
            Update = 1,
            Insert = 2,
            Delete = 3
        }

        public enum ActionLogFrom
        {
            Cms = 0,
            Stb = 1,
            Webservice = 2
        }

        public static Dictionary<int, string> ActionLogFromName = new Dictionary<int, string>()
        {
            {0, "CMS"},
            {1, "STB"},
            {2, "WEBSERVICE"}
        };

        public static Dictionary<int, string> ActionLogTypeName = new Dictionary<int, string>()
        {
            {0,"View"},
            {1,"Update"},
            {2,"Insert"},
            {3,"Delete"},
        };

    }
}
