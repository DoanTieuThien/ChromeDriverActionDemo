namespace ChromeDriverAutomation
{
    partial class FormChromeDriverMain
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
            this.btnLoadWebsite = new System.Windows.Forms.Button();
            this.lbChromeDriverHeader = new System.Windows.Forms.Label();
            this.txtAddressText = new System.Windows.Forms.TextBox();
            this.btnGetElementByID = new System.Windows.Forms.Button();
            this.txtIDInputCheck = new System.Windows.Forms.TextBox();
            this.txtInputClassCheck = new System.Windows.Forms.TextBox();
            this.btnGetElementByClass = new System.Windows.Forms.Button();
            this.cbbActionIDType = new System.Windows.Forms.ComboBox();
            this.cbbActionClassType = new System.Windows.Forms.ComboBox();
            this.txtValueByID = new System.Windows.Forms.TextBox();
            this.txtValueByClass = new System.Windows.Forms.TextBox();
            this.txtLogMonitorWeb = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.cbbAttribute = new System.Windows.Forms.ComboBox();
            this.txtTagNameValue = new System.Windows.Forms.TextBox();
            this.cbbTagNameEvent = new System.Windows.Forms.ComboBox();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.btnActionByTagName = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.radioActionByID = new System.Windows.Forms.RadioButton();
            this.radioActionByClass = new System.Windows.Forms.RadioButton();
            this.radioActionByTagName = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnLoadWebsite
            // 
            this.btnLoadWebsite.Location = new System.Drawing.Point(741, 58);
            this.btnLoadWebsite.Name = "btnLoadWebsite";
            this.btnLoadWebsite.Size = new System.Drawing.Size(151, 34);
            this.btnLoadWebsite.TabIndex = 1;
            this.btnLoadWebsite.Text = "Tải";
            this.btnLoadWebsite.UseVisualStyleBackColor = true;
            this.btnLoadWebsite.Click += new System.EventHandler(this.btnLoadWebsite_Click);
            // 
            // lbChromeDriverHeader
            // 
            this.lbChromeDriverHeader.AutoSize = true;
            this.lbChromeDriverHeader.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChromeDriverHeader.Location = new System.Drawing.Point(314, 9);
            this.lbChromeDriverHeader.Name = "lbChromeDriverHeader";
            this.lbChromeDriverHeader.Size = new System.Drawing.Size(194, 31);
            this.lbChromeDriverHeader.TabIndex = 1;
            this.lbChromeDriverHeader.Text = "Chrome Driver";
            // 
            // txtAddressText
            // 
            this.txtAddressText.Location = new System.Drawing.Point(12, 64);
            this.txtAddressText.Name = "txtAddressText";
            this.txtAddressText.Size = new System.Drawing.Size(723, 25);
            this.txtAddressText.TabIndex = 0;
            // 
            // btnGetElementByID
            // 
            this.btnGetElementByID.Location = new System.Drawing.Point(741, 133);
            this.btnGetElementByID.Name = "btnGetElementByID";
            this.btnGetElementByID.Size = new System.Drawing.Size(151, 34);
            this.btnGetElementByID.TabIndex = 3;
            this.btnGetElementByID.Text = "ActionByID";
            this.btnGetElementByID.UseVisualStyleBackColor = true;
            this.btnGetElementByID.Click += new System.EventHandler(this.btnGetElementByID_Click);
            // 
            // txtIDInputCheck
            // 
            this.txtIDInputCheck.Location = new System.Drawing.Point(12, 139);
            this.txtIDInputCheck.Name = "txtIDInputCheck";
            this.txtIDInputCheck.Size = new System.Drawing.Size(187, 25);
            this.txtIDInputCheck.TabIndex = 2;
            this.txtIDInputCheck.Text = "ID";
            // 
            // txtInputClassCheck
            // 
            this.txtInputClassCheck.Location = new System.Drawing.Point(12, 179);
            this.txtInputClassCheck.Name = "txtInputClassCheck";
            this.txtInputClassCheck.Size = new System.Drawing.Size(187, 25);
            this.txtInputClassCheck.TabIndex = 5;
            this.txtInputClassCheck.Text = "Class";
            // 
            // btnGetElementByClass
            // 
            this.btnGetElementByClass.Location = new System.Drawing.Point(741, 173);
            this.btnGetElementByClass.Name = "btnGetElementByClass";
            this.btnGetElementByClass.Size = new System.Drawing.Size(151, 34);
            this.btnGetElementByClass.TabIndex = 6;
            this.btnGetElementByClass.Text = "ActionByClass";
            this.btnGetElementByClass.UseVisualStyleBackColor = true;
            this.btnGetElementByClass.Click += new System.EventHandler(this.btnGetElementByClass_Click);
            // 
            // cbbActionIDType
            // 
            this.cbbActionIDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbActionIDType.FormattingEnabled = true;
            this.cbbActionIDType.Items.AddRange(new object[] {
            "GET",
            "SET",
            "CLICK"});
            this.cbbActionIDType.Location = new System.Drawing.Point(393, 139);
            this.cbbActionIDType.Name = "cbbActionIDType";
            this.cbbActionIDType.Size = new System.Drawing.Size(115, 25);
            this.cbbActionIDType.TabIndex = 8;
            this.cbbActionIDType.SelectedIndexChanged += new System.EventHandler(this.cbbActionIDType_SelectedIndexChanged);
            // 
            // cbbActionClassType
            // 
            this.cbbActionClassType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbActionClassType.FormattingEnabled = true;
            this.cbbActionClassType.Items.AddRange(new object[] {
            "GET",
            "SET",
            "CLICK"});
            this.cbbActionClassType.Location = new System.Drawing.Point(393, 179);
            this.cbbActionClassType.Name = "cbbActionClassType";
            this.cbbActionClassType.Size = new System.Drawing.Size(115, 25);
            this.cbbActionClassType.TabIndex = 9;
            this.cbbActionClassType.SelectedIndexChanged += new System.EventHandler(this.cbbActionClassType_SelectedIndexChanged);
            // 
            // txtValueByID
            // 
            this.txtValueByID.Location = new System.Drawing.Point(205, 139);
            this.txtValueByID.Name = "txtValueByID";
            this.txtValueByID.Size = new System.Drawing.Size(182, 25);
            this.txtValueByID.TabIndex = 10;
            this.txtValueByID.Text = "Value";
            // 
            // txtValueByClass
            // 
            this.txtValueByClass.Location = new System.Drawing.Point(205, 179);
            this.txtValueByClass.Name = "txtValueByClass";
            this.txtValueByClass.Size = new System.Drawing.Size(182, 25);
            this.txtValueByClass.TabIndex = 11;
            this.txtValueByClass.Text = "Value";
            // 
            // txtLogMonitorWeb
            // 
            this.txtLogMonitorWeb.Location = new System.Drawing.Point(12, 257);
            this.txtLogMonitorWeb.Multiline = true;
            this.txtLogMonitorWeb.Name = "txtLogMonitorWeb";
            this.txtLogMonitorWeb.ReadOnly = true;
            this.txtLogMonitorWeb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogMonitorWeb.Size = new System.Drawing.Size(723, 164);
            this.txtLogMonitorWeb.TabIndex = 12;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(741, 257);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(151, 34);
            this.btnClearLog.TabIndex = 13;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // cbbAttribute
            // 
            this.cbbAttribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAttribute.FormattingEnabled = true;
            this.cbbAttribute.Items.AddRange(new object[] {
            "outerHTML",
            "innerHTML",
            "innerText",
            "value",
            "style",
            "id"});
            this.cbbAttribute.Location = new System.Drawing.Point(514, 179);
            this.cbbAttribute.Name = "cbbAttribute";
            this.cbbAttribute.Size = new System.Drawing.Size(125, 25);
            this.cbbAttribute.TabIndex = 14;
            // 
            // txtTagNameValue
            // 
            this.txtTagNameValue.Location = new System.Drawing.Point(205, 219);
            this.txtTagNameValue.Name = "txtTagNameValue";
            this.txtTagNameValue.Size = new System.Drawing.Size(182, 25);
            this.txtTagNameValue.TabIndex = 17;
            this.txtTagNameValue.Text = "Value";
            // 
            // cbbTagNameEvent
            // 
            this.cbbTagNameEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTagNameEvent.FormattingEnabled = true;
            this.cbbTagNameEvent.Items.AddRange(new object[] {
            "GET",
            "SET",
            "CLICK"});
            this.cbbTagNameEvent.Location = new System.Drawing.Point(393, 219);
            this.cbbTagNameEvent.Name = "cbbTagNameEvent";
            this.cbbTagNameEvent.Size = new System.Drawing.Size(115, 25);
            this.cbbTagNameEvent.TabIndex = 16;
            this.cbbTagNameEvent.SelectedIndexChanged += new System.EventHandler(this.cbbTagNameEvent_SelectedIndexChanged);
            // 
            // txtTagName
            // 
            this.txtTagName.Location = new System.Drawing.Point(12, 219);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(187, 25);
            this.txtTagName.TabIndex = 15;
            this.txtTagName.Text = "tagName";
            // 
            // btnActionByTagName
            // 
            this.btnActionByTagName.Location = new System.Drawing.Point(741, 213);
            this.btnActionByTagName.Name = "btnActionByTagName";
            this.btnActionByTagName.Size = new System.Drawing.Size(151, 34);
            this.btnActionByTagName.TabIndex = 18;
            this.btnActionByTagName.Text = "ActionByTagName";
            this.btnActionByTagName.UseVisualStyleBackColor = true;
            this.btnActionByTagName.Click += new System.EventHandler(this.btnActionByTagName_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(645, 179);
            this.txtPosition.Multiline = true;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(90, 69);
            this.txtPosition.TabIndex = 19;
            this.txtPosition.Text = "0";
            // 
            // radioActionByID
            // 
            this.radioActionByID.AutoSize = true;
            this.radioActionByID.Location = new System.Drawing.Point(12, 97);
            this.radioActionByID.Name = "radioActionByID";
            this.radioActionByID.Size = new System.Drawing.Size(106, 21);
            this.radioActionByID.TabIndex = 20;
            this.radioActionByID.TabStop = true;
            this.radioActionByID.Text = "Action By ID";
            this.radioActionByID.UseVisualStyleBackColor = true;
            this.radioActionByID.CheckedChanged += new System.EventHandler(this.radioActionByID_CheckedChanged);
            // 
            // radioActionByClass
            // 
            this.radioActionByClass.AutoSize = true;
            this.radioActionByClass.Location = new System.Drawing.Point(124, 97);
            this.radioActionByClass.Name = "radioActionByClass";
            this.radioActionByClass.Size = new System.Drawing.Size(122, 21);
            this.radioActionByClass.TabIndex = 21;
            this.radioActionByClass.TabStop = true;
            this.radioActionByClass.Text = "Action By Class";
            this.radioActionByClass.UseVisualStyleBackColor = true;
            this.radioActionByClass.CheckedChanged += new System.EventHandler(this.radioActionByClass_CheckedChanged);
            // 
            // radioActionByTagName
            // 
            this.radioActionByTagName.AutoSize = true;
            this.radioActionByTagName.Location = new System.Drawing.Point(252, 97);
            this.radioActionByTagName.Name = "radioActionByTagName";
            this.radioActionByTagName.Size = new System.Drawing.Size(148, 21);
            this.radioActionByTagName.TabIndex = 22;
            this.radioActionByTagName.TabStop = true;
            this.radioActionByTagName.Text = "Action By TagName";
            this.radioActionByTagName.UseVisualStyleBackColor = true;
            this.radioActionByTagName.CheckedChanged += new System.EventHandler(this.radioActionByTagName_CheckedChanged);
            // 
            // FormChromeDriverMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 428);
            this.Controls.Add(this.radioActionByTagName);
            this.Controls.Add(this.radioActionByClass);
            this.Controls.Add(this.radioActionByID);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.btnActionByTagName);
            this.Controls.Add(this.txtTagNameValue);
            this.Controls.Add(this.cbbTagNameEvent);
            this.Controls.Add(this.txtTagName);
            this.Controls.Add(this.cbbAttribute);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.txtLogMonitorWeb);
            this.Controls.Add(this.txtValueByClass);
            this.Controls.Add(this.txtValueByID);
            this.Controls.Add(this.cbbActionClassType);
            this.Controls.Add(this.cbbActionIDType);
            this.Controls.Add(this.txtInputClassCheck);
            this.Controls.Add(this.btnGetElementByClass);
            this.Controls.Add(this.txtIDInputCheck);
            this.Controls.Add(this.btnGetElementByID);
            this.Controls.Add(this.txtAddressText);
            this.Controls.Add(this.lbChromeDriverHeader);
            this.Controls.Add(this.btnLoadWebsite);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormChromeDriverMain";
            this.Text = "Công cụ tương tác với chrome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChromeDriverMain_FormClosing);
            this.Load += new System.EventHandler(this.FormChromeDriverMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadWebsite;
        private System.Windows.Forms.Label lbChromeDriverHeader;
        private System.Windows.Forms.TextBox txtAddressText;
        private System.Windows.Forms.Button btnGetElementByID;
        private System.Windows.Forms.TextBox txtIDInputCheck;
        private System.Windows.Forms.TextBox txtInputClassCheck;
        private System.Windows.Forms.Button btnGetElementByClass;
        private System.Windows.Forms.ComboBox cbbActionIDType;
        private System.Windows.Forms.ComboBox cbbActionClassType;
        private System.Windows.Forms.TextBox txtValueByID;
        private System.Windows.Forms.TextBox txtValueByClass;
        private System.Windows.Forms.TextBox txtLogMonitorWeb;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.ComboBox cbbAttribute;
        private System.Windows.Forms.TextBox txtTagNameValue;
        private System.Windows.Forms.ComboBox cbbTagNameEvent;
        private System.Windows.Forms.TextBox txtTagName;
        private System.Windows.Forms.Button btnActionByTagName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.RadioButton radioActionByID;
        private System.Windows.Forms.RadioButton radioActionByClass;
        private System.Windows.Forms.RadioButton radioActionByTagName;
    }
}

