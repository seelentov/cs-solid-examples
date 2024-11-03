// 1.Принцип единственной ответственности(Single Responsibility Principle)

// • Описание: Каждый класс должен иметь только одну ответственность и быть полностью отвечающим за эту ответственность. 
// • Пример: Класс Car должен отвечать только за логику автомобиля: движение, изменение скорости, торможение, заправка. Логика взаимодействия с пользователем, например, вывода данных на дисплей, должна быть вынесена в отдельный класс Display.


public class Car
{
    private int _speed;

    public void Start()
    {
        // Логика запуска двигателя
    }

    public void Accelerate()
    {
        _speed += 10;
    }

    public void Brake()
    {
        _speed -= 5;
    }

    public int GetSpeed()
    {
        return _speed;
    }

    // ... другие функции, связанные с управлением автомобилем
}

public class Display
{
    private Car _car;

    public Display(Car car)
    {
        _car = car;
    }

    public void ShowSpeed()
    {
        Console.WriteLine($"Текущая скорость: {_car.GetSpeed()}");
    }

    // ... другие функции, связанные с выводом информации на дисплей
}


