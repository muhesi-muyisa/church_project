namespace appProramme_messe.Forms
{
    partial class Categorie
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.txtIdChants = new System.Windows.Forms.TextBox();
            this.dgtCategorie = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModife = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtReasech = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtCategorie)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(120, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 3);
            this.panel2.TabIndex = 154;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(-71, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 4);
            this.panel3.TabIndex = 4;
            // 
            // txtGame
            // 
            this.txtGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGame.BackColor = System.Drawing.Color.White;
            this.txtGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGame.ForeColor = System.Drawing.Color.DimGray;
            this.txtGame.Location = new System.Drawing.Point(120, 48);
            this.txtGame.Margin = new System.Windows.Forms.Padding(4);
            this.txtGame.Multiline = true;
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(229, 31);
            this.txtGame.TabIndex = 155;
            this.txtGame.Text = "Entrez la catégireie";
            this.txtGame.TextChanged += new System.EventHandler(this.txtGame_TextChanged);
            this.txtGame.Enter += new System.EventHandler(this.txtGame_Enter);
            this.txtGame.Leave += new System.EventHandler(this.txtGame_Leave);
            // 
            // txtIdChants
            // 
            this.txtIdChants.Location = new System.Drawing.Point(142, 53);
            this.txtIdChants.Name = "txtIdChants";
            this.txtIdChants.Size = new System.Drawing.Size(112, 20);
            this.txtIdChants.TabIndex = 153;
            this.txtIdChants.Visible = false;
            // 
            // dgtCategorie
            // 
            this.dgtCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgtCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgtCategorie.Location = new System.Drawing.Point(1, 157);
            this.dgtCategorie.Name = "dgtCategorie";
            this.dgtCategorie.Size = new System.Drawing.Size(676, 293);
            this.dgtCategorie.TabIndex = 152;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "N°";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Catégorie";
            this.Column3.Name = "Column3";
            // 
            // btnModife
            // 
            this.btnModife.FlatAppearance.BorderSize = 0;
            this.btnModife.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnModife.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnModife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModife.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModife.ForeColor = System.Drawing.Color.Black;
            this.btnModife.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModife.Location = new System.Drawing.Point(405, 48);
            this.btnModife.Name = "btnModife";
            this.btnModife.Size = new System.Drawing.Size(154, 31);
            this.btnModife.TabIndex = 156;
            this.btnModife.Text = "Confirmer";
            this.btnModife.UseVisualStyleBackColor = true;
            this.btnModife.Click += new System.EventHandler(this.btnModife_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(207, 140);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 3);
            this.panel1.TabIndex = 158;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel4.Location = new System.Drawing.Point(-71, 28);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 4);
            this.panel4.TabIndex = 4;
            // 
            // txtReasech
            // 
            this.txtReasech.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReasech.BackColor = System.Drawing.Color.White;
            this.txtReasech.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReasech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasech.ForeColor = System.Drawing.Color.DimGray;
            this.txtReasech.Location = new System.Drawing.Point(207, 122);
            this.txtReasech.Margin = new System.Windows.Forms.Padding(4);
            this.txtReasech.Multiline = true;
            this.txtReasech.Name = "txtReasech";
            this.txtReasech.Size = new System.Drawing.Size(229, 31);
            this.txtReasech.TabIndex = 159;
            this.txtReasech.Text = "Recherche ..........................";
            this.txtReasech.TextChanged += new System.EventHandler(this.txtReasech_TextChanged);
            this.txtReasech.Enter += new System.EventHandler(this.txtReasech_Enter);
            this.txtReasech.Leave += new System.EventHandler(this.txtReasech_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 157;
            this.textBox2.Visible = false;
            // 
            // Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtReasech);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnModife);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.txtIdChants);
            this.Controls.Add(this.dgtCategorie);
            this.Name = "Categorie";
            this.Text = "Categorie";
            this.Load += new System.EventHandler(this.Categorie_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtCategorie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.TextBox txtIdChants;
        private System.Windows.Forms.DataGridView dgtCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnModife;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtReasech;
        private System.Windows.Forms.TextBox textBox2;
    }
}