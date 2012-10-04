using System;
using System.Drawing;
using Substrate;

namespace CreativeModePlus
{
 class ElemUndo
 {
  private Rectangle area;
  private int[][] origClr,
                  origLyr;
  private AlphaBlock[][] origBlk;
  public String name;

  public Rectangle undo( Rectangle sArea,
                         int[][] clr, 
                         int[][] lyr, 
                         AlphaBlock[][] blks )
  {
   AlphaBlock tmpB;
   int        tmpC, tmpL, i, j;
   Rectangle  tmpR = area;

   area = sArea; // switch for redo
  
   for( i = 0; i < LoadSave.W; i++ )
   {
    for( j = 0; j < LoadSave.H; j++ )
    {
     tmpB = blks[ i ][ j ];
     tmpC = clr[ i ][ j ];
     tmpL = lyr[ i ][ j ];

     blks[ i ][ j ] = origBlk[ i ][ j ];
     clr[ i ][ j ] = origClr[ i ][ j ];
     lyr[ i ][ j ] = origLyr[ i ][ j ];

     origBlk[ i ][ j ] = tmpB; // switch for redo
     origClr[ i ][ j ] = tmpC;
     origLyr[ i ][ j ] = tmpL;

    }
   }

   return tmpR;

  }

  public ElemUndo( Rectangle sArea,
                   int[][] clr,
                   int[][] lyr,
                   AlphaBlock[][] blk,
                   String cmd )
  {
   int i, j;
   name = cmd;
   area = new Rectangle( sArea.Location, sArea.Size );

   origBlk = new AlphaBlock[ LoadSave.W ][];
   origClr = new int[ LoadSave.W ][];
   origLyr = new int[ LoadSave.W ][];

   for( i = 0; i < LoadSave.W; i++ )
   {
    origBlk[ i ] = new AlphaBlock[ LoadSave.H ];
    origClr[ i ] = new int[ LoadSave.H ];
    origLyr[ i ] = new int[ LoadSave.H ];

    for( j = 0; j < LoadSave.H; j++ )
    {
     origBlk[ i ][ j ] = blk[ i ][ j ];
     origClr[ i ][ j ] = clr[ i ][ j ];
     origLyr[ i ][ j ] = lyr[ i ][ j ];

    }
   }
  }
 }
}
