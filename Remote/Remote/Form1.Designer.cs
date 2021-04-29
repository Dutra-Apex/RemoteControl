namespace controleCarrinho
{
    partial class Form1
    {
        /// <summary>
        /// Necessary design variable
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clear resources being utilized.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_Velocidade = new System.Windows.Forms.TrackBar();
            this.loop = new System.Windows.Forms.Timer(this.components);
            this.btn_Farol = new System.Windows.Forms.Button();
            this.btn_Lanterna = new System.Windows.Forms.Button();
            this.tb_Serial = new System.Windows.Forms.TextBox();
            this.btn_ConectarSerial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btn_Buzina = new System.Windows.Forms.PictureBox();
            this.btn_Esquerda = new System.Windows.Forms.PictureBox();
            this.btn_Re = new System.Windows.Forms.PictureBox();
            this.btn_Frente = new System.Windows.Forms.PictureBox();
            this.btn_Direita = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Velocidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buzina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Esquerda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Re)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Frente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Direita)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Velocidade
            // 
            this.tb_Velocidade.LargeChange = 10;
            this.tb_Velocidade.Location = new System.Drawing.Point(256, 5);
            this.tb_Velocidade.Name = "tb_Velocidade";
            this.tb_Velocidade.Size = new System.Drawing.Size(133, 45);
            this.tb_Velocidade.TabIndex = 6;
            this.tb_Velocidade.Scroll += new System.EventHandler(this.tb_Velocidade_Scroll);
            // 
            // loop
            // 
            this.loop.Tick += new System.EventHandler(this.loop_Tick);
            // 
            // btn_Farol
            // 
            this.btn_Farol.Location = new System.Drawing.Point(285, 56);
            this.btn_Farol.Name = "btn_Farol";
            this.btn_Farol.Size = new System.Drawing.Size(104, 23);
            this.btn_Farol.TabIndex = 7;
            this.btn_Farol.Text = "Ligar Farol";
            this.btn_Farol.UseVisualStyleBackColor = true;
            this.btn_Farol.Click += new System.EventHandler(this.btn_Farol_Click);
            // 
            // btn_Lanterna
            // 
            this.btn_Lanterna.Location = new System.Drawing.Point(285, 85);
            this.btn_Lanterna.Name = "btn_Lanterna";
            this.btn_Lanterna.Size = new System.Drawing.Size(104, 23);
            this.btn_Lanterna.TabIndex = 8;
            this.btn_Lanterna.Text = "Ligar Lanterna";
            this.btn_Lanterna.UseVisualStyleBackColor = true;
            this.btn_Lanterna.Click += new System.EventHandler(this.btn_Lanterna_Click);
            // 
            // tb_Serial
            // 
            this.tb_Serial.Location = new System.Drawing.Point(300, 136);
            this.tb_Serial.Name = "tb_Serial";
            this.tb_Serial.Size = new System.Drawing.Size(49, 20);
            this.tb_Serial.TabIndex = 12;
            this.tb_Serial.Text = "COM1";
            // 
            // btn_ConectarSerial
            // 
            this.btn_ConectarSerial.Location = new System.Drawing.Point(355, 135);
            this.btn_ConectarSerial.Name = "btn_ConectarSerial";
            this.btn_ConectarSerial.Size = new System.Drawing.Size(75, 20);
            this.btn_ConectarSerial.TabIndex = 13;
            this.btn_ConectarSerial.Text = "Conectar";
            this.btn_ConectarSerial.UseVisualStyleBackColor = true;
            this.btn_ConectarSerial.Click += new System.EventHandler(this.btn_ConectarSerial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::controleCarrinho.Properties.Resources.velocimetro_alto;
            this.pictureBox6.Location = new System.Drawing.Point(395, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::controleCarrinho.Properties.Resources.velocimetro_baixo;
            this.pictureBox7.Location = new System.Drawing.Point(215, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 31);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // btn_Buzina
            // 
            this.btn_Buzina.Image = global::controleCarrinho.Properties.Resources.buzina_off;
            this.btn_Buzina.Location = new System.Drawing.Point(215, 56);
            this.btn_Buzina.Name = "btn_Buzina";
            this.btn_Buzina.Size = new System.Drawing.Size(43, 34);
            this.btn_Buzina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Buzina.TabIndex = 9;
            this.btn_Buzina.TabStop = false;
            this.btn_Buzina.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Buzina_MouseDown);
            this.btn_Buzina.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Buzina_MouseUp);
            // 
            // btn_Esquerda
            // 
            this.btn_Esquerda.Image = global::controleCarrinho.Properties.Resources.seta_esquerda_off;
            this.btn_Esquerda.Location = new System.Drawing.Point(12, 56);
            this.btn_Esquerda.Name = "btn_Esquerda";
            this.btn_Esquerda.Size = new System.Drawing.Size(50, 50);
            this.btn_Esquerda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Esquerda.TabIndex = 5;
            this.btn_Esquerda.TabStop = false;
            this.btn_Esquerda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Esquerda_MouseDown);
            this.btn_Esquerda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Esquerda_MouseUp);
            // 
            // btn_Re
            // 
            this.btn_Re.Image = global::controleCarrinho.Properties.Resources.seta_re_off;
            this.btn_Re.Location = new System.Drawing.Point(68, 103);
            this.btn_Re.Name = "btn_Re";
            this.btn_Re.Size = new System.Drawing.Size(50, 50);
            this.btn_Re.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Re.TabIndex = 4;
            this.btn_Re.TabStop = false;
            this.btn_Re.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Re_MouseDown);
            this.btn_Re.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Re_MouseUp);
            // 
            // btn_Frente
            // 
            this.btn_Frente.Image = global::controleCarrinho.Properties.Resources.seta_frente_off;
            this.btn_Frente.Location = new System.Drawing.Point(68, 9);
            this.btn_Frente.Name = "btn_Frente";
            this.btn_Frente.Size = new System.Drawing.Size(50, 50);
            this.btn_Frente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Frente.TabIndex = 3;
            this.btn_Frente.TabStop = false;
            this.btn_Frente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Frente_MouseDown);
            this.btn_Frente.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Frente_MouseUp);
            // 
            // btn_Direita
            // 
            this.btn_Direita.Image = global::controleCarrinho.Properties.Resources.seta_direita_off;
            this.btn_Direita.Location = new System.Drawing.Point(124, 56);
            this.btn_Direita.Name = "btn_Direita";
            this.btn_Direita.Size = new System.Drawing.Size(50, 50);
            this.btn_Direita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Direita.TabIndex = 2;
            this.btn_Direita.TabStop = false;
            this.btn_Direita.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Direita_MouseDown);
            this.btn_Direita.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Direita_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 167);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ConectarSerial);
            this.Controls.Add(this.tb_Serial);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btn_Buzina);
            this.Controls.Add(this.btn_Lanterna);
            this.Controls.Add(this.btn_Farol);
            this.Controls.Add(this.btn_Esquerda);
            this.Controls.Add(this.btn_Re);
            this.Controls.Add(this.btn_Frente);
            this.Controls.Add(this.btn_Direita);
            this.Controls.Add(this.tb_Velocidade);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Velocidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buzina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Esquerda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Re)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Frente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Direita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btn_Direita;
        private System.Windows.Forms.PictureBox btn_Frente;
        private System.Windows.Forms.PictureBox btn_Re;
        private System.Windows.Forms.PictureBox btn_Esquerda;
        private System.Windows.Forms.TrackBar tb_Velocidade;
        private System.Windows.Forms.Timer loop;
        private System.Windows.Forms.Button btn_Farol;
        private System.Windows.Forms.Button btn_Lanterna;
        private System.Windows.Forms.PictureBox btn_Buzina;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox tb_Serial;
        private System.Windows.Forms.Button btn_ConectarSerial;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

