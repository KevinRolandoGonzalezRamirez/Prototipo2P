
namespace CapaVista
{
    partial class ConsultaProceso
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
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.asd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Location = new System.Drawing.Point(51, 112);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.Size = new System.Drawing.Size(691, 267);
            this.dvgConsulta.TabIndex = 0;
            // 
            // asd
            // 
            this.asd.Location = new System.Drawing.Point(274, 25);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(253, 63);
            this.asd.TabIndex = 1;
            this.asd.Text = "Consultar proceso";
            this.asd.UseVisualStyleBackColor = true;
            this.asd.Click += new System.EventHandler(this.asd_Click);
            // 
            // ConsultaProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.dvgConsulta);
            this.Name = "ConsultaProceso";
            this.Text = "ConsultaProceso";
            this.Load += new System.EventHandler(this.ConsultaProceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgConsulta;
        private System.Windows.Forms.Button asd;
    }
}