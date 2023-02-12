int verifyMatchingStrings (string jewels, string stones){
    int count = 0;
    foreach (char c in stones){
        if (jewels.Contains(c)){
            count++;
        }
    }
    return count;
}

Console.WriteLine(verifyMatchingStrings("abc","ac"));
Console.WriteLine(verifyMatchingStrings("Af","AaaddfFf"));
Console.WriteLine(verifyMatchingStrings("AYOPD","ayopd"));