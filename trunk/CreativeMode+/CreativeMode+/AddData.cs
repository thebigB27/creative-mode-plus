using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Substrate;
using Substrate.TileEntities;

namespace CreativeModePlus
{
 public partial class AddData : Form
 {
  public AddData( AlphaBlock plc, Form main )
  {
   InitializeComponent( main );

   selectData( plc, plc.ID );

  }

  private void selectData( AlphaBlock plc, int ID )
  {
   switch( ID )
   {
    default:
     plc.Data = 0;

    break;

    // Monster Spawner
    case 52:
     makeSpawner( plc );

    break;

    // Stairs
    case 53:
    case 67:
    case 108:
    case 109:
    case 114:
    case 128:
    case 134:
    case 135:
    case 136:
     makeStairs( plc );

    break;

    // Torches
    case 50:
    case 75:
    case 76:
     makeTorches( plc );

    break;

    // Repeaters
    case 93:
    case 94:
     makeRepeaters( plc );

    break;

    // Wood Logs
    case 17:
     makeLogs( plc );

    break;

    // Wood Planks, Leaves, Saplings, double slabs
    case 5:
    case 6:
    case 18:
    case 125:
     makeWoodType( plc );

    break;

    // Wood Slabs
    case 126:
     makeWoodSlabs( plc );

    break;

    // Special Rails
    case 27:
    case 28:
     makeSpRails( plc );

    break;

    // Rails
    case 66:
     makeRails( plc );

    break;

    // Pistons
    case 29:
    case 33:
     makePistons( plc );

    break;

    // Tall Grass
    case 31:
     makeGrass( plc );

    break;

    // Wool
    case 35:
     makeWool( plc );

    break;

    // Stone Slabs & doubles
    case 43:
    case 44:
     makeStoneSlabs( plc );

    break;

    // Chests, Furnaces, Ladders, Wall Signs, Dispensers
    case 23:
    case 54:
    case 61:
    case 62:
    case 65:
    case 68:
    case 130:
     makeChests( plc );

    break;

    // End Portal Frame & pumpkins
    case 86:
    case 91:
    case 120:
     makeEndPortalFrame( plc );

    break;

    // Buttons
    case 77:
     makeButtons( plc );

    break;

    // Sign
    case 63:
     makeSign( plc );

    break;

    // Crops
    case 59:
    case 104:
    case 105:
     makeCrops( plc );

    break;

    // Nether Wart
    case 115:
     makeWart( plc );

    break;

    // Farmland
    case 60:
     makeFarm( plc );

    break;

    // Redstone
    case 55:
     makeWires( plc );

    break;

    // Trip Wire Hooks
    case 131:
     makeHooks( plc );

    break;

    // Lever
    case 69:
     makeLevers( plc );

    break;

    // Bed
    case 26:
     makeBed( plc );

    break;

    // Doors
    case 64:
    case 71:
     makeDoors( plc );

    break;

    // Fence Gate
    case 107:
     makeFence( plc );

    break;

    // Trap Door
    case 96:
     makeTraps( plc );

    break;

    // Monster Eggs
    case 97:
     makeEggs( plc );

    break;

    // Stone Brick
    case 98:
     makeStoneBrick( plc );

    break;

    // Sandstone
    case 24:
     makeSandstone( plc );

    break;

    // Vines
    case 106:
     makeVines( plc );

    break;

   }
  }

  private void makeStairs( AlphaBlock plc )
  {
   RadioButton n = new RadioButton(),
               s = new RadioButton(),
               e = new RadioButton(),
               w = new RadioButton();
   CheckBox    inv = new CheckBox();
   Label       opt = new Label();

   Size = new Size( 200, 159 );

   // Set Item Text
   opt.Text = "Stair Options";
   n.Text   = "North";
   s.Text   = "South";
   e.Text   = "East";
   w.Text   = "West";
   inv.Text = "Invert";

   Controls.AddRange( new Control[]{ opt, n, s, e, w, inv });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   n.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   e.Location       = new Point( 15, 50 );
   w.Location       = new Point( 125, 50 );
   inv.Location     = new Point( 15, 73 );
   btnData.Location = new Point( 15, 96 );

   n.Checked = true;

   ShowDialog();

   if( e.Checked )
    plc.Data = 0;

   else if( w.Checked )
    plc.Data = 1;

   else if( s.Checked )
    plc.Data = 2;

   else
    plc.Data = 3;

   if( inv.Checked )
    plc.Data += 4;

  }

  private void makeTorches( AlphaBlock plc )
  {
   RadioButton n = new RadioButton(),
               s = new RadioButton(),
               e = new RadioButton(),
               w = new RadioButton(),
               g = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 200, 159 );

   // Set Item Text
   opt.Text = "Torch Options";
   n.Text   = "North";
   s.Text   = "South";
   e.Text   = "East";
   w.Text   = "West";
   g.Text   = "Ground";

