namespace LoginForm
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnLogin = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txbUsename = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btCreateAccount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnSignup = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btCreate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txbPassword_Signup = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbUsename_Signup = new Guna.UI2.WinForms.Guna2TextBox();
            this.bxtPasswordAgain_sginup = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.lbSignup = new System.Windows.Forms.Label();
            this.pnLogin.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnLogin.Controls.Add(this.label4);
            this.pnLogin.Controls.Add(this.label3);
            this.pnLogin.Controls.Add(this.guna2ToggleSwitch1);
            this.pnLogin.Controls.Add(this.label2);
            this.pnLogin.Controls.Add(this.label1);
            this.pnLogin.Controls.Add(this.btCreateAccount);
            this.pnLogin.Controls.Add(this.btLogin);
            this.pnLogin.Controls.Add(this.txbPassword);
            this.pnLogin.Controls.Add(this.txbUsename);
            this.guna2Transition1.SetDecoration(this.pnLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnLogin.Location = new System.Drawing.Point(231, 114);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.ShadowDecoration.Parent = this.pnLogin;
            this.pnLogin.Size = new System.Drawing.Size(389, 416);
            this.pnLogin.TabIndex = 0;
            // 
            // txbUsename
            // 
            this.txbUsename.Animated = true;
            this.txbUsename.BorderRadius = 8;
            this.txbUsename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txbUsename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txbUsename.DefaultText = "";
            this.txbUsename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbUsename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbUsename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsename.DisabledState.Parent = this.txbUsename;
            this.txbUsename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsename.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txbUsename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsename.FocusedState.Parent = this.txbUsename;
            this.txbUsename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbUsename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsename.HoverState.Parent = this.txbUsename;
            this.txbUsename.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbUsename.IconLeft")));
            this.txbUsename.Location = new System.Drawing.Point(74, 89);
            this.txbUsename.Name = "txbUsename";
            this.txbUsename.PasswordChar = '\0';
            this.txbUsename.PlaceholderText = "Usename";
            this.txbUsename.SelectedText = "";
            this.txbUsename.ShadowDecoration.Parent = this.txbUsename;
            this.txbUsename.Size = new System.Drawing.Size(240, 44);
            this.txbUsename.TabIndex = 0;
            this.txbUsename.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // txbPassword
            // 
            this.txbPassword.Animated = true;
            this.txbPassword.BorderRadius = 8;
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txbPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txbPassword.DefaultText = "";
            this.txbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword.DisabledState.Parent = this.txbPassword;
            this.txbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPassword.FocusedState.Parent = this.txbPassword;
            this.txbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPassword.HoverState.Parent = this.txbPassword;
            this.txbPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbPassword.IconLeft")));
            this.txbPassword.Location = new System.Drawing.Point(74, 150);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '\0';
            this.txbPassword.PlaceholderText = "Password";
            this.txbPassword.SelectedText = "";
            this.txbPassword.ShadowDecoration.Parent = this.txbPassword;
            this.txbPassword.Size = new System.Drawing.Size(240, 44);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.UseSystemPasswordChar = true;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // btLogin
            // 
            this.btLogin.AutoRoundedCorners = true;
            this.btLogin.BorderRadius = 21;
            this.btLogin.CheckedState.Parent = this.btLogin;
            this.btLogin.CustomImages.Parent = this.btLogin;
            this.guna2Transition1.SetDecoration(this.btLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.HoverState.Parent = this.btLogin;
            this.btLogin.Location = new System.Drawing.Point(74, 235);
            this.btLogin.Name = "btLogin";
            this.btLogin.ShadowDecoration.Parent = this.btLogin;
            this.btLogin.Size = new System.Drawing.Size(240, 45);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCreateAccount
            // 
            this.btCreateAccount.AutoRoundedCorners = true;
            this.btCreateAccount.BorderRadius = 21;
            this.btCreateAccount.CheckedState.Parent = this.btCreateAccount;
            this.btCreateAccount.CustomImages.Parent = this.btCreateAccount;
            this.guna2Transition1.SetDecoration(this.btCreateAccount, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btCreateAccount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btCreateAccount.HoverState.Parent = this.btCreateAccount;
            this.btCreateAccount.Location = new System.Drawing.Point(74, 330);
            this.btCreateAccount.Name = "btCreateAccount";
            this.btCreateAccount.ShadowDecoration.Parent = this.btCreateAccount;
            this.btCreateAccount.Size = new System.Drawing.Size(240, 45);
            this.btCreateAccount.TabIndex = 3;
            this.btCreateAccount.Text = "Create Account";
            this.btCreateAccount.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(83, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Don\'t have an account ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(241, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sign up here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2Transition1.SetDecoration(this.guna2ToggleSwitch1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(74, 209);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(40, 21);
            this.guna2ToggleSwitch1.TabIndex = 6;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(120, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Remember me";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "User Login";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(864, 39);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(814, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(38, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(763, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // pnSignup
            // 
            this.pnSignup.BackColor = System.Drawing.Color.Transparent;
            this.pnSignup.Controls.Add(this.lbSignup);
            this.pnSignup.Controls.Add(this.txbEmail);
            this.pnSignup.Controls.Add(this.label6);
            this.pnSignup.Controls.Add(this.bxtPasswordAgain_sginup);
            this.pnSignup.Controls.Add(this.btCreate);
            this.pnSignup.Controls.Add(this.txbPassword_Signup);
            this.pnSignup.Controls.Add(this.txbUsename_Signup);
            this.guna2Transition1.SetDecoration(this.pnSignup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnSignup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnSignup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnSignup.Location = new System.Drawing.Point(231, 114);
            this.pnSignup.Name = "pnSignup";
            this.pnSignup.ShadowDecoration.Parent = this.pnSignup;
            this.pnSignup.Size = new System.Drawing.Size(389, 416);
            this.pnSignup.TabIndex = 2;
            this.pnSignup.Visible = false;
            // 
            // btCreate
            // 
            this.btCreate.AutoRoundedCorners = true;
            this.btCreate.BorderRadius = 21;
            this.btCreate.CheckedState.Parent = this.btCreate;
            this.btCreate.CustomImages.Parent = this.btCreate;
            this.guna2Transition1.SetDecoration(this.btCreate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btCreate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.ForeColor = System.Drawing.Color.White;
            this.btCreate.HoverState.Parent = this.btCreate;
            this.btCreate.Location = new System.Drawing.Point(74, 330);
            this.btCreate.Name = "btCreate";
            this.btCreate.ShadowDecoration.Parent = this.btCreate;
            this.btCreate.Size = new System.Drawing.Size(240, 45);
            this.btCreate.TabIndex = 2;
            this.btCreate.Text = "Creata Account";
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // txbPassword_Signup
            // 
            this.txbPassword_Signup.Animated = true;
            this.txbPassword_Signup.BorderRadius = 8;
            this.txbPassword_Signup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txbPassword_Signup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txbPassword_Signup.DefaultText = "";
            this.txbPassword_Signup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPassword_Signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPassword_Signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword_Signup.DisabledState.Parent = this.txbPassword_Signup;
            this.txbPassword_Signup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword_Signup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txbPassword_Signup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPassword_Signup.FocusedState.Parent = this.txbPassword_Signup;
            this.txbPassword_Signup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbPassword_Signup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPassword_Signup.HoverState.Parent = this.txbPassword_Signup;
            this.txbPassword_Signup.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbPassword_Signup.IconLeft")));
            this.txbPassword_Signup.Location = new System.Drawing.Point(74, 209);
            this.txbPassword_Signup.Name = "txbPassword_Signup";
            this.txbPassword_Signup.PasswordChar = '\0';
            this.txbPassword_Signup.PlaceholderText = "Password";
            this.txbPassword_Signup.SelectedText = "";
            this.txbPassword_Signup.ShadowDecoration.Parent = this.txbPassword_Signup;
            this.txbPassword_Signup.Size = new System.Drawing.Size(240, 44);
            this.txbPassword_Signup.TabIndex = 1;
            this.txbPassword_Signup.UseSystemPasswordChar = true;
            // 
            // txbUsename_Signup
            // 
            this.txbUsename_Signup.Animated = true;
            this.txbUsename_Signup.BorderRadius = 8;
            this.txbUsename_Signup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txbUsename_Signup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txbUsename_Signup.DefaultText = "";
            this.txbUsename_Signup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbUsename_Signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbUsename_Signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsename_Signup.DisabledState.Parent = this.txbUsename_Signup;
            this.txbUsename_Signup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsename_Signup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txbUsename_Signup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsename_Signup.FocusedState.Parent = this.txbUsename_Signup;
            this.txbUsename_Signup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbUsename_Signup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsename_Signup.HoverState.Parent = this.txbUsename_Signup;
            this.txbUsename_Signup.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbUsename_Signup.IconLeft")));
            this.txbUsename_Signup.Location = new System.Drawing.Point(74, 150);
            this.txbUsename_Signup.Name = "txbUsename_Signup";
            this.txbUsename_Signup.PasswordChar = '\0';
            this.txbUsename_Signup.PlaceholderText = "Usename";
            this.txbUsename_Signup.SelectedText = "";
            this.txbUsename_Signup.ShadowDecoration.Parent = this.txbUsename_Signup;
            this.txbUsename_Signup.Size = new System.Drawing.Size(240, 44);
            this.txbUsename_Signup.TabIndex = 0;
            // 
            // bxtPasswordAgain_sginup
            // 
            this.bxtPasswordAgain_sginup.Animated = true;
            this.bxtPasswordAgain_sginup.BorderRadius = 8;
            this.bxtPasswordAgain_sginup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.bxtPasswordAgain_sginup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.bxtPasswordAgain_sginup.DefaultText = "";
            this.bxtPasswordAgain_sginup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bxtPasswordAgain_sginup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bxtPasswordAgain_sginup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bxtPasswordAgain_sginup.DisabledState.Parent = this.bxtPasswordAgain_sginup;
            this.bxtPasswordAgain_sginup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bxtPasswordAgain_sginup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.bxtPasswordAgain_sginup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bxtPasswordAgain_sginup.FocusedState.Parent = this.bxtPasswordAgain_sginup;
            this.bxtPasswordAgain_sginup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bxtPasswordAgain_sginup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bxtPasswordAgain_sginup.HoverState.Parent = this.bxtPasswordAgain_sginup;
            this.bxtPasswordAgain_sginup.IconLeft = ((System.Drawing.Image)(resources.GetObject("bxtPasswordAgain_sginup.IconLeft")));
            this.bxtPasswordAgain_sginup.Location = new System.Drawing.Point(74, 271);
            this.bxtPasswordAgain_sginup.Name = "bxtPasswordAgain_sginup";
            this.bxtPasswordAgain_sginup.PasswordChar = '\0';
            this.bxtPasswordAgain_sginup.PlaceholderText = "Password";
            this.bxtPasswordAgain_sginup.SelectedText = "";
            this.bxtPasswordAgain_sginup.ShadowDecoration.Parent = this.bxtPasswordAgain_sginup;
            this.bxtPasswordAgain_sginup.Size = new System.Drawing.Size(240, 44);
            this.bxtPasswordAgain_sginup.TabIndex = 9;
            this.bxtPasswordAgain_sginup.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(259, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Log in";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Animated = true;
            this.txbEmail.BorderRadius = 8;
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.txbEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txbEmail.DefaultText = "";
            this.txbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.DisabledState.Parent = this.txbEmail;
            this.txbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.FocusedState.Parent = this.txbEmail;
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.HoverState.Parent = this.txbEmail;
            this.txbEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbEmail.IconLeft")));
            this.txbEmail.Location = new System.Drawing.Point(74, 89);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PlaceholderText = "Email";
            this.txbEmail.SelectedText = "";
            this.txbEmail.ShadowDecoration.Parent = this.txbEmail;
            this.txbEmail.Size = new System.Drawing.Size(240, 44);
            this.txbEmail.TabIndex = 11;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation3;
            // 
            // lbSignup
            // 
            this.lbSignup.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbSignup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbSignup.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignup.Location = new System.Drawing.Point(126, 34);
            this.lbSignup.Name = "lbSignup";
            this.lbSignup.Size = new System.Drawing.Size(126, 37);
            this.lbSignup.TabIndex = 12;
            this.lbSignup.Text = "Sign Up";
            // 
            // Login
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 611);
            this.Controls.Add(this.pnSignup);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnLogin);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.pnSignup.ResumeLayout(false);
            this.pnSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txbUsename;
        private Guna.UI2.WinForms.Guna2TextBox txbPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btLogin;
        private Guna.UI2.WinForms.Guna2GradientButton btCreateAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnSignup;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox bxtPasswordAgain_sginup;
        private Guna.UI2.WinForms.Guna2GradientButton btCreate;
        private Guna.UI2.WinForms.Guna2TextBox txbPassword_Signup;
        private Guna.UI2.WinForms.Guna2TextBox txbUsename_Signup;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Label lbSignup;
    }
}

