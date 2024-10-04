public char CalculateGrade(int studentScore)
{
    // Determine the letter grade based on the student's score
    if (studentScore >= 90)
        return 'A';
    else if (studentScore >= 80)
        return 'B';
    else if (studentScore >= 70)
        return 'C';
    else if (studentScore >= 60)
        return 'D';
    else
        return 'F';
}
