namespace HumphreyErik18MultiplicationMaestro
{
    partial class frmMathQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMathQuiz));
            this.lblTitleMultiplication = new System.Windows.Forms.Label();
            this.lblTitleMaestro = new System.Windows.Forms.Label();
            this.prgTimeRemaining = new System.Windows.Forms.ProgressBar();
            this.lblFirstFactor = new System.Windows.Forms.Label();
            this.lblSecondFactor = new System.Windows.Forms.Label();
            this.lblCombo = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.txtUserProductAnswer = new System.Windows.Forms.TextBox();
            this.lblMultiplicationSign = new System.Windows.Forms.Label();
            this.lblEqualsSign = new System.Windows.Forms.Label();
            this.btnStartGameGiveUp = new System.Windows.Forms.Button();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.txtUserInitialsEntry = new System.Windows.Forms.TextBox();
            this.tmrTimeRemaining = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentAccuracy = new System.Windows.Forms.Label();
            this.lblGameDescription = new System.Windows.Forms.Label();
            this.tmrComboDecay = new System.Windows.Forms.Timer(this.components);
            this.lvwScoreTable = new System.Windows.Forms.ListView();
            this.clhScores = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhInitial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prgComboDecay = new System.Windows.Forms.ProgressBar();
            this.lblTheAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleMultiplication
            // 
            this.lblTitleMultiplication.AutoSize = true;
            this.lblTitleMultiplication.Font = new System.Drawing.Font("Myriad Web Pro", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMultiplication.Location = new System.Drawing.Point(7, 9);
            this.lblTitleMultiplication.Name = "lblTitleMultiplication";
            this.lblTitleMultiplication.Size = new System.Drawing.Size(104, 17);
            this.lblTitleMultiplication.TabIndex = 0;
            this.lblTitleMultiplication.Text = "Multiplication";
            // 
            // lblTitleMaestro
            // 
            this.lblTitleMaestro.AutoSize = true;
            this.lblTitleMaestro.Font = new System.Drawing.Font("Myriad Web Pro", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMaestro.Location = new System.Drawing.Point(4, 22);
            this.lblTitleMaestro.Name = "lblTitleMaestro";
            this.lblTitleMaestro.Size = new System.Drawing.Size(124, 33);
            this.lblTitleMaestro.TabIndex = 1;
            this.lblTitleMaestro.Text = "Maestro";
            // 
            // prgTimeRemaining
            // 
            this.prgTimeRemaining.Location = new System.Drawing.Point(23, 190);
            this.prgTimeRemaining.MarqueeAnimationSpeed = 500;
            this.prgTimeRemaining.Maximum = 360;
            this.prgTimeRemaining.Name = "prgTimeRemaining";
            this.prgTimeRemaining.Size = new System.Drawing.Size(380, 12);
            this.prgTimeRemaining.TabIndex = 2;
            this.prgTimeRemaining.Value = 300;
            // 
            // lblFirstFactor
            // 
            this.lblFirstFactor.AutoSize = true;
            this.lblFirstFactor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFirstFactor.Font = new System.Drawing.Font("Myriad Web Pro", 48F);
            this.lblFirstFactor.Location = new System.Drawing.Point(29, 91);
            this.lblFirstFactor.Name = "lblFirstFactor";
            this.lblFirstFactor.Size = new System.Drawing.Size(60, 73);
            this.lblFirstFactor.TabIndex = 3;
            this.lblFirstFactor.Text = "  ";
            // 
            // lblSecondFactor
            // 
            this.lblSecondFactor.AutoSize = true;
            this.lblSecondFactor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSecondFactor.Font = new System.Drawing.Font("Myriad Web Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondFactor.Location = new System.Drawing.Point(130, 91);
            this.lblSecondFactor.Name = "lblSecondFactor";
            this.lblSecondFactor.Size = new System.Drawing.Size(60, 73);
            this.lblSecondFactor.TabIndex = 4;
            this.lblSecondFactor.Text = "  ";
            // 
            // lblCombo
            // 
            this.lblCombo.AutoSize = true;
            this.lblCombo.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo.ForeColor = System.Drawing.Color.Red;
            this.lblCombo.Location = new System.Drawing.Point(106, 57);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(173, 20);
            this.lblCombo.TabIndex = 5;
            this.lblCombo.Text = "WICKED SICK COMBO";
            this.lblCombo.Visible = false;
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Location = new System.Drawing.Point(20, 173);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(81, 13);
            this.lblTimeRemaining.TabIndex = 6;
            this.lblTimeRemaining.Text = "Time remaining:";
            // 
            // txtUserProductAnswer
            // 
            this.txtUserProductAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserProductAnswer.Enabled = false;
            this.txtUserProductAnswer.Font = new System.Drawing.Font("Myriad Web Pro", 48F);
            this.txtUserProductAnswer.Location = new System.Drawing.Point(248, 88);
            this.txtUserProductAnswer.MaxLength = 2;
            this.txtUserProductAnswer.Name = "txtUserProductAnswer";
            this.txtUserProductAnswer.Size = new System.Drawing.Size(113, 73);
            this.txtUserProductAnswer.TabIndex = 8;
            this.txtUserProductAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserProductAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserProductAnswer_KeyPress);
            // 
            // lblMultiplicationSign
            // 
            this.lblMultiplicationSign.AutoSize = true;
            this.lblMultiplicationSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplicationSign.Location = new System.Drawing.Point(86, 100);
            this.lblMultiplicationSign.Name = "lblMultiplicationSign";
            this.lblMultiplicationSign.Size = new System.Drawing.Size(52, 55);
            this.lblMultiplicationSign.TabIndex = 9;
            this.lblMultiplicationSign.Text = "×";
            this.lblMultiplicationSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEqualsSign
            // 
            this.lblEqualsSign.AutoSize = true;
            this.lblEqualsSign.Font = new System.Drawing.Font("Myriad Web Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqualsSign.Location = new System.Drawing.Point(187, 88);
            this.lblEqualsSign.Name = "lblEqualsSign";
            this.lblEqualsSign.Size = new System.Drawing.Size(70, 73);
            this.lblEqualsSign.TabIndex = 10;
            this.lblEqualsSign.Text = "=";
            // 
            // btnStartGameGiveUp
            // 
            this.btnStartGameGiveUp.Enabled = false;
            this.btnStartGameGiveUp.Location = new System.Drawing.Point(211, 25);
            this.btnStartGameGiveUp.Name = "btnStartGameGiveUp";
            this.btnStartGameGiveUp.Size = new System.Drawing.Size(75, 23);
            this.btnStartGameGiveUp.TabIndex = 11;
            this.btnStartGameGiveUp.Text = "Start game";
            this.btnStartGameGiveUp.UseVisualStyleBackColor = true;
            this.btnStartGameGiveUp.Click += new System.EventHandler(this.btnStartGameGiveUp_Click);
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Location = new System.Drawing.Point(319, 15);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(47, 13);
            this.lblCurrentScore.TabIndex = 13;
            this.lblCurrentScore.Text = "Score: 0";
            // 
            // txtUserInitialsEntry
            // 
            this.txtUserInitialsEntry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserInitialsEntry.Font = new System.Drawing.Font("Myriad Web Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserInitialsEntry.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUserInitialsEntry.Location = new System.Drawing.Point(134, 25);
            this.txtUserInitialsEntry.MaxLength = 3;
            this.txtUserInitialsEntry.Name = "txtUserInitialsEntry";
            this.txtUserInitialsEntry.Size = new System.Drawing.Size(71, 26);
            this.txtUserInitialsEntry.TabIndex = 14;
            this.txtUserInitialsEntry.Text = "INITIALS";
            this.txtUserInitialsEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserInitialsEntry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserInitialsEntry_MouseClick);
            this.txtUserInitialsEntry.TextChanged += new System.EventHandler(this.txtUserInitialsEntry_TextChanged);
            this.txtUserInitialsEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserInitialsEntry_KeyDown);
            this.txtUserInitialsEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserInitialsEntry_KeyPress);
            // 
            // tmrTimeRemaining
            // 
            this.tmrTimeRemaining.Tick += new System.EventHandler(this.tmrTimeRemaining_Tick);
            // 
            // lblCurrentAccuracy
            // 
            this.lblCurrentAccuracy.AutoSize = true;
            this.lblCurrentAccuracy.Location = new System.Drawing.Point(319, 28);
            this.lblCurrentAccuracy.Name = "lblCurrentAccuracy";
            this.lblCurrentAccuracy.Size = new System.Drawing.Size(72, 13);
            this.lblCurrentAccuracy.TabIndex = 20;
            this.lblCurrentAccuracy.Text = "Accuracy: 0%";
            // 
            // lblGameDescription
            // 
            this.lblGameDescription.AutoSize = true;
            this.lblGameDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameDescription.Location = new System.Drawing.Point(131, 9);
            this.lblGameDescription.Name = "lblGameDescription";
            this.lblGameDescription.Size = new System.Drawing.Size(168, 13);
            this.lblGameDescription.TabIndex = 21;
            this.lblGameDescription.Text = "Race against the clock with math!";
            // 
            // tmrComboDecay
            // 
            this.tmrComboDecay.Tick += new System.EventHandler(this.tmrComboDecay_Tick);
            // 
            // lvwScoreTable
            // 
            this.lvwScoreTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwScoreTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhScores,
            this.clhInitial});
            this.lvwScoreTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvwScoreTable.FullRowSelect = true;
            this.lvwScoreTable.LabelWrap = false;
            this.lvwScoreTable.Location = new System.Drawing.Point(411, 0);
            this.lvwScoreTable.Margin = new System.Windows.Forms.Padding(0);
            this.lvwScoreTable.MaximumSize = new System.Drawing.Size(84, 214);
            this.lvwScoreTable.MinimumSize = new System.Drawing.Size(84, 214);
            this.lvwScoreTable.MultiSelect = false;
            this.lvwScoreTable.Name = "lvwScoreTable";
            this.lvwScoreTable.Scrollable = false;
            this.lvwScoreTable.Size = new System.Drawing.Size(84, 214);
            this.lvwScoreTable.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvwScoreTable.TabIndex = 26;
            this.lvwScoreTable.UseCompatibleStateImageBehavior = false;
            this.lvwScoreTable.View = System.Windows.Forms.View.Details;
            // 
            // clhScores
            // 
            this.clhScores.Text = "Score";
            this.clhScores.Width = 41;
            // 
            // clhInitial
            // 
            this.clhInitial.Text = "Initials";
            this.clhInitial.Width = 41;
            // 
            // prgComboDecay
            // 
            this.prgComboDecay.Location = new System.Drawing.Point(110, 76);
            this.prgComboDecay.Name = "prgComboDecay";
            this.prgComboDecay.Size = new System.Drawing.Size(166, 6);
            this.prgComboDecay.TabIndex = 27;
            this.prgComboDecay.Value = 100;
            this.prgComboDecay.Visible = false;
            // 
            // lblTheAnswer
            // 
            this.lblTheAnswer.AutoSize = true;
            this.lblTheAnswer.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTheAnswer.Location = new System.Drawing.Point(250, 171);
            this.lblTheAnswer.Name = "lblTheAnswer";
            this.lblTheAnswer.Size = new System.Drawing.Size(91, 13);
            this.lblTheAnswer.TabIndex = 28;
            this.lblTheAnswer.Text = "The answer was: ";
            this.lblTheAnswer.Visible = false;
            // 
            // frmMathQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 214);
            this.Controls.Add(this.lblTheAnswer);
            this.Controls.Add(this.prgComboDecay);
            this.Controls.Add(this.lvwScoreTable);
            this.Controls.Add(this.lblFirstFactor);
            this.Controls.Add(this.lblSecondFactor);
            this.Controls.Add(this.lblGameDescription);
            this.Controls.Add(this.txtUserInitialsEntry);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.btnStartGameGiveUp);
            this.Controls.Add(this.txtUserProductAnswer);
            this.Controls.Add(this.lblEqualsSign);
            this.Controls.Add(this.lblMultiplicationSign);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblCombo);
            this.Controls.Add(this.prgTimeRemaining);
            this.Controls.Add(this.lblTitleMultiplication);
            this.Controls.Add(this.lblTitleMaestro);
            this.Controls.Add(this.lblCurrentAccuracy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 252);
            this.Name = "frmMathQuiz";
            this.Text = "Multiplication Maestro";
            this.Load += new System.EventHandler(this.frmMathQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleMultiplication;
        private System.Windows.Forms.Label lblTitleMaestro;
        private System.Windows.Forms.ProgressBar prgTimeRemaining;
        private System.Windows.Forms.Label lblFirstFactor;
        private System.Windows.Forms.Label lblSecondFactor;
        private System.Windows.Forms.Label lblCombo;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.TextBox txtUserProductAnswer;
        private System.Windows.Forms.Label lblMultiplicationSign;
        private System.Windows.Forms.Label lblEqualsSign;
        private System.Windows.Forms.Button btnStartGameGiveUp;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.TextBox txtUserInitialsEntry;
        private System.Windows.Forms.Timer tmrTimeRemaining;
        private System.Windows.Forms.Label lblCurrentAccuracy;
        private System.Windows.Forms.Label lblGameDescription;
        private System.Windows.Forms.Timer tmrComboDecay;
        private System.Windows.Forms.ListView lvwScoreTable;
        private System.Windows.Forms.ColumnHeader clhScores;
        private System.Windows.Forms.ColumnHeader clhInitial;
        private System.Windows.Forms.ProgressBar prgComboDecay;
        private System.Windows.Forms.Label lblTheAnswer;
    }
}

