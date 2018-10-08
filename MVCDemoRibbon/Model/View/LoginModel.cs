/************************************************************************
* Assembly   : MVCDemo.Model
* Author     : Jonas.Wang
* Created    : 2017/7/13 14:44:38
*
* File Name  : LoginModel
* Class Name : LoginModel
* Function   : N/A
*
*
* Version   ModifiedTime           Author          Summary
* ───────────────────────────────────
* V0.01     2017/7/13 14:44:38     Jonas.Wang      create
*
*  
* Company : N/A                                                     
* Copyright (c) 2017. All rights reserved. 　　　　　　　　　　　　　                   
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDemoRibbon.Broker.Model;
using Jonas.Common.Bindings;

namespace MVCDemoRibbon.Model.View
{
    /// <summary>
    /// 这种绑定模式用于界面只显示，而没有输入
    /// </summary>
    public class LoginModel : AsyncBindingData, ILoginModel
    {
        
        #region  Method 方法
        #endregion  Method

        #region  Property   属性
        public string User
        {
            get { return this.m_user; }
            set
            {
                if (this.m_user == value)
                    return;
                
                m_user = value;
                base.OnPropertyChanged("User");
            }
        }
        public string Password
        {
            get { return this.m_password; }
            set 
            {
                if (this.m_password == value)
                    return;
                
                m_password = value;
                base.OnPropertyChanged("Password");
            }
        }
        public bool Remember
        {
            get { return this.m_remember; }
            set
            {
                if (this.m_remember == value)
                    return;
                
                m_remember = value;
                base.OnPropertyChanged("Remember");
            }
        }
        public string Message
        {
            get { return this.m_message; }
            set
            {
                if (this.m_message == value)
                    return;
                
                m_message = value;
                base.OnPropertyChanged("Message");
            }
        }
        #endregion  Property

        #region  Filed  字段
        private string m_password = "";
        private string m_user = "";
        private bool m_remember = false;
        private string m_message = "";
        #endregion  Filed
    }
}
