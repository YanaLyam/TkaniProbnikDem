namespace TkaniProbnikDem
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAuth = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.lbAuth.Location = new System.Drawing.Point(176, 9);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(185, 38);
            this.lbAuth.TabIndex = 0;
            this.lbAuth.Text = "Авторизация";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.lbPass.Location = new System.Drawing.Point(37, 162);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(116, 38);
            this.lbPass.TabIndex = 1;
            this.lbPass.Text = "Пароль";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.lbLogin.Location = new System.Drawing.Point(37, 99);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(98, 38);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "Логин";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(160, 106);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(229, 31);
            this.tbLogin.TabIndex = 3;
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.Location = new System.Drawing.Point(159, 169);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(229, 31);
            this.tbPass.TabIndex = 4;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.btnEnter.Location = new System.Drawing.Point(200, 266);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(121, 33);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 400);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbAuth);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "AuthForm";
            this.Text = "ООО <Ткани>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAuth;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnEnter;
    }
}

