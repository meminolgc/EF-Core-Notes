namespace HowBitsWork
{
	public class Bit_And_Bytes
	{
		/* 
			Bit Nedir? => 0 yok, 1 var 
			
			Byte Nedir? 8 tane bit
			0001_1101 -> 65 ASCII değerine eşit ve bu da 'A' değerine eşittir.

			1 Byte neden 8 Bit'tir?
			256 neden önemlidir?
			Bitler Nasıl hesaplanır?
		       2x2x2x2x2x2x2x2
		 */



		/* 
		    1 Byte neden 8 Bit'tir?
			Sadece 0 ve 1 kullanarak 00, 01, 10, 11 kombinasyonları yapılabiliyor.
			0 ve 1 değerleri artınca örn(101, veya 1101 gibi) bu sefer bu değerlerin kombinasyonları kadar oluşturulabiliyor. Bu da 2^n demek.
			8 biti kullanarak toplamda 256 kombinasyon üretilebiliyor.
			
		  1    1    1    1   1  1   1  1
		 -------------------------------
		 128  64   32   16   8  4   2  1  -> toplamları 256. 

		65 değerini 0 ve 1 lerden -> 01000001 şeklinde yazarız(yukarıdaki tablodan bize lazım olan 1 leri alıp geri kalanları 0 olarak giriyoruz yani 65 değeri için bize 64 ve 1 değerleri lazım o yüzden 64 ve 1 değerlerine karşılık gelen 1 leri yazıp geriye kalanlara 0 ları ekliyoruz.
		Bu değeri (01000001) bilgisayara byte olarak çevirmek istersek 'A' değerini verecektir.
		(Hesaplamaya sağdan sola şeklinde başlanır.)
		00011011 -> 1 + 2 + 8 + 16 => 27 
		ASCII Kod tablosundaki 27. değere denk gelecek ve bu değer de 'esc' dir.

		*/

		/* 
			var upperAInt = 0b01000001;
			var upperA = (char)upperAInt;
			
			var byteA = (byte)upperA;
			var byteAStr = Convert.ToString(byteA, 2);
			Console.WriteLine("Byte: {0}, Str:{1}" byteA, 2);

			Console.WriteLine("Number: {0}, Value: {1}, upperAInt, upperA);
		 
		 */
	}
}
