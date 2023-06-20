using System.Diagnostics.Metrics;
using Bossfight;
//                                    Hel, Str, Sta
GameCharacter boss = new GameCharacter(400, 30, 10, "Boss");
GameCharacter hero = new GameCharacter(100, 20, 40, "Hero");

while(boss.Health >0 && hero.Health > 0)
{
boss.Fight(hero);
hero.Fight(boss);
}

//Legge til random styrke til Boss
//Passe på at man ikke går under null i health
//CW den som vant