   Controls.AddRange( new Control[]{ opt, n, s, e, w, g });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   n.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   e.Location       = new Point( 15, 50 );
   w.Location       = new Point( 125, 50 );
   g.Location       = new Point( 15, 73 );
   btnData.Location = new Point( 15, 96 );

   g.Checked = true;

   ShowDialog();

   if( e.Checked )
    plc.Data = 1;

   else if( w.Checked )
    plc.Data = 2;

   else if( s.Checked )
    plc.Data = 3;

   else if( n.Checked )
    plc.Data = 4;

   else
    plc.Data = 5;

  }

  private void makeRepeaters( AlphaBlock plc )
  {
   RadioButton n = new RadioButton(),
               s = new RadioButton(),
               e = new RadioButton(),
               w = new RadioButton();
   Label       opt = new Label(),
               tik = new Label();
   HScrollBar  tkB = new HScrollBar();

   Size = new Size( 200, 185 );

   // Set Item Text
   opt.Text = "Repeater Options";
   n.Text   = "North";
   s.Text   = "South";
   e.Text   = "East";
   w.Text   = "West";
   tik.Text = tik.Name = "1 Tick";

   // Set Ranges
   tkB.Minimum = 1;
   tkB.Maximum = 13;
   tkB.Value   = 1;
   tkB.Size    = new Size( 170, 17 );
   tkB.ValueChanged += new EventHandler( tkB_ValueChanged );

   Controls.AddRange( new Control[]{ opt, n, s, e, w, tik, tkB });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   n.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   e.Location       = new Point( 15, 50 );
   w.Location       = new Point( 125, 50 );
   tik.Location     = new Point( 15, 73 );
   tkB.Location     = new Point( 15, 96 );
   btnData.Location = new Point( 15, 119 );

   n.Checked = true;

   ShowDialog();

   if( e.Checked )
    plc.Data = 1;

   else if( w.Checked )
    plc.Data = 3;

   else if( s.Checked )
    plc.Data = 2;

   else
    plc.Data = 0;

   plc.Data += ( tkB.Value - 1 ) * 4;

  }

  private void tkB_ValueChanged( Object sender, EventArgs e )
  {
   Control[] tik = Controls.Find( "1 Tick", true );

   HScrollBar tkB = (( HScrollBar ) sender );

   tik[ 0 ].Text = "" + tkB.Value + " Tick";

   if( tkB.Value > 1 )
    tik[ 0 ].Text += "s";

  }

  private void makeLogs( AlphaBlock plc )
  {
   RadioButton o  = new RadioButton(),
               s  = new RadioButton(),
               b  = new RadioButton(),
               m  = new RadioButton();
   ComboBox    ort = new ComboBox();
   Label       opt = new Label();

   Size = new Size( 200, 159 );

   // Set Item Text
   opt.Text = "Log Options";
   o.Text   = "Oak";
   s.Text   = "Spruce";
   b.Text   = "Birch";
   m.Text   = "Jungle";

   ort.Items.AddRange( new object[]{ "Up-Down", "East-West", "North-South" });
   Controls.AddRange( new Control[]{ opt, o, s, b, m, ort });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   o.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   b.Location       = new Point( 15, 50 );
   m.Location       = new Point( 125, 50 );
   ort.Location     = new Point( 15, 75 );
   btnData.Location = new Point( 15, 98 );

   o.Checked = true;
   ort.SelectedIndex = 0;

   ShowDialog();

   if( b.Checked )
    plc.Data = 2;

   else if( m.Checked )
    plc.Data = 3;

   else if( s.Checked )
    plc.Data = 1;

   else
    plc.Data = 0;

   if( ort.SelectedIndex == 0 )
    plc.Data += 0;

   else if( ort.SelectedIndex == 1 )
    plc.Data += 4;

   else
    plc.Data += 8;

  }

  private void makeWoodType( AlphaBlock plc )
  {
   RadioButton o  = new RadioButton(),
               s  = new RadioButton(),
               b  = new RadioButton(),
               m  = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 200, 136 );

   // Set Item Text
   opt.Text = "Wood Options";
   o.Text   = "Oak";
   s.Text   = "Spruce";
   b.Text   = "Birch";
   m.Text   = "Jungle";

   Controls.AddRange( new Control[]{ opt, o, s, b, m });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   o.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   b.Location       = new Point( 15, 50 );
   m.Location       = new Point( 125, 50 );
   btnData.Location = new Point( 15, 73 );

   o.Checked = true;

   ShowDialog();

   if( b.Checked )
    plc.Data = 2;

   else if( m.Checked )
    plc.Data = 3;

   else if( s.Checked )
    plc.Data = 1;

