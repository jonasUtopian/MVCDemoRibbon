using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDemoRibbon.Broker.View.User;

namespace MVCDemoRibbon.View.User
{
    public partial class EmployeeView : BaseCtrl, IEmployeeView
    {
        public EmployeeView()
        {
            InitializeComponent();
        }

        [Bindable(true)]
        public int EmployeeAge
        {
            get { return employeeAge; }
            set
            {
                employeeAge = value;
                this.label1.Text = value.ToString();
            }
        }

        [Bindable(true)]
        public string EmployeeName
        {
            get { return employeeName; }
            set
            { 
                employeeName = value;
                this.label2.Text = value;
            }
        }

        /// <summary>
        /// The age
        /// </summary>
        private int employeeAge;
        /// <summary>
        /// The name
        /// </summary>
        private string employeeName;


    }
}
