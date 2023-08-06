using CA_Motorcycle;
using CA_Motorcycle.Models;
using CA_Motorcycle.Repository;

MotorcycleRepository mlr = new MotorcycleRepository();

Console.WriteLine("İşlem Seçin");
Console.WriteLine("1-Listeleme");
Console.WriteLine("2-Ekleme");
Console.WriteLine("3-Güncelle");
Console.WriteLine("4-Sil");
Console.WriteLine();

int secim;

while (true)
{
	try
	{
		secim = int.Parse(Console.ReadLine());

		switch (secim)
		{
			//Listeleme
			case 1:
				foreach (Motorcycle item in mlr.GetMotorcycle())
				{
					Console.WriteLine($"ID:{item.Id} * Marka:{item.Brand} * Model:{item.Model} * Tipi:{item.Type} * Renk:{item.Colour} * Yıl:{item.Year}");
				}
				break;

			//Ekleme
			case 2:
				Motorcycle m = new Motorcycle();
				Console.WriteLine("Marka giriniz:");
				m.Brand = Console.ReadLine();
				Console.WriteLine("Model giriniz:");
				m.Model = Console.ReadLine();
				Console.WriteLine("Tipi giriniz:");
				m.Type = Console.ReadLine();
				Console.WriteLine("Renk giriniz:");
				m.Colour = Console.ReadLine();
				Console.WriteLine("Yıl Giriniz:");
				m.Year = Console.ReadLine();

				mlr.AddMotorcycle(m);
				Console.WriteLine("Eklendi");
				break;

			//Güncelleme
			case 3:
				Console.WriteLine("Hangi Motorsikleti güncellemek istersiniz ?");
				int güncelleme = int.Parse(Console.ReadLine());

				Motorcycle güncellemeMotor = new Motorcycle();
				güncellemeMotor.Id = güncelleme;
				Console.WriteLine("Marka Giriniz:");
				güncellemeMotor.Brand = Console.ReadLine();
				Console.WriteLine("Lütfen Model Giriniz:");
				güncellemeMotor.Model = Console.ReadLine();
				Console.WriteLine("Lütfen Tip Giriniz:");
				güncellemeMotor.Type = Console.ReadLine();
				Console.WriteLine("Lütfen Renk Giriniz:");
				güncellemeMotor.Colour = Console.ReadLine();
				Console.WriteLine("Lütfen Yıl Giriniz:");
				güncellemeMotor.Year = Console.ReadLine();

				mlr.UpdateMotorcycle(güncellemeMotor);
				break;

			//Silme
			case 4:
				Console.WriteLine("Hangi Motorcycle silme istersiniz ?");
				int silme = int.Parse(Console.ReadLine());
				mlr.DeleteMotorcycle(silme);
				Console.WriteLine("Motorcycle Veritabanından Kaldırıldı.");
				break;
			default:
				break;
		}
	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.Message);
	}
}