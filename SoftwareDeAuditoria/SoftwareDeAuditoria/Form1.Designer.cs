﻿namespace SoftwareDeAuditoria
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcosDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requerimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeRecursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.proyectosToolStripMenuItem,
            this.marcosDeTrabajoToolStripMenuItem,
            this.recursosToolStripMenuItem,
            this.requerimientosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // marcosDeTrabajoToolStripMenuItem
            // 
            this.marcosDeTrabajoToolStripMenuItem.Name = "marcosDeTrabajoToolStripMenuItem";
            this.marcosDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.marcosDeTrabajoToolStripMenuItem.Text = "Marcos De Trabajo";
            // 
            // recursosToolStripMenuItem
            // 
            this.recursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.asignacionDeRecursosToolStripMenuItem});
            this.recursosToolStripMenuItem.Name = "recursosToolStripMenuItem";
            this.recursosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.recursosToolStripMenuItem.Text = "Recursos";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // requerimientosToolStripMenuItem
            // 
            this.requerimientosToolStripMenuItem.Name = "requerimientosToolStripMenuItem";
            this.requerimientosToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.requerimientosToolStripMenuItem.Text = "Requerimientos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // asignacionDeRecursosToolStripMenuItem
            // 
            this.asignacionDeRecursosToolStripMenuItem.Name = "asignacionDeRecursosToolStripMenuItem";
            this.asignacionDeRecursosToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.asignacionDeRecursosToolStripMenuItem.Text = "Asignacion de Recursos";
            this.asignacionDeRecursosToolStripMenuItem.Click += new System.EventHandler(this.asignacionDeRecursosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcosDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requerimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeRecursosToolStripMenuItem;
    }
}

