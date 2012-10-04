using Substrate;
using System.Drawing;

namespace CreativeModePlus
{
 public enum RunThread
 {
  Init,
  LoadLayer,
  Update,
  SaveLayer

 }

 public struct Limits
 {
  public int[][] clr,
                 lyr;
  public AlphaBlock[][] map;

 }
}