// Программа, которая из имеющегося массива строк, формирует массив строк, длина которых меньше, либо
// равна 3 символа. 
// Примеры:
// ["hello"], "2", "world", ":-)"]->["2",":-)"]
// ["1,2,3,4"], "1567", "-2", "computer science"]->["-2"]
// ["Russia", "Denmark", "Kazan"] - > []

string [] textArray = {"hello", "2", "world", ":-)"};
int quantityLessThen4 = 0; //кол-во слов, длина которых меньше 4 символов

void HowManyWordsIsLessThen4 (string [] startArray)
{
    for (int i = 0; i < textArray.Length; i++)
    {
        if (textArray[i].Length <= 3)
        {
            quantityLessThen4++;
        }
    }
}


void FillArray (string [] Array1)
{
    int count = 0;
    for (int i = 0; i < textArray.Length; i++)
    {
        if (textArray[i].Length <= 3)
        {
            Array1[count] = textArray[i];
            count++;
        }
    }
}