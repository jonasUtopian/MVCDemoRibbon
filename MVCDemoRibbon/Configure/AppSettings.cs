using Jonas.Tool.Authority;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Configure
{
    public static class AppSettings
    {
        #region  Method
        public static void SaveMainViewType(string type)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationElement kvc = config.AppSettings.Settings[m_MainViewType];
            if (kvc == null)
                return;

            kvc.Value = type;
            config.Save();
        }

        public static string GetMainViewType()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return config.AppSettings.Settings[m_MainViewType].Value;
        }

        public static string GetSkinName()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return config.AppSettings.Settings[m_SkinName].Value;
        }

        public static void SaveSkinName(string skinName)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            KeyValueConfigurationElement kvc = config.AppSettings.Settings[m_SkinName];
            if (kvc == null)
            {
                return;
            }

            kvc.Value = skinName;
            config.Save();
        }

        /// <summary>
        /// Saves the remember.
        /// </summary>
        /// <param name="account">The account.</param>
        /// <param name="password">The password.</param>
        public static void SaveRemember(string account, string password)
        {
            Translator translator = new Translator();
            password = translator.Encrypt(password);

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            KeyValueConfigurationElement accountElement = config.AppSettings.Settings[m_RememberAccountKey];
            if (accountElement == null)
            {
                return;
            }
            accountElement.Value = account;

            KeyValueConfigurationElement passwordElement = config.AppSettings.Settings[m_RememberPasswordKey];
            if (passwordElement == null)
            {
                return;
            }
            passwordElement.Value = password;
            config.Save();
        }

        /// <summary>
        /// Gets the remember.
        /// </summary>
        /// <param name="account">The account.</param>
        /// <param name="password">The password.</param>
        public static void GetRemember(ref string account, ref string password)
        {
            Translator translator = new Translator();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            account = config.AppSettings.Settings[m_RememberAccountKey].Value;
            password = config.AppSettings.Settings[m_RememberPasswordKey].Value;
            password = translator.Decrypt(password);
        }

        public static string GetCryptographyKey()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return config.AppSettings.Settings[m_CryptographyKey].Value;
        }

        public static void SaveAuthorityKey(string authorityKey)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationElement kvc = config.AppSettings.Settings[m_AuthorityKey];
            if (kvc == null)
                return;

            kvc.Value = authorityKey;
            config.Save();
        }

        public static string GetAuthorityKey()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return config.AppSettings.Settings[m_AuthorityKey].Value;
        }
        #endregion  Method

        #region  Property   属性

        #endregion  Property

        #region  Filed
        private static readonly string m_RememberAccountKey = "RememberAccount";
        private static readonly string m_RememberPasswordKey = "RememberPassword";
        private static readonly string m_SkinName = "SkinName";
        private static readonly string m_MainViewType = "MainViewType";
        private static readonly string m_AuthorityKey = "AuthorityKey";
        private static readonly string m_CryptographyKey = "CryptographyKey";
        #endregion  Filed
    }
}
