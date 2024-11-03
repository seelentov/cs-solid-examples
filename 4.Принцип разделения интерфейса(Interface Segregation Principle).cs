// 4.Принцип разделения интерфейса(Interface Segregation Principle)

// • Описание: Необходимо создавать маленькие, специализированные интерфейсы, а не один большой, общий интерфейс.
// • Пример: Вместо одного интерфейса ICar с методами для управления автомобилем, движения и климат-контроля, можно разделить его на 3 интерфейса: IMovement, IDrive и IClimateControl.


public interface IMovement
{
    void Start();
    void Stop();
}

public interface IDrive
{
    void Accelerate();
    void Brake();
}

public interface IClimateControl
{
    void SetTemperature(int temperature);
    int GetTemperature();
}

public class Car : IMovement, IDrive, IClimateControl
{
    // ... Реализация методов
}


