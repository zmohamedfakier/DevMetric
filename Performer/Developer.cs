using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMetric
{
  public class Developer
  {
    public string Name { get; set; }

    public Level Level { get; set; }

    public Rank GameRank { get; set; }

    public double WorkPlayRatio { get; set; }

    public bool HasKids { get; set; }

    public bool WatchesAnime { get; set; }
       
  }
}
