using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CreativeModePlus
{
 partial class Tools
 {
  [ DllImport( "User32" )]
  private static extern int RemoveMenu( IntPtr menu, int pos, int flags );

  [ DllImport( "User32" )]
  private static extern IntPtr GetSystemMenu( IntPtr win, bool revert );

  [ DllImport( "User32" )]
  private static extern int GetMenuItemCount( IntPtr win );

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
  private void InitializeComponent( Form main )
  {
   String file  = "CreativeModePlus.res.brush.",
          fname = "";
   IntPtr hThis;
   int items;
   btnSelect = new Button();
   btnMove = new Button();
   btnFill = new Button();
   btnPaint = new Button();
   btnPencil = new Button();
   btnDummy = new Button();
   SuspendLayout();
   // 
   // btnSelect
   // 
   btnSelect.Location = new System.Drawing.Point(1, 1);
   btnSelect.Name = "btnSelect";
   btnSelect.Size = new System.Drawing.Size(25, 25);
   btnSelect.TabIndex = 5;
   fname = file + "Select_btn.png";
   btnSelect.Image =
    Image.FromStream( Asm.exe.GetManifestResourceStream( fname ));
   btnSelect.UseVisualStyleBackColor = true;
   btnSelect.Click += new EventHandler( btn_Pressed );
   // 
   // btnMove
   // 
   btnMove.Location = new System.Drawing.Point(27, 1);
   btnMove.Name = "btnMove";
   btnMove.Size = new System.Drawing.Size(25, 25);
   btnMove.TabIndex = 1;
   fname = file + "MoveSelect_btn.png";
   btnMove.Image =
    Image.FromStream( Asm.exe.GetManifestResourceStream( fname ));
   btnMove.UseVisualStyleBackColor = true;
   btnMove.Click += new EventHandler( btn_Pressed );
   // 
   // btnFill
   // 
   btnFill.Location = new System.Drawing.Point(27, 27);
   btnFill.Name = "btnFill";
   btnFill.Size = new System.Drawing.Size(25, 25);
   btnFill.TabIndex = 3;
   fname = file + "Fill_btn.png";
   btnFill.Image =
    Image.FromStream( Asm.exe.GetManifestResourceStream( fname ));
   btnFill.UseVisualStyleBackColor = true;
   btnFill.Click += new EventHandler( btn_Pressed );
   // 
   // btnPaint
   // 
   btnPaint.Location = new System.Drawing.Point(1, 27);
   btnPaint.Name = "btnPaint";
   btnPaint.Size = new System.Drawing.Size(25, 25);
   btnPaint.TabIndex = 2;
   fname = file + "Paint_btn.png";
   btnPaint.Image =
    Image.FromStream( Asm.exe.GetManifestResourceStream( fname ));
   btnPaint.UseVisualStyleBackColor = true;
   btnPaint.Click += new EventHandler( btn_Pressed );
   // 
   // btnPencil
   // 
   btnPencil.Location = new System.Drawing.Point(1, 53);
   btnPencil.Name = "btnPencil";
   btnPencil.Size = new System.Drawing.Size(25, 25);
   btnPencil.TabIndex = 4;
   fname = file + "Pencil_btn.png";
   btnPencil.Image =
    Image.FromStream( Asm.exe.GetManifestResourceStream( fname ));
   btnPencil.UseVisualStyleBackColor = true;
   btnPencil.Click += new EventHandler( btn_Pressed );
   //
   // btnDummy
   //
   btnDummy.Location = new Point( 100, 100 );
   btnDummy.TabIndex = 0;
   btnDummy.Size = new Size( 25, 25 );
   btnDummy.UseVisualStyleBackColor = true;
   btnDummy.Name = "btnDummy";
   // 
   // Tools
   //
   fname = "CreativeModePlus.res.Minecraft-Icon.ico";
   Bitmap icon = new Bitmap( Asm.exe.GetManifestResourceStream( fname ));
   Icon = Icon.FromHandle( icon.GetHicon());
   AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   AutoScaleMode = AutoScaleMode.Font;
   ClientSize = new System.Drawing.Size(53, 80);
   Controls.Add(btnPencil);
   Controls.Add(btnFill);
   Controls.Add(btnPaint);
   Controls.Add(btnMove);
   Controls.Add(btnSelect);
   Controls.Add(btnDummy);
   FormBorderStyle = FormBorderStyle.FixedToolWindow;
   Location = new Point( main.Location.X + 12, 
                         main.Location.Y + main.Height - 142 );
   MaximizeBox = false;
   MinimizeBox = false;
   Name = "Tools";
   StartPosition = FormStartPosition.Manual;
   Text = "Tools";
   TopMost = true;
   ResumeLayout(false);

   Activated += new EventHandler( Tools_Activated );
   Deactivate += new EventHandler( Tools_Deactivate );

   hThis = GetSystemMenu( this.Handle, false );
   items = GetMenuItemCount( hThis );
   RemoveMenu( hThis, items - 1, 0x400 );

  }

  #endregion

  private Button btnSelect;
  private Button btnMove;
  private Button btnFill;
  private Button btnPaint;
  private Button btnPencil;
  private Button btnDummy;

 }
}