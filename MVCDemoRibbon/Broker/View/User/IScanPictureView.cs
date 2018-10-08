using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.View.User
{
    interface IScanPictureView : ICtrlView
    {
        DevExpress.XtraEditors.TextEdit Txt_SN { get; }
        //System.Windows.Forms.PictureBox PictureBox_ScannedPicture { get; }
        DevExpress.XtraEditors.LabelControl LabelCtrl_Light { get; }
        DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit_Source { get; }
        DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit_ImageType { get; }
        DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit_Dpi { get; }
        DevExpress.XtraEditors.TextEdit Txt_Left { get; }
        DevExpress.XtraEditors.TextEdit Txt_Right { get; }
        DevExpress.XtraEditors.TextEdit Txt_Top { get; }
        DevExpress.XtraEditors.TextEdit Txt_Bottom { get; }
        DevExpress.XtraEditors.TextEdit Txt_ImageIndex { get; }
        DevExpress.XtraEditors.TextEdit Txt_ProductName { get; }
        DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit_FileType { get; }
        DevExpress.XtraEditors.ComboBoxEdit ComboBoxEdit_Rote { get; }
        DevExpress.XtraEditors.TextEdit Txt_Path { get; }
        DevExpress.XtraEditors.TextEdit Txt_FileName { get; }
        DevExpress.XtraEditors.TextEdit Txt_ImageQuaility { get; }
        DevExpress.XtraEditors.TextEdit Txt_PassWord { get; }
        DevExpress.XtraEditors.SimpleButton Btn_EnConnect { get; }
        DevExpress.XtraEditors.SimpleButton Btn_EnDisconnect { get; }
        DevExpress.XtraEditors.SimpleButton Btn_SetScanner { get; }
        DevExpress.XtraEditors.SimpleButton Btn_GetSN { get; }
        DevExpress.XtraEditors.SimpleButton Btn_Scan { get; }
        DevExpress.XtraEditors.SimpleButton Btn_LoadFile { get; }
        DevExpress.XtraEditors.SimpleButton Btn_FreeImage { get; }
        DevExpress.XtraEditors.SimpleButton Btn_Save { get; }
        DevExpress.XtraEditors.SimpleButton Btn_SelectPath { get; }
    }
}
