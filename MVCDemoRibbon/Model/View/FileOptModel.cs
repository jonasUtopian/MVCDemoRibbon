/************************************************************************
* Assembly   : MVCDemo.Model
* Author     : Jonas.Wang
* Created    : 2017/7/9 18:17:42
*
* File Name  : FileOptModel
* Class Name : FileOptModel
* Function   : N/A
*
*
* Version   ModifiedTime           Author          Summary
* ───────────────────────────────────
* V0.01     2017/7/9 18:17:42     Jonas.Wang      create
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
    class FileOptModel : AsyncBindingData, IFileOptModel
    {
        /// <summary>
        /// Gets or sets the desPathName.
        /// </summary>
        /// <value>The name.</value>
        public string SourcePathName
        {
            get { return sourcePathName; }
            set
            {
                if (this.sourcePathName == value)
                    return;
                
                sourcePathName = value;
                base.OnPropertyChanged("SourcePathName");
            }
        }

        /// <summary>
        /// Gets or sets the desPathName.
        /// </summary>
        /// <value>The name.</value>
        public string DesPathName
        {
            get { return desPathName; }
            set
            {
                if (this.desPathName == value)
                    return;
                
                desPathName = value;
                base.OnPropertyChanged("DesPathName");
            }
        }

        private string sourcePathName;
        private string desPathName;
    }
}
