
namespace ConvertResx
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.console = new System.Windows.Forms.RichTextBox();
            this.buttonResx = new System.Windows.Forms.Button();
            this.buttonTXT = new System.Windows.Forms.Button();
            this.textBoxLang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClearConsole = new System.Windows.Forms.Button();
            this.buttonMoreInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.Dock = System.Windows.Forms.DockStyle.Top;
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.console.Location = new System.Drawing.Point(0, 0);
            this.console.Margin = new System.Windows.Forms.Padding(2);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(835, 395);
            this.console.TabIndex = 0;
            this.console.Text = "";
            // 
            // buttonResx
            // 
            this.buttonResx.AutoEllipsis = true;
            this.buttonResx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResx.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonResx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonResx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonResx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResx.Location = new System.Drawing.Point(12, 483);
            this.buttonResx.Name = "buttonResx";
            this.buttonResx.Size = new System.Drawing.Size(361, 53);
            this.buttonResx.TabIndex = 0;
            this.buttonResx.TabStop = false;
            this.buttonResx.Text = "Convert .resx to .txt file";
            this.buttonResx.UseVisualStyleBackColor = true;
            this.buttonResx.Click += new System.EventHandler(this.buttonResx_Click);
            // 
            // buttonTXT
            // 
            this.buttonTXT.AutoEllipsis = true;
            this.buttonTXT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTXT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTXT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTXT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonTXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTXT.Location = new System.Drawing.Point(462, 483);
            this.buttonTXT.Name = "buttonTXT";
            this.buttonTXT.Size = new System.Drawing.Size(361, 53);
            this.buttonTXT.TabIndex = 0;
            this.buttonTXT.TabStop = false;
            this.buttonTXT.Text = "Convert .txt to .resx file";
            this.buttonTXT.UseVisualStyleBackColor = true;
            this.buttonTXT.Click += new System.EventHandler(this.buttonTXT_Click);
            // 
            // textBoxLang
            // 
            this.textBoxLang.BackColor = System.Drawing.Color.Black;
            this.textBoxLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLang.ForeColor = System.Drawing.Color.White;
            this.textBoxLang.Location = new System.Drawing.Point(12, 443);
            this.textBoxLang.MaxLength = 3;
            this.textBoxLang.Name = "textBoxLang";
            this.textBoxLang.Size = new System.Drawing.Size(56, 24);
            this.textBoxLang.TabIndex = 0;
            this.textBoxLang.TabStop = false;
            this.textBoxLang.TextChanged += new System.EventHandler(this.textBoxLang_TextChanged);
            this.textBoxLang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLang_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Write your language culture to translate, like this \"en\" (Not like this: \"en-US\")" +
    "";
            // 
            // buttonClearConsole
            // 
            this.buttonClearConsole.AutoEllipsis = true;
            this.buttonClearConsole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClearConsole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearConsole.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonClearConsole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonClearConsole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonClearConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearConsole.Location = new System.Drawing.Point(713, 400);
            this.buttonClearConsole.Name = "buttonClearConsole";
            this.buttonClearConsole.Size = new System.Drawing.Size(110, 28);
            this.buttonClearConsole.TabIndex = 5;
            this.buttonClearConsole.TabStop = false;
            this.buttonClearConsole.Text = "Clear Console";
            this.buttonClearConsole.UseVisualStyleBackColor = true;
            this.buttonClearConsole.Click += new System.EventHandler(this.buttonClearConsole_Click);
            // 
            // buttonMoreInfo
            // 
            this.buttonMoreInfo.AutoEllipsis = true;
            this.buttonMoreInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMoreInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMoreInfo.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonMoreInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonMoreInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoreInfo.Location = new System.Drawing.Point(74, 444);
            this.buttonMoreInfo.Name = "buttonMoreInfo";
            this.buttonMoreInfo.Size = new System.Drawing.Size(521, 24);
            this.buttonMoreInfo.TabIndex = 6;
            this.buttonMoreInfo.TabStop = false;
            this.buttonMoreInfo.Text = "More Info: Supported Culture Codes";
            this.buttonMoreInfo.UseVisualStyleBackColor = true;
            this.buttonMoreInfo.Click += new System.EventHandler(this.buttonMoreInfo_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(835, 548);
            this.Controls.Add(this.buttonMoreInfo);
            this.Controls.Add(this.buttonClearConsole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLang);
            this.Controls.Add(this.buttonTXT);
            this.Controls.Add(this.buttonResx);
            this.Controls.Add(this.console);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "resx <--> txt file converter by Franco28";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Button buttonResx;
        private System.Windows.Forms.Button buttonTXT;
        private System.Windows.Forms.TextBox textBoxLang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClearConsole;
        private System.Windows.Forms.Button buttonMoreInfo;
    }
}

