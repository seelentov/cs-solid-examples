// 2.Принцип открытости / закрытости(Open / Closed Principle)

// • Описание: Класс должен быть открыт для расширения, но закрыт для модификации.
// • Пример: Мы хотим добавить новую возможность в наш Car - управление климат-контролем. Вместо того, чтобы изменять существующий класс Car, мы создаем новый класс ClimateControl и добавляем в него соответствующие методы. Класс Car может быть расширен с помощью интерфейса IClimateControl:


public interface IClimateControl
{
    void SetTemperature(int temperature);
    int GetTemperature();
}

public class ClimateControl : IClimateControl
{
    private int _temperature;

    public void SetTemperature(int temperature)
    {
        _temperature = temperature;
    }

    public int GetTemperature()
    {
        return _temperature;
    }
}

public class Car
{
    // ... другие методы

    private IClimateControl _climateControl;

    public Car(IClimateControl climateControl)
    {
        _climateControl = climateControl;
    }

    public void ControlClimate(int temperature)
    {
        _climateControl.SetTemperature(temperature);
    }
}

// Использование
Car car = new Car(new ClimateControl());
car.ControlClimate(22);


