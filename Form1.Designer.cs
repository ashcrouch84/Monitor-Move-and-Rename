namespace Monitor_Move_and_Rename
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmdstop = new System.Windows.Forms.Button();
            this.lstMonitor = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboGrottos = new System.Windows.Forms.ComboBox();
            this.cmdsave = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdBarcode = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdBrowse2 = new System.Windows.Forms.Button();
            this.txtBrowse2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdStart = new System.Windows.Forms.Button();
            this.GrottoCamBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdTouch = new System.Windows.Forms.Button();
            this.txtTouchLoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmdstop
            // 
            this.cmdstop.Enabled = false;
            this.cmdstop.Location = new System.Drawing.Point(347, 348);
            this.cmdstop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdstop.Name = "cmdstop";
            this.cmdstop.Size = new System.Drawing.Size(112, 40);
            this.cmdstop.TabIndex = 53;
            this.cmdstop.Text = "stop";
            this.cmdstop.UseVisualStyleBackColor = true;
            this.cmdstop.Click += new System.EventHandler(this.cmdstop_Click);
            // 
            // lstMonitor
            // 
            this.lstMonitor.FormattingEnabled = true;
            this.lstMonitor.Location = new System.Drawing.Point(567, 28);
            this.lstMonitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstMonitor.Name = "lstMonitor";
            this.lstMonitor.Size = new System.Drawing.Size(210, 355);
            this.lstMonitor.TabIndex = 52;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboGrottos);
            this.groupBox3.Location = new System.Drawing.Point(32, 241);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(111, 99);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "This Grotto";
            // 
            // cboGrottos
            // 
            this.cboGrottos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrottos.FormattingEnabled = true;
            this.cboGrottos.Location = new System.Drawing.Point(28, 42);
            this.cboGrottos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGrottos.Name = "cboGrottos";
            this.cboGrottos.Size = new System.Drawing.Size(48, 38);
            this.cboGrottos.TabIndex = 4;
            this.cboGrottos.SelectedIndexChanged += new System.EventHandler(this.cboGrottos_SelectedIndexChanged);
            // 
            // cmdsave
            // 
            this.cmdsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsave.Location = new System.Drawing.Point(438, 152);
            this.cmdsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(79, 23);
            this.cmdsave.TabIndex = 50;
            this.cmdsave.Text = "Save";
            this.cmdsave.UseVisualStyleBackColor = true;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterval.Location = new System.Drawing.Point(171, 153);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(256, 27);
            this.txtInterval.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Timer Interval";
            // 
            // cmdBarcode
            // 
            this.cmdBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBarcode.Location = new System.Drawing.Point(438, 112);
            this.cmdBarcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdBarcode.Name = "cmdBarcode";
            this.cmdBarcode.Size = new System.Drawing.Size(79, 23);
            this.cmdBarcode.TabIndex = 47;
            this.cmdBarcode.Text = "browse";
            this.cmdBarcode.UseVisualStyleBackColor = true;
            this.cmdBarcode.Click += new System.EventHandler(this.cmdBarcode_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(171, 112);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(256, 27);
            this.txtBarcode.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Barcode Location";
            // 
            // cmdBrowse2
            // 
            this.cmdBrowse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrowse2.Location = new System.Drawing.Point(438, 68);
            this.cmdBrowse2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdBrowse2.Name = "cmdBrowse2";
            this.cmdBrowse2.Size = new System.Drawing.Size(79, 23);
            this.cmdBrowse2.TabIndex = 44;
            this.cmdBrowse2.Text = "browse";
            this.cmdBrowse2.UseVisualStyleBackColor = true;
            this.cmdBrowse2.Click += new System.EventHandler(this.cmdBrowse2_Click);
            // 
            // txtBrowse2
            // 
            this.txtBrowse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrowse2.Location = new System.Drawing.Point(171, 68);
            this.txtBrowse2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrowse2.Name = "txtBrowse2";
            this.txtBrowse2.Size = new System.Drawing.Size(256, 27);
            this.txtBrowse2.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Move to";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrowse.Location = new System.Drawing.Point(438, 23);
            this.cmdBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(79, 23);
            this.cmdBrowse.TabIndex = 41;
            this.cmdBrowse.Text = "browse";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // txtBrowse
            // 
            this.txtBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrowse.Location = new System.Drawing.Point(171, 24);
            this.txtBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(256, 27);
            this.txtBrowse.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Folder to Monitor";
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(202, 348);
            this.cmdStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(112, 40);
            this.cmdStart.TabIndex = 38;
            this.cmdStart.Text = "start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdTouch
            // 
            this.cmdTouch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTouch.Location = new System.Drawing.Point(438, 191);
            this.cmdTouch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdTouch.Name = "cmdTouch";
            this.cmdTouch.Size = new System.Drawing.Size(79, 23);
            this.cmdTouch.TabIndex = 56;
            this.cmdTouch.Text = "browse";
            this.cmdTouch.UseVisualStyleBackColor = true;
            this.cmdTouch.Click += new System.EventHandler(this.cmdTouch_Click);
            // 
            // txtTouchLoc
            // 
            this.txtTouchLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTouchLoc.Location = new System.Drawing.Point(171, 191);
            this.txtTouchLoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTouchLoc.Name = "txtTouchLoc";
            this.txtTouchLoc.Size = new System.Drawing.Size(256, 27);
            this.txtTouchLoc.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 54;
            this.label5.Text = "Touch Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 413);
            this.Controls.Add(this.cmdTouch);
            this.Controls.Add(this.txtTouchLoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdstop);
            this.Controls.Add(this.lstMonitor);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdsave);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdBarcode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdBrowse2);
            this.Controls.Add(this.txtBrowse2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.txtBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdStart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Monitor and Move Files";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cmdstop;
        private System.Windows.Forms.ListBox lstMonitor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdBrowse2;
        private System.Windows.Forms.TextBox txtBrowse2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.FolderBrowserDialog GrottoCamBrowser;
        private System.Windows.Forms.Button cmdTouch;
        private System.Windows.Forms.TextBox txtTouchLoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGrottos;
    }
}

