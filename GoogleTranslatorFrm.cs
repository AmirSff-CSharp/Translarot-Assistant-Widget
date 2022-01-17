// Copyright (c) 2010 Ravi Bhavnani
// License: Code Project Open License
// http://www.codeproject.com/info/cpol10.aspx

using Microsoft.Win32;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MyTranslator.GoogleTranslator
{
    /// <summary>
    /// A sample application to demonstrate the <see cref="TranslatorOld"/> class.
    /// </summary>
    public partial class GoogleTranslatorFrm : Form
    {
        #region Constructor

        ///for moving the form when dragging
        ///
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);

                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
            }

            base.WndProc(ref m);
        }


        /// <summary>
        /// for creating round edges
        /// </summary>
        /// <param name="nLeftRect"></param>
        /// <param name="nTopRect"></param>
        /// <param name="nRightRect"></param>
        /// <param name="nBottomRect"></param>
        /// <param name="nWidthEllipse"></param>
        /// <param name="nHeightEllipse"></param>
        /// <returns></returns>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );


        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleTranslatorFrm"/> class.
        /// </summary>
        public GoogleTranslatorFrm()
        {
            InitializeComponent();
            ///for round edge
            ///
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));


            ///for avoid showing in the task manager

            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;


            ///to run application on startup
            ///Create a registry key, then save your program path
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("My Translator", Application.ExecutablePath.ToString());
            //MessageBox.Show("You have been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ///setting the position of the form
            var bounds = Screen.FromControl(this).Bounds;
            bounds.X = bounds.Width - Size.Width;
            bounds.X -= 10;
            bounds.Y += 10;
            Location = bounds.Location;
        }

        //for avoid showing in the task manager
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }

        #endregion

        #region Form event handlers

        /// <summary>
        /// Handles the Load event of the GoogleTranslatorFrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GoogleTranslatorFrm_Load
                (object sender,
                 EventArgs e)
        {
            this._comboFrom.Items.AddRange(Translator.Languages.ToArray());
            this._comboTo.Items.AddRange(Translator.Languages.ToArray());
            this._comboFrom.SelectedItem = "English";
            this._comboTo.SelectedItem = "French";
        }

        #endregion

        #region Button handlers

        /// <summary>
        /// Handles the LinkClicked event of the _lnkSourceEnglish control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void _lnkSourceEnglish_LinkClicked
            (object sender,
             LinkLabelLinkClickedEventArgs e)
        {
            this._comboFrom.SelectedItem = "English";
        }

        /// <summary>
        /// Handles the LinkClicked event of the _lnkTargetEnglish control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void _lnkTargetEnglish_LinkClicked
            (object sender,
             LinkLabelLinkClickedEventArgs e)
        {
            this._comboTo.SelectedItem = "English";
        }

        /// <summary>
        /// Handles the Click event of the _btnTranslate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void _btnTranslate_Click
            (object sender,
             EventArgs e)
        {
            // Initialize the translator
            Translator t = new Translator();

            this._editTarget.Text = string.Empty;
            this._editTarget.Update();
            this._translationSpeakUrl = null;

            // Translate the text
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this._lblStatus.Text = "Translating...";
                this._lblStatus.Update();
                this._editTarget.Text = t.Translate(this._editSourceText.Text.Trim(), (string)this._comboFrom.SelectedItem, (string)this._comboTo.SelectedItem);
                if (t.Error == null)
                {
                    this._editTarget.Update();
                    this._translationSpeakUrl = t.TranslationSpeechUrl;
                }
                else
                {
                    MessageBox.Show(t.Error.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                this._lblStatus.Text = string.Format("Translated in {0} mSec", (int)t.TranslationTime.TotalMilliseconds);
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Handles the Click event of the _btnSpeak control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void _btnSpeak_Click
            (object sender,
             EventArgs e)
        {
            if (!string.IsNullOrEmpty(this._translationSpeakUrl))
            {
                this._webBrowserCtrl.Navigate(this._translationSpeakUrl);
            }
        }

        /// <summary>
        /// Handles the LinkClicked event of the _lnkReverse control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void _lnkReverse_LinkClicked
            (object sender,
             LinkLabelLinkClickedEventArgs e)
        {
            // Swap translation mode
            string from = (string)this._comboFrom.SelectedItem;
            string to = (string)this._comboTo.SelectedItem;
            this._comboFrom.SelectedItem = to;
            this._comboTo.SelectedItem = from;

            // Reset text
            this._editSourceText.Text = this._editTarget.Text;
            this._editTarget.Text = string.Empty;
            this.Update();
            this._translationSpeakUrl = string.Empty;
        }

        #endregion

        #region Fields

        /// <summary>
        /// The URL used to speak the translation.
        /// </summary>
        private string _translationSpeakUrl;

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            Opacity=TopMost ? 1 : 0.9;
        }


        private void GoogleTranslatorFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            //// Display a MsgBox asking the user if he is sure to close
            //if (MessageBox.Show("Are you sure you want to close?", "My Application", MessageBoxButtons.YesNo)
            //   == DialogResult.Yes)
            //{
            //    // Cancel the Closing event from closing the form.
            //    e.Cancel = false;
            //    // e.Cancel = true would close the window
            //}
        }

        private void GoogleTranslatorFrm_MouseDown(object sender, MouseEventArgs e)
        {

        }

    }
}
