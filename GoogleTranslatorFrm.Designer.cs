namespace MyTranslator.GoogleTranslator
{
    partial class GoogleTranslatorFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleTranslatorFrm));
            this.label1 = new System.Windows.Forms.Label();
            this._comboFrom = new System.Windows.Forms.ComboBox();
            this._comboTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._editSourceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._editTarget = new System.Windows.Forms.TextBox();
            this._btnTranslate = new System.Windows.Forms.Button();
            this._lblStatus = new System.Windows.Forms.Label();
            this._lnkReverse = new System.Windows.Forms.LinkLabel();
            this._btnSpeak = new System.Windows.Forms.Button();
            this._webBrowserCtrl = new System.Windows.Forms.WebBrowser();
            this._lnkSourceEnglish = new System.Windows.Forms.LinkLabel();
            this._lnkTargetEnglish = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source language:";
            // 
            // _comboFrom
            // 
            this._comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFrom.FormattingEnabled = true;
            this._comboFrom.Location = new System.Drawing.Point(8, 24);
            this._comboFrom.MaxDropDownItems = 20;
            this._comboFrom.Name = "_comboFrom";
            this._comboFrom.Size = new System.Drawing.Size(156, 21);
            this._comboFrom.Sorted = true;
            this._comboFrom.TabIndex = 1;
            // 
            // _comboTo
            // 
            this._comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboTo.FormattingEnabled = true;
            this._comboTo.Location = new System.Drawing.Point(184, 24);
            this._comboTo.MaxDropDownItems = 20;
            this._comboTo.Name = "_comboTo";
            this._comboTo.Size = new System.Drawing.Size(156, 21);
            this._comboTo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target language:";
            // 
            // _editSourceText
            // 
            this._editSourceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._editSourceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(198)))), ((int)(((byte)(238)))));
            this._editSourceText.Location = new System.Drawing.Point(8, 68);
            this._editSourceText.Multiline = true;
            this._editSourceText.Name = "_editSourceText";
            this._editSourceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._editSourceText.Size = new System.Drawing.Size(344, 60);
            this._editSourceText.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Source text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Translation (non-Western characters may not display correctly):";
            // 
            // _editTarget
            // 
            this._editTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._editTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(198)))), ((int)(((byte)(238)))));
            this._editTarget.Location = new System.Drawing.Point(8, 148);
            this._editTarget.Multiline = true;
            this._editTarget.Name = "_editTarget";
            this._editTarget.ReadOnly = true;
            this._editTarget.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._editTarget.Size = new System.Drawing.Size(344, 60);
            this._editTarget.TabIndex = 10;
            // 
            // _btnTranslate
            // 
            this._btnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnTranslate.Location = new System.Drawing.Point(187, 216);
            this._btnTranslate.Name = "_btnTranslate";
            this._btnTranslate.Size = new System.Drawing.Size(64, 23);
            this._btnTranslate.TabIndex = 13;
            this._btnTranslate.Text = "Translate";
            this._btnTranslate.UseVisualStyleBackColor = true;
            this._btnTranslate.Click += new System.EventHandler(this._btnTranslate_Click);
            // 
            // _lblStatus
            // 
            this._lblStatus.AutoSize = true;
            this._lblStatus.Location = new System.Drawing.Point(6, 220);
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(16, 13);
            this._lblStatus.TabIndex = 11;
            this._lblStatus.Text = "   ";
            // 
            // _lnkReverse
            // 
            this._lnkReverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lnkReverse.AutoSize = true;
            this._lnkReverse.Location = new System.Drawing.Point(308, 52);
            this._lnkReverse.Name = "_lnkReverse";
            this._lnkReverse.Size = new System.Drawing.Size(47, 13);
            this._lnkReverse.TabIndex = 7;
            this._lnkReverse.TabStop = true;
            this._lnkReverse.Text = "Reverse";
            this._lnkReverse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lnkReverse_LinkClicked);
            // 
            // _btnSpeak
            // 
            this._btnSpeak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSpeak.Location = new System.Drawing.Point(257, 216);
            this._btnSpeak.Name = "_btnSpeak";
            this._btnSpeak.Size = new System.Drawing.Size(61, 23);
            this._btnSpeak.TabIndex = 14;
            this._btnSpeak.Text = "Speak";
            this._btnSpeak.UseVisualStyleBackColor = true;
            this._btnSpeak.Click += new System.EventHandler(this._btnSpeak_Click);
            // 
            // _webBrowserCtrl
            // 
            this._webBrowserCtrl.IsWebBrowserContextMenuEnabled = false;
            this._webBrowserCtrl.Location = new System.Drawing.Point(108, 218);
            this._webBrowserCtrl.Name = "_webBrowserCtrl";
            this._webBrowserCtrl.Size = new System.Drawing.Size(68, 20);
            this._webBrowserCtrl.TabIndex = 12;
            this._webBrowserCtrl.Visible = false;
            this._webBrowserCtrl.WebBrowserShortcutsEnabled = false;
            // 
            // _lnkSourceEnglish
            // 
            this._lnkSourceEnglish.AutoSize = true;
            this._lnkSourceEnglish.Location = new System.Drawing.Point(128, 8);
            this._lnkSourceEnglish.Name = "_lnkSourceEnglish";
            this._lnkSourceEnglish.Size = new System.Drawing.Size(40, 13);
            this._lnkSourceEnglish.TabIndex = 2;
            this._lnkSourceEnglish.TabStop = true;
            this._lnkSourceEnglish.Text = "English";
            this._lnkSourceEnglish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lnkSourceEnglish_LinkClicked);
            // 
            // _lnkTargetEnglish
            // 
            this._lnkTargetEnglish.AutoSize = true;
            this._lnkTargetEnglish.Location = new System.Drawing.Point(304, 8);
            this._lnkTargetEnglish.Name = "_lnkTargetEnglish";
            this._lnkTargetEnglish.Size = new System.Drawing.Size(40, 13);
            this._lnkTargetEnglish.TabIndex = 5;
            this._lnkTargetEnglish.TabStop = true;
            this._lnkTargetEnglish.Text = "English";
            this._lnkTargetEnglish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lnkTargetEnglish_LinkClicked);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(324, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoogleTranslatorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(129)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(360, 250);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this._lnkTargetEnglish);
            this.Controls.Add(this._lnkSourceEnglish);
            this.Controls.Add(this._webBrowserCtrl);
            this.Controls.Add(this._btnSpeak);
            this.Controls.Add(this._lnkReverse);
            this.Controls.Add(this._lblStatus);
            this.Controls.Add(this._btnTranslate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._editTarget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._editSourceText);
            this.Controls.Add(this._comboTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._comboFrom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 278);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 250);
            this.Name = "GoogleTranslatorFrm";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Translator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoogleTranslatorFrm_FormClosing);
            this.Load += new System.EventHandler(this.GoogleTranslatorFrm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GoogleTranslatorFrm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _comboFrom;
        private System.Windows.Forms.ComboBox _comboTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _editSourceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _editTarget;
        private System.Windows.Forms.Button _btnTranslate;
        private System.Windows.Forms.Label _lblStatus;
        private System.Windows.Forms.LinkLabel _lnkReverse;
        private System.Windows.Forms.Button _btnSpeak;
        private System.Windows.Forms.WebBrowser _webBrowserCtrl;
        private System.Windows.Forms.LinkLabel _lnkSourceEnglish;
        private System.Windows.Forms.LinkLabel _lnkTargetEnglish;
        private System.Windows.Forms.Button button1;
    }
}