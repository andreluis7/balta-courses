namespace PrimeiroForm
{
    partial class FirstForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_first_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_response = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_response);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_first_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_send);
            this.panel1.Location = new System.Drawing.Point(44, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 241);
            this.panel1.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(117, 103);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(97, 38);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name: ";
            // 
            // txt_first_name
            // 
            this.txt_first_name.Location = new System.Drawing.Point(117, 37);
            this.txt_first_name.Name = "txt_first_name";
            this.txt_first_name.Size = new System.Drawing.Size(100, 26);
            this.txt_first_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name: ";
            // 
            // txt_response
            // 
            this.txt_response.Location = new System.Drawing.Point(117, 192);
            this.txt_response.Name = "txt_response";
            this.txt_response.ReadOnly = true;
            this.txt_response.Size = new System.Drawing.Size(100, 26);
            this.txt_response.TabIndex = 4;
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(437, 341);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FirstForm";
            this.Text = "First Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_response;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_first_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_send;
    }
}

