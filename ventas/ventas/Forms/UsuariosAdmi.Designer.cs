/*
 * Creado por SharpDevelop.
 * Usuario: JL
 * Fecha: 10/05/2018
 * Hora: 01:06 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas
{
	partial class UsuariosAdmi
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonAddUsers;
		private System.Windows.Forms.Button buttonShowUsrAdmi;
		private System.Windows.Forms.Button buttonShowUsers;
		private System.Windows.Forms.Button buttonDeleteUser;
		private System.Windows.Forms.Button buttonModificaUser;
		private System.Windows.Forms.Button button6;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonAddUsers = new System.Windows.Forms.Button();
			this.buttonShowUsrAdmi = new System.Windows.Forms.Button();
			this.buttonShowUsers = new System.Windows.Forms.Button();
			this.buttonDeleteUser = new System.Windows.Forms.Button();
			this.buttonModificaUser = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonAddUsers
			// 
			this.buttonAddUsers.Location = new System.Drawing.Point(21, 12);
			this.buttonAddUsers.Name = "buttonAddUsers";
			this.buttonAddUsers.Size = new System.Drawing.Size(75, 43);
			this.buttonAddUsers.TabIndex = 0;
			this.buttonAddUsers.Text = "Agregar Usuarios";
			this.buttonAddUsers.UseVisualStyleBackColor = true;
			this.buttonAddUsers.Click += new System.EventHandler(this.ButtonAddUsersClick);
			// 
			// buttonShowUsrAdmi
			// 
			this.buttonShowUsrAdmi.Location = new System.Drawing.Point(124, 12);
			this.buttonShowUsrAdmi.Name = "buttonShowUsrAdmi";
			this.buttonShowUsrAdmi.Size = new System.Drawing.Size(75, 43);
			this.buttonShowUsrAdmi.TabIndex = 1;
			this.buttonShowUsrAdmi.Text = "Ver Usuarios Admin";
			this.buttonShowUsrAdmi.UseVisualStyleBackColor = true;
			this.buttonShowUsrAdmi.Click += new System.EventHandler(this.ButtonShowUsrAdmiClick);
			// 
			// buttonShowUsers
			// 
			this.buttonShowUsers.Location = new System.Drawing.Point(215, 12);
			this.buttonShowUsers.Name = "buttonShowUsers";
			this.buttonShowUsers.Size = new System.Drawing.Size(75, 43);
			this.buttonShowUsers.TabIndex = 2;
			this.buttonShowUsers.Text = "Ver Usuarios ";
			this.buttonShowUsers.UseVisualStyleBackColor = true;
			this.buttonShowUsers.Click += new System.EventHandler(this.ButtonShowUsersClick);
			// 
			// buttonDeleteUser
			// 
			this.buttonDeleteUser.Location = new System.Drawing.Point(308, 12);
			this.buttonDeleteUser.Name = "buttonDeleteUser";
			this.buttonDeleteUser.Size = new System.Drawing.Size(75, 43);
			this.buttonDeleteUser.TabIndex = 3;
			this.buttonDeleteUser.Text = "Borrar Usuario";
			this.buttonDeleteUser.UseVisualStyleBackColor = true;
			this.buttonDeleteUser.Click += new System.EventHandler(this.ButtonDeleteUserClick);
			// 
			// buttonModificaUser
			// 
			this.buttonModificaUser.Location = new System.Drawing.Point(405, 12);
			this.buttonModificaUser.Name = "buttonModificaUser";
			this.buttonModificaUser.Size = new System.Drawing.Size(75, 43);
			this.buttonModificaUser.TabIndex = 4;
			this.buttonModificaUser.Text = "Modificar Usuario";
			this.buttonModificaUser.UseVisualStyleBackColor = true;
			this.buttonModificaUser.Click += new System.EventHandler(this.ButtonModificaUserClick);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.Menu;
			this.button6.Location = new System.Drawing.Point(515, 53);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 35);
			this.button6.TabIndex = 5;
			this.button6.Text = "Menú Principal";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// UsuariosAdmi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 90);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.buttonModificaUser);
			this.Controls.Add(this.buttonDeleteUser);
			this.Controls.Add(this.buttonShowUsers);
			this.Controls.Add(this.buttonShowUsrAdmi);
			this.Controls.Add(this.buttonAddUsers);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UsuariosAdmi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "UsuariosAdmi";
			this.ResumeLayout(false);

		}
	}
}
