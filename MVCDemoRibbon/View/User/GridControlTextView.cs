using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDemoRibbon.Broker.View.User;

namespace MVCDemoRibbon.View.User
{
    public partial class GridControlTextView : BaseCtrl, IGridControlTextView
    {
        #region  Method 方法
        public GridControlTextView()
        {
            InitializeComponent();
        }
        #endregion  Method     

        #region  Property

        /// <summary>
        /// Gets the binding source.
        /// </summary>
        /// <value>The binding source.</value>
        BindingSource IGridControlTextView.ClassesBindingSource
        {
            get{ return this.bdSorc_Classes; }
        }
        BindingSource IGridControlTextView.StudentsBindingSource
        {
            get { return this.bdSorc_Students; }
        }
        /// <summary>
        /// Gets the grid view.
        /// </summary>
        /// <value>The grid view.</value>
        GridView IGridControlTextView.GridView
        {
            get { return this.gridView_Classes; }
        }
        BindingNavigator IGridControlTextView.BindingNavigator
        {
            get { return this.bindingNavigator_Classes; }
        }
        Button IGridControlTextView.BtnPrePrint
        {
            get { return this.btnPrePrint; }
        }
        SimpleButton IGridControlTextView.BtnAddClass 
        {
            get { return this.sbt_AddClass; }
        }
        SimpleButton IGridControlTextView.BtnDelClass
        {
            get { return this.sbt_DelClass; }
        }
        DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit IGridControlTextView.StudentRepository 
        {
            get { return this.studentRepository; }
        }
        #endregion  Property

    }
}
