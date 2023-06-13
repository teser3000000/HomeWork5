CargoPlane Tu154B = new CargoPlane(18, 2, "2,8 х 1,87", "Tu154B", 120, 12, 8, "М-14П", "КБ", 9, 49, 500);
CargoPlane Yak42 = new CargoPlane(12, 8, "3 х 1,80", "Yak-42", 80, 8, 8, "М-14Х", "производитель", 8, 40, 400);

PassengerPlane SukhoiSuperjet100 = new PassengerPlane("узкофюзеляжный", "Sukhoi Superjet-100", 108, 4, 32, "АИ-14РФ", "«Корпорация Иркут»", 5, 30, 400);
PassengerPlane AirbusA330 = new PassengerPlane("широкофюзеляжный", "Airbus A330", 253, 4, 30, "М-14ПФ", " Airbus", 5, 50, 320);

PassengerСar AudiTT = new PassengerСar('s', "8N", "Audi TT", "купе", 2012, "роботизированная", "красный", "Бензин", "Audi", 1, 1, 100);
PassengerСar HondaS2000 = new PassengerСar('s', "h2", "Honda S2000", "кабриолет", 1999, "механическая", "оранжевый", "Бензин", "Honda", 1, 2, 240);

СargoСar SinotrukSitrakC7H = new СargoСar(8, 35000, "Sinotruk Sitrak C7H", "самосвал", 2022, "механическая", "красный", "Бензин", "SITRAK", 8800, 9, 90);
СargoСar MANTGX = new СargoСar(6, 30000, "MAN TGX", "шасси", 2023, "автоматическая", "черный", "Дизель", "MAN", 7500, 16, 90);

Train train1 = new Train(12, "дальнего следования", "1Д12400БС2", "ТМХ", 200, 1, 140);

List <PassengerСar> passengerСars = new List<PassengerСar> { AudiTT, HondaS2000 };
List <СargoСar> сargoСars = new List<СargoСar> { SinotrukSitrakC7H, MANTGX };
List <CargoPlane> сargoPlanes = new List<CargoPlane> { Tu154B, Yak42 };
List <PassengerPlane> passengerPlanes = new List<PassengerPlane> { SukhoiSuperjet100, AirbusA330 };
List <Train> trains = new List<Train> { train1 };

Console.WriteLine("Добро пожаловать!\n\nВыберите интересующую вас информацию:\n\n" +
	"1.Вывести всю информацию о всем транспорте\n" + 
	"2.Автомобили\n" + 
	"3.Самолеты\n" + 
	"4.Поезда\n"
	);
switch (int.Parse(Console.ReadLine()))
{
	case 1:
		Console.Clear();
        foreach (var passengerСar in passengerСars) passengerСar.ShowInfo();
        foreach (var сargoСar in сargoСars) сargoСar.ShowInfo();
        foreach (var passengerPlane in passengerPlanes) passengerPlane.ShowInfo();
        foreach (var сargoPlane in сargoPlanes) сargoPlane.ShowInfo();
        foreach (var train in trains) train.ShowInfo();
        break;
	case 2:
		Console.Clear();
        Console.WriteLine("Выберите категорию автомобиля:\n\n" +
			"1.Легковые автомобили\n" + 
			"2.Грузовые автомобили"
			);
		switch (int.Parse(Console.ReadLine()))
		{
			case 1:
				Console.Clear();
				foreach (var passengerСar in passengerСars) passengerСar.ShowInfo();
				break;
			case 2:
                Console.Clear();
                foreach (var сargoСar in сargoСars) сargoСar.ShowInfo();
                break;
			default:
                Console.WriteLine("Такой команды не существует");
                break;
		}
		break;
	case 3:
		Console.Clear();
        Console.WriteLine("Выберите категорию самолета:\n\n" +
            "1.Пассажирские самолеты\n" +
            "2.Грузовые самолеты"
            );
		switch (int.Parse(Console.ReadLine()))
		{
			case 1:
				Console.Clear();
				foreach (var passengerPlane in passengerPlanes) passengerPlane.ShowInfo();
				break;
			case 2:
                Console.Clear();
                foreach (var сargoPlane in сargoPlanes) сargoPlane.ShowInfo();
                break;
			default:
				break;
		}
		break;
	case 4:
		Console.Clear();
		foreach (var train in trains) train.ShowInfo();
		break;
	default:
        Console.WriteLine("Такой команды не существует!");
        break;
}
