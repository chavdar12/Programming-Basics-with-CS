namespace Programs.Tests;

public class ExerciseNestedLoopsTests
{
    [Theory]
    [InlineData("012-Ex1", "7", "1 \n2 3 \n4 5 6 \n7 ")]
    [InlineData("012-Ex1", "3", "1 \n2 3 \n")]
    [InlineData("012-Ex2", "100000\n100050", "100001 100012 100023 100034 100045 ")]
    [InlineData("012-Ex3", "3\n9\n0\n7\n19\n4\nstop", "Sum of all prime numbers is: 29\nSum of all non prime numbers is: 13\n")]
    [InlineData("012-Ex3", "30\n83\n33\n-1\n20\nstop",
        "Number is negative.\nSum of all prime numbers is: 83\nSum of all non prime numbers is: 83\n")]
    [InlineData("012-Ex3", "1\n2\nstop", "Sum of all prime numbers is: 2\nSum of all non prime numbers is: 1\n")]
    [InlineData("012-Ex4", "2\nWhile-Loop\n6.00\n5.50\nFor-Loop\n5.84\n5.66\nFinish",
        "While-Loop - 5.75.\nFor-Loop - 5.75.\nStudent's final assessment is 5.75.\n")]
    [InlineData("012-Ex5", "2\n4",
        "11aa2 11ab2 11ac2 11ad2 11ba2 11bb2 11bc2 11bd2 11ca2 11cb2 11cc2 11cd2 11da2 11db2 11dc2 11dd2 ")]
    [InlineData("012-Ex6", "3", "1111 1113 1131 1133 1311 1313 1331 1333 3111 3113 3131 3133 3311 3313 3331 3333 ")]
    [InlineData("012-Ex7", "3\n5\n5", "2 2 2\n2 2 4\n2 3 2\n2 3 4\n2 5 2\n2 5 4\n")]
    [InlineData("012-Ex8", "a\nc\nb", "aaa aac aca acc caa cac cca ccc 8")]
    [InlineData("012-Ex9", "3", "1212 1221 2112 2121 ")]
    [InlineData("012-Ex10", "2\n3", "3222 3332 ")]
    [InlineData("012-Ex11", "2\n3\n4", "(1 <-> 1) (1 <-> 2) (1 <-> 3) (2 <-> 1) ")]
    [InlineData("012-Ex11", "1\n2\n10", "(1 <-> 1) (1 <-> 2) ")]
    [InlineData("012-Ex12", "B\n3\n2",
        "A1a\nA1b\nA2a\nA2b\nA2c\nA2d\nA3a\nA3b\nB1a\nB1b\nB2a\nB2b\nB2c\nB2d\nB3a\nB3b\nB4a\nB4b\nB4c\nB4d\n20\n")]
    [InlineData("012-Ex13", "2\n3\n10", "#@11@#|$A12A$|%B13B%|&C21C&|'D22D'|(E23E(|\n")]
    [InlineData("012-Ex13", "2\n3\n2", "#@11@#|$A12A$|\n")]
    [InlineData("012-Ex14", "3\n5\n5", "2 2 2\n2 2 4\n2 3 2\n2 3 4\n2 5 2\n2 5 4\n")]
    [InlineData("012-Ex15", "1\n10\n5", "Combination N:4 (1 + 4 = 5)\n")]
    [InlineData("012-Ex15", "23\n24\n20", "4 combinations - neither equals 20\n")]
    [InlineData("012-Ex16", "3\n2\n3\n10",
        "0 * 1 lv. + 0 * 2 lv. + 2 * 5 lv. = 10 lv.\n1 * 1 lv. + 2 * 2 lv. + 1 * 5 lv. = 10 lv.\n3 * 1 lv. + 1 * 2 lv. + 1 * 5 lv. = 10 lv.\n")]
    [InlineData("012-Ex17", "2\n5", "Day: 1 - 5.50 leva\nDay: 2 - 9.50 leva\nTotal: 15.00 leva\n")]
    [InlineData("012-Ex18", "11", "1291 1342 1381 1471 1532 1561 1651 1741 1831 1921 2351 2431 \nPassword: 1471\n")]
    [InlineData("012-Ex18", "3", "No!\n")]
    [InlineData("012-Ex19", "10\n20\n5\n5", "1123\n1323\n")]
    public void Prints_expected_output(string program, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(program, input));
}
