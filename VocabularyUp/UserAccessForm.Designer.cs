namespace VocabularyUp
{
    partial class UserAccessForm
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccessForm));
            this.elipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnlUserLogin = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbForget = new System.Windows.Forms.Label();
            this.lbUserLogin = new System.Windows.Forms.Label();
            this.lbRemember_Login = new System.Windows.Forms.Label();
            this.swRemember_Login = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lbNoAccount_Login = new System.Windows.Forms.Label();
            this.btnCreateAccount_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPassword_Login = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsename_Login = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSignup = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbSignup = new System.Windows.Forms.Label();
            this.txtEmail_SignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbLoginAccess_SignUp = new System.Windows.Forms.Label();
            this.txtRePassword_SignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCreateAccount_SignUp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPassword_SignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername_SignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlTitleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHide = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.animateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.transitionPanel = new Guna.UI2.WinForms.Guna2Transition();
            this.pnlForgetPass = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbCountDown = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.btnCheckEmail = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCheckEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRePassForget = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPassForget = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtValidateCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.countDown = new System.Windows.Forms.Timer(this.components);
            this.countDownText = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUserLogin.SuspendLayout();
            this.pnlSignup.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlForgetPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.BorderRadius = 20;
            this.elipseForm.TargetControl = this;
            // 
            // pnlUserLogin
            // 
            this.pnlUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserLogin.BorderRadius = 30;
            this.pnlUserLogin.Controls.Add(this.lbForget);
            this.pnlUserLogin.Controls.Add(this.lbUserLogin);
            this.pnlUserLogin.Controls.Add(this.lbRemember_Login);
            this.pnlUserLogin.Controls.Add(this.swRemember_Login);
            this.pnlUserLogin.Controls.Add(this.lbNoAccount_Login);
            this.pnlUserLogin.Controls.Add(this.btnCreateAccount_Login);
            this.pnlUserLogin.Controls.Add(this.btnLogin);
            this.pnlUserLogin.Controls.Add(this.txtPassword_Login);
            this.pnlUserLogin.Controls.Add(this.txtUsename_Login);
            this.transitionPanel.SetDecoration(this.pnlUserLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlUserLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(236)))), ((int)(((byte)(141)))));
            this.pnlUserLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(236)))), ((int)(((byte)(141)))));
            this.pnlUserLogin.Location = new System.Drawing.Point(251, 109);
            this.pnlUserLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUserLogin.Name = "pnlUserLogin";
            this.pnlUserLogin.ShadowDecoration.Parent = this.pnlUserLogin;
            this.pnlUserLogin.Size = new System.Drawing.Size(389, 416);
            this.pnlUserLogin.TabIndex = 33;
            // 
            // lbForget
            // 
            this.lbForget.AutoSize = true;
            this.transitionPanel.SetDecoration(this.lbForget, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbForget.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForget.ForeColor = System.Drawing.Color.Red;
            this.lbForget.Location = new System.Drawing.Point(81, 283);
            this.lbForget.Name = "lbForget";
            this.lbForget.Size = new System.Drawing.Size(137, 17);
            this.lbForget.TabIndex = 33;
            this.lbForget.Text = "Forget password?";
            this.lbForget.Click += new System.EventHandler(this.lbForget_Click);
            // 
            // lbUserLogin
            // 
            this.lbUserLogin.AutoSize = true;
            this.transitionPanel.SetDecoration(this.lbUserLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbUserLogin.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserLogin.Location = new System.Drawing.Point(140, 34);
            this.lbUserLogin.Name = "lbUserLogin";
            this.lbUserLogin.Size = new System.Drawing.Size(89, 37);
            this.lbUserLogin.TabIndex = 32;
            this.lbUserLogin.Text = "Login";
            // 
            // lbRemember_Login
            // 
            this.lbRemember_Login.AutoSize = true;
            this.transitionPanel.SetDecoration(this.lbRemember_Login, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbRemember_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemember_Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbRemember_Login.Location = new System.Drawing.Point(120, 209);
            this.lbRemember_Login.Name = "lbRemember_Login";
            this.lbRemember_Login.Size = new System.Drawing.Size(111, 17);
            this.lbRemember_Login.TabIndex = 23;
            this.lbRemember_Login.Text = "Remember me";
            // 
            // swRemember_Login
            // 
            this.swRemember_Login.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.swRemember_Login.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.swRemember_Login.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swRemember_Login.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swRemember_Login.CheckedState.Parent = this.swRemember_Login;
            this.transitionPanel.SetDecoration(this.swRemember_Login, Guna.UI2.AnimatorNS.DecorationType.None);
            this.swRemember_Login.Location = new System.Drawing.Point(75, 209);
            this.swRemember_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swRemember_Login.Name = "swRemember_Login";
            this.swRemember_Login.ShadowDecoration.Parent = this.swRemember_Login;
            this.swRemember_Login.Size = new System.Drawing.Size(40, 21);
            this.swRemember_Login.TabIndex = 22;
            this.swRemember_Login.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.swRemember_Login.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.swRemember_Login.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swRemember_Login.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.swRemember_Login.UncheckedState.Parent = this.swRemember_Login;
            // 
            // lbNoAccount_Login
            // 
            this.lbNoAccount_Login.AutoSize = true;
            this.transitionPanel.SetDecoration(this.lbNoAccount_Login, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbNoAccount_Login.ForeColor = System.Drawing.Color.White;
            this.lbNoAccount_Login.Location = new System.Drawing.Point(113, 327);
            this.lbNoAccount_Login.Name = "lbNoAccount_Login";
            this.lbNoAccount_Login.Size = new System.Drawing.Size(158, 17);
            this.lbNoAccount_Login.TabIndex = 27;
            this.lbNoAccount_Login.Text = "Don\'t have an account?";
            this.lbNoAccount_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateAccount_Login
            // 
            this.btnCreateAccount_Login.AutoRoundedCorners = true;
            this.btnCreateAccount_Login.BorderRadius = 22;
            this.btnCreateAccount_Login.CheckedState.Parent = this.btnCreateAccount_Login;
            this.btnCreateAccount_Login.CustomImages.Parent = this.btnCreateAccount_Login;
            this.transitionPanel.SetDecoration(this.btnCreateAccount_Login, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCreateAccount_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.btnCreateAccount_Login.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.btnCreateAccount_Login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCreateAccount_Login.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount_Login.HoverState.Parent = this.btnCreateAccount_Login;
            this.btnCreateAccount_Login.Location = new System.Drawing.Point(75, 351);
            this.btnCreateAccount_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateAccount_Login.Name = "btnCreateAccount_Login";
            this.btnCreateAccount_Login.ShadowDecoration.Parent = this.btnCreateAccount_Login;
            this.btnCreateAccount_Login.Size = new System.Drawing.Size(240, 46);
            this.btnCreateAccount_Login.TabIndex = 25;
            this.btnCreateAccount_Login.Text = "Create Account";
            this.btnCreateAccount_Login.Click += new System.EventHandler(this.btnCreateAccount_Login_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BorderRadius = 22;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.transitionPanel.SetDecoration(this.btnLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(75, 235);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(240, 46);
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword_Login
            // 
            this.txtPassword_Login.Animated = true;
            this.txtPassword_Login.BorderRadius = 8;
            this.txtPassword_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionPanel.SetDecoration(this.txtPassword_Login, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtPassword_Login.DefaultText = "";
            this.txtPassword_Login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword_Login.DisabledState.Parent = this.txtPassword_Login;
            this.txtPassword_Login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtPassword_Login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword_Login.FocusedState.Parent = this.txtPassword_Login;
            this.txtPassword_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword_Login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword_Login.HoverState.Parent = this.txtPassword_Login;
            this.txtPassword_Login.Location = new System.Drawing.Point(75, 150);
            this.txtPassword_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword_Login.Name = "txtPassword_Login";
            this.txtPassword_Login.PasswordChar = '\0';
            this.txtPassword_Login.PlaceholderText = "Password";
            this.txtPassword_Login.SelectedText = "";
            this.txtPassword_Login.ShadowDecoration.Parent = this.txtPassword_Login;
            this.txtPassword_Login.Size = new System.Drawing.Size(240, 44);
            this.txtPassword_Login.TabIndex = 21;
            this.txtPassword_Login.UseSystemPasswordChar = true;
            // 
            // txtUsename_Login
            // 
            this.txtUsename_Login.Animated = true;
            this.txtUsename_Login.BorderRadius = 8;
            this.txtUsename_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionPanel.SetDecoration(this.txtUsename_Login, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtUsename_Login.DefaultText = "";
            this.txtUsename_Login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsename_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsename_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsename_Login.DisabledState.Parent = this.txtUsename_Login;
            this.txtUsename_Login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsename_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtUsename_Login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsename_Login.FocusedState.Parent = this.txtUsename_Login;
            this.txtUsename_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsename_Login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsename_Login.HoverState.Parent = this.txtUsename_Login;
            this.txtUsename_Login.Location = new System.Drawing.Point(75, 89);
            this.txtUsename_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsename_Login.Name = "txtUsename_Login";
            this.txtUsename_Login.PasswordChar = '\0';
            this.txtUsename_Login.PlaceholderText = "Usename";
            this.txtUsename_Login.SelectedText = "";
            this.txtUsename_Login.ShadowDecoration.Parent = this.txtUsename_Login;
            this.txtUsename_Login.Size = new System.Drawing.Size(240, 44);
            this.txtUsename_Login.TabIndex = 20;
            // 
            // pnlSignup
            // 
            this.pnlSignup.BackColor = System.Drawing.Color.Transparent;
            this.pnlSignup.BorderRadius = 30;
            this.pnlSignup.Controls.Add(this.lbSignup);
            this.pnlSignup.Controls.Add(this.txtEmail_SignUp);
            this.pnlSignup.Controls.Add(this.lbLoginAccess_SignUp);
            this.pnlSignup.Controls.Add(this.txtRePassword_SignUp);
            this.pnlSignup.Controls.Add(this.btnCreateAccount_SignUp);
            this.pnlSignup.Controls.Add(this.txtPassword_SignUp);
            this.pnlSignup.Controls.Add(this.txtUsername_SignUp);
            this.transitionPanel.SetDecoration(this.pnlSignup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlSignup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(236)))), ((int)(((byte)(141)))));
            this.pnlSignup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(236)))), ((int)(((byte)(141)))));
            this.pnlSignup.Location = new System.Drawing.Point(248, 107);
            this.pnlSignup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSignup.Name = "pnlSignup";
            this.pnlSignup.ShadowDecoration.Parent = this.pnlSignup;
            this.pnlSignup.Size = new System.Drawing.Size(389, 416);
            this.pnlSignup.TabIndex = 13;
            this.pnlSignup.Visible = false;
            // 
            // lbSignup
            // 
            this.lbSignup.AutoSize = true;
            this.transitionPanel.SetDecoration(this.lbSignup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbSignup.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignup.Location = new System.Drawing.Point(116, 34);
            this.lbSignup.Name = "lbSignup";
            this.lbSignup.Size = new System.Drawing.Size(126, 37);
            this.lbSignup.TabIndex = 12;
            this.lbSignup.Text = "Sign Up";
            // 
            // txtEmail_SignUp
            // 
            this.txtEmail_SignUp.Animated = true;
            this.txtEmail_SignUp.BorderRadius = 8;
            this.txtEmail_SignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionPanel.SetDecoration(this.txtEmail_SignUp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtEmail_SignUp.DefaultText = "";
            this.txtEmail_SignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail_SignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail_SignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail_SignUp.DisabledState.Parent = this.txtEmail_SignUp;
            this.txtEmail_SignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail_SignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtEmail_SignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail_SignUp.FocusedState.Parent = this.txtEmail_SignUp;
            this.txtEmail_SignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail_SignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail_SignUp.HoverState.Parent = this.txtEmail_SignUp;
            this.txtEmail_SignUp.Location = new System.Drawing.Point(75, 89);
            this.txtEmail_SignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail_SignUp.Name = "txtEmail_SignUp";
            this.txtEmail_SignUp.PasswordChar = '\0';
            this.txtEmail_SignUp.PlaceholderText = "Email";
            this.txtEmail_SignUp.SelectedText = "";
            this.txtEmail_SignUp.ShadowDecoration.Parent = this.txtEmail_SignUp;
            this.txtEmail_SignUp.Size = new System.Drawing.Size(240, 44);
            this.txtEmail_SignUp.TabIndex = 0;
            // 
            // lbLoginAccess_SignUp
            // 
            this.lbLoginAccess_SignUp.AutoSize = true;
            this.transitionPanel.SetDecoration(this.lbLoginAccess_SignUp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbLoginAccess_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginAccess_SignUp.ForeColor = System.Drawing.SystemColors.Info;
            this.lbLoginAccess_SignUp.Location = new System.Drawing.Point(259, 380);
            this.lbLoginAccess_SignUp.Name = "lbLoginAccess_SignUp";
            this.lbLoginAccess_SignUp.Size = new System.Drawing.Size(55, 20);
            this.lbLoginAccess_SignUp.TabIndex = 5;
            this.lbLoginAccess_SignUp.Text = "Log in";
            this.lbLoginAccess_SignUp.Click += new System.EventHandler(this.lbLoginAccess_SignUp_Click);
            // 
            // txtRePassword_SignUp
            // 
            this.txtRePassword_SignUp.Animated = true;
            this.txtRePassword_SignUp.BorderRadius = 8;
            this.txtRePassword_SignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionPanel.SetDecoration(this.txtRePassword_SignUp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtRePassword_SignUp.DefaultText = "";
            this.txtRePassword_SignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRePassword_SignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRePassword_SignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRePassword_SignUp.DisabledState.Parent = this.txtRePassword_SignUp;
            this.txtRePassword_SignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRePassword_SignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtRePassword_SignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRePassword_SignUp.FocusedState.Parent = this.txtRePassword_SignUp;
            this.txtRePassword_SignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRePassword_SignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRePassword_SignUp.HoverState.Parent = this.txtRePassword_SignUp;
            this.txtRePassword_SignUp.Location = new System.Drawing.Point(75, 271);
            this.txtRePassword_SignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRePassword_SignUp.Name = "txtRePassword_SignUp";
            this.txtRePassword_SignUp.PasswordChar = '\0';
            this.txtRePassword_SignUp.PlaceholderText = "Re-password";
            this.txtRePassword_SignUp.SelectedText = "";
            this.txtRePassword_SignUp.ShadowDecoration.Parent = this.txtRePassword_SignUp;
            this.txtRePassword_SignUp.Size = new System.Drawing.Size(240, 44);
            this.txtRePassword_SignUp.TabIndex = 3;
            this.txtRePassword_SignUp.UseSystemPasswordChar = true;
            // 
            // btnCreateAccount_SignUp
            // 
            this.btnCreateAccount_SignUp.AutoRoundedCorners = true;
            this.btnCreateAccount_SignUp.BorderRadius = 22;
            this.btnCreateAccount_SignUp.CheckedState.Parent = this.btnCreateAccount_SignUp;
            this.btnCreateAccount_SignUp.CustomImages.Parent = this.btnCreateAccount_SignUp;
            this.transitionPanel.SetDecoration(this.btnCreateAccount_SignUp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCreateAccount_SignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.btnCreateAccount_SignUp.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.btnCreateAccount_SignUp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount_SignUp.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount_SignUp.HoverState.Parent = this.btnCreateAccount_SignUp;
            this.btnCreateAccount_SignUp.Location = new System.Drawing.Point(75, 330);
            this.btnCreateAccount_SignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateAccount_SignUp.Name = "btnCreateAccount_SignUp";
            this.btnCreateAccount_SignUp.ShadowDecoration.Parent = this.btnCreateAccount_SignUp;
            this.btnCreateAccount_SignUp.Size = new System.Drawing.Size(240, 46);
            this.btnCreateAccount_SignUp.TabIndex = 4;
            this.btnCreateAccount_SignUp.Text = "Create Account";
            this.btnCreateAccount_SignUp.Click += new System.EventHandler(this.btnCreateAccount_SignUp_Click);
            // 
            // txtPassword_SignUp
            // 
            this.txtPassword_SignUp.Animated = true;
            this.txtPassword_SignUp.BorderRadius = 8;
            this.txtPassword_SignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionPanel.SetDecoration(this.txtPassword_SignUp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtPassword_SignUp.DefaultText = "";
            this.txtPassword_SignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword_SignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword_SignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword_SignUp.DisabledState.Parent = this.txtPassword_SignUp;
            this.txtPassword_SignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword_SignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtPassword_SignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword_SignUp.FocusedState.Parent = this.txtPassword_SignUp;
            this.txtPassword_SignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword_SignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword_SignUp.HoverState.Parent = this.txtPassword_SignUp;
            this.txtPassword_SignUp.Location = new System.Drawing.Point(75, 209);
            this.txtPassword_SignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword_SignUp.Name = "txtPassword_SignUp";
            this.txtPassword_SignUp.PasswordChar = '\0';
            this.txtPassword_SignUp.PlaceholderText = "Password";
            this.txtPassword_SignUp.SelectedText = "";
            this.txtPassword_SignUp.ShadowDecoration.Parent = this.txtPassword_SignUp;
            this.txtPassword_SignUp.Size = new System.Drawing.Size(240, 44);
            this.txtPassword_SignUp.TabIndex = 2;
            this.txtPassword_SignUp.UseSystemPasswordChar = true;
            // 
            // txtUsername_SignUp
            // 
            this.txtUsername_SignUp.Animated = true;
            this.txtUsername_SignUp.BorderRadius = 8;
            this.txtUsername_SignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionPanel.SetDecoration(this.txtUsername_SignUp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtUsername_SignUp.DefaultText = "";
            this.txtUsername_SignUp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername_SignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername_SignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername_SignUp.DisabledState.Parent = this.txtUsername_SignUp;
            this.txtUsername_SignUp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername_SignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtUsername_SignUp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername_SignUp.FocusedState.Parent = this.txtUsername_SignUp;
            this.txtUsername_SignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername_SignUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername_SignUp.HoverState.Parent = this.txtUsername_SignUp;
            this.txtUsername_SignUp.Location = new System.Drawing.Point(75, 150);
            this.txtUsername_SignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername_SignUp.Name = "txtUsername_SignUp";
            this.txtUsername_SignUp.PasswordChar = '\0';
            this.txtUsername_SignUp.PlaceholderText = "Usename";
            this.txtUsername_SignUp.SelectedText = "";
            this.txtUsername_SignUp.ShadowDecoration.Parent = this.txtUsername_SignUp;
            this.txtUsername_SignUp.Size = new System.Drawing.Size(240, 44);
            this.txtUsername_SignUp.TabIndex = 1;
            // 
            // dragControl
            // 
            this.dragControl.ContainerControl = this;
            this.dragControl.TargetControl = this.pnlTitleBar;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitleBar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.pnlTitleBar.Controls.Add(this.pictureBox1);
            this.pnlTitleBar.Controls.Add(this.btnHide);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.transitionPanel.SetDecoration(this.pnlTitleBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlTitleBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(236)))), ((int)(((byte)(141)))));
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.ShadowDecoration.Parent = this.pnlTitleBar;
            this.pnlTitleBar.Size = new System.Drawing.Size(864, 39);
            this.pnlTitleBar.TabIndex = 50;
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.transitionPanel.SetDecoration(this.btnHide, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnHide.FillColor = System.Drawing.Color.Transparent;
            this.btnHide.HoverState.Parent = this.btnHide;
            this.btnHide.IconColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(763, 2);
            this.btnHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHide.Name = "btnHide";
            this.btnHide.ShadowDecoration.Parent = this.btnHide;
            this.btnHide.Size = new System.Drawing.Size(45, 30);
            this.btnHide.TabIndex = 51;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.transitionPanel.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(813, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(37, 30);
            this.btnExit.TabIndex = 52;
            // 
            // transitionPanel
            // 
            this.transitionPanel.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.transitionPanel.DefaultAnimation = animation2;
            // 
            // pnlForgetPass
            // 
            this.pnlForgetPass.BackColor = System.Drawing.Color.Transparent;
            this.pnlForgetPass.BorderRadius = 30;
            this.pnlForgetPass.Controls.Add(this.lbCountDown);
            this.pnlForgetPass.Controls.Add(this.checkBox);
            this.pnlForgetPass.Controls.Add(this.lblBack);
            this.pnlForgetPass.Controls.Add(this.btnCheckEmail);
            this.pnlForgetPass.Controls.Add(this.label1);
            this.pnlForgetPass.Controls.Add(this.txtCheckEmail);
            this.pnlForgetPass.Controls.Add(this.label2);
            this.pnlForgetPass.Controls.Add(this.txtRePassForget);
            this.pnlForgetPass.Controls.Add(this.btnConfirm);
            this.pnlForgetPass.Controls.Add(this.txtPassForget);
            this.pnlForgetPass.Controls.Add(this.txtValidateCode);
            this.transitionPanel.SetDecoration(this.pnlForgetPass, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlForgetPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(236)))), ((int)(((byte)(141)))));
            this.pnlForgetPass.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(236)))), ((int)(((byte)(141)))));
            this.pnlForgetPass.Location = new System.Drawing.Point(251, 71);
            this.pnlForgetPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlForgetPass.Name = "pnlForgetPass";
            this.pnlForgetPass.ShadowDecoration.Parent = this.pnlForgetPass;
            this.pnlForgetPass.Size = new System.Drawing.Size(389, 385);
            this.pnlForgetPass.TabIndex = 51;
            this.pnlForgetPass.Visible = false;
            // 
            // lbCountDown
            // 
            this.lbCountDown.AutoSize = true;
            this.transitionPanel.SetDecoration(this.lbCountDown, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbCountDown.Location = new System.Drawing.Point(156, 73);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(79, 17);
            this.lbCountDown.TabIndex = 16;
            this.lbCountDown.Text = "Please wait";
            this.lbCountDown.Visible = false;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.transitionPanel.SetDecoration(this.checkBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.checkBox.Location = new System.Drawing.Point(445, 409);
            this.checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(56, 21);
            this.checkBox.TabIndex = 15;
            this.checkBox.Text = "SSL";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.Visible = false;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.transitionPanel.SetDecoration(this.lblBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.SystemColors.Info;
            this.lblBack.Location = new System.Drawing.Point(21, 263);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(47, 20);
            this.lblBack.TabIndex = 14;
            this.lblBack.Text = "Back";
            this.lblBack.Visible = false;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // btnCheckEmail
            // 
            this.btnCheckEmail.AutoRoundedCorners = true;
            this.btnCheckEmail.BorderRadius = 22;
            this.btnCheckEmail.CheckedState.Parent = this.btnCheckEmail;
            this.btnCheckEmail.CustomImages.Parent = this.btnCheckEmail;
            this.transitionPanel.SetDecoration(this.btnCheckEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCheckEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.btnCheckEmail.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.btnCheckEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckEmail.ForeColor = System.Drawing.Color.White;
            this.btnCheckEmail.HoverState.Parent = this.btnCheckEmail;
            this.btnCheckEmail.Location = new System.Drawing.Point(105, 250);
            this.btnCheckEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckEmail.Name = "btnCheckEmail";
            this.btnCheckEmail.ShadowDecoration.Parent = this.btnCheckEmail;
            this.btnCheckEmail.Size = new System.Drawing.Size(181, 46);
            this.btnCheckEmail.TabIndex = 13;
            this.btnCheckEmail.Text = "Check Email";
            this.btnCheckEmail.Click += new System.EventHandler(this.btnCheckEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.transitionPanel.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Forget Password";
            // 
            // txtCheckEmail
            // 
            this.txtCheckEmail.Animated = true;
            this.txtCheckEmail.BorderRadius = 8;
            this.txtCheckEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionPanel.SetDecoration(this.txtCheckEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtCheckEmail.DefaultText = "";
            this.txtCheckEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCheckEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCheckEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCheckEmail.DisabledState.Parent = this.txtCheckEmail;
            this.txtCheckEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCheckEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtCheckEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCheckEmail.FocusedState.Parent = this.txtCheckEmail;
            this.txtCheckEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCheckEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCheckEmail.HoverState.Parent = this.txtCheckEmail;
            this.txtCheckEmail.Location = new System.Drawing.Point(77, 161);
            this.txtCheckEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckEmail.Name = "txtCheckEmail";
            this.txtCheckEmail.PasswordChar = '\0';
            this.txtCheckEmail.PlaceholderText = "Email";
            this.txtCheckEmail.SelectedText = "";
            this.txtCheckEmail.ShadowDecoration.Parent = this.txtCheckEmail;
            this.txtCheckEmail.Size = new System.Drawing.Size(240, 44);
            this.txtCheckEmail.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.transitionPanel.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(321, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Log in";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRePassForget
            // 
            this.txtRePassForget.Animated = true;
            this.txtRePassForget.BorderRadius = 8;
            this.txtRePassForget.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionPanel.SetDecoration(this.txtRePassForget, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtRePassForget.DefaultText = "";
            this.txtRePassForget.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRePassForget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRePassForget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRePassForget.DisabledState.Parent = this.txtRePassForget;
            this.txtRePassForget.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRePassForget.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtRePassForget.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRePassForget.FocusedState.Parent = this.txtRePassForget;
            this.txtRePassForget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRePassForget.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRePassForget.HoverState.Parent = this.txtRePassForget;
            this.txtRePassForget.Location = new System.Drawing.Point(77, 161);
            this.txtRePassForget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRePassForget.Name = "txtRePassForget";
            this.txtRePassForget.PasswordChar = '\0';
            this.txtRePassForget.PlaceholderText = "Re-password";
            this.txtRePassForget.SelectedText = "";
            this.txtRePassForget.ShadowDecoration.Parent = this.txtRePassForget;
            this.txtRePassForget.Size = new System.Drawing.Size(240, 44);
            this.txtRePassForget.TabIndex = 3;
            this.txtRePassForget.UseSystemPasswordChar = true;
            this.txtRePassForget.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoRoundedCorners = true;
            this.btnConfirm.BorderRadius = 22;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.transitionPanel.SetDecoration(this.btnConfirm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.btnConfirm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(77, 286);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(240, 46);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtPassForget
            // 
            this.txtPassForget.Animated = true;
            this.txtPassForget.BorderRadius = 8;
            this.txtPassForget.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionPanel.SetDecoration(this.txtPassForget, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtPassForget.DefaultText = "";
            this.txtPassForget.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassForget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassForget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassForget.DisabledState.Parent = this.txtPassForget;
            this.txtPassForget.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassForget.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtPassForget.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassForget.FocusedState.Parent = this.txtPassForget;
            this.txtPassForget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassForget.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassForget.HoverState.Parent = this.txtPassForget;
            this.txtPassForget.Location = new System.Drawing.Point(77, 102);
            this.txtPassForget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassForget.Name = "txtPassForget";
            this.txtPassForget.PasswordChar = '\0';
            this.txtPassForget.PlaceholderText = "Password";
            this.txtPassForget.SelectedText = "";
            this.txtPassForget.ShadowDecoration.Parent = this.txtPassForget;
            this.txtPassForget.Size = new System.Drawing.Size(240, 44);
            this.txtPassForget.TabIndex = 2;
            this.txtPassForget.UseSystemPasswordChar = true;
            this.txtPassForget.Visible = false;
            // 
            // txtValidateCode
            // 
            this.txtValidateCode.Animated = true;
            this.txtValidateCode.BorderRadius = 8;
            this.txtValidateCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionPanel.SetDecoration(this.txtValidateCode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtValidateCode.DefaultText = "";
            this.txtValidateCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValidateCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValidateCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValidateCode.DisabledState.Parent = this.txtValidateCode;
            this.txtValidateCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValidateCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtValidateCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValidateCode.FocusedState.Parent = this.txtValidateCode;
            this.txtValidateCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValidateCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValidateCode.HoverState.Parent = this.txtValidateCode;
            this.txtValidateCode.Location = new System.Drawing.Point(77, 217);
            this.txtValidateCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValidateCode.Name = "txtValidateCode";
            this.txtValidateCode.PasswordChar = '\0';
            this.txtValidateCode.PlaceholderText = "Validate-Code";
            this.txtValidateCode.SelectedText = "";
            this.txtValidateCode.ShadowDecoration.Parent = this.txtValidateCode;
            this.txtValidateCode.Size = new System.Drawing.Size(240, 44);
            this.txtValidateCode.TabIndex = 1;
            this.txtValidateCode.Visible = false;
            // 
            // countDown
            // 
            this.countDown.Interval = 5000;
            this.countDown.Tick += new System.EventHandler(this.countDown_Tick);
            // 
            // countDownText
            // 
            this.countDownText.Interval = 1000;
            this.countDownText.Tick += new System.EventHandler(this.countDownText_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.transitionPanel.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 39);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // UserAccessForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 610);
            this.Controls.Add(this.pnlForgetPass);
            this.Controls.Add(this.pnlSignup);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlUserLogin);
            this.transitionPanel.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserAccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocabulary Up";
            this.pnlUserLogin.ResumeLayout(false);
            this.pnlUserLogin.PerformLayout();
            this.pnlSignup.ResumeLayout(false);
            this.pnlSignup.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlForgetPass.ResumeLayout(false);
            this.pnlForgetPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlUserLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUsename_Login;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword_Login;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreateAccount_Login;
        private System.Windows.Forms.Label lbNoAccount_Login;
        private System.Windows.Forms.Label lbRemember_Login;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swRemember_Login;
        private Guna.UI2.WinForms.Guna2Panel pnlTitleBar;
        private Guna.UI2.WinForms.Guna2ControlBox btnHide;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private System.Windows.Forms.Label lbUserLogin;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2AnimateWindow animateWindow;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlSignup;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail_SignUp;
        private System.Windows.Forms.Label lbLoginAccess_SignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtRePassword_SignUp;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreateAccount_SignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword_SignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername_SignUp;
        private Guna.UI2.WinForms.Guna2Transition transitionPanel;
        private System.Windows.Forms.Label lbSignup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlForgetPass;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheckEmail;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtCheckEmail;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtRePassForget;
        private Guna.UI2.WinForms.Guna2GradientButton btnConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtPassForget;
        private Guna.UI2.WinForms.Guna2TextBox txtValidateCode;
        private System.Windows.Forms.Label lbForget;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Timer countDown;
        private System.Windows.Forms.Label lbCountDown;
        private System.Windows.Forms.Timer countDownText;
    }
}