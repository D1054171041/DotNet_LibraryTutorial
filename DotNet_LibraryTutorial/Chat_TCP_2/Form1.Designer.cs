using System;

namespace Chat_TCP_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ServerGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.ServerPortTextBox = new System.Windows.Forms.TextBox();
            this.ServerIPtextBox = new System.Windows.Forms.TextBox();
            this.ClientGroupBox = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientPortTextBox = new System.Windows.Forms.TextBox();
            this.ClientIPtextBox = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDisconnected = new System.Windows.Forms.Button();
            this.ServerGroupBox.SuspendLayout();
            this.ClientGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerGroupBox
            // 
            this.ServerGroupBox.Controls.Add(this.label2);
            this.ServerGroupBox.Controls.Add(this.label1);
            this.ServerGroupBox.Controls.Add(this.btnStart);
            this.ServerGroupBox.Controls.Add(this.ServerPortTextBox);
            this.ServerGroupBox.Controls.Add(this.ServerIPtextBox);
            this.ServerGroupBox.Location = new System.Drawing.Point(23, 32);
            this.ServerGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServerGroupBox.Name = "ServerGroupBox";
            this.ServerGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServerGroupBox.Size = new System.Drawing.Size(268, 135);
            this.ServerGroupBox.TabIndex = 0;
            this.ServerGroupBox.TabStop = false;
            this.ServerGroupBox.Text = "SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(187, 100);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 22);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Location = new System.Drawing.Point(93, 55);
            this.ServerPortTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.Size = new System.Drawing.Size(83, 25);
            this.ServerPortTextBox.TabIndex = 1;
            // 
            // ServerIPtextBox
            // 
            this.ServerIPtextBox.Location = new System.Drawing.Point(93, 25);
            this.ServerIPtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServerIPtextBox.Name = "ServerIPtextBox";
            this.ServerIPtextBox.Size = new System.Drawing.Size(142, 25);
            this.ServerIPtextBox.TabIndex = 0;
            // 
            // ClientGroupBox
            // 
            this.ClientGroupBox.Controls.Add(this.btnConnect);
            this.ClientGroupBox.Controls.Add(this.label4);
            this.ClientGroupBox.Controls.Add(this.label3);
            this.ClientGroupBox.Controls.Add(this.ClientPortTextBox);
            this.ClientGroupBox.Controls.Add(this.ClientIPtextBox);
            this.ClientGroupBox.Location = new System.Drawing.Point(323, 32);
            this.ClientGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientGroupBox.Name = "ClientGroupBox";
            this.ClientGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientGroupBox.Size = new System.Drawing.Size(276, 135);
            this.ClientGroupBox.TabIndex = 1;
            this.ClientGroupBox.TabStop = false;
            this.ClientGroupBox.Text = "CLIENT";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(163, 100);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 29);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // ClientPortTextBox
            // 
            this.ClientPortTextBox.Location = new System.Drawing.Point(83, 54);
            this.ClientPortTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientPortTextBox.Name = "ClientPortTextBox";
            this.ClientPortTextBox.Size = new System.Drawing.Size(79, 25);
            this.ClientPortTextBox.TabIndex = 1;
            // 
            // ClientIPtextBox
            // 
            this.ClientIPtextBox.Location = new System.Drawing.Point(83, 25);
            this.ClientIPtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientIPtextBox.Name = "ClientIPtextBox";
            this.ClientIPtextBox.Size = new System.Drawing.Size(135, 25);
            this.ClientIPtextBox.TabIndex = 0;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(23, 360);
            this.textMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(563, 25);
            this.textMessage.TabIndex = 2;
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 15;
            this.listMessage.Location = new System.Drawing.Point(23, 186);
            this.listMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(657, 154);
            this.listMessage.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(605, 360);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 25);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnDisconnected
            // 
            this.btnDisconnected.Location = new System.Drawing.Point(605, 146);
            this.btnDisconnected.Name = "btnDisconnected";
            this.btnDisconnected.Size = new System.Drawing.Size(126, 23);
            this.btnDisconnected.TabIndex = 6;
            this.btnDisconnected.Text = "Disconnected";
            this.btnDisconnected.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 408);
            this.Controls.Add(this.btnDisconnected);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.ClientGroupBox);
            this.Controls.Add(this.ServerGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "TCP";
            this.ServerGroupBox.ResumeLayout(false);
            this.ServerGroupBox.PerformLayout();
            this.ClientGroupBox.ResumeLayout(false);
            this.ClientGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.GroupBox ServerGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerPortTextBox;
        private System.Windows.Forms.TextBox ServerIPtextBox;
        private System.Windows.Forms.GroupBox ClientGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientPortTextBox;
        private System.Windows.Forms.TextBox ClientIPtextBox;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnected;
    }
}

