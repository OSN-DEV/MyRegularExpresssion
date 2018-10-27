namespace MyRegularExpressionTest {
    partial class MyRegularExpressionMainFrm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyRegularExpressionMainFrm));
            this.cExpressionBackground = new MyLib.ComponentEx.PannelEx(this.components);
            this.cExpression = new MyLib.ComponentEx.TextBoxEx(this.components);
            this.cTargetBackground = new MyLib.ComponentEx.PannelEx(this.components);
            this.cTarget = new MyLib.ComponentEx.RichTextBoxEx(this.components);
            this.cResultBackground = new MyLib.ComponentEx.PannelEx(this.components);
            this.cResult = new MyLib.ComponentEx.RichTextBoxEx(this.components);
            this.cGroupBackground = new MyLib.ComponentEx.PannelEx(this.components);
            this.cGroup = new MyLib.ComponentEx.TextBoxEx(this.components);
            this.cExpressionBackground.SuspendLayout();
            this.cTargetBackground.SuspendLayout();
            this.cResultBackground.SuspendLayout();
            this.cGroupBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // cExpressionBackground
            // 
            this.cExpressionBackground.BackColor = System.Drawing.Color.Gray;
            this.cExpressionBackground.Controls.Add(this.cExpression);
            this.cExpressionBackground.Location = new System.Drawing.Point(10, 10);
            this.cExpressionBackground.Name = "cExpressionBackground";
            this.cExpressionBackground.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.cExpressionBackground.Size = new System.Drawing.Size(306, 23);
            this.cExpressionBackground.TabIndex = 0;
            // 
            // cExpression
            // 
            this.cExpression.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cExpression.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cExpression.Location = new System.Drawing.Point(3, 3);
            this.cExpression.Margin = new System.Windows.Forms.Padding(4);
            this.cExpression.Name = "cExpression";
            this.cExpression.Size = new System.Drawing.Size(300, 17);
            this.cExpression.TabIndex = 0;
            this.cExpression.TextChanged += new System.EventHandler(this.cExpression_TextChanged);
            // 
            // cTargetBackground
            // 
            this.cTargetBackground.BackColor = System.Drawing.Color.Gray;
            this.cTargetBackground.Controls.Add(this.cTarget);
            this.cTargetBackground.Location = new System.Drawing.Point(10, 76);
            this.cTargetBackground.Name = "cTargetBackground";
            this.cTargetBackground.Size = new System.Drawing.Size(306, 106);
            this.cTargetBackground.TabIndex = 2;
            // 
            // cTarget
            // 
            this.cTarget.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cTarget.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cTarget.Location = new System.Drawing.Point(3, 3);
            this.cTarget.Margin = new System.Windows.Forms.Padding(4);
            this.cTarget.Name = "cTarget";
            this.cTarget.Size = new System.Drawing.Size(300, 100);
            this.cTarget.TabIndex = 2;
            this.cTarget.Text = "";
            this.cTarget.TextChanged += new System.EventHandler(this.cTarget_TextChanged);
            // 
            // cResultBackground
            // 
            this.cResultBackground.BackColor = System.Drawing.Color.Gray;
            this.cResultBackground.Controls.Add(this.cResult);
            this.cResultBackground.Location = new System.Drawing.Point(10, 192);
            this.cResultBackground.Name = "cResultBackground";
            this.cResultBackground.Size = new System.Drawing.Size(306, 106);
            this.cResultBackground.TabIndex = 3;
            // 
            // cResult
            // 
            this.cResult.BackColor = System.Drawing.Color.White;
            this.cResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cResult.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cResult.Location = new System.Drawing.Point(3, 3);
            this.cResult.Margin = new System.Windows.Forms.Padding(4);
            this.cResult.Name = "cResult";
            this.cResult.ReadOnly = true;
            this.cResult.Size = new System.Drawing.Size(300, 100);
            this.cResult.TabIndex = 0;
            this.cResult.TabStop = false;
            this.cResult.Text = "";
            // 
            // cGroupBackground
            // 
            this.cGroupBackground.BackColor = System.Drawing.Color.Gray;
            this.cGroupBackground.Controls.Add(this.cGroup);
            this.cGroupBackground.Location = new System.Drawing.Point(10, 43);
            this.cGroupBackground.Name = "cGroupBackground";
            this.cGroupBackground.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.cGroupBackground.Size = new System.Drawing.Size(306, 23);
            this.cGroupBackground.TabIndex = 1;
            // 
            // cGroup
            // 
            this.cGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cGroup.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cGroup.Location = new System.Drawing.Point(3, 3);
            this.cGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cGroup.Name = "cGroup";
            this.cGroup.Size = new System.Drawing.Size(300, 17);
            this.cGroup.TabIndex = 1;
            this.cGroup.TextChanged += new System.EventHandler(this.cGroup_TextChanged);
            // 
            // MyRegularExpressionMainFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(326, 310);
            this.Controls.Add(this.cGroupBackground);
            this.Controls.Add(this.cResultBackground);
            this.Controls.Add(this.cTargetBackground);
            this.Controls.Add(this.cExpressionBackground);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(342, 317);
            this.Name = "MyRegularExpressionMainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "正規表現確認";
            this.Load += new System.EventHandler(this.MyRegularExpressionMainFrm_Load);
            this.Resize += new System.EventHandler(this.MyRegularExpressionMainFrm_Resize);
            this.cExpressionBackground.ResumeLayout(false);
            this.cExpressionBackground.PerformLayout();
            this.cTargetBackground.ResumeLayout(false);
            this.cResultBackground.ResumeLayout(false);
            this.cGroupBackground.ResumeLayout(false);
            this.cGroupBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MyLib.ComponentEx.PannelEx cExpressionBackground;
        private MyLib.ComponentEx.TextBoxEx cExpression;
        private MyLib.ComponentEx.PannelEx cTargetBackground;
        private MyLib.ComponentEx.RichTextBoxEx cTarget;
        private MyLib.ComponentEx.PannelEx cResultBackground;
        private MyLib.ComponentEx.RichTextBoxEx cResult;
        private MyLib.ComponentEx.PannelEx cGroupBackground;
        private MyLib.ComponentEx.TextBoxEx cGroup;
    }
}