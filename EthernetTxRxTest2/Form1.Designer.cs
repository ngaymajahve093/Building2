
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
            this.lb_message = new System.Windows.Forms.Label();
            this.txb_message = new System.Windows.Forms.TextBox();
            this.btn_sent = new System.Windows.Forms.Button();
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
            this.txb_ipAdress.Location = new System.Drawing.Point(119, 6);
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
            this.txb_port.Location = new System.Drawing.Point(119, 44);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(100, 24);
            this.txb_port.TabIndex = 2;
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.Location = new System.Drawing.Point(12, 93);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(73, 18);
            this.lb_message.TabIndex = 0;
            this.lb_message.Text = "Message:";
            // 
            // txb_message
            // 
            this.txb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_message.Location = new System.Drawing.Point(119, 90);
            this.txb_message.Multiline = true;
            this.txb_message.Name = "txb_message";
            this.txb_message.Size = new System.Drawing.Size(565, 143);
            this.txb_message.TabIndex = 3;
            this.txb_message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_message_KeyDown);
            // 
            // btn_sent
            // 
            this.btn_sent.AutoSize = true;
            this.btn_sent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sent.Location = new System.Drawing.Point(119, 239);
            this.btn_sent.Name = "btn_sent";
            this.btn_sent.Size = new System.Drawing.Size(100, 28);
            this.btn_sent.TabIndex = 4;
            this.btn_sent.Text = "SENT";
            this.btn_sent.UseVisualStyleBackColor = true;
            this.btn_sent.Click += new System.EventHandler(this.btn_sent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.btn_sent);
            this.Controls.Add(this.txb_message);
            this.Controls.Add(this.txb_port);
            this.Controls.Add(this.txb_ipAdress);
            this.Controls.Add(this.lb_message);
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
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.TextBox txb_message;
        private System.Windows.Forms.Button btn_sent;
    }
}

