namespace Sermon
{
    partial class Sermon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sermon));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsddComPort = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddComPort,
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1026, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsddComPort
            // 
            this.tsddComPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddComPort.Image = ((System.Drawing.Image)(resources.GetObject("tsddComPort.Image")));
            this.tsddComPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddComPort.Name = "tsddComPort";
            this.tsddComPort.Size = new System.Drawing.Size(53, 20);
            this.tsddComPort.Text = "COM?";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(86, 17);
            this.tsslStatus.Text = "Not connected";
            // 
            // Sermon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 481);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Sermon";
            this.Text = "Sermon";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsddComPort;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
    }
}

