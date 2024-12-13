namespace GestiónTareasPendientes
{
    partial class Tareas
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
            txtTarea = new TextBox();
            btnAgregarTare = new Button();
            lstTareas = new ListBox();
            btnEliminarTarea = new Button();
            SuspendLayout();
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(29, 33);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(239, 23);
            txtTarea.TabIndex = 0;
            txtTarea.TextChanged += txtTarea_TextChanged;
            // 
            // btnAgregarTare
            // 
            btnAgregarTare.BackColor = Color.FromArgb(192, 192, 255);
            btnAgregarTare.Location = new Point(29, 62);
            btnAgregarTare.Name = "btnAgregarTare";
            btnAgregarTare.Size = new Size(99, 23);
            btnAgregarTare.TabIndex = 1;
            btnAgregarTare.Text = "Agregar Tarea";
            btnAgregarTare.UseVisualStyleBackColor = false;
            btnAgregarTare.Click += button1_Click;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(29, 90);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(734, 259);
            lstTareas.TabIndex = 2;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.BackColor = Color.FromArgb(192, 192, 255);
            btnEliminarTarea.Location = new Point(29, 355);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(734, 23);
            btnEliminarTarea.TabIndex = 3;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = false;
            btnEliminarTarea.Click += button2_Click;
            // 
            // Tareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarTarea);
            Controls.Add(lstTareas);
            Controls.Add(btnAgregarTare);
            Controls.Add(txtTarea);
            Name = "Tareas";
            Text = "Tareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTarea;
        private Button btnAgregarTare;
        private ListBox lstTareas;
        private Button btnEliminarTarea;
    }
}