   else
    plc.Data = 0;

  }

  private void makeWoodSlabs( AlphaBlock plc )
  {
   RadioButton o  = new RadioButton(),
               s  = new RadioButton(),
               b  = new RadioButton(),
               m  = new RadioButton();
   CheckBox    inv = new CheckBox();
   Label       opt = new Label();

   Size = new Size( 200, 159 );

   // Set Item Text
   opt.Text = "Stair Options";
   o.Text   = "Oak";
   s.Text   = "Spruce";
   b.Text   = "Birch";
   m.Text   = "Jungle";
   inv.Text = "Invert";

   Controls.AddRange( new Control[]{ opt, o, s, b, m, inv });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   o.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   b.Location       = new Point( 15, 50 );
   m.Location       = new Point( 125, 50 );
   inv.Location     = new Point( 15, 73 );
   btnData.Location = new Point( 15, 96 );

   o.Checked = true;

   ShowDialog();

   if( b.Checked )
    plc.Data = 2;

   else if( m.Checked )
    plc.Data = 3;

   else if( s.Checked )
    plc.Data = 1;

   else
    plc.Data = 0;

   if( inv.Checked )
    plc.Data += 8;

  }

  private void makeSpRails( AlphaBlock plc )
  {
   RadioButton ns = new RadioButton(),
               ew = new RadioButton(),
               n  = new RadioButton(),
               s  = new RadioButton(),
               e  = new RadioButton(),
               w  = new RadioButton();
   CheckBox    pwr = new CheckBox();
   Label       opt = new Label();

   Size = new Size( 350, 159 );

   // Set Item Text
   opt.Text = "Special Rail Options";
   ns.Text  = "North-South";
   ew.Text  = "East-West";
   n.Text   = "Ascend North";
   s.Text   = "Ascend South";
   e.Text   = "Ascend East";
   w.Text   = "Ascend West";
   pwr.Text = "Powered";

   Controls.AddRange( new Control[]{ opt, ns, n, s, ew, e, w, pwr });

   if( plc.ID == 28 )
    pwr.Enabled = false;

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   ns.Location      = new Point( 15, 27 );
   n.Location       = new Point( 125, 27 );
   s.Location       = new Point( 235, 27 );
   ew.Location      = new Point( 15, 50 );
   e.Location       = new Point( 125, 50 );
   w.Location       = new Point( 235, 50 );
   pwr.Location     = new Point( 15, 73 );
   btnData.Location = new Point( 15, 96 );

   ns.Checked = true;

   ShowDialog();

   if( ns.Checked )
    plc.Data = 0;

   else if( ew.Checked )
    plc.Data = 1;

   else if( e.Checked )
    plc.Data = 2;

   else if( w.Checked )
    plc.Data = 3;

   else if( n.Checked )
    plc.Data = 4;

   else
    plc.Data = 5;

   if( pwr.Checked )
    plc.Data += 8;

  }

  private void makeRails( AlphaBlock plc )
  {
   ComboBoxWithIcons ort = new ComboBoxWithIcons();
   Label             opt = new Label();

   Size = new Size( 200, 120 );

   // Set Item Text
   opt.Text = "Rail Options";
   
   // Set Item Configuation
   ort.DropDownStyle = ComboBoxStyle.DropDownList;
   ort.DrawMode = DrawMode.OwnerDrawFixed;

   populate( ort );

   Controls.AddRange( new Control[]{ opt, ort });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   ort.Location     = new Point( 15, 29 );
   btnData.Location = new Point( 15, 55 );

   ort.SelectedIndex = 0;

   ShowDialog();

   plc.Data = ort.SelectedIndex;

  }

  private void populate( ComboBoxWithIcons ort )
  {
   String   pop = "CreativeModePlus.res.block_icons.rails.";
   Assembly exe = Assembly.GetExecutingAssembly();

   ort.Add( "North-South",
            Image.FromStream( exe.GetManifestResourceStream( pop + "0.png" )),
            -1 );
   ort.Add( "East-West",
            Image.FromStream( exe.GetManifestResourceStream( pop + "1.png" )),
            -1 );
   ort.Add( "Ascend East",
            Image.FromStream( exe.GetManifestResourceStream( pop + "1.png" )),
            -1 );
   ort.Add( "Ascend West",
            Image.FromStream( exe.GetManifestResourceStream( pop + "1.png" )),
            -1 );
   ort.Add( "Ascend North",
            Image.FromStream( exe.GetManifestResourceStream( pop + "0.png" )),
            -1 );
   ort.Add( "Ascend South",
            Image.FromStream( exe.GetManifestResourceStream( pop + "0.png" )),
            -1 );
   ort.Add( "South to East",
            Image.FromStream( exe.GetManifestResourceStream( pop + "2.png" )),
            -1 );
   ort.Add( "South to West",
            Image.FromStream( exe.GetManifestResourceStream( pop + "3.png" )),
            -1 );
   ort.Add( "North to West",
            Image.FromStream( exe.GetManifestResourceStream( pop + "4.png" )),
            -1 );
   ort.Add( "North to East",
            Image.FromStream( exe.GetManifestResourceStream( pop + "5.png" )),
            -1 );

  }

  private void makePistons( AlphaBlock plc )
  {
   RadioButton d  = new RadioButton(),
               u  = new RadioButton(),
               n  = new RadioButton(),
               s  = new RadioButton(),
               e  = new RadioButton(),
               w  = new RadioButton();
   CheckBox    pwr = new CheckBox();
   Label       opt = new Label();

   Size = new Size( 350, 159 );

   // Set Item Text
   opt.Text = "Piston Options";
   d.Text   = "Down";
   u.Text   = "Up";
   n.Text   = "North";
   s.Text   = "South";
   e.Text   = "East";
   w.Text   = "West";
   pwr.Text = "Extended";

   Controls.AddRange( new Control[]{ opt, d, n, s, u, e, w, pwr });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   d.Location       = new Point( 15, 27 );
   n.Location       = new Point( 125, 27 );
   s.Location       = new Point( 235, 27 );
   u.Location       = new Point( 15, 50 );
   e.Location       = new Point( 125, 50 );
   w.Location       = new Point( 235, 50 );
   pwr.Location     = new Point( 15, 73 );
   btnData.Location = new Point( 15, 96 );

   d.Checked = true;

   ShowDialog();

   if( d.Checked )
    plc.Data = 0;

   else if( u.Checked )
    plc.Data = 1;

   else if( n.Checked )
    plc.Data = 2;

   else if( s.Checked )
    plc.Data = 3;

   else if( w.Checked )
    plc.Data = 4;

   else
    plc.Data = 5;

   if( pwr.Checked )
    plc.Data += 8;

  }

  private void makeGrass( AlphaBlock plc )
  {
   RadioButton t = new RadioButton(),
               s = new RadioButton(),
               f = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 200, 159 );

   // Set Item Text
   opt.Text = "Grass Options";
   t.Text   = "Tall Grass";
   s.Text   = "Dead Shurb";
   f.Text   = "Fern";

   Controls.AddRange( new Control[]{ opt, t, s, f });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   t.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   f.Location       = new Point( 15, 50 );
   btnData.Location = new Point( 15, 73 );

   t.Checked = true;

   ShowDialog();

   if( s.Checked )
    plc.Data = 0;

   else if( t.Checked )
    plc.Data = 1;

   else 
    plc.Data = 2;

  }

  private void makeWool( AlphaBlock plc )
  {
   ComboBox ort = new ComboBox();
   Label    opt = new Label();

   Size = new Size( 200, 120 );

   // Set Item Text
   opt.Text = "Wool Options";
   
   ort.Items.AddRange( new object[]{ "White",
                                     "Orange",
                                     "Magenta",
                                     "Light Blue",
                                     "Yellow",
                                     "Lime",
                                     "Pink",
                                     "Gray",
                                     "Light Gray",
                                     "Cyan",
                                     "Purple",
                                     "Blue",
                                     "Brown",
                                     "Green",
                                     "Red",
                                     "Black" });
   Controls.AddRange( new Control[]{ opt, ort });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   ort.Location     = new Point( 15, 29 );
   btnData.Location = new Point( 15, 55 );

   ort.SelectedIndex = 0;

   ShowDialog();

   plc.Data = ort.SelectedIndex;

  }

  private void makeStoneSlabs( AlphaBlock plc )
  {
   RadioButton ss = new RadioButton(),
               cs = new RadioButton(),
               b  = new RadioButton(),
               s  = new RadioButton(),
               sb = new RadioButton();
   CheckBox    pwr = new CheckBox();
   Label       opt = new Label();

   Size = new Size( 350, 159 );

   // Set Item Text
   opt.Text = "Piston Options";
   ss.Text  = "Sandstone";
   cs.Text  = "Cobblestone";
   b.Text   = "Brick";
   s.Text   = "Stone";
   sb.Text  = "Stone Brick";
   pwr.Text = "Inverted";

   Controls.AddRange( new Control[]{ opt, s, b, ss, cs, sb, pwr });

   if( plc.ID == 43 )
    pwr.Enabled = false;

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   s.Location       = new Point( 15, 27 );
   b.Location       = new Point( 125, 27 );
   ss.Location      = new Point( 235, 27 );
   cs.Location      = new Point( 15, 50 );
   sb.Location      = new Point( 125, 50 );
   pwr.Location     = new Point( 15, 73 );
   btnData.Location = new Point( 15, 96 );

   s.Checked = true;

   ShowDialog();

   if( s.Checked )
    plc.Data = 0;

   else if( ss.Checked )
    plc.Data = 1;

   else if( cs.Checked )
    plc.Data = 3;

   else if( b.Checked )
    plc.Data = 4;

   else
    plc.Data = 5;

   if( pwr.Checked )
    plc.Data += 8;

  }

  private void makeChests( AlphaBlock plc )
  {
   RadioButton n = new RadioButton(),
               s = new RadioButton(),
               e = new RadioButton(),
               w = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 200, 136 );

   // Set Item Text
   opt.Text = plc.Info.Name + " Options";
   n.Text   = "North";
   s.Text   = "South";
   e.Text   = "East";
   w.Text   = "West";

   Controls.AddRange( new Control[]{ opt, n, s, e, w });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   n.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   e.Location       = new Point( 15, 50 );
   w.Location       = new Point( 125, 50 );
   btnData.Location = new Point( 15, 73 );

   n.Checked = true;

   ShowDialog();

   if( e.Checked )
    plc.Data = 5;

   else if( w.Checked )
    plc.Data = 4;

   else if( s.Checked )
    plc.Data = 3;

   else
    plc.Data = 2;

  }

  private void makeEndPortalFrame( AlphaBlock plc )
  {
   RadioButton n = new RadioButton(),
               s = new RadioButton(),
               e = new RadioButton(),
               w = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 200, 136 );

   // Set Item Text
   opt.Text = plc.Info.Name + " Options";
   n.Text   = "North";
   s.Text   = "South";
   e.Text   = "East";
   w.Text   = "West";

   Controls.AddRange( new Control[]{ opt, n, s, e, w });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   n.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   e.Location       = new Point( 15, 50 );
   w.Location       = new Point( 125, 50 );
   btnData.Location = new Point( 15, 73 );

   n.Checked = true;

   ShowDialog();

   if( e.Checked )
    plc.Data = 3;

   else if( w.Checked )
    plc.Data = 1;

   else if( s.Checked )
    plc.Data = 0;

   else
    plc.Data = 2;

  }

  private void makeButtons( AlphaBlock plc )
  {
   RadioButton n = new RadioButton(),
               s = new RadioButton(),
               e = new RadioButton(),
               w = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 200, 136 );

   // Set Item Text
   opt.Text = "Button Options";
   n.Text   = "North";
   s.Text   = "South";
   e.Text   = "East";
   w.Text   = "West";

   Controls.AddRange( new Control[]{ opt, n, s, e, w });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   n.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   e.Location       = new Point( 15, 50 );
   w.Location       = new Point( 125, 50 );
   btnData.Location = new Point( 15, 73 );

   n.Checked = true;

   ShowDialog();

   if( e.Checked )
    plc.Data = 1;

   else if( w.Checked )
    plc.Data = 2;

   else if( s.Checked )
    plc.Data = 3;

   else
    plc.Data = 4;

  }

  private void makeSign( AlphaBlock plc )
  {
   ComboBox ort = new ComboBox();
   Label    opt = new Label();

   Size = new Size( 200, 120 );

   // Set Item Text
   opt.Text = "Sign Post Options";
   
   ort.Items.AddRange( new object[]{ "South",
                                     "South-Southwest",
                                     "Southwest",
                                     "West-Southwest",
                                     "West",
                                     "West-Northwest",
                                     "Northwest",
                                     "North-Northwest",
                                     "North",
                                     "North-Northeast",
                                     "Northeast",
                                     "East-Northeast",
                                     "East",
                                     "East-Southeast",
                                     "Southeast",
                                     "South-Southeast" });
   Controls.AddRange( new Control[]{ opt, ort });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   ort.Location     = new Point( 15, 29 );
   btnData.Location = new Point( 15, 55 );

   ort.SelectedIndex = 0;

   ShowDialog();

   plc.Data = ort.SelectedIndex;

  }

  private void makeCrops( AlphaBlock plc )
  {
   RadioButton s = new RadioButton(),
               f = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 225, 115 );

   // Set Item Text
   opt.Text = "Crop Options";
   s.Text   = "Just Planted";
   f.Text   = "Full Grown";

   Controls.AddRange( new Control[]{ opt, s, f });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   s.Location       = new Point( 15, 27 );
   f.Location       = new Point( 125, 27 );
   btnData.Location = new Point( 15, 50 );

   s.Checked = true;

   ShowDialog();

   if( s.Checked )
    plc.Data = 0;

   else 
    plc.Data = 7;

  }

  private void makeWart( AlphaBlock plc )
  {
   RadioButton s = new RadioButton(),
               f = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 225, 115 );

   // Set Item Text
   opt.Text = "Wart Options";
   s.Text   = "Just Planted";
   f.Text   = "Full Grown";

   Controls.AddRange( new Control[]{ opt, s, f });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   s.Location       = new Point( 15, 27 );
   f.Location       = new Point( 125, 27 );
   btnData.Location = new Point( 15, 50 );

   s.Checked = true;

   ShowDialog();

   if( s.Checked )
    plc.Data = 0;

   else 
    plc.Data = 3;

  }

  private void makeFarm( AlphaBlock plc )
  {
   RadioButton s = new RadioButton(),
               f = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 225, 115 );

   // Set Item Text
   opt.Text = "Farm Options";
   s.Text   = "Dry";
   f.Text   = "Wet";

   Controls.AddRange( new Control[]{ opt, s, f });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   s.Location       = new Point( 15, 27 );
   f.Location       = new Point( 125, 27 );
   btnData.Location = new Point( 15, 50 );

   s.Checked = true;

   ShowDialog();

   if( s.Checked )
    plc.Data = 0;

   else 
    plc.Data = 8;

  }

  private void makeWires( AlphaBlock plc )
  {
   RadioButton s = new RadioButton(),
               f = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 225, 115 );

   // Set Item Text
   opt.Text = "Wire Options";
   s.Text   = "Unpowered";
   f.Text   = "Powered";

   Controls.AddRange( new Control[]{ opt, s, f });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   s.Location       = new Point( 15, 27 );
   f.Location       = new Point( 125, 27 );
   btnData.Location = new Point( 15, 50 );

   s.Checked = true;

   ShowDialog();

   if( s.Checked )
    plc.Data = 0;

   else 
    plc.Data = 15;

  }

  private void makeHooks( AlphaBlock plc )
  {
   RadioButton n = new RadioButton(),
               s = new RadioButton(),
               e = new RadioButton(),
               w = new RadioButton();
   CheckBox    inv = new CheckBox();
   Label       opt = new Label();

   Size = new Size( 200, 159 );

   // Set Item Text
   opt.Text = "Hook Options";
   n.Text   = "North";
   s.Text   = "South";
   e.Text   = "East";
   w.Text   = "West";
   inv.Text = "Set";

   Controls.AddRange( new Control[]{ opt, n, s, e, w, inv });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   n.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   e.Location       = new Point( 15, 50 );
   w.Location       = new Point( 125, 50 );
   inv.Location     = new Point( 15, 73 );
   btnData.Location = new Point( 15, 96 );

   n.Checked = true;

   ShowDialog();

   if( e.Checked )
    plc.Data = 3;

   else if( w.Checked )
    plc.Data = 1;

   else if( s.Checked )
    plc.Data = 0;

   else
    plc.Data = 2;

   if( inv.Checked )
    plc.Data += 4;

  }

  private void makeLevers( AlphaBlock plc )
  {
   RadioButton gns = new RadioButton(),
               gew = new RadioButton(),
               cns = new RadioButton(),
               cew = new RadioButton(),
               n   = new RadioButton(),
               s   = new RadioButton(),
               e   = new RadioButton(),
               w   = new RadioButton();
   CheckBox    pwr = new CheckBox();
   Label       opt = new Label();

   Size = new Size( 475, 159 );

   // Set Item Text
   opt.Text = "Lever Options";
   gns.Text = "N-S Ground";
   gew.Text = "E-W Ground";
   cns.Text = "N-S Ceiling";
   cew.Text = "E-W Ceiling";
   n.Text   = "North";
   s.Text   = "South";
   e.Text   = "East";
   w.Text   = "West";
   pwr.Text = "Active";

   Controls.AddRange( new Control[]{ opt,
                                     gns,
                                     n,
                                     s,
                                     cns,
                                     gew,
                                     e,
                                     w,
                                     cew,
                                     pwr });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   gns.Location     = new Point( 15, 28 );
   n.Location       = new Point( 125, 28 );
   s.Location       = new Point( 235, 28 );
   cns.Location     = new Point( 355, 28 );
   gew.Location     = new Point( 15, 51 );
   e.Location       = new Point( 125, 51 );
   w.Location       = new Point( 235, 51 );
   cew.Location     = new Point( 355, 51 );
   pwr.Location     = new Point( 15, 73 );
   btnData.Location = new Point( 15, 96 );

   gns.Checked = true;

   ShowDialog();

   if( cns.Checked )
    plc.Data = 0;

   else if( e.Checked )
    plc.Data = 1;

   else if( w.Checked )
    plc.Data = 2;

   else if( s.Checked )
    plc.Data = 3;

   else if( n.Checked )
    plc.Data = 4;

   else if( gns.Checked )
    plc.Data = 5;

   else if( gew.Checked )
    plc.Data = 6;
   
   else
    plc.Data = 7;

   if( pwr.Checked )
    plc.Data += 8;

  }

  private void makeBed( AlphaBlock plc )
  {
   RadioButton n = new RadioButton(),
               s = new RadioButton(),
               e = new RadioButton(),
               w = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 225, 136 );

   // Set Item Text
   opt.Text = "Bed (Head) Options";
   n.Text   = "Head North";
   s.Text   = "Head South";
   e.Text   = "Head East";
   w.Text   = "Head West";

   Controls.AddRange( new Control[]{ opt, n, s, e, w });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   n.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   e.Location       = new Point( 15, 50 );
   w.Location       = new Point( 125, 50 );
   btnData.Location = new Point( 15, 73 );

   n.Checked = true;

   ShowDialog();

   if( e.Checked )
    plc.Data = 11;

   else if( w.Checked )
    plc.Data = 9;

   else if( s.Checked )
    plc.Data = 8;

   else
    plc.Data = 10;

  }

  private void makeDoors( AlphaBlock plc )
  {
   RadioButton n = new RadioButton(),
               s = new RadioButton(),
               e = new RadioButton(),
               w = new RadioButton();
   CheckBox    inv = new CheckBox(),
               opn = new CheckBox();
   Label       opt = new Label();

   Size = new Size( 200, 159 );

   // Set Item Text
   opt.Text = "Door Options";
   n.Text   = "Northwest";
   s.Text   = "Northeast";
   e.Text   = "Southeast";
   w.Text   = "Southwest";
   inv.Text = "Top";
   opn.Text = "Open";

   Controls.AddRange( new Control[]{ opt, n, s, e, w, inv, opn });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   n.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   e.Location       = new Point( 15, 50 );
   w.Location       = new Point( 125, 50 );
   inv.Location     = new Point( 15, 73 );
   opn.Location     = new Point( 125, 73 );
   btnData.Location = new Point( 15, 96 );

   n.Checked = true;

   ShowDialog();

   if( e.Checked )
    plc.Data = 2;

   else if( w.Checked )
    plc.Data = 3;

   else if( s.Checked )
    plc.Data = 1;

   else
    plc.Data = 0;

   if( inv.Checked )
    plc.Data += 4;

   if( opn.Checked )
    plc.Data += 8;

  }

  private void makeFence( AlphaBlock plc )
  {
   RadioButton n = new RadioButton(),
               s = new RadioButton(),
               e = new RadioButton(),
               w = new RadioButton();
   CheckBox    opn = new CheckBox();
   Label       opt = new Label();

   Size = new Size( 200, 159 );

   // Set Item Text
   opt.Text = "Fence Options";
   n.Text   = "North";
   s.Text   = "South";
   e.Text   = "East";
   w.Text   = "West";
   opn.Text = "Open";

   Controls.AddRange( new Control[]{ opt, n, s, e, w, opn });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   n.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   e.Location       = new Point( 15, 50 );
   w.Location       = new Point( 125, 50 );
   opn.Location     = new Point( 15, 73 );
   btnData.Location = new Point( 15, 96 );

   n.Checked = true;

   ShowDialog();

   if( e.Checked )
    plc.Data = 3;

   else if( w.Checked )
    plc.Data = 1;

   else if( s.Checked )
    plc.Data = 0;

   else
    plc.Data = 2;

   if( opn.Checked )
    plc.Data += 4;

  }

  private void makeTraps( AlphaBlock plc )
  {
   RadioButton n = new RadioButton(),
               s = new RadioButton(),
               e = new RadioButton(),
               w = new RadioButton();
   CheckBox    opn = new CheckBox();
   Label       opt = new Label();

   Size = new Size( 200, 159 );

   // Set Item Text
   opt.Text = "Trap Options";
   n.Text   = "North";
   s.Text   = "South";
   e.Text   = "East";
   w.Text   = "West";
   opn.Text = "Open";

   Controls.AddRange( new Control[]{ opt, n, s, e, w, opn });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   n.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   e.Location       = new Point( 15, 50 );
   w.Location       = new Point( 125, 50 );
   opn.Location     = new Point( 15, 73 );
   btnData.Location = new Point( 15, 96 );

   n.Checked = true;

   ShowDialog();

   if( e.Checked )
    plc.Data = 2;

   else if( w.Checked )
    plc.Data = 3;

   else if( s.Checked )
    plc.Data = 0;

   else
    plc.Data = 1;

   if( opn.Checked )
    plc.Data += 4;

  }

  private void makeEggs( AlphaBlock plc )
  {
   RadioButton t = new RadioButton(),
               s = new RadioButton(),
               f = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 200, 159 );

   // Set Item Text
   opt.Text = "Egg Options";
   t.Text   = "Stone";
   s.Text   = "Cobblestone";
   f.Text   = "Stone Brick";

   Controls.AddRange( new Control[]{ opt, t, s, f });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   t.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   f.Location       = new Point( 15, 50 );
   btnData.Location = new Point( 15, 73 );

   t.Checked = true;

   ShowDialog();

   if( s.Checked )
    plc.Data = 1;

   else if( t.Checked )
    plc.Data = 0;

   else 
    plc.Data = 2;

  }

  private void makeStoneBrick( AlphaBlock plc )
  {
   RadioButton sb = new RadioButton(),
               cr = new RadioButton(),
               ms = new RadioButton(),
               ch = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 225, 135 );

   // Set Item Text
   opt.Text = "Brick Options";
   sb.Text  = "Stone Brick";
   cr.Text  = "Cracked Brick";
   ms.Text  = "Mossy Brick";
   ch.Text  = "Chiseled Brick";

   Controls.AddRange( new Control[]{ opt, sb, cr, ms, ch });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   sb.Location      = new Point( 15, 27 );
   cr.Location      = new Point( 125, 27 );
   ms.Location      = new Point( 15, 50 );
   ch.Location      = new Point( 125, 50 );
   btnData.Location = new Point( 15, 73 );

   sb.Checked = true;

   ShowDialog();

   if( sb.Checked )
    plc.Data = 0;

   else if( cr.Checked )
    plc.Data = 2;

   else if( ms.Checked )
    plc.Data = 3;

   else
    plc.Data = 3;

  }

  private void makeSandstone( AlphaBlock plc )
  {
   RadioButton t = new RadioButton(),
               s = new RadioButton(),
               f = new RadioButton();
   Label       opt = new Label();

   Size = new Size( 200, 135 );

   // Set Item Text
   opt.Text = "Egg Options";
   t.Text   = "Sandstone";
   s.Text   = "Chiseled";
   f.Text   = "Smooth";

   Controls.AddRange( new Control[]{ opt, t, s, f });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   t.Location       = new Point( 15, 27 );
   s.Location       = new Point( 125, 27 );
   f.Location       = new Point( 15, 50 );
   btnData.Location = new Point( 15, 73 );

   t.Checked = true;

   ShowDialog();

   if( s.Checked )
    plc.Data = 1;

   else if( t.Checked )
    plc.Data = 0;

   else 
    plc.Data = 2;

  }

  private void makeVines( AlphaBlock plc )
  {
   CheckBox t = new CheckBox(),
            n = new CheckBox(),
            s = new CheckBox(),
            e = new CheckBox(),
            w = new CheckBox();
   Label    opt = new Label();

   Size = new Size( 350, 159 );

   // Set Item Text
   opt.Text = "Vine Options";
   t.Text   = t.Name = "Top";
   n.Text   = n.Name = "North";
   s.Text   = s.Name = "South";
   e.Text   = e.Name = "East";
   w.Text   = w.Name = "West";

   t.CheckedChanged += new EventHandler( vine_CheckedChanged );
   n.CheckedChanged += new EventHandler( vine_CheckedChanged );
   s.CheckedChanged += new EventHandler( vine_CheckedChanged );
   e.CheckedChanged += new EventHandler( vine_CheckedChanged );
   w.CheckedChanged += new EventHandler( vine_CheckedChanged );

   Controls.AddRange( new Control[]{ opt, t, n, s, e, w });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   t.Location       = new Point( 15, 27 );
   n.Location       = new Point( 125, 27 );
   s.Location       = new Point( 235, 27 );
   e.Location       = new Point( 15, 50 );
   w.Location       = new Point( 125, 50 );
   btnData.Location = new Point( 15, 96 );

   t.Checked = true;

   ShowDialog();

   if( t.Checked )
    plc.Data = 0;

   if( n.Checked )
    plc.Data += 4;

   if( s.Checked )
    plc.Data += 1;

   if( e.Checked )
    plc.Data += 8;

   if( w.Checked )
    plc.Data += 2;

  }

  private void vine_CheckedChanged( object sender, EventArgs e )
  {
   CheckBox temp = (( CheckBox ) sender );

   if( temp.Name == "Top" && temp.Checked )
   {
    foreach( object chg in Controls )
    {
     if( chg.GetType() == temp.GetType() &&
         chg != sender )
      (( CheckBox ) chg ).Checked = false;

    }
   }

   else if( temp.Name != "Top" && temp.Checked == true )
   {
    CheckBox tp = (( CheckBox ) Controls.Find( "Top", true )[ 0 ]);
    tp.Checked = false;

   }
  }

  private void makeSpawner( AlphaBlock plc )
  {
   ComboBox ort = new ComboBox();
   Label    opt = new Label();
   TileEntityMobSpawner mob;

   Size = new Size( 200, 120 );

   // Set Item Text
   opt.Text = "Spawner Options";
   ort.Items.AddRange( new object[]{ "Creeper",
                                     "Skeleton",
                                     "Spider",
                                     "Giant",
                                     "Zombie",
                                     "Slime",
                                     "Ghast",
                                     "PigZombie",
                                     "Enderman",
                                     "CaveSpider",
                                     "Silverfish",
                                     "Blaze",
                                     "LavaSlime",
                                     "EnderDragon" });
                                     //"Whither", });

   Controls.AddRange( new Control[]{ opt, ort });

   // Set Locations
   opt.Location     = new Point( 12, 9 );
   ort.Location     = new Point( 15, 29 );
   btnData.Location = new Point( 15, 55 );

   ort.SelectedIndex = 0;

   ShowDialog();

   mob = (( TileEntityMobSpawner ) plc.GetTileEntity());
   mob.EntityID = (( String ) ort.SelectedItem );
   plc.SetTileEntity( mob ); 

  }
 }
}
