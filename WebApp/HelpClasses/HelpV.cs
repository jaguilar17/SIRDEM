using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.HelpClasses
{
    public static class HelpV
    {
        public static string GetRowFooterHiddenField(GridView gv, String ElementId)
        {
            return Convert.ToString(((HiddenField)gv.FooterRow.FindControl(ElementId)).Value);
        }
        public static DateTime GetRowFooterHiddenFieldDate(GridView gv, String ElementId)
        {
            return Convert.ToDateTime(((HiddenField)gv.FooterRow.FindControl(ElementId)).Value);
        }
        public static string GetRowFooterLabelText(GridView gv, String ElementId)
        {
            return Convert.ToString(((Label)gv.FooterRow.FindControl(ElementId)).Text);
        }
        public static Int32 GetRowFooterLabelTextInt(GridView gv, String ElementId)
        {
            return Convert.ToInt32(((Label)gv.FooterRow.FindControl(ElementId)).Text);
        }
        public static string GetRowFooterTextBoxText(GridView gv, String ElementId)
        {
            return Convert.ToString(((TextBox)gv.FooterRow.FindControl(ElementId)).Text).Trim();
        }
        public static bool GetRowFooterCheckBoxChecked(GridView gv, String ElementId)
        {
            return Convert.ToBoolean(((CheckBox)gv.FooterRow.FindControl(ElementId)).Checked);
        }
        public static string GetRowFooterDdlValue(GridView gv, String ElementId)
        {
            return Convert.ToString(((DropDownList)gv.FooterRow.FindControl(ElementId)).SelectedValue);
        }
        public static string GetRowFooterDdlText(GridView gv, String ElementId)
        {
            return Convert.ToString(((DropDownList)gv.FooterRow.FindControl(ElementId)).SelectedItem.Text);
        }
        public static Int32 GetRowFooterTextBoxTextInt(GridView gv, String ElementId)
        {
            return Convert.ToInt32(((TextBox)gv.FooterRow.FindControl(ElementId)).Text);
        }
        public static FileUpload GetRowFooterFileUpload(GridView gv, String ElementId)
        {
            return ((FileUpload)(gv.FooterRow.FindControl(ElementId)));
        }

        //--------------------------------------------------------------------------------------
        public static string GetRowLabelText(GridView gv, String ElementId)
        {
            return Convert.ToString(((Label)gv.Rows[gv.EditIndex].FindControl(ElementId)).Text);
        }
        public static Int32 GetRowLabelTextInt(GridView gv, String ElementId)
        {
            return Convert.ToInt32(((Label)gv.Rows[gv.EditIndex].FindControl(ElementId)).Text.Trim());
        }
        public static string GetRowTextBoxText(GridView gv, String ElementId)
        {
            return Convert.ToString(((TextBox)gv.Rows[gv.EditIndex].FindControl(ElementId)).Text).Trim();
        }

        public static bool GetRowCheckBoxChecked(GridView gv, String ElementId)
        {
            return Convert.ToBoolean(((CheckBox)gv.Rows[gv.EditIndex].FindControl(ElementId)).Checked);
        }
        public static string GetRowDdlValue(GridView gv, String ElementId)
        {
            return Convert.ToString(((DropDownList)gv.Rows[gv.EditIndex].FindControl(ElementId)).SelectedValue);
        }
        public static string GetRowDdlValueText(GridView gv, String ElementId)
        {
            return Convert.ToString(((DropDownList)gv.Rows[gv.EditIndex].FindControl(ElementId)).SelectedItem.Text);
        }
        public static String GetRowEditHiddenValueString(GridView gv, String ElementId)
        {
            return ((HiddenField)gv.Rows[gv.EditIndex].FindControl(ElementId)).Value.Trim();
        }
        public static Int32 GetRowEditHiddenValueInt(GridView gv, String ElementId)
        {
            return Convert.ToInt32(((HiddenField)gv.Rows[gv.EditIndex].FindControl(ElementId)).Value.Trim());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="HiddenElementID"></param>
        /// <returns></returns>
        public static String GetRowItemLabelText(GridViewCommandEventArgs e, String HiddenElementID)
        {
            return ((Label)((GridViewRow)(((Control)e.CommandSource).NamingContainer)).FindControl(HiddenElementID)).Text;
        }
        public static String GetRowHiddenValue(GridViewCommandEventArgs e, String HiddenElementID)
        {
            return ((HiddenField)((GridViewRow)(((Control)e.CommandSource).NamingContainer)).FindControl(HiddenElementID)).Value;
        }
        public static String GetRowHiddenValue(GridView gv, GridViewDeleteEventArgs e, String HiddenElementID)
        {
            return ((HiddenField)gv.Rows[e.RowIndex].FindControl(HiddenElementID)).Value.Trim();
        }
        public static String GetRowTextBoxText(GridViewCommandEventArgs e, String ElementId)
        {
            return ((TextBox)((GridViewRow)(((Control)e.CommandSource).NamingContainer)).FindControl(ElementId)).Text;
        }
        public static FileUpload GetRowFileUpload(GridViewCommandEventArgs e, String ElementId)
        {
            return ((FileUpload)((GridViewRow)(((Control)e.CommandSource).NamingContainer)).FindControl(ElementId));
        }

        public static Int32 GetRowHiddenValueInt(GridViewCommandEventArgs e, String HiddenElementID)
        {
            return Convert.ToInt32(((HiddenField)((GridViewRow)(((Control)e.CommandSource).NamingContainer)).FindControl(HiddenElementID)).Value);
        }
        public static void RowEditing(object sender, GridViewEditEventArgs e)
        {
            var gv = (GridView)sender;
            gv.EditIndex = e.NewEditIndex;
        }
        public static void RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            var gv = (GridView)sender;
            //e.Cancel = true;
            gv.EditIndex = -1;
        }
        public static void PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView gv = (GridView)sender;
            gv.PageIndex = e.NewPageIndex;
        }

        //----------------------------------------------------------------------------------

        public const string MailUser = "no-reply";
        public const string MailSender = "no-reply@lcperu.pe"; //Cambiar a otro. 
        public const string MailPassword = "39x3.6x0r";
        public const string MailSMTP = "correo.lcperu.pe";
        public static void SendMailToOne(String mail, String EmailBody, String asunto)
        {
            try
            {
                var msg = new MailMessage();
                msg.From = new MailAddress(MailSender, "LCPeru");
                msg.To.Add(mail);
                msg.Subject = asunto;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.High;
                var client = new SmtpClient(MailSMTP);
                client.UseDefaultCredentials = false;
                client.Port = 25;
                client.Credentials = new NetworkCredential(MailUser, MailPassword);
                msg.Body = EmailBody;
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(msg.Body, null, "text/html");
                msg.AlternateViews.Add(htmlView);
                client.Send(msg);
            }
            catch (Exception ex)
            {
                SendErrorMail("lvizcarra@lcperu.pe", "error envio de mail", ex.Message + ex.StackTrace);
            }
        }
        public static void SendMailToOneCC(String mail, String EmailBody, String asunto, List<String> mailCC)
        {
            try
            {
                var msg = new MailMessage();
                msg.From = new MailAddress(MailSender, "LCPeru");
                msg.To.Add(mail);
                msg.Subject = asunto;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.High;
                foreach (String cc in mailCC)
                {
                    msg.CC.Add(new MailAddress(cc));
                }
                var client = new SmtpClient(MailSMTP);
                client.UseDefaultCredentials = false;
                client.Port = 25;
                client.Credentials = new NetworkCredential(MailUser, MailPassword);
                msg.Body = EmailBody;
                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(msg.Body, null, "text/html");
                msg.AlternateViews.Add(htmlView);
                client.Send(msg);
            }
            catch (Exception ex)
            {
                SendErrorMail("lvizcarra@lcperu.pe", "error envio de mail", ex.Message + ex.StackTrace);
            }
        }
        public static bool SendErrorMail(String mail, String Error, String BodyMessage)
        {
            string Asunto = Error;
            var msg = new MailMessage(MailSender, mail, Asunto, BodyMessage);
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.High;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess | DeliveryNotificationOptions.OnFailure | DeliveryNotificationOptions.Delay;
            var client = new SmtpClient(MailSMTP);
            //client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Port = 25;
            client.Credentials = new NetworkCredential(MailUser, MailPassword);
            msg.Body = BodyMessage;
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(msg.Body, null, "text/html");
            msg.AlternateViews.Add(htmlView);
            client.Send(msg);
            try
            {
                client.Send(msg);
                return true;
            }
            catch { return false; }
        }
        public static String FileContentType(String FileName)
        {
            String ContentType = String.Empty;
            switch (FileName.Substring(FileName.LastIndexOf(".") + 1).Trim().ToLower())
            {
                case "pdf":
                    ContentType = "application/pdf"; break;
                case "png":
                case "jpg":
                case "jpeg":
                case "gif":
                    ContentType = "image/" + FileName.Substring(FileName.LastIndexOf(".") + 1).Trim().ToLower();
                    break;
                case "ico":
                    ContentType = "image/vnd.microsoft.icon"; break;

                case "zip":
                case "rar":
                case "7zp":
                    ContentType = "application/" + FileName.Substring(FileName.LastIndexOf(".") + 1).Trim().ToLower(); break;
                #region Office
                case "xls":
                case "xlsx":
                    ContentType = "application/vnd.ms-excel"; break;
                case "doc":
                case "docx":
                    ContentType = "application/vnd.ms-word"; break;
                case "ppt":
                case "pptx":
                    ContentType = "application/vnd.ms-powerpoint"; break;
                #endregion
                default: ContentType = "application/octet-stream"; break;
            }
            return ContentType;
        }

    }
}