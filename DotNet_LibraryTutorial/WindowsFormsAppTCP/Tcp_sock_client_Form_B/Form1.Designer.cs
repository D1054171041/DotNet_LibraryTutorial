namespace Tcp_sock_client_Form_B
{
    partial class Tcp_sock
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
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.Server_IP_label = new System.Windows.Forms.Label();
            this.Server_groupBox = new System.Windows.Forms.GroupBox();
            this.Server_Port_label = new System.Windows.Forms.Label();
            this.Server_IP_textBox = new System.Windows.Forms.TextBox();
            this.Server_Port_textBox = new System.Windows.Forms.TextBox();
            this.Client_groupBox = new System.Windows.Forms.GroupBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.Client_IP_label = new System.Windows.Forms.Label();
            this.Client_Port_label = new System.Windows.Forms.Label();
            this.Client_IP_textBox = new System.Windows.Forms.TextBox();
            this.Client_Port_textBox = new System.Windows.Forms.TextBox();
            this.Message_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Server_groupBox.SuspendLayout();
            this.Client_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(278, 58);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(121, 23);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect to Server";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            // 
            // Server_IP_label
            // 
            this.Server_IP_label.AutoSize = true;
            this.Server_IP_label.Location = new System.Drawing.Point(43, 33);
            this.Server_IP_label.Name = "Server_IP_label";
            this.Server_IP_label.Size = new System.Drawing.Size(15, 12);
            this.Server_IP_label.TabIndex = 1;
            this.Server_IP_label.Text = "IP";
            // 
            // Server_groupBox
            // 
            this.Server_groupBox.Controls.Add(this.Server_Port_textBox);
            this.Server_groupBox.Controls.Add(this.Server_IP_textBox);
            this.Server_groupBox.Controls.Add(this.Server_Port_label);
            this.Server_groupBox.Controls.Add(this.ConnectBtn);
            this.Server_groupBox.Controls.Add(this.Server_IP_label);
            this.Server_groupBox.Location = new System.Drawing.Point(22, 12);
            this.Server_groupBox.Name = "Server_groupBox";
            this.Server_groupBox.Size = new System.Drawing.Size(437, 100);
            this.Server_groupBox.TabIndex = 2;
            this.Server_groupBox.TabStop = false;
            this.Server_groupBox.Text = "Remote(be_a_Server)";
            // 
            // Server_Port_label
            // 
            this.Server_Port_label.AutoSize = true;
            this.Server_Port_label.Location = new System.Drawing.Point(24, 65);
            this.Server_Port_label.Name = "Server_Port_label";
            this.Server_Port_label.Size = new System.Drawing.Size(34, 12);
            this.Server_Port_label.TabIndex = 2;
            this.Server_Port_label.Text = "PORT";
            // 
            // Server_IP_textBox
            // 
            this.Server_IP_textBox.Location = new System.Drawing.Point(64, 30);
            this.Server_IP_textBox.Name = "Server_IP_textBox";
            this.Server_IP_textBox.Size = new System.Drawing.Size(190, 22);
            this.Server_IP_textBox.TabIndex = 3;
            // 
            // Server_Port_textBox
            // 
            this.Server_Port_textBox.Location = new System.Drawing.Point(64, 59);
            this.Server_Port_textBox.Name = "Server_Port_textBox";
            this.Server_Port_textBox.Size = new System.Drawing.Size(100, 22);
            this.Server_Port_textBox.TabIndex = 4;
            // 
            // Client_groupBox
            // 
            this.Client_groupBox.Controls.Add(this.label1);
            this.Client_groupBox.Controls.Add(this.Message_textBox);
            this.Client_groupBox.Controls.Add(this.Client_Port_textBox);
            this.Client_groupBox.Controls.Add(this.Client_IP_textBox);
            this.Client_groupBox.Controls.Add(this.Client_Port_label);
            this.Client_groupBox.Controls.Add(this.Client_IP_label);
            this.Client_groupBox.Controls.Add(this.Send_button);
            this.Client_groupBox.Location = new System.Drawing.Point(22, 151);
            this.Client_groupBox.Name = "Client_groupBox";
            this.Client_groupBox.Size = new System.Drawing.Size(437, 135);
            this.Client_groupBox.TabIndex = 3;
            this.Client_groupBox.TabStop = false;
            this.Client_groupBox.Text = "Local(be_a_Client)";
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(278, 93);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(75, 23);
            this.Send_button.TabIndex = 0;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            // 
            // Client_IP_label
            // 
            this.Client_IP_label.AutoSize = true;
            this.Client_IP_label.Location = new System.Drawing.Point(43, 25);
            this.Client_IP_label.Name = "Client_IP_label";
            this.Client_IP_label.Size = new System.Drawing.Size(15, 12);
            this.Client_IP_label.TabIndex = 1;
            this.Client_IP_label.Text = "IP";
            // 
            // Client_Port_label
            // 
            this.Client_Port_label.AutoSize = true;
            this.Client_Port_label.Location = new System.Drawing.Point(24, 53);
            this.Client_Port_label.Name = "Client_Port_label";
            this.Client_Port_label.Size = new System.Drawing.Size(34, 12);
            this.Client_Port_label.TabIndex = 2;
            this.Client_Port_label.Text = "PORT";
            // 
            // Client_IP_textBox
            // 
            this.Client_IP_textBox.Location = new System.Drawing.Point(64, 22);
            this.Client_IP_textBox.Name = "Client_IP_textBox";
            this.Client_IP_textBox.Size = new System.Drawing.Size(190, 22);
            this.Client_IP_textBox.TabIndex = 3;
            // 
            // Client_Port_textBox
            // 
            this.Client_Port_textBox.Location = new System.Drawing.Point(64, 50);
            this.Client_Port_textBox.Name = "Client_Port_textBox";
            this.Client_Port_textBox.Size = new System.Drawing.Size(100, 22);
            this.Client_Port_textBox.TabIndex = 4;
            // 
            // Message_textBox
            // 
            this.Message_textBox.Location = new System.Drawing.Point(64, 93);
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.Size = new System.Drawing.Size(190, 22);
            this.Message_textBox.TabIndex = 5;
            this.Message_textBox.Text = "Message_to_send";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message";
            // 
            // Tcp_sock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 308);
            this.Controls.Add(this.Client_groupBox);
            this.Controls.Add(this.Server_groupBox);
            this.Name = "Tcp_sock";
            this.Text = "Tcp_sock_client_B";
            this.Server_groupBox.ResumeLayout(false);
            this.Server_groupBox.PerformLayout();
            this.Client_groupBox.ResumeLayout(false);
            this.Client_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label Server_IP_label;
        private System.Windows.Forms.GroupBox Server_groupBox;
        private System.Windows.Forms.TextBox Server_Port_textBox;
        private System.Windows.Forms.TextBox Server_IP_textBox;
        private System.Windows.Forms.Label Server_Port_label;
        private System.Windows.Forms.GroupBox Client_groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Message_textBox;
        private System.Windows.Forms.TextBox Client_Port_textBox;
        private System.Windows.Forms.TextBox Client_IP_textBox;
        private System.Windows.Forms.Label Client_Port_label;
        private System.Windows.Forms.Label Client_IP_label;
        private System.Windows.Forms.Button Send_button;
    }
}

