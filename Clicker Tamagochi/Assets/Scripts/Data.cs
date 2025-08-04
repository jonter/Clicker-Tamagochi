using System;

[Serializable]
public class Data 
{
    public float Coins = 0;
    public int level = 0;

    public int simpleClick = 0;
    public float simpleClickPrice = 50;

    public int autoEarn = 0;
    public float autoEarnPrice = 30;

    //increase click power by 10
    public int coolClick = 0;
    public float coolClickPrice = 400;

    //increase coins earn per second by 20
    public int autoFactory = 0;
    public float autoFactoryPrice = 1500;

}
