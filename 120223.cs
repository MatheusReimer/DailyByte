/*

This question is asked by Amazon. Given a string representing your stones and another string representing a list of jewels, return the number of stones that you have that are also jewels.

Ex: Given the following jewels and stones...

jewels = "abc", stones = "ac", return 2
jewels = "Af", stones = "AaaddfFf", return 3
jewels = "AYOPD", stones = "ayopd", return 0

*/
int verifyMatchingStrings (string jewels, string stones){
    int count = 0;
    foreach (char c in stones){
        if (jewels.Contains(c)){
            count++;
        }
    }
    return count;
}

