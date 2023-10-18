int heroPoints = 10;
int monsterPoints = 10;
Random attack = new Random();
int loss = 0;

do{
    loss = attack.Next(1, 11);
    monsterPoints -= loss;
    Console.WriteLine($"Monster was damaged and lost {loss} health and now has {monsterPoints} health.");
    if(monsterPoints <= 0) continue;
    loss = attack.Next(1, 11);
    heroPoints -= loss;
    Console.WriteLine($"Hero was damaged and lost {loss} health and now has {heroPoints} health.");

}while(heroPoints > 0 &&  monsterPoints > 0);

Console.WriteLine(heroPoints > monsterPoints ? "Hero wins!" : "Monster wins!");