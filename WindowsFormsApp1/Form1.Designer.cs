
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tboxPW = new System.Windows.Forms.TextBox();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tboxUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tboxNow = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.pboxMain = new System.Windows.Forms.PictureBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.tboxPW);
            this.groupBox1.Controls.Add(this.tboxID);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(280, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. 특정 Site Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(203, 19);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(66, 45);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "button1";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tboxPW
            // 
            this.tboxPW.Location = new System.Drawing.Point(53, 44);
            this.tboxPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxPW.Name = "tboxPW";
            this.tboxPW.Size = new System.Drawing.Size(135, 21);
            this.tboxPW.TabIndex = 1;
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(53, 19);
            this.tboxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(135, 21);
            this.tboxID.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tboxUrl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.tboxSearch);
            this.groupBox2.Location = new System.Drawing.Point(10, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(280, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2.1. 이미지 검색";
            // 
            // tboxUrl
            // 
            this.tboxUrl.Location = new System.Drawing.Point(60, 63);
            this.tboxUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxUrl.Multiline = true;
            this.tboxUrl.Name = "tboxUrl";
            this.tboxUrl.Size = new System.Drawing.Size(209, 166);
            this.tboxUrl.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "URL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "검색어:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(214, 36);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 20);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // tboxSearch
            // 
            this.tboxSearch.Location = new System.Drawing.Point(60, 35);
            this.tboxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(148, 21);
            this.tboxSearch.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.tboxNow);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Controls.Add(this.btnGo);
            this.groupBox3.Controls.Add(this.pboxMain);
            this.groupBox3.Controls.Add(this.btnPre);
            this.groupBox3.Location = new System.Drawing.Point(307, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(382, 341);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2.2. 이미지 검색 상세";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(175, 320);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 12);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "/ 0";
            // 
            // tboxNow
            // 
            this.tboxNow.Location = new System.Drawing.Point(135, 315);
            this.tboxNow.Name = "tboxNow";
            this.tboxNow.Size = new System.Drawing.Size(34, 21);
            this.tboxNow.TabIndex = 7;
            this.tboxNow.Text = "0";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(290, 316);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(55, 20);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(229, 316);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(55, 20);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // pboxMain
            // 
            this.pboxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxMain.Location = new System.Drawing.Point(5, 19);
            this.pboxMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxMain.Name = "pboxMain";
            this.pboxMain.Size = new System.Drawing.Size(372, 292);
            this.pboxMain.TabIndex = 4;
            this.pboxMain.TabStop = false;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(74, 315);
            this.btnPre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(55, 21);
            this.btnPre.TabIndex = 3;
            this.btnPre.Text = "◀";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboxMain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tboxNow;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tboxUrl;
    }
}

