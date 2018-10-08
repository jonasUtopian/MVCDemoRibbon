using MVCDemoRibbon.Broker.View.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCDemoRibbon.View.User
{
    public partial class RecordGridView : BaseCtrl, IRecordGridView
    {
        public RecordGridView()
        {
            InitializeComponent();
        }

        DevExpress.XtraGrid.Views.Grid.GridView IRecordGridView.GridViewRecords 
        {
            get { return this.gridViewRecords; }
        }
        System.Windows.Forms.BindingNavigator IRecordGridView.BindingNavigator 
        {
            get { return this.bindingNavigator1; }
        }
        System.Windows.Forms.BindingSource IRecordGridView.BindingSourceRecord 
        {
            get { return this.bindingSourceRecord; } 
        }
        DevExpress.XtraGrid.Columns.GridColumn IRecordGridView.ColTime 
        {
            get { return this.colTime; } 
        }
        DevExpress.XtraGrid.Columns.GridColumn IRecordGridView.GetColChannel(int index)
        {
            switch (index)
            {
                case 0:
                    return this.colChannel1;
                case 1:
                    return this.colChannel2;
                case 2:
                    return this.colChannel3;
                case 3:
                    return this.colChannel4;
                case 4:
                    return this.colChannel5;
                case 5:
                    return this.colChannel6;
                case 6:
                    return this.colChannel7;
                case 7:
                    return this.colChannel8;
                case 8:
                    return this.colChannel9;
                case 9:
                    return this.colChannel10;
                case 10:
                    return this.colChannel11;
                case 11:
                    return this.colChannel12;
                case 12:
                    return this.colChannel13;
                case 13:
                    return this.colChannel14;
                case 14:
                    return this.colChannel15;
                case 15:
                    return this.colChannel16;
                case 16:
                    return this.colChannel17;
                case 17:
                    return this.colChannel18;
                case 18:
                    return this.colChannel19;
                case 19:
                    return this.colChannel20;
                case 20:
                    return this.colChannel21;
                case 21:
                    return this.colChannel22;
                case 22:
                    return this.colChannel23;
                case 23:
                    return this.colChannel24;
                case 24:
                    return this.colChannel25;
                case 25:
                    return this.colChannel26;
                case 26:
                    return this.colChannel27;
                case 27:
                    return this.colChannel28;
                case 28:
                    return this.colChannel29;
                case 29:
                    return this.colChannel30;
                case 30:
                    return this.colChannel31;
                case 31:
                    return this.colChannel32;
                default:
                    return null;
            }
        }
    }
}
