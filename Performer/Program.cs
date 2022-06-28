using DevMetric;

Developer zak = new Developer() { 
  Name = "Zak", 
  GameRank = Rank.Godlike, 
  HasKids = true, 
  WatchesAnime = true, 
  WorkPlayRatio = 0.75, 
  Level = Level.Ancient 
};

double storyPoints = VelocityCalculator.CalculateFactor(zak) * 80;

Console.WriteLine($"Zak can complete {storyPoints} points");


