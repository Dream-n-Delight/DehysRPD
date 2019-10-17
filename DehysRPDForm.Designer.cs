using System;
using System.Drawing;

namespace DehysRPD
{
    partial class DehysRPDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DehysRPDForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHeaderLogo = new System.Windows.Forms.Panel();
            this.pictureboxLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMinimizeButton = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Panel();
            this.panelExitButton = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Panel();
            this.panelConfiguration = new System.Windows.Forms.Panel();
            this.lblApplicationId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textboxApplicationId = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listboxProccesses = new System.Windows.Forms.ListBox();
            this.lblSmallText = new System.Windows.Forms.Label();
            this.lblBigText = new System.Windows.Forms.Label();
            this.panelSmallPictureIndicator = new System.Windows.Forms.Panel();
            this.panelBigPictureIndicator = new System.Windows.Forms.Panel();
            this.lblSmallPicture = new System.Windows.Forms.Label();
            this.lblBigPicture = new System.Windows.Forms.Label();
            this.textboxSmallPictureText = new System.Windows.Forms.TextBox();
            this.textboxSmallPictureAsset = new System.Windows.Forms.TextBox();
            this.textboxBigPictureText = new System.Windows.Forms.TextBox();
            this.textboxBigPictureAsset = new System.Windows.Forms.TextBox();
            this.textboxState = new System.Windows.Forms.TextBox();
            this.textboxDetails = new System.Windows.Forms.TextBox();
            this.lblApplication = new System.Windows.Forms.Label();
            this.panelImagePreview = new System.Windows.Forms.Panel();
            this.lblImageSmall = new System.Windows.Forms.Label();
            this.lblImageBig = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelUpdateButton = new System.Windows.Forms.Panel();
            this.pictureboxAnimation = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelHeaderLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogo)).BeginInit();
            this.panelMinimizeButton.SuspendLayout();
            this.panelExitButton.SuspendLayout();
            this.panelConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textboxApplicationId)).BeginInit();
            this.panelImagePreview.SuspendLayout();
            this.panelUpdateButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelHeader.Controls.Add(this.panelHeaderLogo);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.panelMinimizeButton);
            this.panelHeader.Controls.Add(this.panelExitButton);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(300, 25);
            this.panelHeader.TabIndex = 0;
            // 
            // panelHeaderLogo
            // 
            this.panelHeaderLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelHeaderLogo.Controls.Add(this.pictureboxLogo);
            this.panelHeaderLogo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelHeaderLogo.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderLogo.Name = "panelHeaderLogo";
            this.panelHeaderLogo.Size = new System.Drawing.Size(30, 25);
            this.panelHeaderLogo.TabIndex = 3;
            this.panelHeaderLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onHeaderMouseMove);
            // 
            // pictureboxLogo
            // 
            this.pictureboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureboxLogo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureboxLogo.Image = global::DehysRPD.Properties.Resources.Discord;
            this.pictureboxLogo.Location = new System.Drawing.Point(4, 3);
            this.pictureboxLogo.Name = "pictureboxLogo";
            this.pictureboxLogo.Size = new System.Drawing.Size(23, 23);
            this.pictureboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxLogo.TabIndex = 0;
            this.pictureboxLogo.TabStop = false;
            this.pictureboxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onHeaderMouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Rich Presence Discord";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onHeaderMouseMove);
            // 
            // panelMinimizeButton
            // 
            this.panelMinimizeButton.BackColor = System.Drawing.Color.White;
            this.panelMinimizeButton.Controls.Add(this.btnMinimize);
            this.panelMinimizeButton.Location = new System.Drawing.Point(220, 0);
            this.panelMinimizeButton.Name = "panelMinimizeButton";
            this.panelMinimizeButton.Size = new System.Drawing.Size(40, 25);
            this.panelMinimizeButton.TabIndex = 1;
            this.panelMinimizeButton.MouseEnter += new System.EventHandler(this.onMinimizeMouseEnter);
            this.panelMinimizeButton.MouseLeave += new System.EventHandler(this.onMinimizeMouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::DehysRPD.Properties.Resources.min;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 25);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMinimizeMouseDown);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.onMinimizeMouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.onMinimizeMouseLeave);
            // 
            // panelExitButton
            // 
            this.panelExitButton.BackColor = System.Drawing.Color.White;
            this.panelExitButton.Controls.Add(this.btnExit);
            this.panelExitButton.Location = new System.Drawing.Point(260, 0);
            this.panelExitButton.Name = "panelExitButton";
            this.panelExitButton.Size = new System.Drawing.Size(40, 25);
            this.panelExitButton.TabIndex = 0;
            this.panelExitButton.MouseEnter += new System.EventHandler(this.onExitMouseEnter);
            this.panelExitButton.MouseLeave += new System.EventHandler(this.onExitMouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::DehysRPD.Properties.Resources.ex;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onExitMouseDown);
            this.btnExit.MouseEnter += new System.EventHandler(this.onExitMouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.onExitMouseLeave);
            // 
            // panelConfiguration
            // 
            this.panelConfiguration.BackColor = System.Drawing.Color.Transparent;
            this.panelConfiguration.Controls.Add(this.lblApplicationId);
            this.panelConfiguration.Controls.Add(this.panel2);
            this.panelConfiguration.Controls.Add(this.textboxApplicationId);
            this.panelConfiguration.Controls.Add(this.panel1);
            this.panelConfiguration.Controls.Add(this.label1);
            this.panelConfiguration.Controls.Add(this.listboxProccesses);
            this.panelConfiguration.Controls.Add(this.lblSmallText);
            this.panelConfiguration.Controls.Add(this.lblBigText);
            this.panelConfiguration.Controls.Add(this.panelSmallPictureIndicator);
            this.panelConfiguration.Controls.Add(this.panelBigPictureIndicator);
            this.panelConfiguration.Controls.Add(this.lblSmallPicture);
            this.panelConfiguration.Controls.Add(this.lblBigPicture);
            this.panelConfiguration.Controls.Add(this.textboxSmallPictureText);
            this.panelConfiguration.Controls.Add(this.textboxSmallPictureAsset);
            this.panelConfiguration.Controls.Add(this.textboxBigPictureText);
            this.panelConfiguration.Controls.Add(this.textboxBigPictureAsset);
            this.panelConfiguration.Controls.Add(this.textboxState);
            this.panelConfiguration.Controls.Add(this.textboxDetails);
            this.panelConfiguration.Controls.Add(this.lblApplication);
            this.panelConfiguration.Controls.Add(this.panelImagePreview);
            this.panelConfiguration.Location = new System.Drawing.Point(0, 31);
            this.panelConfiguration.Name = "panelConfiguration";
            this.panelConfiguration.Size = new System.Drawing.Size(300, 338);
            this.panelConfiguration.TabIndex = 1;
            // 
            // lblApplicationId
            // 
            this.lblApplicationId.AutoSize = true;
            this.lblApplicationId.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationId.ForeColor = System.Drawing.Color.White;
            this.lblApplicationId.Location = new System.Drawing.Point(37, 19);
            this.lblApplicationId.Name = "lblApplicationId";
            this.lblApplicationId.Size = new System.Drawing.Size(74, 13);
            this.lblApplicationId.TabIndex = 21;
            this.lblApplicationId.Text = "Application Id:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(262, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 16);
            this.panel2.TabIndex = 20;
            // 
            // textboxApplicationId
            // 
            this.textboxApplicationId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textboxApplicationId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxApplicationId.ForeColor = System.Drawing.Color.White;
            this.textboxApplicationId.Location = new System.Drawing.Point(118, 19);
            this.textboxApplicationId.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.textboxApplicationId.Name = "textboxApplicationId";
            this.textboxApplicationId.Size = new System.Drawing.Size(162, 16);
            this.textboxApplicationId.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(275, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 90);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(19, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Running Processes ";
            // 
            // listboxProccesses
            // 
            this.listboxProccesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.listboxProccesses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxProccesses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listboxProccesses.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxProccesses.ForeColor = System.Drawing.Color.White;
            this.listboxProccesses.FormattingEnabled = true;
            this.listboxProccesses.ItemHeight = 15;
            this.listboxProccesses.Location = new System.Drawing.Point(27, 240);
            this.listboxProccesses.Margin = new System.Windows.Forms.Padding(5);
            this.listboxProccesses.Name = "listboxProccesses";
            this.listboxProccesses.Size = new System.Drawing.Size(276, 90);
            this.listboxProccesses.TabIndex = 15;
            this.listboxProccesses.DoubleClick += new System.EventHandler(this.onProccessesDoubleClick);
            // 
            // lblSmallText
            // 
            this.lblSmallText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.lblSmallText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallText.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblSmallText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.lblSmallText.Location = new System.Drawing.Point(12, 86);
            this.lblSmallText.Name = "lblSmallText";
            this.lblSmallText.Size = new System.Drawing.Size(80, 24);
            this.lblSmallText.TabIndex = 14;
            this.lblSmallText.Text = "Small Text";
            this.lblSmallText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSmallText.Visible = false;
            // 
            // lblBigText
            // 
            this.lblBigText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.lblBigText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBigText.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblBigText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBigText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.lblBigText.Location = new System.Drawing.Point(12, 51);
            this.lblBigText.Name = "lblBigText";
            this.lblBigText.Size = new System.Drawing.Size(80, 24);
            this.lblBigText.TabIndex = 13;
            this.lblBigText.Text = "Big Text";
            this.lblBigText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBigText.Visible = false;
            // 
            // panelSmallPictureIndicator
            // 
            this.panelSmallPictureIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(89)))));
            this.panelSmallPictureIndicator.Location = new System.Drawing.Point(20, 168);
            this.panelSmallPictureIndicator.Name = "panelSmallPictureIndicator";
            this.panelSmallPictureIndicator.Size = new System.Drawing.Size(10, 10);
            this.panelSmallPictureIndicator.TabIndex = 10;
            // 
            // panelBigPictureIndicator
            // 
            this.panelBigPictureIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(144)))));
            this.panelBigPictureIndicator.Location = new System.Drawing.Point(20, 148);
            this.panelBigPictureIndicator.Name = "panelBigPictureIndicator";
            this.panelBigPictureIndicator.Size = new System.Drawing.Size(10, 10);
            this.panelBigPictureIndicator.TabIndex = 9;
            // 
            // lblSmallPicture
            // 
            this.lblSmallPicture.AutoSize = true;
            this.lblSmallPicture.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallPicture.ForeColor = System.Drawing.Color.White;
            this.lblSmallPicture.Location = new System.Drawing.Point(36, 165);
            this.lblSmallPicture.Name = "lblSmallPicture";
            this.lblSmallPicture.Size = new System.Drawing.Size(72, 13);
            this.lblSmallPicture.TabIndex = 8;
            this.lblSmallPicture.Text = "Small Picture:";
            // 
            // lblBigPicture
            // 
            this.lblBigPicture.AutoSize = true;
            this.lblBigPicture.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBigPicture.ForeColor = System.Drawing.Color.White;
            this.lblBigPicture.Location = new System.Drawing.Point(36, 146);
            this.lblBigPicture.Name = "lblBigPicture";
            this.lblBigPicture.Size = new System.Drawing.Size(60, 13);
            this.lblBigPicture.TabIndex = 7;
            this.lblBigPicture.Text = "Big Picture:";
            // 
            // textboxSmallPictureText
            // 
            this.textboxSmallPictureText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textboxSmallPictureText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxSmallPictureText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSmallPictureText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.textboxSmallPictureText.Location = new System.Drawing.Point(193, 163);
            this.textboxSmallPictureText.Name = "textboxSmallPictureText";
            this.textboxSmallPictureText.Size = new System.Drawing.Size(95, 16);
            this.textboxSmallPictureText.TabIndex = 12;
            this.textboxSmallPictureText.Text = "Text";
            this.textboxSmallPictureText.TextChanged += new System.EventHandler(this.onSmallPictureTextTextChanged);
            // 
            // textboxSmallPictureAsset
            // 
            this.textboxSmallPictureAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textboxSmallPictureAsset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxSmallPictureAsset.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSmallPictureAsset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.textboxSmallPictureAsset.Location = new System.Drawing.Point(118, 163);
            this.textboxSmallPictureAsset.Name = "textboxSmallPictureAsset";
            this.textboxSmallPictureAsset.Size = new System.Drawing.Size(70, 16);
            this.textboxSmallPictureAsset.TabIndex = 6;
            this.textboxSmallPictureAsset.Text = "Asset Name";
            // 
            // textboxBigPictureText
            // 
            this.textboxBigPictureText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textboxBigPictureText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxBigPictureText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxBigPictureText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.textboxBigPictureText.Location = new System.Drawing.Point(193, 144);
            this.textboxBigPictureText.Name = "textboxBigPictureText";
            this.textboxBigPictureText.Size = new System.Drawing.Size(95, 16);
            this.textboxBigPictureText.TabIndex = 11;
            this.textboxBigPictureText.Text = "Text";
            this.textboxBigPictureText.TextChanged += new System.EventHandler(this.onBigPictureTextTextChanged);
            // 
            // textboxBigPictureAsset
            // 
            this.textboxBigPictureAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textboxBigPictureAsset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxBigPictureAsset.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxBigPictureAsset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.textboxBigPictureAsset.Location = new System.Drawing.Point(118, 144);
            this.textboxBigPictureAsset.Name = "textboxBigPictureAsset";
            this.textboxBigPictureAsset.Size = new System.Drawing.Size(70, 16);
            this.textboxBigPictureAsset.TabIndex = 5;
            this.textboxBigPictureAsset.Text = "Asset Name";
            // 
            // textboxState
            // 
            this.textboxState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textboxState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.textboxState.Location = new System.Drawing.Point(118, 95);
            this.textboxState.Name = "textboxState";
            this.textboxState.Size = new System.Drawing.Size(170, 16);
            this.textboxState.TabIndex = 4;
            this.textboxState.Text = "everyone!";
            // 
            // textboxDetails
            // 
            this.textboxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textboxDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.textboxDetails.Location = new System.Drawing.Point(118, 76);
            this.textboxDetails.Name = "textboxDetails";
            this.textboxDetails.Size = new System.Drawing.Size(170, 16);
            this.textboxDetails.TabIndex = 3;
            this.textboxDetails.Text = "Good day";
            // 
            // lblApplication
            // 
            this.lblApplication.AutoSize = true;
            this.lblApplication.BackColor = System.Drawing.Color.Transparent;
            this.lblApplication.Cursor = System.Windows.Forms.Cursors.No;
            this.lblApplication.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
            this.lblApplication.Location = new System.Drawing.Point(115, 55);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(79, 18);
            this.lblApplication.TabIndex = 2;
            this.lblApplication.Text = "Application";
            // 
            // panelImagePreview
            // 
            this.panelImagePreview.BackgroundImage = global::DehysRPD.Properties.Resources.preview;
            this.panelImagePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImagePreview.Controls.Add(this.lblImageSmall);
            this.panelImagePreview.Controls.Add(this.lblImageBig);
            this.panelImagePreview.Location = new System.Drawing.Point(30, 55);
            this.panelImagePreview.Name = "panelImagePreview";
            this.panelImagePreview.Size = new System.Drawing.Size(70, 70);
            this.panelImagePreview.TabIndex = 0;
            // 
            // lblImageSmall
            // 
            this.lblImageSmall.AutoSize = true;
            this.lblImageSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImageSmall.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageSmall.ForeColor = System.Drawing.Color.White;
            this.lblImageSmall.Location = new System.Drawing.Point(53, 51);
            this.lblImageSmall.Name = "lblImageSmall";
            this.lblImageSmall.Size = new System.Drawing.Size(13, 15);
            this.lblImageSmall.TabIndex = 5;
            this.lblImageSmall.Text = "S";
            this.lblImageSmall.MouseEnter += new System.EventHandler(this.onImageSmallMouseEnter);
            this.lblImageSmall.MouseLeave += new System.EventHandler(this.onImageSmallMouseLeave);
            // 
            // lblImageBig
            // 
            this.lblImageBig.AutoSize = true;
            this.lblImageBig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImageBig.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageBig.ForeColor = System.Drawing.Color.White;
            this.lblImageBig.Location = new System.Drawing.Point(12, 18);
            this.lblImageBig.Margin = new System.Windows.Forms.Padding(0);
            this.lblImageBig.Name = "lblImageBig";
            this.lblImageBig.Size = new System.Drawing.Size(47, 29);
            this.lblImageBig.TabIndex = 4;
            this.lblImageBig.Text = "BIG";
            this.lblImageBig.MouseEnter += new System.EventHandler(this.onImageBigMouseEnter);
            this.lblImageBig.MouseLeave += new System.EventHandler(this.onImageBigMouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(144)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 35);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.onUpdateClick);
            this.btnUpdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onUpdateMouseDown);
            // 
            // panelUpdateButton
            // 
            this.panelUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(144)))));
            this.panelUpdateButton.Controls.Add(this.btnUpdate);
            this.panelUpdateButton.Location = new System.Drawing.Point(12, 403);
            this.panelUpdateButton.Name = "panelUpdateButton";
            this.panelUpdateButton.Size = new System.Drawing.Size(190, 35);
            this.panelUpdateButton.TabIndex = 17;
            // 
            // pictureboxAnimation
            // 
            this.pictureboxAnimation.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxAnimation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureboxAnimation.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxAnimation.Image")));
            this.pictureboxAnimation.Location = new System.Drawing.Point(71, 375);
            this.pictureboxAnimation.Name = "pictureboxAnimation";
            this.pictureboxAnimation.Size = new System.Drawing.Size(40, 40);
            this.pictureboxAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxAnimation.TabIndex = 16;
            this.pictureboxAnimation.TabStop = false;
            this.pictureboxAnimation.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(198)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(209, 403);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(81, 35);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.onStopClick);
            this.btnStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onUpdateMouseDown);
            // 
            // DehysRPDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.panelUpdateButton);
            this.Controls.Add(this.panelConfiguration);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.pictureboxAnimation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DehysRPDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DehysRPDForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeaderLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogo)).EndInit();
            this.panelMinimizeButton.ResumeLayout(false);
            this.panelExitButton.ResumeLayout(false);
            this.panelConfiguration.ResumeLayout(false);
            this.panelConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textboxApplicationId)).EndInit();
            this.panelImagePreview.ResumeLayout(false);
            this.panelImagePreview.PerformLayout();
            this.panelUpdateButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAnimation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelExitButton;
        private System.Windows.Forms.Panel panelMinimizeButton;
        private System.Windows.Forms.Panel panelConfiguration;
        private System.Windows.Forms.Panel panelImagePreview;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.TextBox textboxDetails;
        private System.Windows.Forms.Label lblImageSmall;
        private System.Windows.Forms.Label lblImageBig;
        private System.Windows.Forms.TextBox textboxState;
        private System.Windows.Forms.Panel panelHeaderLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureboxLogo;
        private System.Windows.Forms.Label lblSmallPicture;
        private System.Windows.Forms.Label lblBigPicture;
        private System.Windows.Forms.TextBox textboxSmallPictureAsset;
        private System.Windows.Forms.TextBox textboxBigPictureAsset;
        private System.Windows.Forms.Panel panelSmallPictureIndicator;
        private System.Windows.Forms.Panel panelBigPictureIndicator;
        private System.Windows.Forms.TextBox textboxSmallPictureText;
        private System.Windows.Forms.TextBox textboxBigPictureText;
        private System.Windows.Forms.Label lblBigText;
        private System.Windows.Forms.Label lblSmallText;
        private System.Windows.Forms.Panel btnMinimize;
        private System.Windows.Forms.Panel btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureboxAnimation;
        private System.Windows.Forms.Panel panelUpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown textboxApplicationId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblApplicationId;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listboxProccesses;
    }
}