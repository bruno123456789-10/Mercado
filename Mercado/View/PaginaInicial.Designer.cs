namespace Mercado.View
{
    partial class PaginaInicial
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
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oque deseja fazer agora?";
            // 
            // btnAdm
            // 
            this.btnAdm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdm.Location = new System.Drawing.Point(160, 189);
            this.btnAdm.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(200, 180);
            this.btnAdm.TabIndex = 1;
            this.btnAdm.Text = "Administração";
            this.btnAdm.UseVisualStyleBackColor = true;
            // 
            // btnVendas
            // 
            this.btnVendas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVendas.Location = new System.Drawing.Point(416, 189);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(200, 180);
            this.btnVendas.TabIndex = 2;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.label1);
            this.Name = "PaginaInicial";
            this.Text = "Pagina inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAdm;
        private Button btnVendas;
    }
}