﻿using LoginDemo.Commom;

namespace LoginDemo.Entity.UserAccount
{
    public class UserInfo : BaseEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// account
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// password 
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// nickname
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public bool Gender { get; set; }

        /// <summary>
        /// company name 
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// remark
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// account type ,not include into UserInfo table 
        /// the field of UserAccountTypeMapping
        /// mean   1：mobile 2：emial 0：username
        /// </summary>

        [IgnoreField]
        public int AccountType { get; set; }

    }
}