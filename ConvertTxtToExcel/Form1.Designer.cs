namespace ConvertTxtToExcel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_OutPutPath = new TextBox();
            lbl_Path = new Label();
            lbl_TextMain = new Label();
            lbl_Spliter = new Label();
            txt_Spliter = new TextBox();
            btn_Convert = new Button();
            lbl_Formats = new Label();
            com_Formats = new ComboBox();
            txt_inputText = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            btn_SelectFile = new Button();
            btn_SelectPath = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // txt_OutPutPath
            // 
            txt_OutPutPath.Location = new Point(128, 53);
            txt_OutPutPath.Name = "txt_OutPutPath";
            txt_OutPutPath.Size = new Size(733, 30);
            txt_OutPutPath.TabIndex = 0;
            // 
            // lbl_Path
            // 
            lbl_Path.AutoSize = true;
            lbl_Path.Location = new Point(18, 56);
            lbl_Path.Name = "lbl_Path";
            lbl_Path.Size = new Size(104, 23);
            lbl_Path.TabIndex = 1;
            lbl_Path.Text = "OutPut Path";
            // 
            // lbl_TextMain
            // 
            lbl_TextMain.AutoSize = true;
            lbl_TextMain.Location = new Point(32, 23);
            lbl_TextMain.Name = "lbl_TextMain";
            lbl_TextMain.Size = new Size(90, 23);
            lbl_TextMain.TabIndex = 2;
            lbl_TextMain.Text = "Input Path";
            // 
            // lbl_Spliter
            // 
            lbl_Spliter.AutoSize = true;
            lbl_Spliter.Location = new Point(64, 107);
            lbl_Spliter.Name = "lbl_Spliter";
            lbl_Spliter.Size = new Size(58, 23);
            lbl_Spliter.TabIndex = 4;
            lbl_Spliter.Text = "Spliter";
            // 
            // txt_Spliter
            // 
            txt_Spliter.Location = new Point(128, 103);
            txt_Spliter.Name = "txt_Spliter";
            txt_Spliter.Size = new Size(95, 30);
            txt_Spliter.TabIndex = 5;
            txt_Spliter.Text = "\"|\"";
            // 
            // btn_Convert
            // 
            btn_Convert.BackColor = SystemColors.ActiveCaption;
            btn_Convert.Location = new Point(855, 97);
            btn_Convert.Name = "btn_Convert";
            btn_Convert.Size = new Size(155, 42);
            btn_Convert.TabIndex = 6;
            btn_Convert.Text = "Convert";
            btn_Convert.UseVisualStyleBackColor = false;
            btn_Convert.Click += btn_Convert_Click;
            // 
            // lbl_Formats
            // 
            lbl_Formats.AutoSize = true;
            lbl_Formats.Location = new Point(229, 107);
            lbl_Formats.Name = "lbl_Formats";
            lbl_Formats.Size = new Size(64, 23);
            lbl_Formats.TabIndex = 7;
            lbl_Formats.Text = "Format";
            // 
            // com_Formats
            // 
            com_Formats.FormattingEnabled = true;
            com_Formats.Location = new Point(294, 105);
            com_Formats.Name = "com_Formats";
            com_Formats.Size = new Size(550, 31);
            com_Formats.TabIndex = 8;
            // 
            // txt_inputText
            // 
            txt_inputText.Location = new Point(128, 17);
            txt_inputText.Name = "txt_inputText";
            txt_inputText.Size = new Size(733, 30);
            txt_inputText.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_SelectFile
            // 
            btn_SelectFile.Location = new Point(867, 17);
            btn_SelectFile.Name = "btn_SelectFile";
            btn_SelectFile.Size = new Size(126, 34);
            btn_SelectFile.TabIndex = 9;
            btn_SelectFile.Text = "Select File";
            btn_SelectFile.UseVisualStyleBackColor = true;
            btn_SelectFile.Click += btn_SelectFile_Click;
            // 
            // btn_SelectPath
            // 
            btn_SelectPath.Location = new Point(867, 53);
            btn_SelectPath.Name = "btn_SelectPath";
            btn_SelectPath.Size = new Size(126, 34);
            btn_SelectPath.TabIndex = 9;
            btn_SelectPath.Text = "Select Path";
            btn_SelectPath.UseVisualStyleBackColor = true;
            btn_SelectPath.Click += btn_SelectPath_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 165);
            Controls.Add(btn_SelectPath);
            Controls.Add(btn_SelectFile);
            Controls.Add(com_Formats);
            Controls.Add(lbl_Formats);
            Controls.Add(btn_Convert);
            Controls.Add(txt_Spliter);
            Controls.Add(lbl_Spliter);
            Controls.Add(lbl_TextMain);
            Controls.Add(lbl_Path);
            Controls.Add(txt_inputText);
            Controls.Add(txt_OutPutPath);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Text Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_OutPutPath;
        private Label lbl_Path;
        private Label lbl_TextMain;
        private Label lbl_Spliter;
        private TextBox txt_Spliter;
        private Button btn_Convert;
        private Label lbl_Formats;
        private ComboBox com_Formats;
        private TextBox txt_inputText;
        private OpenFileDialog openFileDialog1;
        private Button btn_SelectFile;
        private Button btn_SelectPath;
        private SaveFileDialog saveFileDialog1;
    }
}
