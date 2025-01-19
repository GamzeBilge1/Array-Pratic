
int[] array = new int[10];  // Boyutu 10 olan bir tamsayı dizisi oluşturuldu.

for (int i = 0; i < array.Length; i++)
{
    array[i] = i; // Her bir eleman, sırasıyla 0'dan 9'a kadar sayılarla dolduruluyor.

}

foreach (var item in array)
{
    Console.WriteLine(item + 1 + ". eleman:" + item);  // Eleman sırasını ve değerini ekrana yazdırır. 

}

Console.WriteLine("diziye yeni bir eleman ekleyiniz");  //  Kullanıcıdan 11. eleman için değer alındı
int input = Convert.ToInt32(Console.ReadLine());

int[] newArray = new int[array.Length + 1]; // ilk diziden eleman sayısı bir fazla olan yeni bir dizi oluşturuldu

Array.Copy(array, newArray, array.Length); // `array` dizisinin elemanlarını baştan sona `newArray` dizisine kopyalar. 
                                           // Kopyalamadan sonra, `newArray` dizisinin sonuncu elemanı (yani [10] indeksi) boş kalır. 

newArray[newArray.Length - 1] = input; // Kullanıcıdan alınan değer yeni dizinin sonuncu elemanına atanır.

Array.Sort(newArray); // Dizi küçükten büyüğe sıralanır
Array.Reverse(newArray); // dizi ters çevrilir (büyükten küçüğe sıralanmış olur) 

Console.WriteLine("YENİ DİZİ ELEMANLARI");

foreach (var item in newArray) // yeni dizi elemanları( büyükten küçüğe yazdırılır.)
{
    Console.Write(item + " ");
}

Console.WriteLine();