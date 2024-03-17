namespace Factory_Method
{
    partial class Client
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
            textResult = new TextBox();
            pictureObject = new PictureBox();
            listObject = new ComboBox();
            txt = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureObject).BeginInit();
            SuspendLayout();
            // 
            // textResult
            // 
            textResult.Dock = DockStyle.Bottom;
            textResult.Enabled = false;
            textResult.Font = new Font("Segoe UI", 13F);
            textResult.ForeColor = Color.Black;
            textResult.Location = new Point(0, 81);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.Size = new Size(800, 49);
            textResult.TabIndex = 2;
            textResult.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureObject
            // 
            pictureObject.Dock = DockStyle.Bottom;
            pictureObject.Location = new Point(0, 130);
            pictureObject.Name = "pictureObject";
            pictureObject.Size = new Size(800, 320);
            pictureObject.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureObject.TabIndex = 3;
            pictureObject.TabStop = false;
            // 
            // listObject
            // 
            listObject.DropDownStyle = ComboBoxStyle.DropDownList;
            listObject.FormattingEnabled = true;
            listObject.Location = new Point(212, 47);
            listObject.Name = "listObject";
            listObject.Size = new Size(382, 28);
            listObject.TabIndex = 4;
            listObject.SelectedIndexChanged += listObject_SelectedIndexChanged;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Font = new Font("Sylfaen", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt.ForeColor = Color.OrangeRed;
            txt.Location = new Point(158, -1);
            txt.Name = "txt";
            txt.Size = new Size(501, 33);
            txt.TabIndex = 5;
            txt.Text = "🌟 Оберіть тип транспортного засобу 🌟";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt);
            Controls.Add(listObject);
            Controls.Add(textResult);
            Controls.Add(pictureObject);
            Name = "Client";
            Text = "Client";
            Load += Client_Load;
            ((System.ComponentModel.ISupportInitialize)pictureObject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textResult;
        private PictureBox pictureObject;
        private ComboBox listObject;
        private Label txt;
    }
}
