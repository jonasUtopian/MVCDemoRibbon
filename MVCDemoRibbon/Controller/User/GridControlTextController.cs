using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCDemoRibbon.Broker.Control;
using MVCDemoRibbon.Broker.Control.User;
using MVCDemoRibbon.Broker.View.User;
using MVCDemoRibbon.View;
using Jonas.Common;
using MVCDemoRibbon.Model.Extra;

namespace MVCDemoRibbon.Controller.User
{
    class GridControlTextController : ACtrlController, IGridControlTextController
    {
        #region  Method

        public GridControlTextController(IMdiRibbonController mdiNavigateController, Logger logger, UserEventArgs userEventArgs)
            : base(mdiNavigateController, logger, userEventArgs)
        {
            this.ViewName = "GridControlTextView";
            Initialize();
        }

        /// <summary>
        /// Initialize the view to be shown
        /// </summary>
        private void Initialize()
        {
            try
            {
                this.m_view = base.CreateView() as IGridControlTextView;
                using (DevExpress.Utils.WaitDialogForm dlg = new DevExpress.Utils.WaitDialogForm("请稍等", "正在登录中...",
                new System.Drawing.Size(200, 50),
                null))
                {
                    SetGridStyle(this.m_view.GridView);
                    InitData();
                    InitializeRepository();

                    m_view.BtnPrePrint.Click += BtnPrePrint_Click;
                    m_view.BtnAddClass.Click += BtnAddClass_Click;
                    m_view.BtnDelClass.Click += BtnDelClass_Click;
                    m_view.StudentsBindingSource.PositionChanged += StudentsBindingSource_PositionChanged;
                    m_view.ClassesBindingSource.PositionChanged += ClassesBindingSource_PositionChanged;
                    m_view.StudentRepository.Click += StudentRepository_Click;
                    m_view.ClassesBindingSource.Position = 0;
                }          
            }
            catch (Exception)
            {
                throw;
            }
        }

        void StudentsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Class classObj = this.m_view.ClassesBindingSource.Current as Class;
            if (null != classObj)
            {
                classObj.Monitor = m_view.StudentsBindingSource.Current as Student;
                m_view.StudentsBindingSource.DataSource = classObj.Students;
            }
        }

