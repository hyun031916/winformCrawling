
namespace WinFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tboxPW = new System.Windows.Forms.TextBox();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tboxUrl = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tboxGo = new System.Windows.Forms.TextBox();
            this.tbnNext = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.pboxMain = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.tboxPW);
            this.groupBox1.Controls.Add(this.tboxID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. 특정 Site Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(213, 31);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 67);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // tboxPW
            // 
            this.tboxPW.Location = new System.Drawing.Point(85, 71);
            this.tboxPW.Name = "tboxPW";
            this.tboxPW.Size = new System.Drawing.Size(116, 27);
            this.tboxPW.TabIndex = 3;
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(85, 31);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(116, 27);
            this.tboxID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tboxUrl);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.tboxSearch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 282);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2.1. 이미지 검색";
            // 
            // tboxUrl
            // 
            this.tboxUrl.Location = new System.Drawing.Point(85, 70);
            this.tboxUrl.Name = "tboxUrl";
            this.tboxUrl.Size = new System.Drawing.Size(207, 193);
            this.tboxUrl.TabIndex = 7;
            this.tboxUrl.Text = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(237, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tboxSearch
            // 
            this.tboxSearch.Location = new System.Drawing.Point(85, 36);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(144, 27);
            this.tboxSearch.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "URL: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "검색어: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.tboxGo);
            this.groupBox3.Controls.Add(this.tbnNext);
            this.groupBox3.Controls.Add(this.btnGo);
            this.groupBox3.Controls.Add(this.btnPre);
            this.groupBox3.Controls.Add(this.pboxMain);
            this.groupBox3.Location = new System.Drawing.Point(340, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 426);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2.2. 이미지 검색 상세";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(181, 394);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "/ 0";
            // 
            // tboxGo
            // 
            this.tboxGo.Location = new System.Drawing.Point(118, 391);
            this.tboxGo.Name = "tboxGo";
            this.tboxGo.Size = new System.Drawing.Size(49, 27);
            this.tboxGo.TabIndex = 4;
            this.tboxGo.Text = "0";
            // 
            // tbnNext
            // 
            this.tbnNext.Location = new System.Drawing.Point(337, 391);
            this.tbnNext.Name = "tbnNext";
            this.tbnNext.Size = new System.Drawing.Size(61, 29);
            this.tbnNext.TabIndex = 3;
            this.tbnNext.Text = "▶";
            this.tbnNext.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(237, 391);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(94, 29);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(51, 391);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(61, 29);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "◀";
            this.btnPre.UseVisualStyleBackColor = true;
            // 
            // pboxMain
            // 
            this.pboxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxMain.Location = new System.Drawing.Point(6, 26);
            this.pboxMain.Name = "pboxMain";
            this.pboxMain.Size = new System.Drawing.Size(442, 353);
            this.pboxMain.TabIndex = 0;
            this.pboxMain.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "PW:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tboxPW;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RichTextBox tboxUrl;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tbnNext;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.PictureBox pboxMain;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tboxGo;
        private System.Windows.Forms.Label label2;
    }
}

