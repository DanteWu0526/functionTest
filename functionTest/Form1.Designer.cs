namespace functionTest
{
    partial class FunctionTest
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionTest));
            this.languageSelection = new System.Windows.Forms.GroupBox();
            this.enRadioButton = new System.Windows.Forms.RadioButton();
            this.chRadioButton = new System.Windows.Forms.RadioButton();
            this.testGroupBox = new System.Windows.Forms.GroupBox();
            this.checkUSBButton = new System.Windows.Forms.Button();
            this.rs422Button = new System.Windows.Forms.Button();
            this.checkMacsButton = new System.Windows.Forms.Button();
            this.testListLabel = new System.Windows.Forms.Label();
            this.listRichTextBox = new System.Windows.Forms.RichTextBox();
            this.checkAudioButton = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.languageSelection.SuspendLayout();
            this.testGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // languageSelection
            // 
            this.languageSelection.Controls.Add(this.enRadioButton);
            this.languageSelection.Controls.Add(this.chRadioButton);
            this.languageSelection.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.languageSelection.Location = new System.Drawing.Point(13, 14);
            this.languageSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.languageSelection.Name = "languageSelection";
            this.languageSelection.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.languageSelection.Size = new System.Drawing.Size(259, 217);
            this.languageSelection.TabIndex = 0;
            this.languageSelection.TabStop = false;
            this.languageSelection.Text = "選擇顯示語言:            Select display language:";
            // 
            // enRadioButton
            // 
            this.enRadioButton.AutoSize = true;
            this.enRadioButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enRadioButton.Location = new System.Drawing.Point(6, 109);
            this.enRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enRadioButton.Name = "enRadioButton";
            this.enRadioButton.Size = new System.Drawing.Size(82, 23);
            this.enRadioButton.TabIndex = 1;
            this.enRadioButton.TabStop = true;
            this.enRadioButton.Text = "English";
            this.enRadioButton.UseVisualStyleBackColor = true;
            this.enRadioButton.Click += new System.EventHandler(this.enRadioButton_Click);
            // 
            // chRadioButton
            // 
            this.chRadioButton.AutoSize = true;
            this.chRadioButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chRadioButton.Location = new System.Drawing.Point(6, 68);
            this.chRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chRadioButton.Name = "chRadioButton";
            this.chRadioButton.Size = new System.Drawing.Size(65, 23);
            this.chRadioButton.TabIndex = 0;
            this.chRadioButton.TabStop = true;
            this.chRadioButton.Text = "中文";
            this.chRadioButton.UseVisualStyleBackColor = true;
            this.chRadioButton.Click += new System.EventHandler(this.chRadioButton_Click);
            // 
            // testGroupBox
            // 
            this.testGroupBox.Controls.Add(this.checkAudioButton);
            this.testGroupBox.Controls.Add(this.checkUSBButton);
            this.testGroupBox.Controls.Add(this.rs422Button);
            this.testGroupBox.Controls.Add(this.checkMacsButton);
            this.testGroupBox.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.testGroupBox.Location = new System.Drawing.Point(12, 239);
            this.testGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testGroupBox.Name = "testGroupBox";
            this.testGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testGroupBox.Size = new System.Drawing.Size(224, 222);
            this.testGroupBox.TabIndex = 1;
            this.testGroupBox.TabStop = false;
            this.testGroupBox.Text = "測試選單視窗:";
            this.testGroupBox.Visible = false;
            // 
            // checkUSBButton
            // 
            this.checkUSBButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkUSBButton.Location = new System.Drawing.Point(6, 127);
            this.checkUSBButton.Name = "checkUSBButton";
            this.checkUSBButton.Size = new System.Drawing.Size(212, 36);
            this.checkUSBButton.TabIndex = 2;
            this.checkUSBButton.Text = "確認USB功能";
            this.checkUSBButton.UseVisualStyleBackColor = true;
            this.checkUSBButton.Click += new System.EventHandler(this.checkUSBButton_Click);
            // 
            // rs422Button
            // 
            this.rs422Button.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rs422Button.Location = new System.Drawing.Point(6, 85);
            this.rs422Button.Name = "rs422Button";
            this.rs422Button.Size = new System.Drawing.Size(212, 36);
            this.rs422Button.TabIndex = 1;
            this.rs422Button.Text = "確認RS422功能";
            this.rs422Button.UseVisualStyleBackColor = true;
            this.rs422Button.Click += new System.EventHandler(this.rs422Button_Click);
            // 
            // checkMacsButton
            // 
            this.checkMacsButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkMacsButton.Location = new System.Drawing.Point(6, 43);
            this.checkMacsButton.Name = "checkMacsButton";
            this.checkMacsButton.Size = new System.Drawing.Size(212, 36);
            this.checkMacsButton.TabIndex = 0;
            this.checkMacsButton.Text = "確認網路位置";
            this.checkMacsButton.UseVisualStyleBackColor = true;
            this.checkMacsButton.Click += new System.EventHandler(this.checkMacsButton_Click);
            // 
            // testListLabel
            // 
            this.testListLabel.AutoSize = true;
            this.testListLabel.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.testListLabel.Location = new System.Drawing.Point(278, 9);
            this.testListLabel.Name = "testListLabel";
            this.testListLabel.Size = new System.Drawing.Size(104, 22);
            this.testListLabel.TabIndex = 3;
            this.testListLabel.Text = "測試歷程:";
            // 
            // listRichTextBox
            // 
            this.listRichTextBox.Location = new System.Drawing.Point(278, 34);
            this.listRichTextBox.Name = "listRichTextBox";
            this.listRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.listRichTextBox.Size = new System.Drawing.Size(493, 197);
            this.listRichTextBox.TabIndex = 4;
            this.listRichTextBox.Text = "";
            // 
            // checkAudioButton
            // 
            this.checkAudioButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkAudioButton.Location = new System.Drawing.Point(6, 169);
            this.checkAudioButton.Name = "checkAudioButton";
            this.checkAudioButton.Size = new System.Drawing.Size(212, 36);
            this.checkAudioButton.TabIndex = 3;
            this.checkAudioButton.Text = "確認影像及音樂功能";
            this.checkAudioButton.UseVisualStyleBackColor = true;
            this.checkAudioButton.Click += new System.EventHandler(this.checkAudioButton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(278, 234);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(493, 315);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // FunctionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.listRichTextBox);
            this.Controls.Add(this.testListLabel);
            this.Controls.Add(this.testGroupBox);
            this.Controls.Add(this.languageSelection);
            this.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FunctionTest";
            this.Text = "FunctionTest";
            this.languageSelection.ResumeLayout(false);
            this.languageSelection.PerformLayout();
            this.testGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox languageSelection;
        private System.Windows.Forms.RadioButton enRadioButton;
        private System.Windows.Forms.RadioButton chRadioButton;
        private System.Windows.Forms.GroupBox testGroupBox;
        private System.Windows.Forms.Button checkMacsButton;
        private System.Windows.Forms.Label testListLabel;
        private System.Windows.Forms.RichTextBox listRichTextBox;
        private System.Windows.Forms.Button rs422Button;
        private System.Windows.Forms.Button checkUSBButton;
        private System.Windows.Forms.Button checkAudioButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

