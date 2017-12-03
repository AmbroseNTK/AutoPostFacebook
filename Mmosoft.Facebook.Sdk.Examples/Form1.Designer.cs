namespace Mmosoft.Facebook.Sdk.Examples
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnPostMyWall = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLogout = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPostGroup = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numSecond = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btLoadGroupList = new System.Windows.Forms.Button();
            this.comboGroupList = new System.Windows.Forms.ComboBox();
            this.btSaveListGroup = new System.Windows.Forms.Button();
            this.processPost = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPostMyWall
            // 
            this.btnPostMyWall.Location = new System.Drawing.Point(613, 271);
            this.btnPostMyWall.Name = "btnPostMyWall";
            this.btnPostMyWall.Size = new System.Drawing.Size(102, 23);
            this.btnPostMyWall.TabIndex = 0;
            this.btnPostMyWall.Text = "Đăng lên tường";
            this.btnPostMyWall.UseVisualStyleBackColor = true;
            this.btnPostMyWall.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLogout);
            this.groupBox1.Controls.Add(this.btLogin);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập tài khoản Facebook của bạn";
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(467, 22);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(69, 46);
            this.btLogout.TabIndex = 18;
            this.btLogout.Text = "Đăng xuất";
            this.btLogout.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(392, 22);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(69, 46);
            this.btLogin.TabIndex = 17;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(289, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(96, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(289, 20);
            this.txtUsername.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // btnPostGroup
            // 
            this.btnPostGroup.Location = new System.Drawing.Point(505, 271);
            this.btnPostGroup.Name = "btnPostGroup";
            this.btnPostGroup.Size = new System.Drawing.Size(102, 23);
            this.btnPostGroup.TabIndex = 3;
            this.btnPostGroup.Text = "Đăng lên group";
            this.btnPostGroup.UseVisualStyleBackColor = true;
            this.btnPostGroup.Click += new System.EventHandler(this.btnPostGroup_Click);
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(12, 118);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(703, 134);
            this.txtContent.TabIndex = 4;
            this.txtContent.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhập ID group:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(259, 300);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(456, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numSecond
            // 
            this.numSecond.Location = new System.Drawing.Point(139, 303);
            this.numSecond.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numSecond.Name = "numSecond";
            this.numSecond.Size = new System.Drawing.Size(102, 20);
            this.numSecond.TabIndex = 12;
            this.numSecond.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSecond.ValueChanged += new System.EventHandler(this.numSecond_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Chu kỳ post (seconds):";
            // 
            // btLoadGroupList
            // 
            this.btLoadGroupList.Location = new System.Drawing.Point(303, 271);
            this.btLoadGroupList.Name = "btLoadGroupList";
            this.btLoadGroupList.Size = new System.Drawing.Size(95, 23);
            this.btLoadGroupList.TabIndex = 14;
            this.btLoadGroupList.Text = "Nhập danh sách group";
            this.btLoadGroupList.UseVisualStyleBackColor = true;
            this.btLoadGroupList.Click += new System.EventHandler(this.btLoadGroupList_Click);
            // 
            // comboGroupList
            // 
            this.comboGroupList.FormattingEnabled = true;
            this.comboGroupList.Location = new System.Drawing.Point(102, 271);
            this.comboGroupList.Name = "comboGroupList";
            this.comboGroupList.Size = new System.Drawing.Size(195, 21);
            this.comboGroupList.TabIndex = 15;
            this.comboGroupList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboGroupList_KeyDown);
            // 
            // btSaveListGroup
            // 
            this.btSaveListGroup.Location = new System.Drawing.Point(404, 271);
            this.btSaveListGroup.Name = "btSaveListGroup";
            this.btSaveListGroup.Size = new System.Drawing.Size(95, 23);
            this.btSaveListGroup.TabIndex = 16;
            this.btSaveListGroup.Text = "Lưu danh sách";
            this.btSaveListGroup.UseVisualStyleBackColor = true;
            this.btSaveListGroup.Click += new System.EventHandler(this.btSaveListGroup_Click);
            // 
            // processPost
            // 
            this.processPost.Location = new System.Drawing.Point(259, 329);
            this.processPost.Name = "processPost";
            this.processPost.Size = new System.Drawing.Size(456, 23);
            this.processPost.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tiến trình:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.processPost);
            this.Controls.Add(this.btSaveListGroup);
            this.Controls.Add(this.comboGroupList);
            this.Controls.Add(this.btLoadGroupList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numSecond);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnPostGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPostMyWall);
            this.Name = "Form1";
            this.Text = "Auto Post Facebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPostMyWall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPostGroup;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btLoadGroupList;
        private System.Windows.Forms.ComboBox comboGroupList;
        private System.Windows.Forms.Button btSaveListGroup;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.ProgressBar processPost;
        private System.Windows.Forms.Label label5;
    }
}