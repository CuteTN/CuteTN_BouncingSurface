namespace BouncingSurface
{
    partial class FormMain
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
            this.nudViscosity = new System.Windows.Forms.NumericUpDown();
            this.labelViscosity = new System.Windows.Forms.Label();
            this.labelFriction = new System.Windows.Forms.Label();
            this.nudFriction = new System.Windows.Forms.NumericUpDown();
            this.labelFps = new System.Windows.Forms.Label();
            this.nudFps = new System.Windows.Forms.NumericUpDown();
            this.labelDensity = new System.Windows.Forms.Label();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.btnWaterColor = new System.Windows.Forms.Button();
            this.btnBackground = new System.Windows.Forms.Button();
            this.labelApplyRange = new System.Windows.Forms.Label();
            this.nudApplyRange = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudViscosity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFriction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApplyRange)).BeginInit();
            this.SuspendLayout();
            // 
            // nudViscosity
            // 
            this.nudViscosity.DecimalPlaces = 9;
            this.nudViscosity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudViscosity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudViscosity.Location = new System.Drawing.Point(10, 40);
            this.nudViscosity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudViscosity.Name = "nudViscosity";
            this.nudViscosity.Size = new System.Drawing.Size(140, 31);
            this.nudViscosity.TabIndex = 0;
            this.nudViscosity.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudViscosity.ValueChanged += new System.EventHandler(this.nudViscosity_ValueChanged);
            // 
            // labelViscosity
            // 
            this.labelViscosity.AutoSize = true;
            this.labelViscosity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViscosity.Location = new System.Drawing.Point(10, 10);
            this.labelViscosity.Name = "labelViscosity";
            this.labelViscosity.Size = new System.Drawing.Size(87, 25);
            this.labelViscosity.TabIndex = 0;
            this.labelViscosity.Text = "Viscosity";
            // 
            // labelFriction
            // 
            this.labelFriction.AutoSize = true;
            this.labelFriction.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriction.Location = new System.Drawing.Point(180, 10);
            this.labelFriction.Name = "labelFriction";
            this.labelFriction.Size = new System.Drawing.Size(77, 25);
            this.labelFriction.TabIndex = 1;
            this.labelFriction.Text = "Friction";
            // 
            // nudFriction
            // 
            this.nudFriction.DecimalPlaces = 9;
            this.nudFriction.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFriction.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudFriction.Location = new System.Drawing.Point(180, 40);
            this.nudFriction.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFriction.Name = "nudFriction";
            this.nudFriction.Size = new System.Drawing.Size(140, 31);
            this.nudFriction.TabIndex = 1;
            this.nudFriction.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudFriction.ValueChanged += new System.EventHandler(this.nudFriction_ValueChanged);
            // 
            // labelFps
            // 
            this.labelFps.AutoSize = true;
            this.labelFps.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFps.Location = new System.Drawing.Point(520, 10);
            this.labelFps.Name = "labelFps";
            this.labelFps.Size = new System.Drawing.Size(43, 25);
            this.labelFps.TabIndex = 3;
            this.labelFps.Text = "FPS";
            // 
            // nudFps
            // 
            this.nudFps.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFps.Location = new System.Drawing.Point(520, 40);
            this.nudFps.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudFps.Name = "nudFps";
            this.nudFps.Size = new System.Drawing.Size(140, 31);
            this.nudFps.TabIndex = 3;
            this.nudFps.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFps.ValueChanged += new System.EventHandler(this.nudFps_ValueChanged);
            // 
            // labelDensity
            // 
            this.labelDensity.AutoSize = true;
            this.labelDensity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDensity.Location = new System.Drawing.Point(350, 10);
            this.labelDensity.Name = "labelDensity";
            this.labelDensity.Size = new System.Drawing.Size(77, 25);
            this.labelDensity.TabIndex = 2;
            this.labelDensity.Text = "Density";
            // 
            // nudDensity
            // 
            this.nudDensity.DecimalPlaces = 9;
            this.nudDensity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDensity.Location = new System.Drawing.Point(350, 40);
            this.nudDensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.Size = new System.Drawing.Size(140, 31);
            this.nudDensity.TabIndex = 2;
            this.nudDensity.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDensity.ValueChanged += new System.EventHandler(this.nudDensity_ValueChanged);
            // 
            // btnWaterColor
            // 
            this.btnWaterColor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnWaterColor.Location = new System.Drawing.Point(10, 96);
            this.btnWaterColor.Name = "btnWaterColor";
            this.btnWaterColor.Size = new System.Drawing.Size(140, 31);
            this.btnWaterColor.TabIndex = 5;
            this.btnWaterColor.Text = "Water color";
            this.btnWaterColor.UseVisualStyleBackColor = true;
            this.btnWaterColor.Click += new System.EventHandler(this.btnWaterColor_Click);
            // 
            // btnBackground
            // 
            this.btnBackground.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnBackground.Location = new System.Drawing.Point(180, 96);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(140, 31);
            this.btnBackground.TabIndex = 6;
            this.btnBackground.Text = "Background";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // labelApplyRange
            // 
            this.labelApplyRange.AutoSize = true;
            this.labelApplyRange.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplyRange.Location = new System.Drawing.Point(690, 10);
            this.labelApplyRange.Name = "labelApplyRange";
            this.labelApplyRange.Size = new System.Drawing.Size(121, 25);
            this.labelApplyRange.TabIndex = 4;
            this.labelApplyRange.Text = "Apply Range";
            // 
            // nudApplyRange
            // 
            this.nudApplyRange.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudApplyRange.Location = new System.Drawing.Point(690, 40);
            this.nudApplyRange.Name = "nudApplyRange";
            this.nudApplyRange.Size = new System.Drawing.Size(140, 31);
            this.nudApplyRange.TabIndex = 4;
            this.nudApplyRange.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudApplyRange.ValueChanged += new System.EventHandler(this.nudApplyRange_ValueChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 548);
            this.Controls.Add(this.labelApplyRange);
            this.Controls.Add(this.nudApplyRange);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.btnWaterColor);
            this.Controls.Add(this.labelDensity);
            this.Controls.Add(this.nudDensity);
            this.Controls.Add(this.labelFps);
            this.Controls.Add(this.nudFps);
            this.Controls.Add(this.labelFriction);
            this.Controls.Add(this.nudFriction);
            this.Controls.Add(this.labelViscosity);
            this.Controls.Add(this.nudViscosity);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "BouncingSurface - CuteTN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudViscosity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFriction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApplyRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudViscosity;
        private System.Windows.Forms.Label labelViscosity;
        private System.Windows.Forms.Label labelFriction;
        private System.Windows.Forms.NumericUpDown nudFriction;
        private System.Windows.Forms.Label labelFps;
        private System.Windows.Forms.NumericUpDown nudFps;
        private System.Windows.Forms.Label labelDensity;
        private System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.Button btnWaterColor;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.Label labelApplyRange;
        private System.Windows.Forms.NumericUpDown nudApplyRange;
    }
}

