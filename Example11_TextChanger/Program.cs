// Свапы различных символов в тексте через цикл.

string text = "Описание лесного пейзажа у костра под звездным небом. "
+ "Лесной пейзаж — это не только деревья, но и лес. "
+ "В лесу могут быть дубы, ели, сосны, лиственницы, осины, березы и другие деревья. "
+ "Не менее красиво смотрятся лесные поляны и луга. "
+ "На лугах растут злаковые травы и цветы. "
+ "Там, где есть вода, растут кувшинки и водяные лилии. "
+ "Когда люди отправляются в лес, они берут с собой еду, воду, спички, зажигалки. "
+ "Если они знают, как развести костер, то могут приготовить вкусный ужин.";

string ConvertText(string txt, char v1char, char v2char)
{
    string newtext = String.Empty;
    int textsize = txt.Length;
    for (int i = 0; i < textsize; i++) 
    {
        if (txt[i] == v1char)
            newtext = newtext + $"{v2char}";
        else
            newtext = newtext + $"{txt[i]}";
    }
    return (newtext);
}
string textv2 = ConvertText(text, 'л', 'Л');
string textv3 = ConvertText(textv2, ' ', '|');

Console.WriteLine(textv3);
