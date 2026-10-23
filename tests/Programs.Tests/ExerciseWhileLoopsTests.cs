namespace Programs.Tests;

public class ExerciseWhileLoopsTests
{
    [Theory]
    [InlineData("010-Ex1", "Troy\nStronger\nLife Style\nTroy", "You checked 2 books and found it.\n")]
    [InlineData("010-Ex1", "The Spot\nHunger Games\nHarry Potter\nTorronto\nSpotify\nNo More Books",
        "The book you search is not here!\nYou checked 4 books.\n")]
    [InlineData("010-Ex2", "3\nMoney\n6\nStory\n4\nSpring Time\n5\nBus\n6\nEnough",
        "Average score: 5.25\nNumber of problems: 4\nLast problem: Bus\n")]
    [InlineData("010-Ex2", "2\nIncome\n3\nGame Info\n6\nBest Player\n4", "You need a break, 2 poor grades.\n")]
    [InlineData("010-Ex3", "2000\n1000\nspend\n1200\nsave\n2000", "You saved the money for 2 days.\n")]
    [InlineData("010-Ex3", "110\n60\nspend\n10\nspend\n10\nspend\n10\nspend\n10\nspend\n10", "You can't save the money.\n5\n")]
    [InlineData("010-Ex4", "1000\n1500\n2000\n6500", "Goal reached! Good job!\n1000 steps over the goal!\n")]
    [InlineData("010-Ex4", "1500\n300\n2500\n3000\nGoing home\n200", "2500 more steps to reach goal.\n")]
    [InlineData("010-Ex5", "1.23", "4\n")]
    [InlineData("010-Ex5", "2", "1\n")]
    [InlineData("010-Ex5", "0.56", "3\n")]
    [InlineData("010-Ex5", "2.73", "5\n")]
    [InlineData("010-Ex5", "1", "1\n")]
    [InlineData("010-Ex5", "3", "2\n")]
    [InlineData("010-Ex6", "10\n10\n20\n20\n20\n20\n21", "No more cake left! You need 1 pieces more.\n")]
    [InlineData("010-Ex6", "10\n2\n2\n4\n6\nSTOP", "8 pieces are left.\n")]
    public void Prints_expected_output(string program, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(program, input));
}
