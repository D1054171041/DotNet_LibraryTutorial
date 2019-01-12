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
            this.Remote_groupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.R_Client_Port_textBox = new System.Windows.Forms.TextBox();
            this.R_Server_Port_textBox = new System.Windows.Forms.TextBox();
            this.Remote_IP_textBox = new System.Windows.Forms.TextBox();
            this.Server_Port_label = new System.Windows.Forms.Label();
            this.Local_groupBox = new System.Windows.Forms.GroupBox();
            this.L_Client_Port_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.L_Server_Port_textBox = new System.Windows.Forms.TextBox();
            this.Local_IP_textBox = new System.Windows.Forms.TextBox();
            this.Client_Port_label = new System.Windows.Forms.Label();
            this.Client_IP_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Message_textBox = new System.Windows.Forms.TextBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.Message_listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Remote_groupBox.SuspendLayout();
            this.Local_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(474, 149);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(145, 29);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect to Server";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // Server_IP_label
            // 
            this.Server_IP_label.AutoSize = true;
            this.Server_IP_label.Location = new System.Drawing.Point(25, 28);
            this.Server_IP_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Server_IP_label.Name = "Server_IP_label";
            this.Server_IP_label.Size = new System.Drawing.Size(70, 15);
            this.Server_IP_label.TabIndex = 1;
            this.Server_IP_label.Text = "Remote_IP";
            // 
            // Remote_groupBox
            // 
            this.Remote_groupBox.Controls.Add(this.button1);
            this.Remote_groupBox.Controls.Add(this.label3);
            this.Remote_groupBox.Controls.Add(this.R_Client_Port_textBox);
            this.Remote_groupBox.Controls.Add(this.R_Server_Port_textBox);
            this.Remote_groupBox.Controls.Add(this.Remote_IP_textBox);
            this.Remote_groupBox.Controls.Add(this.Server_Port_label);
            this.Remote_groupBox.Controls.Add(this.Server_IP_label);
            this.Remote_groupBox.Location = new System.Drawing.Point(321, 13);
            this.Remote_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.Remote_groupBox.Name = "Remote_groupBox";
            this.Remote_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.Remote_groupBox.Size = new System.Drawing.Size(298, 126);
            this.Remote_groupBox.TabIndex = 2;
            this.Remote_groupBox.TabStop = false;
            this.Remote_groupBox.Text = "Remote";
            this.Remote_groupBox.Enter += new System.EventHandler(this.Server_groupBox_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "R_Client_PORT";
            // 
            // R_Client_Port_textBox
            // 
            this.R_Client_Port_textBox.Location = new System.Drawing.Point(119, 89);
            this.R_Client_Port_textBox.Name = "R_Client_Port_textBox";
            this.R_Client_Port_textBox.Size = new System.Drawing.Size(81, 25);
            this.R_Client_Port_textBox.TabIndex = 5;
            // 
            // R_Server_Port_textBox
            // 
            this.R_Server_Port_textBox.Location = new System.Drawing.Point(119, 58);
            this.R_Server_Port_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.R_Server_Port_textBox.Name = "R_Server_Port_textBox";
            this.R_Server_Port_textBox.Size = new System.Drawing.Size(81, 25);
            this.R_Server_Port_textBox.TabIndex = 4;
            // 
            // Remote_IP_textBox
            // 
            this.Remote_IP_textBox.Location = new System.Drawing.Point(103, 25);
            this.Remote_IP_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Remote_IP_textBox.Name = "Remote_IP_textBox";
            this.Remote_IP_textBox.Size = new System.Drawing.Size(155, 25);
            this.Remote_IP_textBox.TabIndex = 3;
            this.Remote_IP_textBox.TextChanged += new System.EventHandler(this.Server_IP_textBox_TextChanged);
            // 
            // Server_Port_label
            // 
            this.Server_Port_label.AutoSize = true;
            this.Server_Port_label.Location = new System.Drawing.Point(8, 60);
            this.Server_Port_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Server_Port_label.Name = "Server_Port_label";
            this.Server_Port_label.Size = new System.Drawing.Size(103, 15);
            this.Server_Port_label.TabIndex = 2;
            this.Server_Port_label.Text = "R_Server_PORT";
            // 
            // Local_groupBox
            // 
            this.Local_groupBox.Controls.Add(this.L_Client_Port_textBox);
            this.Local_groupBox.Controls.Add(this.label2);
            this.Local_groupBox.Controls.Add(this.L_Server_Port_textBox);
            this.Local_groupBox.Controls.Add(this.Local_IP_textBox);
            this.Local_groupBox.Controls.Add(this.Client_Port_label);
            this.Local_groupBox.Controls.Add(this.Client_IP_label);
            this.Local_groupBox.Location = new System.Drawing.Point(27, 13);
            this.Local_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.Local_groupBox.Name = "Local_groupBox";
            this.Local_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.Local_groupBox.Size = new System.Drawing.Size(286, 126);
            this.Local_groupBox.TabIndex = 3;
            this.Local_groupBox.TabStop = false;
            this.Local_groupBox.Text = "Local(Host)";
            // 
            // L_Client_Port_textBox
            // 
            this.L_Client_Port_textBox.Location = new System.Drawing.Point(119, 90);
            this.L_Client_Port_textBox.Name = "L_Client_Port_textBox";
            this.L_Client_Port_textBox.Size = new System.Drawing.Size(100, 25);
            this.L_Client_Port_textBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "L_Client_PORT";
            // 
            // L_Server_Port_textBox
            // 
            this.L_Server_Port_textBox.Location = new System.Drawing.Point(119, 61);
            this.L_Server_Port_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.L_Server_Port_textBox.Name = "L_Server_Port_textBox";
            this.L_Server_Port_textBox.Size = new System.Drawing.Size(100, 25);
            this.L_Server_Port_textBox.TabIndex = 4;
            // 
            // Local_IP_textBox
            // 
            this.Local_IP_textBox.Location = new System.Drawing.Point(103, 28);
            this.Local_IP_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Local_IP_textBox.Name = "Local_IP_textBox";
            this.Local_IP_textBox.Size = new System.Drawing.Size(159, 25);
            this.Local_IP_textBox.TabIndex = 3;
            // 
            // Client_Port_label
            // 
            this.Client_Port_label.AutoSize = true;
            this.Client_Port_label.Location = new System.Drawing.Point(8, 64);
            this.Client_Port_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Client_Port_label.Name = "Client_Port_label";
            this.Client_Port_label.Size = new System.Drawing.Size(103, 15);
            this.Client_Port_label.TabIndex = 2;
            this.Client_Port_label.Text = "L_Server_PORT";
            // 
            // Client_IP_label
            // 
            this.Client_IP_label.AutoSize = true;
            this.Client_IP_label.Location = new System.Drawing.Point(36, 31);
            this.Client_IP_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Client_IP_label.Name = "Client_IP_label";
            this.Client_IP_label.Size = new System.Drawing.Size(59, 15);
            this.Client_IP_label.TabIndex = 1;
            this.Client_IP_label.Text = "Local_IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message";
            // 
            // Message_textBox
            // 
            this.Message_textBox.Location = new System.Drawing.Point(98, 149);
            this.Message_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.Size = new System.Drawing.Size(252, 25);
            this.Message_textBox.TabIndex = 5;
            this.Message_textBox.Text = "Message_to_send";
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(366, 149);
            this.Send_button.Margin = new System.Windows.Forms.Padding(4);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(100, 29);
            this.Send_button.TabIndex = 0;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            // 
            // Message_listBox
            // 
            this.Message_listBox.FormattingEnabled = true;
            this.Message_listBox.ItemHeight = 15;
            this.Message_listBox.Location = new System.Drawing.Point(27, 186);
            this.Message_listBox.Margin = new System.Windows.Forms.Padding(4);
            this.Message_listBox.Name = "Message_listBox";
            this.Message_listBox.ScrollAlwaysVisible = true;
            this.Message_listBox.Size = new System.Drawing.Size(592, 229);
            this.Message_listBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Host Loop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tcp_sock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 433);
            this.Controls.Add(this.Message_listBox);
            this.Controls.Add(this.Local_groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Remote_groupBox);
            this.Controls.Add(this.Message_textBox);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.Send_button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tcp_sock";
            this.Text = "Tcp_socket";
            this.Remote_groupBox.ResumeLayout(false);
            this.Remote_groupBox.PerformLayout();
            this.Local_groupBox.ResumeLayout(false);
            this.Local_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label Server_IP_label;
        private System.Windows.Forms.GroupBox Remote_groupBox;
        private System.Windows.Forms.TextBox R_Server_Port_textBox;
        private System.Windows.Forms.TextBox Remote_IP_textBox;
        private System.Windows.Forms.Label Server_Port_label;
        private System.Windows.Forms.GroupBox Local_groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Message_textBox;
        private System.Windows.Forms.TextBox L_Server_Port_textBox;
        private System.Windows.Forms.TextBox Local_IP_textBox;
        private System.Windows.Forms.Label Client_Port_label;
        private System.Windows.Forms.Label Client_IP_label;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.ListBox Message_listBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox R_Client_Port_textBox;
        private System.Windows.Forms.TextBox L_Client_Port_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

