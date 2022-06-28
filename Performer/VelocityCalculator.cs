using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMetric
{
  public class VelocityCalculator
  {
    public static double CalculateFactor(Developer dev)
    {
      double factor = 1;

      switch (dev.Level)
      {
        case Level.I: factor *= 0.01; break;
        case Level.II: factor *= 0.05; break;
        case Level.III: factor *= 0.1; break;
        case Level.Ancient: factor *= 0.5; break;
        case Level.Grandmaster: factor *= 1; break;
        default: factor *= 0.1; break;
      }

      switch (dev.GameRank)
      {
        case Rank.Casual: factor *= 1; break;
        case Rank.Amateur: factor *= 0.9; break;
        case Rank.Seasoned: factor *= 0.8; break;
        case Rank.Unstoppable: factor *= 0.7; break;
        case Rank.Godlike: factor *= 0.5; break;
      }

      if (dev.HasKids)
        factor *= 0.5;

      if (dev.WatchesAnime)
        factor *= 0.5;

      return factor;
    }
  }
}
