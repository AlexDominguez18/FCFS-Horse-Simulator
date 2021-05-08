
namespace FCFS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.posStart1 = new System.Windows.Forms.Label();
            this.posStart2 = new System.Windows.Forms.Label();
            this.posStart3 = new System.Windows.Forms.Label();
            this.posStart4 = new System.Windows.Forms.Label();
            this.posStart5 = new System.Windows.Forms.Label();
            this.buttonArea = new System.Windows.Forms.GroupBox();
            this.winnersList = new System.Windows.Forms.ListBox();
            this.finishProcessesLB = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.buttonArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 43);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(147, 30);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Iniciar";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(169, 43);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 30);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.flowLayoutPanel1.Controls.Add(this.posStart1);
            this.flowLayoutPanel1.Controls.Add(this.posStart2);
            this.flowLayoutPanel1.Controls.Add(this.posStart3);
            this.flowLayoutPanel1.Controls.Add(this.posStart4);
            this.flowLayoutPanel1.Controls.Add(this.posStart5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 9);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(20, 361);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(20, 361);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // posStart1
            // 
            this.posStart1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.posStart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posStart1.ForeColor = System.Drawing.Color.DarkRed;
            this.posStart1.Location = new System.Drawing.Point(3, 0);
            this.posStart1.MaximumSize = new System.Drawing.Size(20, 70);
            this.posStart1.MinimumSize = new System.Drawing.Size(20, 70);
            this.posStart1.Name = "posStart1";
            this.posStart1.Size = new System.Drawing.Size(20, 70);
            this.posStart1.TabIndex = 8;
            this.posStart1.Text = "1";
            this.posStart1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // posStart2
            // 
            this.posStart2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.posStart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posStart2.ForeColor = System.Drawing.Color.DarkRed;
            this.posStart2.Location = new System.Drawing.Point(3, 70);
            this.posStart2.MaximumSize = new System.Drawing.Size(20, 70);
            this.posStart2.MinimumSize = new System.Drawing.Size(20, 70);
            this.posStart2.Name = "posStart2";
            this.posStart2.Size = new System.Drawing.Size(20, 70);
            this.posStart2.TabIndex = 9;
            this.posStart2.Text = "2";
            this.posStart2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // posStart3
            // 
            this.posStart3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.posStart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posStart3.ForeColor = System.Drawing.Color.DarkRed;
            this.posStart3.Location = new System.Drawing.Point(3, 140);
            this.posStart3.MaximumSize = new System.Drawing.Size(20, 70);
            this.posStart3.MinimumSize = new System.Drawing.Size(20, 70);
            this.posStart3.Name = "posStart3";
            this.posStart3.Size = new System.Drawing.Size(20, 70);
            this.posStart3.TabIndex = 10;
            this.posStart3.Text = "3";
            this.posStart3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // posStart4
            // 
            this.posStart4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.posStart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posStart4.ForeColor = System.Drawing.Color.DarkRed;
            this.posStart4.Location = new System.Drawing.Point(3, 210);
            this.posStart4.MaximumSize = new System.Drawing.Size(20, 70);
            this.posStart4.MinimumSize = new System.Drawing.Size(20, 70);
            this.posStart4.Name = "posStart4";
            this.posStart4.Size = new System.Drawing.Size(20, 70);
            this.posStart4.TabIndex = 11;
            this.posStart4.Text = "4";
            this.posStart4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // posStart5
            // 
            this.posStart5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.posStart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posStart5.ForeColor = System.Drawing.Color.DarkRed;
            this.posStart5.Location = new System.Drawing.Point(3, 280);
            this.posStart5.MaximumSize = new System.Drawing.Size(20, 70);
            this.posStart5.MinimumSize = new System.Drawing.Size(20, 70);
            this.posStart5.Name = "posStart5";
            this.posStart5.Size = new System.Drawing.Size(20, 70);
            this.posStart5.TabIndex = 12;
            this.posStart5.Text = "5";
            this.posStart5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonArea
            // 
            this.buttonArea.BackColor = System.Drawing.Color.White;
            this.buttonArea.Controls.Add(this.finishProcessesLB);
            this.buttonArea.Controls.Add(this.winnersList);
            this.buttonArea.Controls.Add(this.startButton);
            this.buttonArea.Controls.Add(this.exitButton);
            this.buttonArea.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArea.Location = new System.Drawing.Point(-4, 376);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(846, 86);
            this.buttonArea.TabIndex = 7;
            this.buttonArea.TabStop = false;
            this.buttonArea.Text = "Simulación FCFS";
            // 
            // winnersList
            // 
            this.winnersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winnersList.BackColor = System.Drawing.Color.LightGray;
            this.winnersList.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnersList.FormattingEnabled = true;
            this.winnersList.ItemHeight = 15;
            this.winnersList.Location = new System.Drawing.Point(329, 29);
            this.winnersList.Name = "winnersList";
            this.winnersList.Size = new System.Drawing.Size(497, 49);
            this.winnersList.TabIndex = 5;
            // 
            // finishProcessesLB
            // 
            this.finishProcessesLB.AutoSize = true;
            this.finishProcessesLB.Location = new System.Drawing.Point(586, 0);
            this.finishProcessesLB.Name = "finishProcessesLB";
            this.finishProcessesLB.Size = new System.Drawing.Size(240, 26);
            this.finishProcessesLB.TabIndex = 6;
            this.finishProcessesLB.Text = "Tabla de posiciones";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.buttonArea.ResumeLayout(false);
            this.buttonArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label posStart1;
        private System.Windows.Forms.Label posStart2;
        private System.Windows.Forms.Label posStart3;
        private System.Windows.Forms.Label posStart4;
        private System.Windows.Forms.Label posStart5;
        private System.Windows.Forms.GroupBox buttonArea;
        private System.Windows.Forms.ListBox winnersList;
        private System.Windows.Forms.Label finishProcessesLB;
    }
}