        void ClassesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Class classObj = m_view.ClassesBindingSource.Current as Class;
            if (null != classObj)
            {
                m_view.StudentsBindingSource.DataSource = classObj.Students;
                m_view.StudentsBindingSource.Position = 0;
            }
        }

        void StudentRepository_Click(object sender, EventArgs e)
        {
            Class classObj = this.m_view.ClassesBindingSource.Current as Class;
            if (null != classObj)
            {
                classObj.Monitor = m_view.StudentsBindingSource.Current as Student;
                m_view.StudentsBindingSource.DataSource = classObj.Students;
            }
        }

        void BtnDelClass_Click(object sender, EventArgs e)
        {
            Class classObj = this.m_view.ClassesBindingSource.Current as Class;
            if (null != classObj)
            {
                this.m_view.ClassesBindingSource.RemoveCurrent();
                this.m_view.ClassesBindingSource.CurrencyManager.Refresh();
            }
        }

        void BtnAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                Random ran = new Random();
                Class newClass = new Class()
                {
                    Grade = ran.Next(1, 9),
                    ClassIdx = ran.Next(1, 20),
                    Students = new List<Student>()
                };

                List<Student> studentObjs = new List<Student>();
                for (int i = 0; i < 10; i++)
                {
                    int code = ran.Next(1, 100);
                    Student student = new Student()
                    {
                        Name = string.Format("学生{0}", i),
                        Age = 22,
                        Code = code,
                        Grade = newClass.Grade,
                        ClassIdx = newClass.ClassIdx
                    };
                    studentObjs.Add(student);
                }
                newClass.Students.AddRange(studentObjs.ToArray());

                this.m_view.ClassesBindingSource.Add(newClass);

                this.m_view.ClassesBindingSource.CurrencyManager.Refresh();     
            }
            catch (Exception ex)
            {
                base.Logger.Error(ex.Message);
            }    
        }

        private void BtnPrePrint_Click(object sender, EventArgs e)
        {
            if (null != m_view.ClassesBindingSource.DataSource)
            {
                View.Report.ClassReport report = FactoryReport.GetReport("ClassReport") as View.Report.ClassReport;
                report.SetBindingDataSource(m_view.ClassesBindingSource.DataSource);
                report.ShowPreview();
            } 
        }

        protected Color SelectedRowBackColor
        {
            //get{return Color.FromArgb(55, 105, 135);}
            get { return Color.LightBlue; }
        }
        /// <summary>
        /// Grid样式设定
        /// </summary>
        protected virtual void SetGridStyle(DevExpress.XtraGrid.Views.Grid.GridView grdView)
        {
            grdView.OptionsView.ShowFooter = false;
            grdView.OptionsView.ShowGroupPanel = false;
            grdView.OptionsView.ShowViewCaption = false;
            grdView.OptionsView.EnableAppearanceOddRow = false;
            grdView.OptionsView.EnableAppearanceEvenRow = false;
            grdView.OptionsView.ShowIndicator = false;
            grdView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;//垂直分割线
            grdView.OptionsView.ShowColumnHeaders = true;//显示列头

            grdView.OptionsCustomization.AllowColumnMoving = false;
            grdView.OptionsCustomization.AllowFilter = false;
            grdView.OptionsCustomization.AllowGroup = false;
            grdView.OptionsCustomization.AllowQuickHideColumns = false;
            grdView.OptionsCustomization.AllowSort = false;
            grdView.OptionsCustomization.AllowColumnResizing = false;

            grdView.OptionsBehavior.Editable = true;//可编辑
            grdView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;//鼠标按下进入编辑
            grdView.OptionsSelection.MultiSelect = false;//选择多行

            grdView.OptionsMenu.EnableColumnMenu = false;
            grdView.OptionsMenu.EnableFooterMenu = false;
            grdView.OptionsMenu.EnableGroupPanelMenu = false;
            grdView.OptionsMenu.ShowAutoFilterRowItem = false;
            grdView.OptionsMenu.ShowConditionalFormattingItem = true;
            grdView.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            grdView.OptionsMenu.ShowGroupSortSummaryItems = false;
            grdView.OptionsMenu.ShowGroupSummaryEditorItem = true;
            grdView.OptionsMenu.ShowSplitItem = false;

            grdView.OptionsSelection.EnableAppearanceFocusedCell = true;
            grdView.OptionsSelection.EnableAppearanceFocusedRow = false;

            grdView.OptionsFilter.AllowColumnMRUFilterList = false;
            grdView.OptionsFilter.AllowFilterEditor = false;
            grdView.OptionsFilter.AllowFilterIncrementalSearch = false;
            grdView.OptionsFilter.AllowMRUFilterList = false;
            grdView.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            grdView.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;

            grdView.DetailHeight = 1000;
            grdView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus;
            grdView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;//垂直滚动条
            grdView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;//水平滚动条
            grdView.ColumnPanelRowHeight = 46;
            grdView.RowHeight = 36;
            grdView.RowCellStyle += grdView_RowCellStyle;

            foreach (DevExpress.XtraGrid.Columns.GridColumn item in grdView.Columns)
            {
                item.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
                item.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
                item.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                item.AppearanceHeader.Options.UseFont = true;
                item.AppearanceHeader.Options.UseTextOptions = true;

                item.AppearanceCell.Options.UseTextOptions = true;
                item.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            } 
        }
        protected void grdView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle == ((DevExpress.XtraGrid.Views.Grid.GridView)sender).FocusedRowHandle)
            {
                e.Appearance.BackColor = SelectedRowBackColor;
            }
        }
        private void InitData()
        {
            Random ran = new Random();
            List<Class> classObjs = new List<Class>();
            List<Student> studentObjs = new List<Student>();

            int temp = 1;
            foreach (var item in classObjs)
            {
                int studentcnt = ran.Next(10, 20);
                studentObjs = new List<Student>();
                for (int i = 0; i < studentcnt; i++)
                {
                    int code = ran.Next(1, 100);
                    Student student = new Student()
                    {
                        Name = string.Format("学生{0}_{1}", temp, code),
                        Age = 22,
                        Code = code,
                        Grade = item.Grade,
                        ClassIdx = item.ClassIdx
                    };
                    studentObjs.Add(student);
                }
                temp++;

                item.Students = new List<Student>();
                item.Students.AddRange(studentObjs.ToArray());
            }

            m_view.StudentsBindingSource.DataSource = studentObjs;
            m_view.ClassesBindingSource.DataSource = classObjs;
        }

        private void InitializeRepository()
        {
            this.m_view.StudentRepository.DisplayMember = "Name";
            this.m_view.StudentRepository.ValueMember = "Name";
            this.m_view.StudentRepository.PopulateViewColumns();
            this.m_view.StudentRepository.ShowAddNewButton = false;
            this.m_view.StudentRepository.ShowClearButton = false;

            this.m_view.StudentRepository.View.Columns["Name"].Visible = true;
            this.m_view.StudentRepository.View.Columns["Age"].Visible = true;
            this.m_view.StudentRepository.View.Columns["Code"].Visible = true;
            this.m_view.StudentRepository.View.Columns["Name"].Caption = "姓名";
            this.m_view.StudentRepository.View.Columns["Age"].Caption = "年龄";
            this.m_view.StudentRepository.View.Columns["Code"].Caption = "学号";
            this.m_view.StudentRepository.View.OptionsView.ShowGroupPanel = false;
            this.m_view.StudentRepository.View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.m_view.StudentRepository.View.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.m_view.StudentRepository.View.BestFitColumns();

            this.m_view.StudentRepository.AddNewValue += StudentRepository_AddNewValue;
            this.m_view.StudentRepository.EditValueChanged += StudentRepository_EditValueChanged;
        }

        void StudentRepository_EditValueChanged(object sender, EventArgs e)
        {
            Class classObj = m_view.ClassesBindingSource.Current as Class;
            if (null != classObj)
            {
                classObj.Monitor = m_view.StudentsBindingSource.Current as Student;
                this.m_view.ClassesBindingSource.CurrencyManager.Refresh();
            }
        }

        void StudentRepository_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion  Method

        #region  Property   属性
        IGridControlTextView IGridControlTextController.GridControlTextView 
        {
            get { return this.m_view; }
        }

        #endregion  Property

        #region  Filed

        /// <summary>
        /// the view
        /// </summary>
        private IGridControlTextView m_view;

        #endregion  Filed
    }
}
