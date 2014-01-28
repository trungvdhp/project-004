using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public class Notify
    {
        public static class InforNotifyHelper
        {
            public static string InsertErrorText = "Thêm dữ liệu không thành công";
            public static string UpdateErrorText = "Cập nhật dữ liệu không thành công";
            public static string DeleteErrorText = "Xóa dữ liệu không thành công";
            public static string PrintErrorText = "Không thể in dữ liệu";

            public static string DeleteConfirmText = "Bạn có chắc chắn muốn xóa dữ liệu này?";
            
            public static string InsertErrorCaption = "Lỗi thêm dữ liệu";
            public static string UpdateErrorCaption = "Lỗi cập nhật dữ liệu";
            public static string DeleteErrorCaption = "Lỗi xóa dữ liệu";
            public static string PringErrorCaption = "Lỗi in dữ liệu";

            public static string DeleteConfirmCaption = "Xác nhận xóa dữ liệu";

            public static string NotGreaterThanZero = "Dữ liệu phải lớn hơn 0";
            public static string Duplicated = "Dữ liệu bị lặp lại";
            public static string NullOrEmpty = "Không được để trống";
            public static string InvalidDate = "Ngày tháng không hợp lệ";

            public static string UpdateSuccessText = "Cập nhật dữ liệu thành công";
            public static string InsertSuccessText = "Thêm dữ liệu thành công";
            public static string DeleteSuccessText = "Xóa dữ liệu thành công";
            public static string UpdateWarningText = "Không có thay đổi nào được cập nhật";

            public static string InsertSuccessCaption = "Thêm thành công";
            public static string UpdateSuccessCaption = "Cập nhật thành công";
            public static string DeleteSuccessCaption = "Xóa thành công";

            public static string UpdateWarningCaption = "Cảnh báo cập nhật dữ liệu";
        }

        public static DialogResult ShowInsertError()
        {
            return XtraMessageBox.Show(InforNotifyHelper.InsertErrorText, InforNotifyHelper.InsertErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowInsertError(string error)
        {
            return XtraMessageBox.Show(error, InforNotifyHelper.InsertErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowInsertSuccess()
        {
            return XtraMessageBox.Show(InforNotifyHelper.InsertSuccessText, InforNotifyHelper.InsertSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowInsertSuccess(string info)
        {
            return XtraMessageBox.Show(info, InforNotifyHelper.InsertSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowUpdateError()
        {
            return XtraMessageBox.Show(InforNotifyHelper.UpdateErrorText, InforNotifyHelper.UpdateErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowUpdateError(string error)
        {
            return XtraMessageBox.Show(error, InforNotifyHelper.UpdateErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public static DialogResult ShowUpdateWarning()
        {
            return XtraMessageBox.Show(InforNotifyHelper.UpdateWarningText, InforNotifyHelper.UpdateWarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowUpdateWarning(string warning)
        {
            return XtraMessageBox.Show(warning, InforNotifyHelper.UpdateErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public static DialogResult ShowUpdateSuccess()
        {
            return XtraMessageBox.Show(InforNotifyHelper.UpdateSuccessText, InforNotifyHelper.UpdateSuccessCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowUpdateSuccess(string success)
        {
            return XtraMessageBox.Show(success, InforNotifyHelper.UpdateErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static DialogResult ShowDeleteError()
        {
            return XtraMessageBox.Show(InforNotifyHelper.DeleteErrorText, InforNotifyHelper.DeleteErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowDeleteError(string error)
        {
            return XtraMessageBox.Show(error, InforNotifyHelper.DeleteErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowDeleteConfirm()
        {
            return XtraMessageBox.Show(InforNotifyHelper.DeleteConfirmText, InforNotifyHelper.DeleteErrorCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult ShowDeleteConfirm(string question)
        {
            return XtraMessageBox.Show(question, InforNotifyHelper.DeleteErrorCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult ShowPrintError()
        {
            return XtraMessageBox.Show(InforNotifyHelper.PrintErrorText, InforNotifyHelper.PringErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowPrintError(string error)
        {
            return XtraMessageBox.Show(error, InforNotifyHelper.PringErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowError(string error, string caption)
        {
            return XtraMessageBox.Show(error, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowInfo(string info, string caption)
        {
            return XtraMessageBox.Show(info, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowWarning(string warning, string caption)
        {
            return XtraMessageBox.Show(warning, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
