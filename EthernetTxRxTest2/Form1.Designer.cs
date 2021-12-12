
namespace EthernetTxRxTest2
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
            this.lb_ipAdress = new System.Windows.Forms.Label();
            this.txb_ipAdress = new System.Windows.Forms.TextBox();
            this.lb_port = new System.Windows.Forms.Label();
            this.txb_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_ipAdress
            // 
            this.lb_ipAdress.AutoSize = true;
            this.lb_ipAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ipAdress.Location = new System.Drawing.Point(12, 9);
            this.lb_ipAdress.Name = "lb_ipAdress";
            this.lb_ipAdress.Size = new System.Drawing.Size(103, 18);
            this.lb_ipAdress.TabIndex = 0;
            this.lb_ipAdress.Text = "IP Destination:";
            // 
            // txb_ipAdress
            // 
            this.txb_ipAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ipAdress.Location = new System.Drawing.Point(129, 6);
            this.txb_ipAdress.Name = "txb_ipAdress";
            this.txb_ipAdress.Size = new System.Drawing.Size(100, 24);
            this.txb_ipAdress.TabIndex = 1;
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_port.Location = new System.Drawing.Point(12, 47);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(40, 18);
            this.lb_port.TabIndex = 0;
            this.lb_port.Text = "Port:";
            // 
            // txb_port
            // 
            this.txb_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_port.Location = new System.Drawing.Point(129, 44);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(100, 24);
            this.txb_port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(129, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txb_port);
            this.Controls.Add(this.txb_ipAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_port);
            this.Controls.Add(this.lb_ipAdress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ipAdress;
        private System.Windows.Forms.TextBox txb_ipAdress;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.TextBox txb_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

