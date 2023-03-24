
namespace Tez_v1
{
    partial class DepoKayıtGenelEkranı
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonButton7 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::Tez_v1.Properties.Resources.shutdown__v1;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::Tez_v1.Properties.Resources.shutdown__v1;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::Tez_v1.Properties.Resources.shutdown__v1;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::Tez_v1.Properties.Resources.maximize_window__v1;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::Tez_v1.Properties.Resources.maximize_window__v1;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::Tez_v1.Properties.Resources.maximize_window__v1;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::Tez_v1.Properties.Resources.minimize_window__1_;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::Tez_v1.Properties.Resources.minimize_window__1_;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::Tez_v1.Properties.Resources.minimize_window__1_;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(3, 5, 3, -1);
            // 
            // kryptonButton7
            // 
            this.kryptonButton7.Location = new System.Drawing.Point(12, 12);
            this.kryptonButton7.Name = "kryptonButton7";
            this.kryptonButton7.Size = new System.Drawing.Size(83, 51);
            this.kryptonButton7.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton7.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonButton7.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.StateCommon.Border.Rounding = 15;
            this.kryptonButton7.TabIndex = 58;
            this.kryptonButton7.Values.Text = "    Depo\r\nTanımlama";
            this.kryptonButton7.Click += new System.EventHandler(this.kryptonButton7_Click);
            // 
            // DepoKayıtGenelEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(326, 196);
            this.Controls.Add(this.kryptonButton7);
            this.Name = "DepoKayıtGenelEkranı";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepoKayıtGenelEkranı";
            this.Load += new System.EventHandler(this.DepoKayıtGenelEkranı_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton7;
    }
}