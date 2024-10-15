namespace V_AKITAS_App
{
    partial class Gestion_Realizar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlanN = new System.Windows.Forms.Button();
            this.btnTablaN = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido usuario de V-AKITAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Que gestión deseas hacer?";
            // 
            // btnPlanN
            // 
            this.btnPlanN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlanN.Location = new System.Drawing.Point(7, 171);
            this.btnPlanN.Name = "btnPlanN";
            this.btnPlanN.Size = new System.Drawing.Size(207, 76);
            this.btnPlanN.TabIndex = 2;
            this.btnPlanN.Text = "Plan nutrocional para tu bovino";
            this.btnPlanN.UseVisualStyleBackColor = false;
            this.btnPlanN.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTablaN
            // 
            this.btnTablaN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTablaN.Location = new System.Drawing.Point(258, 171);
            this.btnTablaN.Name = "btnTablaN";
            this.btnTablaN.Size = new System.Drawing.Size(207, 76);
            this.btnTablaN.TabIndex = 3;
            this.btnTablaN.Text = "Tabla Nutricional";
            this.btnTablaN.UseVisualStyleBackColor = false;
            this.btnTablaN.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInfo.Location = new System.Drawing.Point(504, 171);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(207, 76);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Ver información acerca de V-AKITAS";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(588, 390);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(123, 48);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar al inicio de sesión";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button4_Click);
            // 
            // Gestion_Realizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(112)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnTablaN);
            this.Controls.Add(this.btnPlanN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gestion_Realizar";
            this.Text = "Gestion a Realizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlanN;
        private System.Windows.Forms.Button btnTablaN;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnRegresar;
    }
}