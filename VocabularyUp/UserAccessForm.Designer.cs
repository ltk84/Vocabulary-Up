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
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccessForm));
            this.elipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnlUserLogin = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbUserLogin = new System.Windows.Forms.Label();
            this.lbRemember_Login = new System.Windows.Forms.Label();
            this.swRemember_Login = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lbNoAccount_Login = new System.Windows.Forms.Label();
            this.btnCreateAccount_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPassword_Login = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsename_Login = new Guna.UI2.WinForms.Guna2TextBox();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlTitleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHide = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.animateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pnlSignup = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbSignup = new System.Windows.Forms.Label();
            this.txtEmail_SignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbLoginAccess_SignUp = new System.Windows.Forms.Label();
            this.txtRePassword_SignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCreateAccount_SignUp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPassword_SignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername_SignUp = new Guna.UI2.WinForms.Guna2TextBox();
            this.transitionPanel = new Guna.UI2.WinForms.Guna2Transition();
            this.pnlUserLogin.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSignup.SuspendLayout();
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
            this.pnlUserLogin.Location = new System.Drawing.Point(231, 114);
            this.pnlUserLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUserLogin.Name = "pnlUserLogin";
            this.pnlUserLogin.ShadowDecoration.Parent = this.pnlUserLogin;
            this.pnlUserLogin.Size = new System.Drawing.Size(389, 416);
            this.pnlUserLogin.TabIndex = 33;
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
            this.lbNoAccount_Login.Location = new System.Drawing.Point(113, 310);
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
            this.btnCreateAccount_Login.Location = new System.Drawing.Point(75, 332);
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
            // dragControl
            // 
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
            this.pnlSignup.Location = new System.Drawing.Point(231, 114);
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
            this.lbSignup.Location = new System.Drawing.Point(125, 34);
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
            this.lbLoginAccess_SignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            // transitionPanel
            // 
            this.transitionPanel.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.transitionPanel.DefaultAnimation = animation3;
            // 
            // UserAccessForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(223)))), ((int)(((byte)(158)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 610);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlSignup);
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
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSignup.ResumeLayout(false);
            this.pnlSignup.PerformLayout();
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
    }
}