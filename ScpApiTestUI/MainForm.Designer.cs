namespace ScpApiTestUI
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnc = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnDecCom = new System.Windows.Forms.Button();
            this.btnEncCom = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnc
            // 
            this.btnEnc.Location = new System.Drawing.Point(169, 216);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(140, 52);
            this.btnEnc.TabIndex = 0;
            this.btnEnc.Text = "암호모듈 테스트\r\n\r\nText→Enc→Dec";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(76, 24);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(238, 21);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "d:\\dbms_api\\scpdb_agent.ini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(361, 24);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(94, 21);
            this.txtKey.TabIndex = 3;
            this.txtKey.Text = "KEY1";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(76, 54);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(379, 48);
            this.txtText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enccrypt";
            // 
            // txtEnc
            // 
            this.txtEnc.Location = new System.Drawing.Point(76, 108);
            this.txtEnc.Multiline = true;
            this.txtEnc.Name = "txtEnc";
            this.txtEnc.Size = new System.Drawing.Size(379, 48);
            this.txtEnc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Decrypt";
            // 
            // txtDec
            // 
            this.txtDec.Location = new System.Drawing.Point(76, 162);
            this.txtDec.Multiline = true;
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(379, 48);
            this.txtDec.TabIndex = 9;
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(315, 216);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(140, 52);
            this.btnDec.TabIndex = 11;
            this.btnDec.Text = "암호모듈 테스트\r\n\r\nEnc→Dec";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnDecCom
            // 
            this.btnDecCom.Location = new System.Drawing.Point(315, 286);
            this.btnDecCom.Name = "btnDecCom";
            this.btnDecCom.Size = new System.Drawing.Size(140, 52);
            this.btnDecCom.TabIndex = 13;
            this.btnDecCom.Text = "암호모듈 테스트\r\n\r\nEnc→Dec";
            this.btnDecCom.UseVisualStyleBackColor = true;
            this.btnDecCom.Click += new System.EventHandler(this.btnDecCom_Click);
            // 
            // btnEncCom
            // 
            this.btnEncCom.Location = new System.Drawing.Point(169, 286);
            this.btnEncCom.Name = "btnEncCom";
            this.btnEncCom.Size = new System.Drawing.Size(140, 52);
            this.btnEncCom.TabIndex = 12;
            this.btnEncCom.Text = "암호모듈 테스트\r\n\r\nText→Enc→Dec";
            this.btnEncCom.UseVisualStyleBackColor = true;
            this.btnEncCom.Click += new System.EventHandler(this.btnEncCom_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(53, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Library 버전";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(53, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "COM+ 버전";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 360);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDecCom);
            this.Controls.Add(this.btnEncCom);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnEnc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnDecCom;
        private System.Windows.Forms.Button btnEncCom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

