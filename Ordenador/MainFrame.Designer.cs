
namespace Ordenador
{
    partial class fOrdenador
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
            this.components = new System.ComponentModel.Container();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.lDigite = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lLista = new System.Windows.Forms.Label();
            this.lSoma = new System.Windows.Forms.Label();
            this.tbSoma = new System.Windows.Forms.TextBox();
            this.bLimpar = new System.Windows.Forms.Button();
            this.tbDigite = new System.Windows.Forms.TextBox();
            this.lErro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbLista = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.Color.LightGreen;
            this.bConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bConfirmar.FlatAppearance.BorderSize = 0;
            this.bConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmar.Location = new System.Drawing.Point(283, 73);
            this.bConfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(97, 26);
            this.bConfirmar.TabIndex = 1;
            this.bConfirmar.Text = "Confirmar";
            this.toolTip1.SetToolTip(this.bConfirmar, "Adicionar um número na lista");
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // lDigite
            // 
            this.lDigite.AutoSize = true;
            this.lDigite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDigite.Location = new System.Drawing.Point(28, 76);
            this.lDigite.Name = "lDigite";
            this.lDigite.Size = new System.Drawing.Size(134, 20);
            this.lDigite.TabIndex = 1;
            this.lDigite.Text = "Digite um número";
            // 
            // lLista
            // 
            this.lLista.AutoSize = true;
            this.lLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLista.Location = new System.Drawing.Point(28, 148);
            this.lLista.Name = "lLista";
            this.lLista.Size = new System.Drawing.Size(144, 20);
            this.lLista.TabIndex = 5;
            this.lLista.Text = "Números Digitados";
            // 
            // lSoma
            // 
            this.lSoma.AutoSize = true;
            this.lSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSoma.Location = new System.Drawing.Point(28, 236);
            this.lSoma.Name = "lSoma";
            this.lSoma.Size = new System.Drawing.Size(51, 20);
            this.lSoma.TabIndex = 6;
            this.lSoma.Text = "Soma";
            // 
            // tbSoma
            // 
            this.tbSoma.BackColor = System.Drawing.SystemColors.Info;
            this.tbSoma.Enabled = false;
            this.tbSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoma.Location = new System.Drawing.Point(86, 233);
            this.tbSoma.Name = "tbSoma";
            this.tbSoma.Size = new System.Drawing.Size(133, 26);
            this.tbSoma.TabIndex = 7;
            this.tbSoma.TabStop = false;
            this.tbSoma.Text = "0";
            this.toolTip1.SetToolTip(this.tbSoma, "Soma dos números digitados");
            // 
            // bLimpar
            // 
            this.bLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimpar.Location = new System.Drawing.Point(302, 230);
            this.bLimpar.Name = "bLimpar";
            this.bLimpar.Size = new System.Drawing.Size(78, 29);
            this.bLimpar.TabIndex = 2;
            this.bLimpar.TabStop = false;
            this.bLimpar.Text = "Limpar";
            this.toolTip1.SetToolTip(this.bLimpar, "Limpar campos");
            this.bLimpar.UseVisualStyleBackColor = false;
            this.bLimpar.Click += new System.EventHandler(this.bLimpar_Click);
            // 
            // tbDigite
            // 
            this.tbDigite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDigite.Location = new System.Drawing.Point(166, 73);
            this.tbDigite.Name = "tbDigite";
            this.tbDigite.Size = new System.Drawing.Size(114, 26);
            this.tbDigite.TabIndex = 0;
            this.tbDigite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDigite_KeyPress);
            // 
            // lErro
            // 
            this.lErro.AutoSize = true;
            this.lErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErro.Location = new System.Drawing.Point(163, 111);
            this.lErro.Name = "lErro";
            this.lErro.Size = new System.Drawing.Size(0, 20);
            this.lErro.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbLista
            // 
            this.tbLista.BackColor = System.Drawing.SystemColors.Info;
            this.tbLista.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbLista.Enabled = false;
            this.tbLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLista.Location = new System.Drawing.Point(32, 172);
            this.tbLista.Multiline = true;
            this.tbLista.Name = "tbLista";
            this.tbLista.ReadOnly = true;
            this.tbLista.Size = new System.Drawing.Size(348, 52);
            this.tbLista.TabIndex = 9;
            this.tbLista.TabStop = false;
            this.toolTip1.SetToolTip(this.tbLista, "Números digitados, em ordem crescente");
            // 
            // fOrdenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(406, 313);
            this.Controls.Add(this.tbLista);
            this.Controls.Add(this.lErro);
            this.Controls.Add(this.tbDigite);
            this.Controls.Add(this.bLimpar);
            this.Controls.Add(this.tbSoma);
            this.Controls.Add(this.lSoma);
            this.Controls.Add(this.lLista);
            this.Controls.Add(this.lDigite);
            this.Controls.Add(this.bConfirmar);
            this.Name = "fOrdenador";
            this.Text = "Ordenador";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Label lDigite;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lLista;
        private System.Windows.Forms.Label lSoma;
        private System.Windows.Forms.TextBox tbSoma;
        private System.Windows.Forms.Button bLimpar;
        private System.Windows.Forms.TextBox tbDigite;
        private System.Windows.Forms.Label lErro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbLista;
    }
}

