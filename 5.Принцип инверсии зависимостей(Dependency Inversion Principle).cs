// 5.Принцип инверсии зависимостей(Dependency Inversion Principle)

// • Описание: Модули высокого уровня не должны зависеть от модулей низкого уровня. Оба должны зависеть от абстракций.
// • Пример: Класс Car не должен напрямую зависеть от конкретного класса Engine. Вместо этого он должен зависеть от абстрактного интерфейса IEngine, который определяет методы работы двигателя.


public interface IEngine
{
    void Start();
    void Stop();
}

public class PetrolEngine : IEngine
{
    public void Start()
    {
        // Логика запуска бензинового двигателя
    }

    public void Stop()
    {
        // Логика остановки бензинового двигателя
    }
}

public class Car
{
    private IEngine _engine;

    public Car(IEngine engine)
    {
        _engine = engine;
    }

    public void Start()
    {
        _engine.Start();
    }
}

// Использование
Car car = new Car(new PetrolEngine());
car.Start();


// В этом примере класс Car не привязан к конкретной реализации двигателя. Можно легко заменить его на другой, например, электронный двигатель, реализующий интерфейс IEngine.