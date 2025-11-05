namespace concert_ticketing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            concertToolStripMenuItem = new ToolStripMenuItem();
            ticketToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, concertToolStripMenuItem, ticketToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1093, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(105, 25);
            accountToolStripMenuItem.Text = "Account";
            accountToolStripMenuItem.Click += accountToolStripMenuItem_Click;
            // 
            // concertToolStripMenuItem
            // 
            concertToolStripMenuItem.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            concertToolStripMenuItem.Name = "concertToolStripMenuItem";
            concertToolStripMenuItem.Size = new Size(106, 25);
            concertToolStripMenuItem.Text = "Concert";
            concertToolStripMenuItem.Click += concertToolStripMenuItem_Click;
            // 
            // ticketToolStripMenuItem
            // 
            ticketToolStripMenuItem.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            ticketToolStripMenuItem.Size = new Size(90, 25);
            ticketToolStripMenuItem.Text = "Ticket";
            ticketToolStripMenuItem.Click += ticketToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 560);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 584);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem concertToolStripMenuItem;
        private ToolStripMenuItem ticketToolStripMenuItem;
        private Panel panel1;
    }
}
