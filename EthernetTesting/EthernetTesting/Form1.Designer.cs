namespace EthernetTesting
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
         this.Port = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
         this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
         this.btnInitPort = new System.Windows.Forms.Button();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.Statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
         this.txtpayload = new DevComponents.DotNetBar.Controls.TextBoxX();
         this.label2 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.statusStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // Port
         // 
         this.Port.AutoSize = true;
         this.Port.Location = new System.Drawing.Point(43, 58);
         this.Port.Name = "Port";
         this.Port.Size = new System.Drawing.Size(67, 17);
         this.Port.TabIndex = 0;
         this.Port.Text = "Port Add:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(33, 92);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(77, 17);
         this.label1.TabIndex = 1;
         this.label1.Text = "Socket No:";
         // 
         // textBoxX1
         // 
         // 
         // 
         // 
         this.textBoxX1.Border.Class = "TextBoxBorder";
         this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.textBoxX1.Location = new System.Drawing.Point(125, 92);
         this.textBoxX1.Name = "textBoxX1";
         this.textBoxX1.PreventEnterBeep = true;
         this.textBoxX1.Size = new System.Drawing.Size(100, 22);
         this.textBoxX1.TabIndex = 3;
         this.textBoxX1.Text = "5002";
         // 
         // textBoxX2
         // 
         // 
         // 
         // 
         this.textBoxX2.Border.Class = "TextBoxBorder";
         this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.textBoxX2.Location = new System.Drawing.Point(125, 53);
         this.textBoxX2.Name = "textBoxX2";
         this.textBoxX2.PreventEnterBeep = true;
         this.textBoxX2.Size = new System.Drawing.Size(231, 22);
         this.textBoxX2.TabIndex = 4;
         this.textBoxX2.Text = "192.168.255.1";
         // 
         // btnInitPort
         // 
         this.btnInitPort.Location = new System.Drawing.Point(254, 92);
         this.btnInitPort.Name = "btnInitPort";
         this.btnInitPort.Size = new System.Drawing.Size(75, 23);
         this.btnInitPort.TabIndex = 5;
         this.btnInitPort.Text = "initilize";
         this.btnInitPort.UseVisualStyleBackColor = true;
         this.btnInitPort.Click += new System.EventHandler(this.btnInitPort_Click);
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Statuslbl});
         this.statusStrip1.Location = new System.Drawing.Point(0, 384);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(424, 22);
         this.statusStrip1.TabIndex = 6;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // Statuslbl
         // 
         this.Statuslbl.Name = "Statuslbl";
         this.Statuslbl.Size = new System.Drawing.Size(0, 17);
         // 
         // txtpayload
         // 
         // 
         // 
         // 
         this.txtpayload.Border.Class = "TextBoxBorder";
         this.txtpayload.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
         this.txtpayload.Location = new System.Drawing.Point(125, 146);
         this.txtpayload.Name = "txtpayload";
         this.txtpayload.PreventEnterBeep = true;
         this.txtpayload.Size = new System.Drawing.Size(231, 22);
         this.txtpayload.TabIndex = 7;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 148);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(96, 17);
         this.label2.TabIndex = 8;
         this.label2.Text = "Send Payload";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(254, 185);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 9;
         this.button1.Text = "Send";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(254, 237);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(111, 23);
         this.button2.TabIndex = 10;
         this.button2.Text = "Read Ethernet";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(424, 406);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtpayload);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.btnInitPort);
         this.Controls.Add(this.textBoxX2);
         this.Controls.Add(this.textBoxX1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.Port);
         this.Name = "Form1";
         this.Text = "Form1";
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label Port;
      private System.Windows.Forms.Label label1;
      private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
      private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
      private System.Windows.Forms.Button btnInitPort;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel Statuslbl;
      private DevComponents.DotNetBar.Controls.TextBoxX txtpayload;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
   }
}

