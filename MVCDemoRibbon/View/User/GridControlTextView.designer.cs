namespace MVCDemoRibbon.View.User
{
    partial class GridControlTextView
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridControlTextView));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdSorc_Classes = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_Classes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClassIdx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonitor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.studentRepository = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.bdSorc_Students = new System.Windows.Forms.BindingSource(this.components);
            this.studentRepositoryView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStudentCnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExaminationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.bindingNavigator_Classes = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnPrePrint = new System.Windows.Forms.Button();
            this.sbt_AddClass = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_DelClass = new DevExpress.XtraEditors.SimpleButton();
            this.panelControlBottom = new DevExpress.XtraEditors.PanelControl();
            this.panelControlTop = new DevExpress.XtraEditors.PanelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSorc_Classes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Classes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSorc_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRepositoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Classes)).BeginInit();
            this.bindingNavigator_Classes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).BeginInit();
            this.panelControlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).BeginInit();
            this.panelControlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdSorc_Classes;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView_Classes;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTimeEdit1,
            this.studentRepository});
            this.gridControl1.Size = new System.Drawing.Size(893, 651);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Classes});
            // 
            // bdSorc_Classes
            // 
            this.bdSorc_Classes.AllowNew = true;
            // 
            // gridView_Classes
            // 
            this.gridView_Classes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrade,
            this.colClassIdx,
            this.colMonitor,
            this.colStudentCnt,
            this.colExaminationDate});
            this.gridView_Classes.GridControl = this.gridControl1;
            this.gridView_Classes.Name = "gridView_Classes";
            // 
            // colGrade
            // 
            this.colGrade.AppearanceCell.Options.UseTextOptions = true;
            this.colGrade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrade.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrade.Caption = "年级";
            this.colGrade.FieldName = "Grade";
            this.colGrade.Name = "colGrade";
            this.colGrade.Visible = true;
            this.colGrade.VisibleIndex = 4;
            this.colGrade.Width = 89;
            // 
            // colClassIdx
            // 
            this.colClassIdx.AppearanceCell.Options.UseTextOptions = true;
            this.colClassIdx.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClassIdx.AppearanceHeader.Options.UseTextOptions = true;
            this.colClassIdx.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClassIdx.Caption = "班级";
            this.colClassIdx.FieldName = "ClassIdx";
            this.colClassIdx.Name = "colClassIdx";
            this.colClassIdx.Visible = true;
            this.colClassIdx.VisibleIndex = 0;
            this.colClassIdx.Width = 89;
            // 
            // colMonitor
            // 
            this.colMonitor.AppearanceCell.Options.UseTextOptions = true;
            this.colMonitor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonitor.AppearanceHeader.Options.UseTextOptions = true;
            this.colMonitor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonitor.Caption = "班长";
            this.colMonitor.ColumnEdit = this.studentRepository;
            this.colMonitor.FieldName = "Monitor.Name";
            this.colMonitor.Name = "colMonitor";
            this.colMonitor.OptionsFilter.AllowFilter = false;
            this.colMonitor.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.colMonitor.Visible = true;
            this.colMonitor.VisibleIndex = 1;
            // 
            // studentRepository
            // 
            this.studentRepository.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.studentRepository.DataSource = this.bdSorc_Students;
            this.studentRepository.DisplayMember = "Name";
            this.studentRepository.Name = "studentRepository";
            this.studentRepository.View = this.studentRepositoryView;
            // 
            // bdSorc_Students
            // 
            //this.bdSorc_Students.DataSource = typeof(MVCDemoRibbon.Database.Data.Student);
            // 
            // studentRepositoryView
            // 
            this.studentRepositoryView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.studentRepositoryView.Name = "studentRepositoryView";
            this.studentRepositoryView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.studentRepositoryView.OptionsView.ShowGroupPanel = false;
            // 
            // colStudentCnt
            // 
            this.colStudentCnt.AppearanceCell.Options.UseTextOptions = true;
            this.colStudentCnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStudentCnt.AppearanceHeader.Options.UseTextOptions = true;
            this.colStudentCnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStudentCnt.Caption = "学生总数";
            this.colStudentCnt.FieldName = "StudentCnt";
            this.colStudentCnt.Name = "colStudentCnt";
            this.colStudentCnt.Visible = true;
            this.colStudentCnt.VisibleIndex = 2;
            this.colStudentCnt.Width = 133;
            // 
            // colExaminationDate
            // 
            this.colExaminationDate.AppearanceCell.Options.UseTextOptions = true;
            this.colExaminationDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExaminationDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colExaminationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExaminationDate.Caption = "考试日期";
            this.colExaminationDate.ColumnEdit = this.repositoryItemTimeEdit1;
            this.colExaminationDate.DisplayFormat.FormatString = "F";
            this.colExaminationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colExaminationDate.FieldName = "ExaminationDateTime";
            this.colExaminationDate.Name = "colExaminationDate";
            this.colExaminationDate.Visible = true;
            this.colExaminationDate.VisibleIndex = 3;
            this.colExaminationDate.Width = 214;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.DisplayFormat.FormatString = "F";
            this.repositoryItemTimeEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTimeEdit1.EditFormat.FormatString = "F";
            this.repositoryItemTimeEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTimeEdit1.Mask.EditMask = "F";
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // bindingNavigator_Classes
            // 
            this.bindingNavigator_Classes.AddNewItem = null;
            this.bindingNavigator_Classes.BindingSource = this.bdSorc_Classes;
            this.bindingNavigator_Classes.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator_Classes.DeleteItem = null;
            this.bindingNavigator_Classes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigator_Classes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.bindingNavigator_Classes.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator_Classes.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator_Classes.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator_Classes.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator_Classes.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator_Classes.Name = "bindingNavigator_Classes";
            this.bindingNavigator_Classes.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator_Classes.Size = new System.Drawing.Size(1156, 37);
            this.bindingNavigator_Classes.TabIndex = 1;
            this.bindingNavigator_Classes.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 34);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 34);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 34);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 34);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 34);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 34);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // btnPrePrint
            // 
            this.btnPrePrint.Location = new System.Drawing.Point(888, 5);
            this.btnPrePrint.Name = "btnPrePrint";
            this.btnPrePrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrePrint.TabIndex = 2;
            this.btnPrePrint.Text = "打印预览";
            this.btnPrePrint.UseVisualStyleBackColor = true;
            // 
            // sbt_AddClass
            // 
            this.sbt_AddClass.Location = new System.Drawing.Point(460, 5);
            this.sbt_AddClass.Name = "sbt_AddClass";
            this.sbt_AddClass.Size = new System.Drawing.Size(75, 23);
            this.sbt_AddClass.TabIndex = 3;
            this.sbt_AddClass.Text = "添加班级";
            // 
            // sbt_DelClass
            // 
            this.sbt_DelClass.Location = new System.Drawing.Point(653, 5);
            this.sbt_DelClass.Name = "sbt_DelClass";
            this.sbt_DelClass.Size = new System.Drawing.Size(75, 23);
            this.sbt_DelClass.TabIndex = 4;
            this.sbt_DelClass.Text = "删除班级";
            // 
            // panelControlBottom
            // 
            this.panelControlBottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlBottom.Controls.Add(this.sbt_AddClass);
            this.panelControlBottom.Controls.Add(this.btnPrePrint);
            this.panelControlBottom.Controls.Add(this.sbt_DelClass);
            this.panelControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlBottom.Location = new System.Drawing.Point(0, 688);
            this.panelControlBottom.Name = "panelControlBottom";
            this.panelControlBottom.Size = new System.Drawing.Size(1156, 33);
            this.panelControlBottom.TabIndex = 5;
            // 
            // panelControlTop
            // 
            this.panelControlTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlTop.Controls.Add(this.bindingNavigator_Classes);
            this.panelControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTop.Location = new System.Drawing.Point(0, 0);
            this.panelControlTop.Name = "panelControlTop";
            this.panelControlTop.Size = new System.Drawing.Size(1156, 37);
            this.panelControlTop.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 37);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1156, 651);
            this.splitContainerControl1.SplitterPosition = 893;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(258, 651);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            // 
            // GridControlTextView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 721);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControlTop);
            this.Controls.Add(this.panelControlBottom);
            this.Name = "GridControlTextView";
            this.Text = "GridControl测试";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSorc_Classes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Classes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSorc_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRepositoryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Classes)).EndInit();
            this.bindingNavigator_Classes.ResumeLayout(false);
            this.bindingNavigator_Classes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).EndInit();
            this.panelControlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).EndInit();
            this.panelControlTop.ResumeLayout(false);
            this.panelControlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Classes;
        private System.Windows.Forms.BindingSource bdSorc_Classes;
        private DevExpress.XtraGrid.Columns.GridColumn colGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colClassIdx;
        private DevExpress.XtraGrid.Columns.GridColumn colStudentCnt;
        private DevExpress.XtraGrid.Columns.GridColumn colExaminationDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private System.Windows.Forms.BindingNavigator bindingNavigator_Classes;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colMonitor;
        private System.Windows.Forms.BindingSource bdSorc_Students;
        private System.Windows.Forms.Button btnPrePrint;
        private DevExpress.XtraEditors.SimpleButton sbt_AddClass;
        private DevExpress.XtraGrid.Views.Grid.GridView studentRepositoryView;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit studentRepository;
        private DevExpress.XtraEditors.SimpleButton sbt_DelClass;
        private DevExpress.XtraEditors.PanelControl panelControlBottom;
        private DevExpress.XtraEditors.PanelControl panelControlTop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

