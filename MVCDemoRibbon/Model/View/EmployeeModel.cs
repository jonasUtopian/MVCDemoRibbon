// ***********************************************************************
// Assembly         : MVC.Demo
// Author           : stephen.wang
// Created          : 06-17-2017
//
// Last Modified By : stephen.wang
// Last Modified On : 06-17-2017
// ***********************************************************************
// <copyright file="EmployeeModel.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using Jonas.Common.Bindings;
using System.ComponentModel;
using System.Threading;

namespace MVCDemoRibbon.Model.View
{
    
    /// <summary>
    /// Class EmployeeModel.
    /// 这种模型只适合用数据去刷新UI，而不能接收UI的输入
    /// </summary>
    public class EmployeeModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>The age.</value>
        public int Age
        {
            get { return age; }
            set 
            {
                if(this.age == value)
                    return;
                
                this.age = value;
                this.OnPropertyChanged("Age");
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get { return name; }
            set 
            { 
                if(this.name==value)
                    return;

                name = value;
                this.OnPropertyChanged("Name");
            }
        }

        private int age;
        private string name;
    }
}
